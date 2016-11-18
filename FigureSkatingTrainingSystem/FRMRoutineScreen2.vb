Imports System.Environment
Imports System.Data
Imports System.Xml
Public Class FRMRoutineScreen2

    Private DS As New DataSet 'Dataset to store all queried information from the database

    Private SkatingHR As Integer 'Stores the Skating HR value for the currently selected pupil
    Private RestingHR As Integer 'Stores the Resting HR value for the currently selected pupil
    Private HRDecreaseRate As Single 'Stores the HR Decrease Rate for the currently selected pupil
    Private MaxHR As Integer 'Stores the Maximum HR value for the currently selected pupil
    Private SelectedPupilID As Integer = FRMRoutineScreen1.GetPupilID 'Stores the ID for the currently selected pupil
    Private PresentationScore As Single 'Stores the Presentation Score for the currently selected pupil
    Private PupilLevel As Integer 'Stores the Level for the currently selected pupil
    Private CMBEnabled As Boolean 'Stores a boolean value, True if CMBLevel on FRMRoutineScreen1 is enabled, And false if it is not

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click

        'Return to the routine planning menu

        FRMRoutineMenu.MdiParent = FRMParent
        Me.Close()
        FRMRoutineScreen1.Close()
        FRMRoutineMenu.WindowState = FormWindowState.Maximized
        FRMRoutineMenu.Show()
    End Sub

    Private Sub FRMRoutineScreen2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Loads in all required information from database and populates checked list boxes

        Dim i As Integer 'Stepper/Counter variable for FOR loops
        Dim RecordCount As Integer 'Number of records in database
        Dim CurrentElement As String 'Stores the unique ID for the current element being processed

        PupilLevel = FRMRoutineScreen1.CMBLevel.SelectedItem
        CMBEnabled = FRMRoutineScreen1.CMBLevel.Enabled

        DS = FileManagement.QueryDatabase("SELECT * FROM [Pupil] WHERE Pupil_ID = " & SelectedPupilID, "pupilinfo")

        RecordCount = DS.Tables("pupilinfo").Rows.Count

        For i = 7 To 30
            CurrentElement = Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName))
            If CMBEnabled = True Then
                Select Case PupilLevel
                    Case Is = 1
                        If CurrentElement = "1S" Or CurrentElement = "1T" Or CurrentElement = "1Lo" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                    Case Is = 2
                        If CurrentElement = "1S" Or CurrentElement = "1T" Or CurrentElement = "1Lo" Or CurrentElement = "1F" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                    Case Is = 3
                        If CurrentElement = "1S" Or CurrentElement = "1T" Or CurrentElement = "1Lo" Or CurrentElement = "1F" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                    Case Is = 4
                        If CurrentElement = "1Lo" Or CurrentElement = "1F" Or CurrentElement = "1Lz" Or CurrentElement = "1A" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                    Case Is = 5
                        If CurrentElement = "1F" Or CurrentElement = "1Lz" Or CurrentElement = "1A" Or CurrentElement = "2S" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                    Case Is = 6
                        If CurrentElement = "1Lz" Or CurrentElement = "1A" Or CurrentElement = "2S" Or CurrentElement = "2T" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                    Case Is = 7
                        If CurrentElement = "1A" Or CurrentElement = "2S" Or CurrentElement = "2T" Or CurrentElement = "2Lo" Or CurrentElement = "1Lz" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                    Case Is = 8
                        If CurrentElement = "1A" Or CurrentElement = "2S" Or CurrentElement = "2T" Or CurrentElement = "2Lo" Or CurrentElement = "1Lz" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                    Case Is = 9
                        If CurrentElement = "2A" Or CurrentElement = "2S" Or CurrentElement = "2T" Or CurrentElement = "2Lo" Or CurrentElement = "2F" Or CurrentElement = "2Lz" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                    Case Is = 10
                        If CurrentElement = "2A" Or CurrentElement = "3S" Or CurrentElement = "2T" Or CurrentElement = "2Lo" Or CurrentElement = "2F" Or CurrentElement = "2Lz" Or CurrentElement = "2S" Then
                            CLBNeeded.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
                        End If
                End Select
            Else
                CLBOther.Items.Add(CurrentElement & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
            End If
        Next
        For i = 31 To 34
            CurrentElement = Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName))
            If CMBEnabled = True Then
                Select Case PupilLevel
                    Case Is = 1
                        If CurrentElement = "USp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Is = 2
                        If CurrentElement = "USp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Is = 3
                        If CurrentElement = "SSp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Is = 4
                        If CurrentElement = "CSp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Is = 5
                        If CurrentElement = "SSp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Is = 6
                        If CurrentElement = "CSp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Is = 7
                        If CurrentElement = "SSp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Is = 8
                        If CurrentElement = "CSp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Else
                        CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                End Select
            Else
                CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
            End If
        Next
        For i = 39 To 42
            CurrentElement = Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName))
            If CMBEnabled = True Then
                Select Case PupilLevel
                    Case Is = 9
                        If CurrentElement = "FCSp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Is = 10
                        If CurrentElement = "FSSp" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                        End If
                    Case Else
                        CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
                End Select
            Else
                CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
            End If
        Next
        For i = 47 To 50
            CLBOther.Items.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)) & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 4).ToString & ")")
        Next
        For i = 55 To 56
            CurrentElement = Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName))
            If CMBEnabled = True Then
                Select Case PupilLevel
                    Case Is = 1
                        CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 2).ToString & ")")
                    Case Else
                        If CurrentElement = "(F)CoSp2p" Then
                            CLBNeeded.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 2).ToString & ")")
                        Else
                            CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 2).ToString & ")")
                        End If
                End Select
            Else
                CLBOther.Items.Add(CurrentElement & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 2).ToString & ")")
            End If
        Next
        For i = 59 To 60
            CLBOther.Items.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)) & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 2).ToString & ")")
        Next
        For i = 63 To 63
            If CMBEnabled = True Then
                CLBNeeded.Items.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)) & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 1).ToString & ")")
            Else
                CLBOther.Items.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)) & DS.Tables("pupilinfo").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupilinfo").Rows(0).Item(i + 1).ToString & ")")
            End If
        Next
        For i = 65 To 65
            CLBOther.Items.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)) & " (" & DS.Tables("pupilinfo").Rows(0).Item(i).ToString & ")")
        Next

        SkatingHR = DS.Tables("pupilinfo").Rows(0).Item(70)
        RestingHR = DS.Tables("pupilinfo").Rows(0).Item(69)
        HRDecreaseRate = DS.Tables("pupilinfo").Rows(0).Item(68)
        MaxHR = DS.Tables("pupilinfo").Rows(0).Item(67)
        PresentationScore = DS.Tables("pupilinfo").Rows(0).Item(71)

    End Sub

    Private Sub CMDStart_Click(sender As Object, e As EventArgs) Handles CMDStart.Click

        'Starts the routine planning algorithm and provides it will all required information

        Dim Elements As New ArrayList 'Stores a list of all the elements to be included in the routine as String values
        Dim RoutineLength As Integer 'Stores the length of the routine to be created in seconds

        If CLBOther.CheckedItems.Count + CLBNeeded.CheckedItems.Count <= 13 And CLBOther.CheckedItems.Count + CLBNeeded.CheckedItems.Count > 0 Then
            Elements.AddRange(CLBOther.CheckedItems)
            Elements.AddRange(CLBNeeded.CheckedItems)
            RoutineLength = CDec(FRMRoutineScreen1.CMBLength.SelectedItem.ToString.Replace(":", ".")) * 60

            RoutinePlanning.Main(Elements, RoutineLength)
        Else
            MsgBox("You must select between 1 and 13 elements!")
        End If

    End Sub

    Public Function GetSkatingHR() As Integer
        Return SkatingHR
    End Function
    Public Function GetRestingHR() As Integer
        Return RestingHR
    End Function
    Public Function GetHRDecreaseRate() As Integer
        Return HRDecreaseRate
    End Function
    Public Function GetMaxHR() As Integer
        Return MaxHR
    End Function
    Public Function GetSelectedPupilID() As Integer
        Return SelectedPupilID
    End Function
    Public Function GetPresentationScore() As Integer
        Return PresentationScore
    End Function

    Private Sub CMDAuto_Click(sender As Object, e As EventArgs) Handles CMDAuto.Click

        'Automatically selects all elements in the required elements checked list box

        Dim i As Integer 'Counter variable for FOR loops

        For i = 0 To CLBNeeded.Items.Count - 1
            CLBNeeded.SetItemChecked(i, True)
        Next
    End Sub
End Class