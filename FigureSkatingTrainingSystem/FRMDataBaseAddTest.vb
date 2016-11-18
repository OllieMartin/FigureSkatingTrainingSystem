Public Class FRMDataBaseAddTest

    Private Sub CMDAdd_Click(sender As Object, e As EventArgs) Handles CMDAdd.Click
        FileManagement.ExecuteDatabaseCommand("INSERT INTO [Test] (Test_Date) VALUES ('" & DTPStart.Value & "')")

        FRMDataBaseMenu.MdiParent = FRMParent
        Me.Close()
        FRMDataBaseAddMenu.Close()
        FRMDataBaseMenu.WindowState = FormWindowState.Maximized
        FRMDataBaseMenu.Show()

        MsgBox("Record Added to database!")
    End Sub

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click
        FRMDataBaseMenu.MdiParent = FRMParent
        Me.Close()
        FRMDataBaseAddMenu.Close()
        FRMDataBaseMenu.WindowState = FormWindowState.Maximized
        FRMDataBaseMenu.Show()
    End Sub

End Class