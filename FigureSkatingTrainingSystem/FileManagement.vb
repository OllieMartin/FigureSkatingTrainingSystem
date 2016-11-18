Imports System.Environment
Imports System.IO
Module FileManagement

    Public DocPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Public MainPath As String = DocPath & "\FigureSkatingTrainingSystem"
    Public RoutinePath As String = MainPath & "\Routines"
    Public DiaryPath As String = MainPath & "\Diaries"
    Public DBPath As String = MainPath & "\Databases"
    Private OFD As New OpenFileDialog

    Public Sub StartUp()

        Dim FatalErrorResult As Integer

        If Not Directory.Exists(MainPath) Then
            FirstStart()
        Else
            If Not Directory.Exists(RoutinePath) Or Not Directory.Exists(DBPath) Or Not Directory.Exists(DiaryPath) Then

                FatalErrorResult = MsgBox("Files have become corrupted, do you wish to restore your system and files to factory settings? This will delete all stored routines, diaries and databases? If Not the system will now close.", MsgBoxStyle.YesNo)
                If FatalErrorResult = vbYes Then
                    Directory.Delete(MainPath, True)
                    FirstStart()
                Else
                    FRMMainMenu.Close()
                    FRMParent.Close()
                End If

            Else
                If Not File.Exists(DBPath & "\FigureSkatingTrainingSystem.accdb") Then
                    MsgBox("ERROR - Database not found! Please select the database you wish to use")
                    OFD.Filter = "Access Database Files (*.accdb)|*.accdb"
                    OFD.ShowDialog()
                    My.Computer.FileSystem.CopyFile(OFD.FileName, DBPath & "\FigureSkatingTrainingSystem.accdb")
                End If
            End If
        End If

    End Sub

    Private Sub FirstStart()

        MsgBox("Welcome to the Figure Skating Training System, as this is your first time using the program, please select the database you wish to use.")

        Directory.CreateDirectory(MainPath)
        Directory.CreateDirectory(RoutinePath)
        Directory.CreateDirectory(DiaryPath)
        Directory.CreateDirectory(DBPath)

        OFD.Filter = "Access Database Files (*.accdb)|*.accdb"
        OFD.ShowDialog()
        My.Computer.FileSystem.CopyFile(OFD.FileName, DBPath & "\FigureSkatingTrainingSystem.accdb")

    End Sub

    Public Function QueryDatabase(ByVal SQL As String, ByVal Table As String) As DataSet

        Dim DS As New DataSet 'Dataset
        Dim CN As New OleDb.OleDbConnection 'Database Connection
        Dim DA As New OleDb.OleDbDataAdapter 'Database Adaptor

        Dim DataBaseVersion As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
        Dim DataBasePath As String = DBPath & "\FigureSkatingTrainingSystem.accdb;"

        CN.ConnectionString = DataBaseVersion & DataBasePath
        DA = New OleDb.OleDbDataAdapter(sql, CN)

        CN.Open()

        DA.Fill(DS, Table)

        CN.Close()

        Return DS

    End Function

    Public Sub ExecuteDatabaseCommand(ByVal SQL As String)

        Dim CN As New OleDb.OleDbConnection 'Database Connection
        Dim DA As New OleDb.OleDbDataAdapter 'Database Adaptor

        Dim DataBaseVersion As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
        Dim DataBasePath As String = DBPath & "\FigureSkatingTrainingSystem.accdb;"

        Dim CMD As New OleDb.OleDbCommand(SQL, CN)

        CN.ConnectionString = DataBaseVersion & DataBasePath
        DA = New OleDb.OleDbDataAdapter(SQL, CN)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch
            MsgBox("An Error Has Occurred, Check the following:" & Chr(13) & "- That your database exists and is in the correct directory" & Chr(13) & "- That you are not trying to edit the value of a primary key" & Chr(13) & "- That you are entering a valid piece of data for the field" & Chr(13) & "- That you are not trying to modify a record which is referenced by other records. (Ex: Deleting a coach whilst pupils still have them stored as their current coach)" & Chr(13) & Chr(13) & "If this error persists consult the user manual")
        End Try

        CN.Close()

    End Sub

End Module
