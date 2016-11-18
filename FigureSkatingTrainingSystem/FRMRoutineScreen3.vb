Option Explicit On
Imports FigureSkatingTrainingSystem.RoutinePlanning.TRoutine
Imports FigureSkatingTrainingSystem.RoutinePlanning.TElement
Imports FigureSkatingTrainingSystem.RoutinePlanning.TScore
Imports System.Environment
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports Microsoft.Office.Interop

Public Class FRMRoutineScreen3

    <Serializable()> _
    Public Structure TSavedRoutine
        Dim PupilID As Integer
        Dim PupilName As String
        Dim Routine() As TRoutine
        Dim NumberOfElements As Integer
        Dim PresentationScore As Single
    End Structure

    Private GOEDictionary As New Dictionary(Of Integer, String)
    Private DS As New DataSet
    Private GPupilID As Integer

    Private GlobalNumberOfElements As Integer
    Private GlobalFinalRoutine(13) As TRoutine
    Private GlobalPresentationScore As Single

    Public Sub Main(ByVal NumberOfElements As Integer, ByRef FinalRoutine() As TRoutine, ByVal PresentationScore As Single, ByVal PupilID As Integer)

        'The main subroutine, calls the majority of other procedures and is the procedure that calculates scores based on the results of routine planning.

        Dim Element As TRoutine

        GPupilID = PupilID

        DS.Tables.Add("RoutineOutput")
        DS.Tables("RoutineOutput").Columns.Add("Element_Code")
        DS.Tables("RoutineOutput").Columns.Add("Location")
        DS.Tables("RoutineOutput").Columns.Add("Heart_Rate")
        DS.Tables("RoutineOutput").Columns.Add("Score")
        DS.Tables("RoutineOutput").Columns.Add("GOE")

        For i = 1 To NumberOfElements

            Element = FinalRoutine(i)
            DS.Tables("RoutineOutput").Rows.Add(Element.Element.Code, Element.Location, Element.HeartRate, Element.Score.PredictedBase, Element.Score.PredictedGOE)

        Next

        GOEDictionary.Add(3, "Plus_3")
        GOEDictionary.Add(2, "Plus_2")
        GOEDictionary.Add(1, "Plus_1")
        GOEDictionary.Add(-1, "Minus_1")
        GOEDictionary.Add(-2, "Minus_2")
        GOEDictionary.Add(-3, "Minus_3")

        DGVRoutine.DataSource = DS.Tables("RoutineOutput")

        UpdateScores(NumberOfElements, FinalRoutine, PresentationScore)

        UpdateGraph(NumberOfElements)

        GlobalNumberOfElements = NumberOfElements
        GlobalFinalRoutine = FinalRoutine
        GlobalPresentationScore = PresentationScore

    End Sub 'The main routine to manage this results form

    Private Sub UpdateScores(ByVal NumberOfElements As Integer, ByRef FinalRoutine() As TRoutine, ByVal PresentationScore As Single)



        Dim PredictedScore As Single
        Dim CleanScore As Single
        Dim BadScore As Single
        Dim CurrentBase As Single
        Dim CurrentGOE As Integer
        Dim NewGOE As Single
        Dim ElementCode As String

        For i = 1 To NumberOfElements

            ElementCode = DS.Tables("RoutineOutput").Rows(i - 1).Item(0)

            CurrentBase = DS.Tables("RoutineOutput").Rows(i - 1).Item(3)
            CurrentGOE = DS.Tables("RoutineOutput").Rows(i - 1).Item(4)
            NewGOE = GetSOVScore(CurrentGOE, ElementCode)
            If NewGOE + CurrentBase < 0 Then
                NewGOE = 0
            End If
            If Not CurrentBase = 0 Then
                PredictedScore = PredictedScore + NewGOE + CurrentBase
            End If

            CurrentBase = FinalRoutine(i).Score.CleanBase
            CurrentGOE = FinalRoutine(i).Score.CleanGOE
            NewGOE = GetSOVScore(CurrentGOE, ElementCode)
            If NewGOE + CurrentBase < 0 Then
                NewGOE = 0
            End If
            If Not CurrentBase = 0 Then
                CleanScore = CleanScore + NewGOE + CurrentBase
            End If

            CurrentBase = FinalRoutine(i).Score.BadBase
            CurrentGOE = FinalRoutine(i).Score.BadGOE
            NewGOE = GetSOVScore(CurrentGOE, ElementCode)
            If NewGOE + CurrentBase < 0 Then
                NewGOE = 0
            End If
            If Not CurrentBase = 0 Then
                BadScore = BadScore + NewGOE + CurrentBase
            End If

        Next

        PredictedScore = PredictedScore + PresentationScore * 4
        CleanScore = CleanScore + PresentationScore * 4
        If PresentationScore <= 5 Then
            BadScore = BadScore + PresentationScore * 4
        Else
            BadScore = BadScore + (PresentationScore - 1) * 4
        End If

        LBLPredicted.Text = "Predicted Score = " & PredictedScore
        LBLClean.Text = "Clean Skate Score = " & CleanScore
        LBLBadSkate.Text = "Bad Skate Score = " & BadScore

    End Sub 'Uses information from the database to update all scores on the results form
    Private Function GetSOVScore(ByVal GOE As Integer, ByVal ElementCode As String)

        Dim sql As String 'SQL command to execute
        Dim GOEText As String
        Dim GOEResult As New DataSet

        If Not GOE = 0 Then
            GOEText = GOEDictionary(GOE)
            sql = "SELECT " & GOEText & " FROM [SOVHR] WHERE Element_ID = '" & ElementCode & "'"

            GOEResult = FileManagement.QueryDatabase(sql, "QueryResult")

            Return GOEResult.Tables("QueryResult").Rows(0).Item(0)
        Else
            Return 0
        End If

    End Function 'Retrive the SOV value for a given element
    Private Sub UpdateGraph(ByVal NumberOfElements As Integer)

        CHTHeartRate.Series.Clear()
        CHTHeartRate.Series.Add("HeartRate")
        CHTHeartRate.ChartAreas(0).AxisX.MinorTickMark.Enabled = True
        CHTHeartRate.ChartAreas(0).AxisX.Interval = 1
        CHTHeartRate.ChartAreas(0).AxisX.IsLabelAutoFit = True
        'CHTHeartRate.ChartAreas(0).AxisX.LabelStyle.IsStaggered = True
        CHTHeartRate.ChartAreas(0).AxisX.LabelAutoFitStyle = DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont
        CHTHeartRate.Series("HeartRate").SmartLabelStyle.IsOverlappedHidden = False
        'CHTHeartRate.Series("HeartRate").SmartLabelStyle.IsMarkerOverlappingAllowed = True
        CHTHeartRate.Series("HeartRate").SmartLabelStyle.AllowOutsidePlotArea = True

        For i = 1 To NumberOfElements
            CHTHeartRate.Series("HeartRate").Points.Add(DS.Tables("RoutineOutput").Rows(i - 1).Item(2))
            CHTHeartRate.Series("HeartRate").Points(i - 1).AxisLabel = DS.Tables("RoutineOutput").Rows(i - 1).Item(0)
        Next
    End Sub 'Update the graph

    Private Sub DGVRoutine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRoutine.CellClick

        ChangePredictedGOELabel()

    End Sub 'If a new element is selected

    Private Sub ChangePredictedGOELabel()

        LBLCurrentGOE.Text = DS.Tables("RoutineOutput").Rows(DGVRoutine.SelectedRows.Item(0).Index).Item(4).ToString

    End Sub 'Change the element whose GOE mark is shown in the text box

    Private Sub CMDIncreaseGOE_Click(sender As Object, e As EventArgs) Handles CMDIncreaseGOE.Click

        Dim CurrentGOE As Integer = DS.Tables("RoutineOutput").Rows(DGVRoutine.SelectedRows.Item(0).Index).Item(4)

        If Not CurrentGOE = 3 Then

            DS.Tables("RoutineOutput").Rows(DGVRoutine.SelectedRows.Item(0).Index).Item(4) = CurrentGOE + 1

        End If

        UpdateScores(GlobalNumberOfElements, GlobalFinalRoutine, GlobalPresentationScore)

        ChangePredictedGOELabel()

    End Sub 'Increase the GOE of a given element

    Private Sub CMDDecreaseGOE_Click(sender As Object, e As EventArgs) Handles CMDDecreaseGOE.Click

        Dim CurrentGOE As Integer = DS.Tables("RoutineOutput").Rows(DGVRoutine.SelectedRows.Item(0).Index).Item(4)

        If Not CurrentGOE = -3 Then

            DS.Tables("RoutineOutput").Rows(DGVRoutine.SelectedRows.Item(0).Index).Item(4) = CurrentGOE - 1

        End If

        UpdateScores(GlobalNumberOfElements, GlobalFinalRoutine, GlobalPresentationScore)

        ChangePredictedGOELabel()

    End Sub 'Decrease the GOE of a given element

    Private Sub CMDBack_Click(sender As Object, e As EventArgs) Handles CMDBack.Click

        FRMRoutineMenu.MdiParent = FRMParent
        Me.Close()
        FRMRoutineScreen2.Close()
        FRMRoutineScreen1.Close()
        FRMRoutineMenu.WindowState = FormWindowState.Maximized
        FRMRoutineMenu.Show()

    End Sub 'Return to the routine planning menu, closing all current routine planning forms

    Private Sub CMDSave_Click(sender As Object, e As EventArgs) Handles CMDSave.Click

        Dim PupilNameDS As New DataSet
        PupilNameDS = FileManagement.QueryDatabase("SELECT Pupil_Forename,Pupil_Surname FROM [Pupil] WHERE Pupil_ID = " & GPupilID, "pupilname")

        Dim PupilName As String = PupilNameDS.Tables("pupilname").Rows(0).Item(0) & " " & PupilNameDS.Tables("pupilname").Rows(0).Item(1)
        Dim RoutineSave As TSavedRoutine

        Dim Avaliable As Boolean = False
        Dim counter As Integer = 0

        RoutineSave.Routine = GlobalFinalRoutine
        RoutineSave.NumberOfElements = GlobalNumberOfElements
        RoutineSave.PresentationScore = GlobalPresentationScore
        RoutineSave.PupilID = GPupilID

        

        Do
            If File.Exists(FileManagement.RoutinePath & "\" & GPupilID & "-" & PupilName & ".rtn") Then
                counter = counter + 1
                If counter = 1 Then
                    PupilName = PupilName & counter.ToString
                Else
                    PupilName = Mid(PupilName, 1, Len(PupilName) - 1) & counter
                End If
            Else
                Avaliable = True
            End If
        Loop Until Avaliable

        Dim FS As FileStream = File.Open(FileManagement.RoutinePath & "\" & GPupilID & "-" & PupilName & ".rtn", FileMode.OpenOrCreate)
        Dim BF As New BinaryFormatter

        BF.Serialize(FS, RoutineSave)
        FS.Close()

        MsgBox("Routine Saved Successfully At " & FileManagement.RoutinePath & "\" & GPupilID & "-" & PupilName & ".rtn")

    End Sub

    Private Sub CMDPrint_Click(sender As Object, e As EventArgs) Handles CMDPrint.Click
        Dim wordapp3 As Word.Application
        Dim worddoc3 As Word.Document
        Dim wordpara3 As Word.Paragraph
        Dim pupilID As Integer = GPupilID
        Dim counter As Integer

        Dim pupilName As String
        Dim DS1 As New DataSet

        DS1 = FileManagement.QueryDatabase("SELECT Pupil_Forename,Pupil_Surname,Field_Moves_Level FROM [Pupil] WHERE Pupil_ID = " & pupilID, "pupilquery")
        pupilName = DS1.Tables("pupilquery").Rows(0).Item(0) & " " & DS1.Tables("pupilquery").Rows(0).Item(1).ToString

        wordapp3 = CreateObject("word.application")
        wordapp3.Visible = False
        worddoc3 = wordapp3.Documents.Add

        AddHeading(wordpara3, worddoc3, "Routine for " & pupilName & " - Level " & DS1.Tables("pupilquery").Rows(0).Item(2))

        AddHeading(wordpara3, worddoc3, "ROUTINE ELEMENTS:")

        For i = 0 To GlobalNumberOfElements - 1
            AddPara(wordpara3, worddoc3, "Element: " & DS.Tables("RoutineOutput").Rows(i).Item(0).ToString)
            AddPara(wordpara3, worddoc3, "Location: " & DS.Tables("RoutineOutput").Rows(i).Item(1).ToString)
            AddPara(wordpara3, worddoc3, "Heart Rate: " & DS.Tables("RoutineOutput").Rows(i).Item(2).ToString)
            AddPara(wordpara3, worddoc3, "Score: " & DS.Tables("RoutineOutput").Rows(i).Item(3).ToString)
            AddPara(wordpara3, worddoc3, "GOE: " & DS.Tables("RoutineOutput").Rows(i).Item(4).ToString)
            AddPara(wordpara3, worddoc3, "")
        Next

        AddHeadAndFoot(worddoc3, "FIGURE SKATING TRAINING SYSTEM - " & Now.ToString, "")

        wordapp3.Visible = True
        wordapp3.PrintPreview = True

    End Sub
    Private Sub AddHeading(ByRef wordpara As Word.Paragraph, ByRef worddoc As Word.Document, ByVal text As String)

        wordpara = worddoc.Content.Paragraphs.Add
        wordpara.Range.Text = text
        wordpara.Range.Style = "Heading 1"
        wordpara.Range.InsertParagraphAfter()

    End Sub
    Private Sub AddPara(ByRef wordpara As Word.Paragraph, ByRef worddoc As Word.Document, ByVal text As String)

        wordpara = worddoc.Content.Paragraphs.Add
        wordpara.Range.Text = text
        wordpara.Range.InsertParagraphAfter()

    End Sub
    Private Sub AddHeadAndFoot(ByRef worddoc As Word.Document, ByVal header As String, ByVal footer As String)

        worddoc.Sections(1).Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.Text = header
        worddoc.Sections(1).Footers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).PageNumbers.Add()

    End Sub
End Class