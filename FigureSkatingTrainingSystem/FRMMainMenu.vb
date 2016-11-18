Public Class FRMMainMenu

    Private Sub CMDClose_Click(sender As Object, e As EventArgs) Handles CMDClose.Click
        'Closes the parent form and hence all child forms and terminates the program
        FRMParent.Close()
    End Sub

    Private Sub CMDRoutine_Click(sender As Object, e As EventArgs) Handles CMDRoutine.Click
        'Go to the routine planning section of the system
        FormManagement.SwitchForm(Me, FRMRoutineMenu, EMethod.Hide)
    End Sub

    Private Sub CMDDiary_Click(sender As Object, e As EventArgs) Handles CMDDiary.Click
        'Go to the training diary section of the system
        FormManagement.SwitchForm(Me, FRMDiaryMenu, EMethod.Hide)
    End Sub

    Private Sub CMDDBMS_Click(sender As Object, e As EventArgs) Handles CMDDBMS.Click
        'Go to the database management section of the system
        FormManagement.SwitchForm(Me, FRMDataBaseMenu, EMethod.Hide)
    End Sub

    Private Sub FRMMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class