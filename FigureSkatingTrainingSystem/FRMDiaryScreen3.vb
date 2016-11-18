Imports FigureSkatingTrainingSystem.TDiary
Imports FigureSkatingTrainingSystem.TPeriod
Imports FigureSkatingTrainingSystem.Periods
Imports Microsoft.Office.Interop
Imports System.Environment
Imports System.IO
Public Class FRMDiaryScreen3

    Private GTransition As TPeriod
    Private GOffSeason As TPeriod
    Private GPreseason As TPeriod
    Private GInSeason As TPeriod
    Private GDiary(366) As TDiary

    Public Sub Main(ByRef Diary() As TDiary, ByVal Transition As TPeriod, ByVal OffSeason As TPeriod, ByVal Preseason As TPeriod, ByVal InSeason As TPeriod)

        LBLTransition.Text = "Transition: " & Transition.StartDate
        LBLOffSeason.Text = "Off-Season: " & OffSeason.StartDate
        LBLPreSeason.Text = "Preseason: " & Preseason.StartDate
        LBLInSeason.Text = "In-Season: " & InSeason.StartDate

        GTransition = Transition
        GOffSeason = OffSeason
        GPreseason = Preseason
        GInSeason = InSeason
        GDiary = Diary

    End Sub

    Private Sub CMDBack_Click(sender As Object, e As EventArgs) Handles CMDBack.Click

        FRMDiaryMenu.MdiParent = FRMParent
        Me.Hide()
        FRMDiaryMenu.WindowState = FormWindowState.Maximized
        FRMDiaryMenu.Show()
        FRMDiaryScreen1.Close()
        FRMDiaryScreen2.Close()
        Me.Close()

    End Sub 'Close all diary forms and return to diary menu

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

    Private Sub CMDSave_Click(sender As Object, e As EventArgs) Handles CMDSave.Click
        Dim wordapp2 As Word.Application
        Dim worddoc2 As Word.Document
        Dim wordpara2 As Word.Paragraph
        Dim pupilID As Integer = FRMDiaryScreen1.GetPupilID
        Dim counter As Integer
        Dim Avaliable As Boolean

        Dim pupilName As String
        Dim DS As New DataSet

        FRMProgressBar.Show()
        FRMProgressBar.Main("Your training diary is being created, please wait...")

        DS = FileManagement.QueryDatabase("SELECT Pupil_Forename,Pupil_Surname,Field_Moves_Level FROM [Pupil] WHERE Pupil_ID = " & pupilID, "pupilquery")
        pupilName = DS.Tables("pupilquery").Rows(0).Item(0) & " " & DS.Tables("pupilquery").Rows(0).Item(1)
        Dim path As String = FileManagement.DiaryPath & "\" & pupilID & "-" & pupilName & ".doc"

        wordapp2 = CreateObject("word.application")
        wordapp2.Visible = False
        worddoc2 = wordapp2.Documents.Add

        AddHeading(wordpara2, worddoc2, "Training Diary for " & pupilName & " - Level " & DS.Tables("pupilquery").Rows(0).Item(2))
        AddHeading(wordpara2, worddoc2, "Starting Date: " & GDiary(1).NodeDate)
        AddHeading(wordpara2, worddoc2, "Season Start Dates:")

        AddPara(wordpara2, worddoc2, "  - Transition: " & GTransition.StartDate)
        AddPara(wordpara2, worddoc2, "  - Off-Season: " & GOffSeason.StartDate)
        AddPara(wordpara2, worddoc2, "  - Preseason: " & GPreseason.StartDate)
        AddPara(wordpara2, worddoc2, "  - In-Season: " & GInSeason.StartDate)

        AddHeading(wordpara2, worddoc2, "TRANSITION PHASE")

        FRMProgressBar.PRGBar.Value = 20

        For i = GTransition.StartIndex To GTransition.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara2, worddoc2, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara2, worddoc2, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        FRMProgressBar.PRGBar.Value = 40

        AddHeading(wordpara2, worddoc2, "OFF-SEASON PHASE")

        For i = GOffSeason.StartIndex To GOffSeason.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara2, worddoc2, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara2, worddoc2, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        FRMProgressBar.PRGBar.Value = 60

        AddHeading(wordpara2, worddoc2, "PRESEASON PHASE")

        For i = GPreseason.StartIndex To GPreseason.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara2, worddoc2, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara2, worddoc2, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        FRMProgressBar.PRGBar.Value = 80

        AddHeading(wordpara2, worddoc2, "IN-SEASON PHASE")

        For i = GInSeason.StartIndex To GInSeason.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara2, worddoc2, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara2, worddoc2, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        AddHeadAndFoot(worddoc2, "FIGURE SKATING TRAINING SYSTEM - " & Now.ToString, "")

        FRMProgressBar.PRGBar.Value = 100

        Do
            If File.Exists(path) Then
                counter = counter + 1
                If counter = 1 Then
                    path = Mid(path, 1, Len(path) - 4) & counter.ToString
                Else
                    path = Mid(path, 1, Len(path) - 5) & counter
                End If
            Else
                Avaliable = True
            End If
        Loop Until Avaliable
        worddoc2.SaveAs2(path)

        FRMProgressBar.Close()
        MsgBox("Diary Saved!")

        wordapp2.Quit()
    End Sub
    Private Sub CMDPrint_Click(sender As Object, e As EventArgs) Handles CMDPrint.Click
        Dim wordapp3 As Word.Application
        Dim worddoc3 As Word.Document
        Dim wordpara3 As Word.Paragraph
        Dim pupilID As Integer = FRMDiaryScreen1.GetPupilID
        Dim counter As Integer
        Dim Avaliable As Boolean

        Dim pupilName As String
        Dim DS As New DataSet

        FRMProgressBar.Show()
        FRMProgressBar.Main("Your training diary is being created, please wait...")

        DS = FileManagement.QueryDatabase("SELECT Pupil_Forename,Pupil_Surname,Field_Moves_Level FROM [Pupil] WHERE Pupil_ID = " & pupilID, "pupilquery")
        pupilName = DS.Tables("pupilquery").Rows(0).Item(0) & " " & DS.Tables("pupilquery").Rows(0).Item(1)
        Dim path As String = FileManagement.DiaryPath & "\" & pupilID & "-" & pupilName & ".doc"

        wordapp3 = CreateObject("word.application")
        wordapp3.Visible = False
        worddoc3 = wordapp3.Documents.Add

        AddHeading(wordpara3, worddoc3, "Training Diary for " & pupilName & " - Level " & DS.Tables("pupilquery").Rows(0).Item(2))
        AddHeading(wordpara3, worddoc3, "Starting Date: " & GDiary(1).NodeDate)
        AddHeading(wordpara3, worddoc3, "Season Start Dates:")

        AddPara(wordpara3, worddoc3, "  - Transition: " & GTransition.StartDate)
        AddPara(wordpara3, worddoc3, "  - Off-Season: " & GOffSeason.StartDate)
        AddPara(wordpara3, worddoc3, "  - Preseason: " & GPreseason.StartDate)
        AddPara(wordpara3, worddoc3, "  - In-Season: " & GInSeason.StartDate)

        AddHeading(wordpara3, worddoc3, "TRANSITION PHASE")

        FRMProgressBar.PRGBar.Value = 20

        For i = GTransition.StartIndex To GTransition.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara3, worddoc3, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara3, worddoc3, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        FRMProgressBar.PRGBar.Value = 40

        AddHeading(wordpara3, worddoc3, "OFF-SEASON PHASE")

        For i = GOffSeason.StartIndex To GOffSeason.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara3, worddoc3, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara3, worddoc3, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        FRMProgressBar.PRGBar.Value = 60

        AddHeading(wordpara3, worddoc3, "PRESEASON PHASE")

        For i = GPreseason.StartIndex To GPreseason.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara3, worddoc3, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara3, worddoc3, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        FRMProgressBar.PRGBar.Value = 80

        AddHeading(wordpara3, worddoc3, "IN-SEASON PHASE")

        For i = GInSeason.StartIndex To GInSeason.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara3, worddoc3, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara3, worddoc3, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        AddHeadAndFoot(worddoc3, "FIGURE SKATING TRAINING SYSTEM - " & Now.ToString, "")

        FRMProgressBar.PRGBar.Value = 100

        Do
            If File.Exists(path) Then
                counter = counter + 1
                If counter = 1 Then
                    path = Mid(path, 1, Len(path) - 4) & counter.ToString
                Else
                    path = Mid(path, 1, Len(path) - 5) & counter
                End If
            Else
                Avaliable = True
            End If
        Loop Until Avaliable
        worddoc3.SaveAs2(path)

        FRMProgressBar.Close()
        MsgBox("Diary Created and Saved! The diary will now be printed, press 'OK'")

        wordapp3.PrintPreview = True

        Try
            wordapp3.PrintOut()
        Catch
            MsgBox("Cannot connect to printer! Please make sure you have a default printer selected and that it is switched on.")
        End Try

        wordapp3.Quit()

    End Sub
    Private Sub CMDViewDiary_Click(sender As Object, e As EventArgs) Handles CMDViewDiary.Click
        Dim wordapp As Word.Application
        Dim worddoc As Word.Document
        Dim wordpara As Word.Paragraph
        Dim pupilID As Integer = FRMDiaryScreen1.GetPupilID
        Dim counter As Integer
        Dim Avaliable As Boolean

        Dim pupilName As String
        Dim DS As New DataSet

        FRMProgressBar.Show()
        FRMProgressBar.Main("Your training diary is being created inside Microsoft Word, please wait...")

        DS = FileManagement.QueryDatabase("SELECT Pupil_Forename,Pupil_Surname,Field_Moves_Level FROM [Pupil] WHERE Pupil_ID = " & pupilID, "pupilquery")
        pupilName = DS.Tables("pupilquery").Rows(0).Item(0) & " " & DS.Tables("pupilquery").Rows(0).Item(1)
        Dim path As String = FileManagement.DiaryPath & "\" & pupilID & "-" & pupilName & ".doc"

        wordapp = CreateObject("word.application")
        wordapp.Visible = False
        worddoc = wordapp.Documents.Add
        Dim para As Word.Paragraph = worddoc.Paragraphs.Add()

        AddHeading(wordpara, worddoc, "Training Diary for " & pupilName & " - Level " & DS.Tables("pupilquery").Rows(0).Item(2))
        AddHeading(wordpara, worddoc, "Starting Date: " & GDiary(1).NodeDate)
        AddHeading(wordpara, worddoc, "Season Start Dates:")

        AddPara(wordpara, worddoc, "  - Transition: " & GTransition.StartDate)
        AddPara(wordpara, worddoc, "  - Off-Season: " & GOffSeason.StartDate)
        AddPara(wordpara, worddoc, "  - Preseason: " & GPreseason.StartDate)
        AddPara(wordpara, worddoc, "  - In-Season: " & GInSeason.StartDate)

        AddHeading(wordpara, worddoc, "TRANSITION PHASE")

        FRMProgressBar.PRGBar.Value = 20

        For i = GTransition.StartIndex To GTransition.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara, worddoc, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara, worddoc, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        FRMProgressBar.PRGBar.Value = 40

        AddHeading(wordpara, worddoc, "OFF-SEASON PHASE")

        For i = GOffSeason.StartIndex To GOffSeason.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara, worddoc, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara, worddoc, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        FRMProgressBar.PRGBar.Value = 60

        AddHeading(wordpara, worddoc, "PRESEASON PHASE")

        For i = GPreseason.StartIndex To GPreseason.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara, worddoc, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara, worddoc, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        FRMProgressBar.PRGBar.Value = 80

        AddHeading(wordpara, worddoc, "IN-SEASON PHASE")

        For i = GInSeason.StartIndex To GInSeason.EndIndex
            If GDiary(i).Skate = True Then
                AddPara(wordpara, worddoc, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - TRAINING SESSION AT ICE RINK - " & GDiary(i).Activities)
            Else
                AddPara(wordpara, worddoc, GDiary(i).NodeDate & " - " & (GDiary(i).NodeDate.DayOfWeek) & " - " & GDiary(i).Activities)
            End If
        Next

        AddHeadAndFoot(worddoc, "FIGURE SKATING TRAINING SYSTEM - " & Now.ToString, "")

        FRMProgressBar.PRGBar.Value = 100

        Do
            If File.Exists(path) Then
                counter = counter + 1
                If counter = 1 Then
                    path = Mid(path, 1, Len(path) - 4) & counter.ToString
                Else
                    path = Mid(path, 1, Len(path) - 5) & counter
                End If
            Else
                Avaliable = True
            End If
        Loop Until Avaliable
        worddoc.SaveAs2(path)

        FRMProgressBar.Close()
        MsgBox("Diary Created and saved! Press OK to view the diary")
        wordapp.Visible = True

    End Sub

End Class