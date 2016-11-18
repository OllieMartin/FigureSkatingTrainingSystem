Imports System.IO
Imports FigureSkatingTrainingSystem.FRMRoutineScreen3.TSavedRoutine
Imports System.Runtime.Serialization.Formatters.Binary
Public Class FRMRoutineMenu 'The menu for the routine planning section of the system

    Private Sub CMDBack_Click(sender As Object, e As EventArgs) Handles CMDBack.Click
        'Returns to the main menu form
        FormManagement.SwitchForm(Me, FRMMainMenu, EMethod.Hide)
    End Sub

    Private Sub CMDNew_Click(sender As Object, e As EventArgs) Handles CMDNew.Click
        'Loads FRMRoutineScreen1
        FormManagement.SwitchForm(Me, FRMRoutineScreen1, EMethod.Hide)
    End Sub

    Private Sub CMDView_Click(sender As Object, e As EventArgs) Handles CMDView.Click

        'Opens an OpenFileDialog so that the user can select a previously created routine
        'This file information will then be loaded and provided to FRMRoutineScreen3
        'This form is closed and FRMRoutineScreen3 is displayed with the loaded routine

        Dim OFD As New OpenFileDialog

        Dim RoutineSave As FRMRoutineScreen3.TSavedRoutine

        OFD.InitialDirectory = FileManagement.RoutinePath
        OFD.Filter = "FSTS Routine Files (*.rtn)|*.rtn|All Files (*.*)|*.*"
        OFD.ShowDialog()

        If Not OFD.FileName = "" Then

            Dim FS As FileStream = File.Open(FileManagement.RoutinePath & "\" & FRMRoutineScreen1.GetPupilID & ".rtn", FileMode.OpenOrCreate)
            Dim BF As New BinaryFormatter

            FS = File.Open(OFD.FileName, FileMode.Open)
            RoutineSave = DirectCast(BF.Deserialize(FS), FRMRoutineScreen3.TSavedRoutine)
            FS.Close()

            FormManagement.SwitchForm(Me, FRMRoutineScreen3, EMethod.Hide)
            FRMRoutineScreen3.Main(RoutineSave.NumberOfElements, RoutineSave.Routine, RoutineSave.PresentationScore, RoutineSave.PupilID)

        End If

    End Sub

End Class