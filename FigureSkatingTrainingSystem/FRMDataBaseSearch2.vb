Public Class FRMDataBaseSearch2

    Private Sub CMDUpdate_Click(sender As Object, e As EventArgs) Handles CMDUpdate.Click

        Try
            FileManagement.ExecuteDatabaseCommand("UPDATE [" & FRMDataBaseSearch.GetSelectedTable & "] SET [" & FRMDataBaseSearch.GetSelectedField & "]=" & "'" & TextBox1.Text & "'" & " WHERE [" & FRMDataBaseSearch.GetSelectedIDFieldName & "]=" & FRMDataBaseSearch.GetSelectedID)
            FRMDataBaseSearch.Search()
            Me.Close()
        Catch
            Try
                FileManagement.ExecuteDatabaseCommand("UPDATE [" & FRMDataBaseSearch.GetSelectedTable & "] SET [" & FRMDataBaseSearch.GetSelectedField & "]=" & TextBox1.Text & " WHERE [" & FRMDataBaseSearch.GetSelectedIDFieldName & "]=" & FRMDataBaseSearch.GetSelectedID)
                FRMDataBaseSearch.Search()
                Me.Close()
            Catch
                MsgBox("Invalid Input")
            End Try
        End Try

    End Sub

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click
        Me.Close()
    End Sub

End Class