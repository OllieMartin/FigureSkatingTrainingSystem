Imports System.Environment
Imports System.Data
Imports System.Xml

Public Class FRMDiaryScreen2

    Private Enum Competitions
        ID = 0
        Name = 1
        StartDate = 2
        EndDate = 3
        Level = 4
    End Enum
    Private Enum Tests
        ID = 0
        StartDate = 1
    End Enum
    Public Structure TCompetition
        Dim ID As Integer
        Dim Name As String
        Dim StartDate As Date
        Dim EndDate As Date
        Dim Level As Integer
    End Structure
    Public Structure TTest
        Dim ID As Integer
        Dim StartDate As Date
    End Structure

    Private DS As New DataSet 'Dataset

    Private ElementsList As New ArrayList 'Stores all selected elements to be used in the diary
    Private CompetitionsList As New ArrayList
    Private TestsList As New ArrayList
    Private CompetitionDates As New ArrayList
    Private TestDates As New ArrayList

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click

        'Returns to FRMDiaryMenu

        FRMDiaryMenu.MdiParent = FRMParent
        Me.Close()
        FRMDiaryScreen1.Close()
        FRMDiaryMenu.WindowState = FormWindowState.Maximized
        FRMDiaryMenu.Show()
    End Sub

    Private Sub FRMDiaryScreen2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Populates all checked list boxes upon form load

        PopulateElementsBox()
        PopulateCompetitionsBox()
        PopulateTestsBox()
    End Sub
    Private Sub PopulateElementsBox()

        'Populates the elements box with all elements that the pupil has a competency level of 3 or less for.

        Dim i As Integer 'Stepper variable for FOR loops
        Dim RecordCount As Integer ' Number of records in database
        Dim SelectedPupilID As Integer = FRMDiaryScreen1.GetPupilID

        DS.Merge(FileManagement.QueryDatabase("SELECT * FROM [Pupil] Where Pupil_ID = " & SelectedPupilID, "pupil3"))

        RecordCount = DS.Tables("pupil3").Rows.Count

        For i = 7 To 30
            If DS.Tables("pupil3").Rows(0).Item(i) <= 3 Then
                CLBElements.Items.Add(Mid(DS.Tables("pupil3").Columns(i).ColumnName, 3, Len(DS.Tables("pupil3").Columns(i).ColumnName)) & " (" & DS.Tables("pupil3").Rows(0).Item(i).ToString & ")")
            End If
        Next
        For i = 31 To 34
            If DS.Tables("pupil3").Rows(0).Item(i + 4) <= 3 Then
                CLBElements.Items.Add(Mid(DS.Tables("pupil3").Columns(i).ColumnName, 3, Len(DS.Tables("pupil3").Columns(i).ColumnName)) & DS.Tables("pupil3").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupil3").Rows(0).Item(i + 4).ToString & ")")
            End If
        Next
        For i = 39 To 42
            If DS.Tables("pupil3").Rows(0).Item(i + 4) <= 3 Then
                CLBElements.Items.Add(Mid(DS.Tables("pupil3").Columns(i).ColumnName, 3, Len(DS.Tables("pupil3").Columns(i).ColumnName)) & DS.Tables("pupil3").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupil3").Rows(0).Item(i + 4).ToString & ")")
            End If
        Next
        For i = 47 To 50
            If DS.Tables("pupil3").Rows(0).Item(i + 4) <= 3 Then
                CLBElements.Items.Add(Mid(DS.Tables("pupil3").Columns(i).ColumnName, 3, Len(DS.Tables("pupil3").Columns(i).ColumnName)) & DS.Tables("pupil3").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupil3").Rows(0).Item(i + 4).ToString & ")")
            End If
        Next
        For i = 55 To 56
            If DS.Tables("pupil3").Rows(0).Item(i + 2) <= 3 Then
                CLBElements.Items.Add(Mid(DS.Tables("pupil3").Columns(i).ColumnName, 3, Len(DS.Tables("pupil3").Columns(i).ColumnName)) & DS.Tables("pupil3").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupil3").Rows(0).Item(i + 2).ToString & ")")
            End If
        Next
        For i = 59 To 60
            If DS.Tables("pupil3").Rows(0).Item(i + 2) <= 3 Then
                CLBElements.Items.Add(Mid(DS.Tables("pupil3").Columns(i).ColumnName, 3, Len(DS.Tables("pupil3").Columns(i).ColumnName)) & DS.Tables("pupil3").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupil3").Rows(0).Item(i + 2).ToString & ")")
            End If
        Next
        For i = 63 To 63
            If DS.Tables("pupil3").Rows(0).Item(i + 1) <= 3 Then
                CLBElements.Items.Add(Mid(DS.Tables("pupil3").Columns(i).ColumnName, 3, Len(DS.Tables("pupil3").Columns(i).ColumnName)) & DS.Tables("pupil3").Rows(0).Item(i).ToString.Replace(0, "B") & " (" & DS.Tables("pupil3").Rows(0).Item(i + 1).ToString & ")")
            End If
        Next
        For i = 65 To 65
            If DS.Tables("pupil3").Rows(0).Item(i) <= 3 Then
                CLBElements.Items.Add(Mid(DS.Tables("pupil3").Columns(i).ColumnName, 3, Len(DS.Tables("pupil3").Columns(i).ColumnName)) & " (" & DS.Tables("pupil3").Rows(0).Item(i).ToString & ")")
            End If
        Next
    End Sub
    Private Sub PopulateCompetitionsBox()

        'Populates the competitions box with all competitions that are present in the year.

        Dim i As Integer 'Stepper variable for FOR loops

        Dim RecordCount As Integer ' Number of records in database
        Dim SelectedPupilID As Integer = FRMDiaryScreen1.GetPupilID - 1
        Dim PUPILLEVEL As Integer

        DS.Merge(FileManagement.QueryDatabase("SELECT Field_Moves_Level FROM [Pupil] WHERE Pupil_ID = " & FRMDiaryScreen1.GetPupilID, "pupillevel"))
        PUPILLEVEL = DS.Tables("pupillevel").Rows(0).Item(0)

        DS.Merge(FileManagement.QueryDatabase("SELECT * FROM [Competition]", "comp"))

        RecordCount = DS.Tables("comp").Rows.Count
        Dim StartMonth As String = FRMDiaryScreen1.CMBMonth.SelectedItem
        Dim CurrentYear As Integer = FRMDiaryScreen1.CMBStartYear.SelectedItem
        Dim MonthDictionary As New Dictionary(Of String, Integer)
        MonthDictionary.Add("January", Months.Jan)
        MonthDictionary.Add("February", Months.Feb)
        MonthDictionary.Add("March", Months.Mar)
        MonthDictionary.Add("April", Months.Apr)
        MonthDictionary.Add("May", Months.May)
        MonthDictionary.Add("June", Months.Jun)
        MonthDictionary.Add("July", Months.Jul)
        MonthDictionary.Add("August", Months.Aug)
        MonthDictionary.Add("September", Months.Sep)
        MonthDictionary.Add("October", Months.Oct)
        MonthDictionary.Add("November", Months.Nov)
        MonthDictionary.Add("December", Months.Dec)
        Dim DiaryStartDate As Date = "1/" & MonthDictionary(StartMonth) & "/" & CurrentYear

        For i = 1 To RecordCount

            If DateDiff(DateInterval.Day, DiaryStartDate.AddMonths(1), DS.Tables("comp").Rows(i - 1).Item(Competitions.StartDate)) >= 0 And DateDiff(DateInterval.Day, DiaryStartDate, DS.Tables("comp").Rows(i - 1).Item(Competitions.EndDate)) <= 365 And DS.Tables("comp").Rows(i - 1).Item(Competitions.Level) <= PUPILLEVEL Then
                CLBCompetitions.Items.Add(DS.Tables("comp").Rows(i - 1).Item(Competitions.Name) & " (ID:" & DS.Tables("comp").Rows(i - 1).Item(Competitions.ID) & ")")
            End If
        Next

    End Sub
    Private Sub PopulateTestsBox()

        'Populates the tests box with all tests that are present in the year.

        Dim i As Integer 'Stepper variable for FOR loops
        Dim RecordCount As Integer ' Number of records in database
        Dim SelectedPupilID As Integer = FRMDiaryScreen1.GetPupilID - 1

        DS.Merge(FileManagement.QueryDatabase("SELECT * FROM [Test]", "test"))

        RecordCount = DS.Tables("test").Rows.Count

        Dim StartMonth As String = FRMDiaryScreen1.CMBMonth.SelectedItem
        Dim CurrentYear As Integer = FRMDiaryScreen1.CMBStartYear.SelectedItem
        Dim MonthDictionary As New Dictionary(Of String, Integer)
        MonthDictionary.Add("January", Months.Jan)
        MonthDictionary.Add("February", Months.Feb)
        MonthDictionary.Add("March", Months.Mar)
        MonthDictionary.Add("April", Months.Apr)
        MonthDictionary.Add("May", Months.May)
        MonthDictionary.Add("June", Months.Jun)
        MonthDictionary.Add("July", Months.Jul)
        MonthDictionary.Add("August", Months.Aug)
        MonthDictionary.Add("September", Months.Sep)
        MonthDictionary.Add("October", Months.Oct)
        MonthDictionary.Add("November", Months.Nov)
        MonthDictionary.Add("December", Months.Dec)
        Dim DiaryStartDate As Date = "1/" & MonthDictionary(StartMonth) & "/" & CurrentYear

        For i = 1 To RecordCount
            If DateDiff(DateInterval.Day, DiaryStartDate, DS.Tables("test").Rows(i - 1).Item(Tests.StartDate)) > 0 And DateDiff(DateInterval.Day, DiaryStartDate, DS.Tables("test").Rows(i - 1).Item(Tests.StartDate)) <= 365 Then
                CLBTests.Items.Add(DS.Tables("test").Rows(i - 1).Item(Tests.StartDate) & " (ID:" & DS.Tables("test").Rows(i - 1).Item(Tests.ID) & ")")
            End If
        Next

    End Sub

    Private Sub CMDCreate_Click(sender As Object, e As EventArgs) Handles CMDCreate.Click

        'Adds all chosen elements, tests and competitions to array list ready to be used in the training diary algorithm. Executes upon clicking CMDCreate and runs the main subroutine of the DiaryCreation module

        Dim CurrentCompetition As TCompetition
        Dim CurrentTest As TTest


        If Not CLBCompetitions.CheckedItems.Count = 0 Then
            ElementsList.AddRange(CLBElements.CheckedItems)
            CompetitionsList.AddRange(CLBCompetitions.CheckedItems)
            TestsList.AddRange(CLBTests.CheckedItems)

            For i = 0 To DS.Tables("comp").Rows.Count - 1
                CurrentCompetition.ID = DS.Tables("comp").Rows(i).Item(Competitions.ID)
                CurrentCompetition.Name = DS.Tables("comp").Rows(i).Item(Competitions.Name)
                CurrentCompetition.StartDate = "#" & CStr(DS.Tables("comp").Rows(i).Item(Competitions.StartDate)) & "#"
                CurrentCompetition.EndDate = "#" & CStr(DS.Tables("comp").Rows(i).Item(Competitions.EndDate)) & "#"
                CurrentCompetition.Level = DS.Tables("comp").Rows(i).Item(Competitions.Level)
                CompetitionDates.Add(CurrentCompetition)
            Next
            For i = 0 To DS.Tables("test").Rows.Count - 1
                CurrentTest.ID = DS.Tables("test").Rows(i).Item(Tests.ID)
                CurrentTest.StartDate = "#" & CStr(DS.Tables("test").Rows(i).Item(Tests.StartDate)) & "#"
                TestDates.Add(CurrentTest)
            Next

            DiaryCreation.Main()
        Else
            MsgBox("You must select at least one competition to create a training diary!")
        End If

    End Sub

    Public Function GetElementsList() As ArrayList
        Return ElementsList
    End Function
    Public Function GetCompetitionsLists() As ArrayList
        Return CompetitionsList
    End Function
    Public Function GetTestsList() As ArrayList
        Return TestsList
    End Function
    Public Function GetCompetitionDates() As ArrayList
        Return CompetitionDates
    End Function
    Public Function GetTestDates() As ArrayList
        Return TestDates
    End Function
End Class