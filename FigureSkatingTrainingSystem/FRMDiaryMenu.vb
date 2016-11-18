Imports Microsoft.Office.Interop

Public Class FRMDiaryMenu

    Private OFD1 As New OpenFileDialog

    Private Sub CMDBack_Click(sender As Object, e As EventArgs) Handles CMDBack.Click

        'Returns to the main menu

        FRMMainMenu.MdiParent = FRMParent
        Me.Hide()
        FRMMainMenu.WindowState = FormWindowState.Maximized
        FRMMainMenu.Show()
    End Sub

    Private Sub CMDCreate_Click(sender As Object, e As EventArgs) Handles CMDCreate.Click

        'Switches to FRMDiaryScreen1

        FRMDiaryScreen1.MdiParent = FRMParent
        Me.Hide()
        FRMDiaryScreen1.WindowState = FormWindowState.Maximized
        FRMDiaryScreen1.Show()
    End Sub

    Private Sub CMDView_Click(sender As Object, e As EventArgs) Handles CMDView.Click

        'Displays an openfiledialog so the user can select a previous diary, then opens it in Microsoft Word

        Dim Wordapp As New Word.Application
        Dim Worddoc As New Word.Document
        Dim FileName As String
        OFD1.InitialDirectory = FileManagement.DiaryPath
        OFD1.Filter = "Microsoft Word Files (*.doc)|*.doc|All Files (*.*)|*.*"
        OFD1.ShowDialog()
        FileName = OFD1.FileName()

        If Not FileName = "" Then

            Wordapp = CreateObject("word.application")
            Wordapp.Visible = True
            Worddoc = Wordapp.Documents.Add
            Wordapp.Documents.Open(FileName)

        End If

    End Sub

End Class