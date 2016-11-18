Option Explicit On
Imports System.Data
Imports System.Xml
Imports System.Environment

Public Class FRMRoutineScreen1

    Private Structure TPupilInfo
        Dim Index As Integer
        Dim FirstName As String
        Dim Surname As String
        Dim ID As Integer
    End Structure

    Private DS As New DataSet 'This dataset will hold all results from database queries

    Private PupilList As New ArrayList 'Will store the list of pupils from the database of type TPupilInfo
    Private RoutineLengthList As New ArrayList 'Will store the list of possible routine lengths
    Private LevelList As New ArrayList 'Will store the list of possible levels

    Private PupilID As Integer 'Stores the ID of whatever pupil is currently selected
    Private RDBEnabled As Boolean 'Stores a boolean value depending on if the radio buttons are enabled
    Private CMBEnabled As Boolean 'Stores a boolean value depending on if the second two combo boxes are enabled

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click

        'Returns to the routine planning menu

        FRMRoutineMenu.MdiParent = FRMParent
        Me.Close()
        FRMRoutineMenu.WindowState = FormWindowState.Maximized
        FRMRoutineMenu.Show()

    End Sub

    Private Sub FRMLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        'Executes when the form is loaded and sets controls to their default values

        PopulateComboBoxes()
        RDBEnabled = False
        CMBEnabled = False
        RDBCompetition.Enabled = False
        RDBTest.Enabled = False
        RDBOther.Enabled = False
        CMBLength.Enabled = False
        CMBLevel.Enabled = False
        CMDPlan.Enabled = False

    End Sub

    Private Sub UpdatePupilID(sender As Object, e As EventArgs) Handles CMBPupil.SelectedIndexChanged

        'Updates the PupilID value to that of the selected pupil

        PupilID = PupilList(CMBPupil.SelectedIndex).ID
        If RDBEnabled = False Then
            RDBCompetition.Enabled = True
            RDBTest.Enabled = True
            RDBOther.Enabled = True
        End If
        UpdateDefaultValues()
    End Sub

    ' The following 3 subroutines handle combo box updates
    Private Sub RDBTest_CheckedChanged(sender As Object, e As EventArgs) Handles RDBTest.Click

        'Handles when the radio button selection is updated and updates the combo boxes as required

        CMBEnabled = True
        UpdateDefaultValues()
    End Sub
    Private Sub RDBCompetition_CheckedChanged(sender As Object, e As EventArgs) Handles RDBCompetition.Click

        'Handles when the radio button selection is updated and updates the combo boxes as required

        CMBEnabled = True
        UpdateDefaultValues()
    End Sub
    Private Sub RDBOther_CheckedChanged(sender As Object, e As EventArgs) Handles RDBOther.Click

        'Handles when the radio button selection is updated and updates the combo boxes as required

        CMBEnabled = True
        UpdateDefaultValues()
    End Sub

    Private Sub UpdateDefaultValues()

        'Selects the default indices for the combo boxes

        Dim QueryResult As DataSet

        QueryResult = FileManagement.QueryDatabase("SELECT Field_Moves_Level FROM [Pupil] WHERE Pupil_ID = " & PupilID, "pupillevel")

        If RDBTest.Checked Then
            CMBLevel.SelectedIndex = QueryResult.Tables("pupillevel").Rows(0).Item(0)
            CMBLevel.Enabled = True
            CMBLength.Enabled = True
        ElseIf RDBCompetition.Checked Then
            CMBLevel.Enabled = True
            CMBLevel.SelectedIndex = QueryResult.Tables("pupillevel").Rows(0).Item(0) - 1
            CMBLength.Enabled = True
        ElseIf RDBOther.Checked Then
            CMBLevel.Enabled = False
            CMBLength.Enabled = True
        Else
            CMBLevel.Enabled = False
            CMBLength.Enabled = False
        End If

    End Sub

    Public Sub PopulateComboBoxes()

        'Populates all combo boxes on the form

        Dim i As Integer 'Stepper variable for FOR loops
        Dim RecordCount As Integer 'Stores the number of records in the database table
        Dim PupilData As TPupilInfo 'Temporarily stores a single record of pupil information before it is added to the array list

        CMBPupil.Items.Clear()
        CMBLevel.Items.Clear()
        CMBLength.Items.Clear()

        DS = FileManagement.QueryDatabase("SELECT Pupil_ID,Pupil_Forename,Pupil_Surname,Free_Level FROM [Pupil]", "pupilinfo")

        RecordCount = DS.Tables("pupilinfo").Rows.Count

        For i = 0 To RecordCount - 1
            PupilData.FirstName = DS.Tables("pupilinfo").Rows(i).Item(1).ToString
            PupilData.Surname = DS.Tables("pupilinfo").Rows(i).Item(2).ToString
            PupilData.ID = CInt(DS.Tables("pupilinfo").Rows(i).Item(0))
            PupilData.Index = i
            PupilList.Add(PupilData)
            CMBPupil.Items.Add("(" & PupilData.ID & ") " & PupilData.FirstName & " " & PupilData.Surname)
        Next

        For i = 1 To 10
            LevelList.Add(i)
            CMBLevel.Items.Add(i)
        Next

        RoutineLengthList.AddRange({"1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00"})
        CMBLength.Items.AddRange({"1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00"})

    End Sub

    Private Sub CMBLength_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBLength.SelectedIndexChanged

        'When a length is chosen enable the start button

        CMDPlan.Enabled = True
    End Sub

    Private Sub CMDPlan_Click(sender As Object, e As EventArgs) Handles CMDPlan.Click

        'Continue to the next routine planning form

        FRMRoutineScreen2.MdiParent = FRMParent
        Me.Hide()
        FRMRoutineScreen2.WindowState = FormWindowState.Maximized
        FRMRoutineScreen2.Show()
    End Sub

    Public Function GetPupilID() As Integer

        'Returns the selected PupilID

        Return PupilID
    End Function

    Private Sub CMDAddPupil_Click(sender As Object, e As EventArgs) Handles CMDAddPupil.Click

        'Switch to FRMDataBaseAddPupil to add a new pupil to the database

        FRMDataBaseAddPupil.MdiParent = FRMParent
        Me.Hide()
        FRMDataBaseAddPupil.WindowState = FormWindowState.Maximized
        FRMDataBaseAddPupil.PreviousForm = Me
        FRMDataBaseAddPupil.Show()
    End Sub

End Class