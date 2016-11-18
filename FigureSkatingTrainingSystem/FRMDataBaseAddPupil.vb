Public Class FRMDataBaseAddPupil

    Private DS As New DataSet
    Public PreviousForm As Windows.Forms.Form
    Private Valid As Boolean

    Private Sub TXTFirstName_LostFocus(sender As Object, e As EventArgs) Handles TXTFirstName.LostFocus

        If Not IsText(TXTFirstName.Text) Then

            MsgBox("Must only use letters A-Z")
            TXTFirstName.Focus()

        End If

    End Sub

    Private Sub TXTSurname_LostFocus(sender As Object, e As EventArgs) Handles TXTSurname.LostFocus
        If Not IsText(TXTSurname.Text) Then

            MsgBox("Must only use letters A-Z")
            TXTSurname.Focus()

        End If
    End Sub

    Private Sub TXTFMLevel_LostFocus(sender As Object, e As EventArgs) Handles TXTFMLevel.LostFocus

        Valid = False

        If IsNumeric(TXTFMLevel.Text) Then
            If CInt(TXTFMLevel.Text) >= 0 And CInt(TXTFMLevel.Text) <= 10 Then
                Valid = True
            End If
        Else
            If TXTFMLevel.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a numerical value between 0 and 10")
            TXTFMLevel.Focus()
        End If

    End Sub

    Private Sub TXTElementsLevel_LostFocus(sender As Object, e As EventArgs) Handles TXTElementsLevel.LostFocus

        Valid = False

        If IsNumeric(TXTElementsLevel.Text) Then
            If CInt(TXTElementsLevel.Text) >= 0 And CInt(TXTElementsLevel.Text) <= 10 Then
                Valid = True
            End If
        Else
            If TXTElementsLevel.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a numerical value between 0 and 10")
            TXTElementsLevel.Focus()
        End If

    End Sub

    Private Sub TXTFreeLevel_LostFocus(sender As Object, e As EventArgs) Handles TXTFreeLevel.LostFocus

        Valid = False

        If IsNumeric(TXTFreeLevel.Text) Then
            If CInt(TXTFreeLevel.Text) >= 0 And CInt(TXTFreeLevel.Text) <= 10 Then
                Valid = True
            End If
        Else
            If TXTFreeLevel.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a numerical value between 0 and 10")
            TXTFreeLevel.Focus()
        End If

    End Sub

    Private Sub TXTMaxHR_LostFocus(sender As Object, e As EventArgs) Handles TXTMaxHR.LostFocus

        Valid = False

        If IsNumeric(TXTMaxHR.Text) Then
            If CInt(TXTMaxHR.Text) >= 0 And CInt(TXTMaxHR.Text) <= 300 Then
                Valid = True
            End If
        Else
            If TXTMaxHR.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a numerical value between 0 and 300")
            TXTMaxHR.Focus()
        End If

    End Sub

    Private Sub TXTRestHR_LostFocus(sender As Object, e As EventArgs) Handles TXTRestHR.LostFocus

        Valid = False

        If IsNumeric(TXTRestHR.Text) Then
            If CInt(TXTRestHR.Text) >= 0 And CInt(TXTRestHR.Text) <= 300 Then
                Valid = True
            End If
        Else
            If TXTRestHR.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a numerical value between 0 and 300")
            TXTRestHR.Focus()
        End If

    End Sub

    Private Sub TXTSkatingHR_LostFocus(sender As Object, e As EventArgs) Handles TXTSkatingHR.LostFocus

        Valid = False

        If IsNumeric(TXTSkatingHR.Text) Then
            If CInt(TXTSkatingHR.Text) >= 0 And CInt(TXTSkatingHR.Text) <= 300 Then
                Valid = True
            End If
        Else
            If TXTSkatingHR.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a numerical value between 0 and 300")
            TXTSkatingHR.Focus()
        End If

    End Sub

    Private Sub TXTHRDecRate_LostFocus(sender As Object, e As EventArgs) Handles TXTHRDecRate.LostFocus

        Valid = False

        If IsNumeric(TXTHRDecRate.Text) Then
            If CDec(TXTHRDecRate.Text) >= 0 And CDec(TXTHRDecRate.Text) <= 1 Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a decimal value between 0 and 1")
            TXTHRDecRate.Focus()
        End If

    End Sub

    Private Sub TXTPresentationScore_LostFocus(sender As Object, e As EventArgs) Handles TXTPresentationScore.LostFocus

        Valid = False

        If IsNumeric(TXTPresentationScore.Text) Then
            If CDec(TXTPresentationScore.Text) >= 0 And CDec(TXTPresentationScore.Text) <= 10 Then
                Valid = True
            End If
        Else
            If TXTPresentationScore.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a decimal value between 0 and 10")
            TXTPresentationScore.Focus()
        End If

    End Sub

    Private Sub TXTStandingJump_LostFocus(sender As Object, e As EventArgs) Handles TXTStandingJump.LostFocus

        Valid = False

        If IsNumeric(TXTStandingJump.Text) Then
            If CDec(TXTStandingJump.Text) >= 0 And CDec(TXTStandingJump.Text) < 100 Then
                Valid = True
            End If
        Else
            If TXTStandingJump.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a decimal value greater than or equal to 0 but less than 100")
            TXTStandingJump.Focus()
        End If

    End Sub

    Private Sub TXTPikeReach_LostFocus(sender As Object, e As EventArgs) Handles TXTPikeReach.LostFocus

        Valid = False

        If IsNumeric(TXTPikeReach.Text) Then
            If CDec(TXTPikeReach.Text) >= 0 And CDec(TXTPikeReach.Text) < 100 Then
                Valid = True
            End If
        Else
            If TXTPikeReach.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a decimal value greater than or equal to 0 but less than 100")
            TXTPikeReach.Focus()
        End If

    End Sub

    Private Sub TXTBleepTest_LostFocus(sender As Object, e As EventArgs) Handles TXTBleepTest.LostFocus

        Valid = False

        If IsNumeric(TXTBleepTest.Text) Then
            If CDec(TXTBleepTest.Text) >= 0 And CDec(TXTBleepTest.Text) < 100 Then
                Valid = True
            End If
        Else
            If TXTBleepTest.Text = "" Then
                Valid = True
            End If
        End If

        If Not Valid Then
            MsgBox("Must be a decimal value greater than or equal to 0 but less than 100")
            TXTBleepTest.Focus()
        End If

    End Sub

    Private Function IsText(ByVal Input As String)

        Dim Checker As Boolean = False

        For i = 0 To Input.Length - 1
            If Not Char.IsLetter(Input.Chars(i)) Then
                Checker = True
            End If
        Next

        If Not Checker = True Then
            Return True
        End If

    End Function

    Private Sub FRMDataBaseAddPupil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateComboBox()
        TXTMaxHR.Text = "200"
        TXTRestHR.Text = "60"
        TXTHRDecRate.Text = "0.1"
        TXTSkatingHR.Text = "80"

    End Sub

    Public Sub PopulateComboBox()

        Dim i As Integer 'Stepper variable for FOR loops
        Dim RecordCount As Integer ' Number of records in database

        DS = FileManagement.QueryDatabase("SELECT * FROM [Coach]", "coachinfo")

        RecordCount = DS.Tables("coachinfo").Rows.Count

        CMBPupilCoach.Items.Clear()

        For i = 0 To RecordCount - 1
            CMBPupilCoach.Items.Add("(" & DS.Tables("coachinfo").Rows(i).Item(0) & ") " & DS.Tables("coachinfo").Rows(i).Item(1) & " " & DS.Tables("coachinfo").Rows(i).Item(2))
        Next

    End Sub 'Populate all combo boxes on the form

    Private Sub CMDNext_Click(sender As Object, e As EventArgs) Handles CMDNext.Click
        If TXTFirstName.Text <> "" And TXTSurname.Text <> "" And TXTFMLevel.Text <> "" And TXTElementsLevel.Text <> "" And TXTFreeLevel.Text <> "" And TXTHRDecRate.Text <> "" And TXTMaxHR.Text <> "" And TXTPresentationScore.Text <> "" And TXTRestHR.Text <> "" And TXTSkatingHR.Text <> "" And CMBPupilCoach.SelectedIndex >= 0 Then
            If TXTBleepTest.Text = "" Then
                TXTBleepTest.Text = "0"
            End If
            If TXTPikeReach.Text = "" Then
                TXTPikeReach.Text = "0"
            End If
            If TXTStandingJump.Text = "" Then
                TXTStandingJump.Text = "0"
            End If
            FileManagement.ExecuteDatabaseCommand("INSERT INTO [Pupil] (Pupil_Forename,Pupil_Surname,Date_Of_Birth,Field_Moves_Level,Elements_Level,Free_Level,Pupil_Coach_ID,Max_HR,HR_Decrease_Rate,Resting_HR,Skating_HR,Presentation_Score,Standing_Jump,Pike_Reach,Bleep_Test) VALUES ('" & TXTFirstName.Text & "','" & TXTSurname.Text & "','" & DTPPupilDOB.Value & "','" & TXTFMLevel.Text & "','" & TXTElementsLevel.Text & "','" & TXTFreeLevel.Text & "','" & DS.Tables("coachinfo").Rows(CMBPupilCoach.SelectedIndex).Item(0) & "','" & TXTMaxHR.Text & "','" & TXTHRDecRate.Text & "','" & TXTRestHR.Text & "','" & TXTSkatingHR.Text & "','" & TXTPresentationScore.Text & "','" & TXTStandingJump.Text & "','" & TXTPikeReach.Text & "','" & TXTBleepTest.Text & "')")

            FRMDataBaseAddPupil2.MdiParent = FRMParent
            Me.Hide()
            FRMDataBaseAddPupil2.WindowState = FormWindowState.Maximized
            FRMDataBaseAddPupil2.Show()

            MsgBox("Record Added to database!")
        Else
            MsgBox("Please fill in all required fields marked with a * to continue")
        End If
    End Sub

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click

        If Not PreviousForm.Name = "FRMDataBaseAddMenu" Then
            PreviousForm.MdiParent = FRMParent
            Me.Close()
            PreviousForm.WindowState = FormWindowState.Maximized
            PreviousForm.Show()
            If PreviousForm.Name = "FRMRoutineScreen1" Then
                FRMRoutineScreen1.PopulateComboBoxes()
            ElseIf PreviousForm.Name = "FRMDiaryScreen1" Then
                FRMDiaryScreen1.PopulateComboBoxes()
            End If
        Else
            FRMDataBaseMenu.MdiParent = FRMParent
            Me.Close()
            FRMDataBaseAddMenu.Close()
            FRMDataBaseMenu.WindowState = FormWindowState.Maximized
            FRMDataBaseMenu.Show()
        End If

    End Sub

    Private Sub CMDAddNewCoach_Click(sender As Object, e As EventArgs) Handles CMDAddNewCoach.Click

        FRMDataBaseAddCoach.MdiParent = FRMParent
        Me.Hide()
        FRMDataBaseAddCoach.WindowState = FormWindowState.Maximized
        FRMDataBaseAddCoach.PreviousForm = Me
        FRMDataBaseAddCoach.Show()

    End Sub
End Class