Imports System.Data
Imports System.Xml
Imports System.Environment
Public Class FRMDiaryScreen1
    Private DS As New DataSet 'Dataset to store results of database queries
    Private PupilID As Integer 'Stores the currently selected PupilID
    Private ChosenMonth As Integer 'Stores the currently selected Month in CMBMonth
    Private ChosenYear As Integer 'Stores the currently selected Year in CMBStartYear
    Private PupilList As New ArrayList 'Stores the list of all pupils queried from the database

    Private Enum Month
        Jan = 1
        Feb = 2
        Mar = 3
        Apr = 4
        May = 5
        Jun = 6
        Jul = 7
        Aug = 8
        Sep = 9
        Oct = 10
        Nov = 11
        Dec = 12
    End Enum
    Private Structure TPupilInfo
        Dim Index As Integer
        Dim FirstName As String
        Dim Surname As String
        Dim ID As Integer
    End Structure

    Private Sub FRMDiaryScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initalises objects on form and populates combo boxes from database

        CMDCreate.Enabled = False
        CMBMonth.Enabled = False
        CMBStartYear.Enabled = False
        PopulateComboBoxes()
    End Sub 'The code to run upon startup
    Public Sub PopulateComboBoxes()

        'Populates all the combo boxes on the form by reading in information from the database

        Dim i As Integer 'Stepper variable for FOR loops
        Dim RecordCount As Integer 'Number of records in database
        Dim PupilData As TPupilInfo 'Temporarily stores the information for each pupil as they are read from the database hef0re they are added to the PupilList

        CMBPupil.Items.Clear()
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
        CMBMonth.Items.Clear()
        CMBMonth.Items.AddRange({"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})

        CMBStartYear.Items.Clear()
        Dim CurrentYear As Integer = Now.Year

        For i = -2 To 2 Step 1
            CMBStartYear.Items.Add(CurrentYear - i)
        Next



    End Sub 'Gets data from database into query boxes

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click
        FRMDiaryMenu.MdiParent = FRMParent
        Me.Close()
        FRMDiaryMenu.WindowState = FormWindowState.Maximized
        FRMDiaryMenu.Show()
    End Sub
    Private Sub CMBPupil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPupil.SelectedIndexChanged
        CMBMonth.Enabled = True
        CMBStartYear.Enabled = True
        CMBStartYear.SelectedIndex = 2
        ChosenYear = CMBStartYear.SelectedItem
        PupilID = PupilList(CMBPupil.SelectedIndex).ID 'Get the pupil ID of the current selected value in the combo box
    End Sub
    Private Sub CMBMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBMonth.SelectedIndexChanged
        CMDCreate.Enabled = True
        ChosenMonth = CMBMonth.SelectedIndex + 1
    End Sub
    Private Sub CMDCreate_Click(sender As Object, e As EventArgs) Handles CMDCreate.Click
        FRMDiaryScreen2.MdiParent = FRMParent
        Me.Hide()
        FRMDiaryScreen2.WindowState = FormWindowState.Maximized
        FRMDiaryScreen2.Show()
    End Sub

    Public Function GetPupilID() As Integer
        Return PupilID
    End Function

    Private Sub CMDAddPupil_Click(sender As Object, e As EventArgs) Handles CMDAddPupil.Click
        FRMDataBaseAddPupil.MdiParent = FRMParent
        Me.Hide()
        FRMDataBaseAddPupil.WindowState = FormWindowState.Maximized
        FRMDataBaseAddPupil.PreviousForm = Me
        FRMDataBaseAddPupil.Show()
    End Sub

    Private Sub CMBStartYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBStartYear.SelectedIndexChanged
        ChosenYear = CMBStartYear.SelectedItem
    End Sub
End Class