Public Class FRMDataBaseAddComp

    Private Sub CMDAdd_Click(sender As Object, e As EventArgs) Handles CMDAdd.Click
        If TXTCompName.Text <> "" And CMBLevel.SelectedIndex >= 0 Then
            FileManagement.ExecuteDatabaseCommand("INSERT INTO [Competition] (Competition_Name,Competition_Start_Date,Competition_Finish_Date,Minimum_Level) VALUES ('" & TXTCompName.Text & "','" & DTPStart.Value & "','" & DTPFinish.Value & "','" & CMBLevel.SelectedIndex & "')")

            FRMDataBaseMenu.MdiParent = FRMParent
            Me.Close()
            FRMDataBaseAddMenu.Close()
            FRMDataBaseMenu.WindowState = FormWindowState.Maximized
            FRMDataBaseMenu.Show()

            MsgBox("Record Added to database!")
        Else
            MsgBox("Please fill in all fields to add a new competition")
        End If
    End Sub

    Private Sub FRMDataBaseAddComp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 10
            CMBLevel.Items.Add(i)
        Next
    End Sub

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click
        FRMDataBaseMenu.MdiParent = FRMParent
        Me.Close()
        FRMDataBaseAddMenu.Close()
        FRMDataBaseMenu.WindowState = FormWindowState.Maximized
        FRMDataBaseMenu.Show()
    End Sub
End Class