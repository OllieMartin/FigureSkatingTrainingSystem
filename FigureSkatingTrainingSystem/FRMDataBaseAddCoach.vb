Public Class FRMDataBaseAddCoach

    Public PreviousForm As Windows.Forms.Form

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

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click
        If Not PreviousForm.Name = "FRMDataBaseMenu" Then
            PreviousForm.MdiParent = FRMParent
            Me.Close()
            PreviousForm.WindowState = FormWindowState.Maximized
            PreviousForm.Show()
            If PreviousForm.Name = "FRMDataBaseAddPupil" Then
                FRMDataBaseAddPupil.PopulateComboBox()
            End If
        Else
            FRMDataBaseMenu.MdiParent = FRMParent
            Me.Close()
            FRMDataBaseAddMenu.Close()
            FRMDataBaseMenu.WindowState = FormWindowState.Maximized
            FRMDataBaseMenu.Show()
        End If

    End Sub

    Private Sub CMDAdd_Click(sender As Object, e As EventArgs) Handles CMDAdd.Click

        If TXTFirstName.Text <> "" And TXTSurname.Text <> "" Then

            FileManagement.ExecuteDatabaseCommand("INSERT INTO [Coach] (Coach_Forename,Coach_Surname) VALUES ('" & TXTFirstName.Text & "','" & TXTSurname.Text & "')")

            If Not PreviousForm.Name = "FRMDataBaseMenu" Then
                PreviousForm.MdiParent = FRMParent
                Me.Close()
                PreviousForm.WindowState = FormWindowState.Maximized
                PreviousForm.Show()
                If PreviousForm.Name = "FRMDataBaseAddPupil" Then
                    FRMDataBaseAddPupil.PopulateComboBox()
                End If
            Else
                FRMDataBaseMenu.MdiParent = FRMParent
                Me.Close()
                FRMDataBaseAddMenu.Close()
                FRMDataBaseMenu.WindowState = FormWindowState.Maximized
                FRMDataBaseMenu.Show()
            End If

            MsgBox("Record Added to database!")

        Else

            MsgBox("Please complete all fields beforing trying to add a new coach")

        End If
    End Sub
End Class