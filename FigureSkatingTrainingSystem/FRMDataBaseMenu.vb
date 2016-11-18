Public Class FRMDataBaseMenu

    Private Sub CMDBack_Click(sender As Object, e As EventArgs) Handles CMDBack.Click
        FRMMainMenu.MdiParent = FRMParent
        Me.Hide()
        FRMMainMenu.WindowState = FormWindowState.Maximized
        FRMMainMenu.Show()
    End Sub

    Private Sub CMDCreate_Click(sender As Object, e As EventArgs) Handles CMDCreate.Click
        FRMDataBaseAddMenu.MdiParent = FRMParent
        Me.Hide()
        FRMDataBaseAddMenu.WindowState = FormWindowState.Maximized
        FRMDataBaseAddMenu.Show()
    End Sub

    Private Sub CMDView_Click(sender As Object, e As EventArgs) Handles CMDView.Click
        FRMDataBaseSearch.MdiParent = FRMParent
        Me.Hide()
        FRMDataBaseSearch.WindowState = FormWindowState.Maximized
        FRMDataBaseSearch.Show()
    End Sub

End Class