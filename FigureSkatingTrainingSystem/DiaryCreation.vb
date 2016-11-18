Option Explicit On
Imports System.Data
Imports System.Xml
Imports System.Environment
Imports FigureSkatingTrainingSystem.FRMDiaryScreen2.TCompetition
Imports FigureSkatingTrainingSystem.FRMDiaryScreen2.TTest

Public Enum Competitions
    ID = 0
    Name = 1
    StartDate = 2
    EndDate = 3
    Level = 4
End Enum
Public Enum Tests
    ID = 0
    StartDate = 1
End Enum
Public Enum Days
    Mon = 1
    Tue = 2
    Wed = 3
    Thu = 4
    Fri = 5
    Sat = 6
    Sun = 7
End Enum
Public Enum Months
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
Public Enum Periods
    Transition = 1
    OffSeason = 2
    Preseason = 3
    InSeason = 4
End Enum
Public Enum ElementType
    Jump = 1
    Spin = 2
    StSq = 3
    ChSq = 4
End Enum

Public Structure TDiary
    Dim NodeDate As Date
    Dim Period As Periods
    Dim Skate As Boolean
    Dim Activities As String
End Structure
Public Structure TPeriod
    Dim StartDate As Date
    Dim FinishDate As Date
    Dim StartIndex As Integer
    Dim EndIndex As Integer
End Structure

Module DiaryCreation

    Private PupilLevel As Integer
    Public Diary(366) As TDiary
    Private Transition As TPeriod
    Private OffSeason As TPeriod
    Private Preseason As TPeriod
    Private Inseason As TPeriod
    Private Competitions As New ArrayList
    Private Tests As New ArrayList
    Private Elements As New ArrayList
    Private CompetitionDates As New ArrayList
    Private TestDates As New ArrayList
    Public DiaryStartDate As Date
    Private LeapYear As Boolean
    Private DaysUsed As Integer

    Public Sub Main()

        Dim StartMonth As String = FRMDiaryScreen1.CMBMonth.SelectedItem
        Dim MonthDictionary As New Dictionary(Of String, Integer)
        Dim CurrentYear As Integer = FRMDiaryScreen1.CMBStartYear.SelectedItem
        Dim TempDate As Date
        Dim DS As DataSet

        DS = FileManagement.QueryDatabase("SELECT Field_Moves_Level FROM [Pupil] WHERE Pupil_ID = " & FRMDiaryScreen1.GetPupilID, "pupillevel")
        PUPILLEVEL = DS.Tables("pupillevel").Rows(0).Item(0)

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

        Competitions = FRMDiaryScreen2.GetCompetitionsLists
        Tests = FRMDiaryScreen2.GetTestsList
        Elements = FRMDiaryScreen2.GetElementsList
        CompetitionDates = FRMDiaryScreen2.GetCompetitionDates
        TestDates = FRMDiaryScreen2.GetTestDates

        DiaryStartDate = "1/" & MonthDictionary(StartMonth) & "/" & CurrentYear


        If Date.IsLeapYear(CurrentYear) Then
            TempDate = "29/02/" & CurrentYear
            If DateTime.Compare(DiaryStartDate, TempDate) < 0 Then
                LeapYear = True
            Else
                LeapYear = False
            End If
        End If

        PopulateDiary()

        CalculatePeriodDates()

        PlanTrainingExercises()
        If Not FRMDiaryScreen2.CLBElements.CheckedItems.Count = 0 Then
            PlanElementsToAchieve()
        End If
        AddCompetitionsAndTests()

        OpenResultsForm(Diary)

    End Sub

    Private Sub PopulateDiary()

        Dim Counter As Integer
        If LeapYear Then
            Counter = 366
        Else
            Counter = 365
        End If

        For i = 1 To Counter
            Diary(i).NodeDate = DateAdd(DateInterval.Day, i - 1, DiaryStartDate)
        Next

    End Sub

    Private Sub CalculatePeriodDates()

        Inseason = GetInSeasonPhaseDates()
        Preseason = GetPreSeasonPhaseDates()
        OffSeason = GetOffSeasonPhaseDates()
        Transition = GetTransitionPhaseDates()
        GetSeasonIndexForArray()

    End Sub

    Private Function GetInSeasonPhaseDates() As TPeriod
        Dim CurrentIndex As Integer
        Dim RequiredIndex As Integer
        Dim StartDate As Date
        Dim EndDate As Date
        Dim CurrentStart As Date
        Dim CurrentEnd As Date
        Dim ReturnPeriod As TPeriod
        Dim DateCompare As Integer
        Dim FirstIteration As Boolean = True

        'This loop acquires the competitions the user has selected to be included in the routine
        'It then finds the start date of the first competition and the finish date of the last competition
        'These are used to calcualte the InSeason phase dates

        For i = 0 To Competitions.Count - 1

            CurrentIndex = Mid(Competitions(i), Len(Competitions(i)) - 1, 1)

            For j = 0 To CompetitionDates.Count - 1

                If CompetitionDates(j).ID = CurrentIndex Then
                    RequiredIndex = j
                End If

            Next

            CurrentStart = CompetitionDates(RequiredIndex).StartDate
            CurrentEnd = CompetitionDates(RequiredIndex).EndDate

            If FirstIteration Then

                StartDate = CurrentStart
                EndDate = CurrentEnd
                FirstIteration = False

            Else

                DateCompare = DateTime.Compare(CurrentStart, StartDate)

                If DateCompare < 0 Then

                    StartDate = CurrentStart

                End If

                DateCompare = DateTime.Compare(CurrentEnd, EndDate)

                If DateCompare > 0 Then

                    EndDate = CurrentEnd

                End If

            End If

        Next

        ReturnPeriod.StartDate = StartDate
        ReturnPeriod.FinishDate = EndDate

        DaysUsed = DateDiff(DateInterval.Day, StartDate, EndDate) + 1

        Return ReturnPeriod

    End Function
    Private Function GetPreSeasonPhaseDates() As TPeriod

        Dim StartDate As Date
        Dim EndDate As Date
        Dim NumberOfDays As Integer
        Dim ReturnPeriod As TPeriod

        NumberOfDays = Math.Abs(DateDiff(DateInterval.Day, DateAdd(DateInterval.Day, -1, Inseason.StartDate), DiaryStartDate)) + 1

        NumberOfDays = Math.Round((4 / 7) * NumberOfDays)

        EndDate = DateAdd(DateInterval.Day, -1, Inseason.StartDate)

        StartDate = DateAdd(DateInterval.Day, -(NumberOfDays - 1), EndDate)

        ReturnPeriod.StartDate = StartDate
        ReturnPeriod.FinishDate = EndDate

        Return ReturnPeriod

    End Function
    Private Function GetOffSeasonPhaseDates() As TPeriod

        Dim StartDate As Date
        Dim EndDate As Date
        Dim NumberOfDays As Integer
        Dim ReturnPeriod As TPeriod

        NumberOfDays = Math.Abs(DateDiff(DateInterval.Day, DateAdd(DateInterval.Day, -1, Inseason.StartDate), DiaryStartDate)) + 1

        NumberOfDays = Math.Round((2 / 7) * NumberOfDays)

        EndDate = DateAdd(DateInterval.Day, -1, Preseason.StartDate)
        StartDate = DateAdd(DateInterval.Day, -(NumberOfDays - 1), EndDate)

        ReturnPeriod.StartDate = StartDate
        ReturnPeriod.FinishDate = EndDate

        Return ReturnPeriod

    End Function
    Private Function GetTransitionPhaseDates() As TPeriod

        Dim StartDate As Date
        Dim EndDate As Date
        Dim NumberOfDays As Integer
        Dim ReturnPeriod As TPeriod

        NumberOfDays = Math.Abs(DateDiff(DateInterval.Day, DateAdd(DateInterval.Day, -1, Inseason.StartDate), DiaryStartDate)) + 1

        NumberOfDays = Math.Round((1 / 7) * NumberOfDays)

        EndDate = DateAdd(DateInterval.Day, -1, OffSeason.StartDate)
        StartDate = DateAdd(DateInterval.Day, -(NumberOfDays - 1), EndDate)

        ReturnPeriod.StartDate = StartDate
        ReturnPeriod.FinishDate = EndDate

        Return ReturnPeriod

    End Function
    Private Sub GetSeasonIndexForArray()

        Dim DateDifference As Integer

        DateDifference = DateDiff(DateInterval.Day, Transition.StartDate, DiaryStartDate)
        Transition.StartIndex = Math.Abs(DateDifference) + 1
        DateDifference = DateDiff(DateInterval.Day, Transition.FinishDate, DiaryStartDate)
        Transition.EndIndex = Math.Abs(DateDifference) + 1
        DateDifference = DateDiff(DateInterval.Day, OffSeason.StartDate, DiaryStartDate)
        OffSeason.StartIndex = Math.Abs(DateDifference) + 1
        DateDifference = DateDiff(DateInterval.Day, OffSeason.FinishDate, DiaryStartDate)
        OffSeason.EndIndex = Math.Abs(DateDifference) + 1
        DateDifference = DateDiff(DateInterval.Day, Preseason.StartDate, DiaryStartDate)
        Preseason.StartIndex = Math.Abs(DateDifference) + 1
        DateDifference = DateDiff(DateInterval.Day, Preseason.FinishDate, DiaryStartDate)
        Preseason.EndIndex = Math.Abs(DateDifference) + 1
        DateDifference = DateDiff(DateInterval.Day, Inseason.StartDate, DiaryStartDate)
        Inseason.StartIndex = Math.Abs(DateDifference) + 1
        DateDifference = DateDiff(DateInterval.Day, Inseason.FinishDate, DiaryStartDate)
        Inseason.EndIndex = Math.Abs(DateDifference) + 1

    End Sub

    Private Sub PlanTrainingExercises()

        Dim JumpCount As Integer
        Dim SpinCount As Integer
        Dim StSqCount As Integer
        Dim ChSqCount As Integer
        Dim MostCommonElement As Integer
        Dim RandomNumber As Integer
        Dim Iterations As Integer
        Dim DayCounter As Integer
        Dim NumberScheduled As Integer
        Dim Week As Integer

        Dim ScheduledType1 As Integer
        Dim ScheduledType2 As Integer
        Dim NumberToSchedule As Integer
        Dim CurrentMostCommon As Integer

        Dim NumberExtra As Integer

        Dim FirstNumber As Integer


        For i = 0 To Elements.Count - 1
            If Len(Elements(i)) < 8 Then
                JumpCount = JumpCount + 1
            ElseIf Mid(Elements(i), 1, 4) = "ChSq" Then
                ChSqCount = ChSqCount + 1
            ElseIf Mid(Elements(i), 1, 4) = "StSq" Then
                StSqCount = StSqCount + 1
            Else
                SpinCount = SpinCount + 1
            End If
        Next

        If JumpCount > (SpinCount And StSqCount And ChSqCount) Then
            MostCommonElement = ElementType.Jump
        End If
        If SpinCount > (JumpCount And StSqCount And ChSqCount) Then
            MostCommonElement = ElementType.Spin
        End If
        If StSqCount > (SpinCount And JumpCount And ChSqCount) Then
            MostCommonElement = ElementType.StSq
        End If
        If ChSqCount > (SpinCount And StSqCount And JumpCount) Then
            MostCommonElement = ElementType.ChSq
        End If

        '=====================================================TRANSITION PERIOD CODE=====================================================

        Week = 0

        For i = Transition.StartIndex To Transition.EndIndex Step 7

            Week = Week + 1

            Randomize()
            RandomNumber = Rnd() * 6 + 1

            Diary(i + (RandomNumber - 1)).Skate = True

            Iterations = 0
            DayCounter = i
            NumberScheduled = 0

            Do
                If Diary(DayCounter).Skate = False Then
                    If (Week Mod 2 <> 0 And NumberScheduled < 2) Or (Week Mod 2 = 0 And NumberScheduled = 2) Then
                        Select Case MostCommonElement
                            Case Is = ElementType.Jump
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Swimming Session, "
                            Case Is = ElementType.Spin
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Stretch Class, "
                            Case Is = ElementType.StSq
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Running Session, "
                            Case Is = ElementType.ChSq
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Running Session, "
                        End Select
                        NumberScheduled = NumberScheduled + 1
                    ElseIf (Week Mod 2 <> 0 And NumberScheduled = 2) Or (Week Mod 2 = 0 And NumberScheduled < 2) Then
                        Select Case MostCommonElement
                            Case Is = ElementType.Jump
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Cycling Session, "
                            Case Is = ElementType.Spin
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Pilates Class, "
                            Case Is = ElementType.StSq
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Pilates Class, "
                            Case Is = ElementType.ChSq
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Pilates Class, "
                        End Select
                        NumberScheduled = NumberScheduled + 1
                    ElseIf NumberScheduled = 3 Then
                        If Week Mod 2 = 0 Then
                            Select Case MostCommonElement
                                Case Is = ElementType.Jump
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Stretch Class, "
                                Case Is = ElementType.Spin
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Swimming Session, "
                                Case Is = ElementType.StSq
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Swimming Session, "
                                Case Is = ElementType.ChSq
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Running Session, "
                            End Select
                        Else
                            Select Case MostCommonElement
                                Case Is = ElementType.Jump
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Pilates Session, "
                                Case Is = ElementType.Spin
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Cycling Session, "
                                Case Is = ElementType.StSq
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Stretch Class, "
                                Case Is = ElementType.ChSq
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Stretch Class, "
                            End Select
                        End If
                        NumberScheduled = NumberScheduled + 1
                    Else
                        Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Gym Session, "
                    End If
                End If

                Iterations = Iterations + 1
                DayCounter = DayCounter + 1

            Loop Until Iterations = 6

        Next

        '=====================================================OFF SEASON PERIOD CODE=====================================================

        Week = 0

        For i = OffSeason.StartIndex To OffSeason.EndIndex Step 7

            Week = Week + 1

            Randomize()
            RandomNumber = Rnd() * 5 + 1

            For j = i To i + 5
                If Not j = i + (RandomNumber - 1) Then
                    Diary(j).Skate = True
                End If
            Next

            NumberToSchedule = Rnd() * 2 + 1

            '=========================================================================================================================
            'If their level is greater than 7 then
            'Allocate an endurance session each week for the first 2 weeks
            'Have a week with no endurance sessions
            'Allocate two endurance sessions in the next week
            'Repeat this process for all weeks in this phase.
            'If their level is less than 7 then
            'Allocate an endurance session every other week
            '=========================================================================================================================

            Iterations = 0
            DayCounter = i
            NumberScheduled = 0
            ScheduledType1 = 0
            ScheduledType2 = 0
            NumberExtra = 0

            Select Case MostCommonElement
                Case Is = ElementType.Jump
                    CurrentMostCommon = ElementType.Jump
                Case Is = ElementType.Spin
                    CurrentMostCommon = ElementType.Spin
                Case Else
                    If Week Mod 2 = 0 Then
                        CurrentMostCommon = ElementType.Jump
                    Else
                        CurrentMostCommon = ElementType.Spin
                    End If
            End Select

            Do

                If ScheduledType1 < 1 Then
                    Select Case CurrentMostCommon
                        Case Is = ElementType.Jump
                            Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jump Training Session, "
                        Case Is = ElementType.Spin
                            Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Stretch Training Session, "
                    End Select
                    ScheduledType1 = ScheduledType1 + 1
                ElseIf ScheduledType2 < 1 Then
                    Select Case CurrentMostCommon
                        Case Is = ElementType.Jump
                            Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session, "
                        Case Is = ElementType.Spin
                            Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Stretch Training Session, "
                    End Select
                    ScheduledType2 = ScheduledType2 + 1
                End If

                If NumberToSchedule = 3 And ScheduledType1 = 1 And ScheduledType2 = 1 Then
                    If Rnd() <= 0.5 Then
                        ScheduledType1 = ScheduledType1 + 1
                        Select Case CurrentMostCommon
                            Case Is = ElementType.Jump
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jump Training Session, "
                            Case Is = ElementType.Spin
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Stretch Training Session, "
                        End Select
                    Else
                        Select Case CurrentMostCommon
                            Case Is = ElementType.Jump
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session, "
                            Case Is = ElementType.Spin
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Stretch Training Session, "
                        End Select
                        ScheduledType2 = ScheduledType2 + 1
                    End If
                End If

                Iterations = Iterations + 1
                DayCounter = DayCounter + 1

            Loop Until Iterations = 6

            NumberExtra = 0

            For j = DayCounter - 6 To DayCounter

                Select Case CurrentMostCommon

                    Case Is = ElementType.Jump
                        If Diary(j).Activities = "" Then
                            If NumberExtra < NumberToSchedule - 1 Then
                                Diary(j).Activities = Diary(j).Activities + "Stretch Training"
                                NumberExtra = NumberExtra + 1
                            End If
                        End If
                    Case Is = ElementType.Spin
                        If Diary(j).Activities = "" Then
                            If NumberExtra < NumberToSchedule - 1 Then
                                If NumberExtra = 1 Then
                                    Diary(j).Activities = Diary(j).Activities + "Strength Training"
                                    NumberExtra = NumberExtra + 1
                                Else
                                    Diary(j).Activities = Diary(j).Activities + "Jump Training"
                                    NumberExtra = NumberExtra + 1
                                End If
                            End If
                        End If

                End Select

            Next

            NumberExtra = 0

            If PupilLevel > 7 Then

                If Week < 3 Then

                    For j = DayCounter - 6 To DayCounter

                        If NumberExtra = 0 And Diary(j).Activities = "" Then
                            Diary(j).Activities = Diary(j).Activities + "Endurance Training,"
                            NumberExtra = NumberExtra + 1
                        End If

                    Next

                    If NumberExtra = 0 Then
                        Diary(DayCounter - 6).Activities = Diary(DayCounter - 6).Activities + "Endurance Training,"
                    End If

                ElseIf Week = 4 Then

                    For j = DayCounter - 6 To DayCounter

                        If NumberExtra < 2 And Diary(j).Activities = "" Then
                            Diary(j).Activities = Diary(j).Activities + "Endurance Training,"
                            NumberExtra = NumberExtra + 1
                        End If

                    Next

                    If NumberExtra = 0 Then
                        Diary(DayCounter - 6).Activities = Diary(DayCounter - 6).Activities + "Endurance Training,"
                        NumberExtra = NumberExtra + 1
                        Diary(DayCounter - 5).Activities = Diary(DayCounter - 5).Activities + "Endurance Training,"
                        NumberExtra = NumberExtra + 1
                    End If

                End If

            End If

        Next

        '=========================================================================================================================
        '                       For each week allocate strength, flexibility or jumping training sessions
        '                       This should be whatever activity they have not already completed that week
        '                           If they have scheduled two of their element based training sessions
        '                           Randomly decide whether or not to allocate 1 or 2 of these sessions
        '                                These should be on whatever day has least activities
        '                                    If days have equal activities pick randomly 
        '=========================================================================================================================
        '=====================================================PRE SEASON PERIOD CODE=====================================================

        Week = 0

        For i = Preseason.StartIndex To Preseason.EndIndex Step 7

            NumberExtra = 0
            Iterations = 0
            ScheduledType1 = 0

            Week = Week + 1

            Randomize()
            RandomNumber = Rnd() * 5 + 1

            For j = i To i + 5
                If Not j = i + (RandomNumber - 1) Then
                    Diary(j).Skate = True
                End If
            Next

            Randomize()
            RandomNumber = Rnd() * 6 + 1

            Diary(i + (RandomNumber - 1)).Activities = Diary(i + (RandomNumber - 1)).Activities & "Gym Session,"

            Select Case NumberExtra
                Case Is = 0
                    NumberExtra = 1
                Case Is = 1
                    NumberExtra = 2
                Case Is = 2
                    NumberExtra = 3
                Case Is = 3
                    NumberExtra = 4
                Case Is = 4
                    NumberExtra = 1
            End Select

            DayCounter = i

            Do

                If Diary(DayCounter).Skate = False Then
                    Select Case NumberExtra
                        Case Is = 1
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 3
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 4
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                        Case Is = 2
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 3
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 4
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                        Case Is = 3
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 3
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 4
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                        Case Is = 4
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 3
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 4
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                    End Select
                End If

                DayCounter = DayCounter + 1
                Iterations = Iterations + 1
            Loop Until Iterations = 6 Or ScheduledType1 = 5

            DayCounter = i
            Iterations = 0

            Do

                Select Case NumberExtra
                    Case Is = 1
                        Select Case ScheduledType1
                            Case Is < 2
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 2
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 3
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 4
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                        End Select
                    Case Is = 2
                        Select Case ScheduledType1
                            Case Is < 2
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 2
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 3
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 4
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                        End Select
                    Case Is = 3
                        Select Case ScheduledType1
                            Case Is < 2
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 2
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 3
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 4
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                        End Select
                    Case Is = 4
                        Select Case ScheduledType1
                            Case Is < 2
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 2
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 3
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                            Case Is = 4
                                Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                ScheduledType1 = ScheduledType1 + 1
                        End Select
                End Select

                DayCounter = DayCounter + 1
                Iterations = Iterations + 1
            Loop Until Iterations = 6 Or ScheduledType1 = 5

        Next

        '=====================================================IN  SEASON PERIOD CODE=====================================================

        Week = 0

        For i = Inseason.StartIndex To Inseason.EndIndex Step 7

            NumberExtra = 0
            Iterations = 0
            ScheduledType1 = 0

            Week = Week + 1

            Randomize()
            RandomNumber = Rnd() * 5 + 1
            FirstNumber = RandomNumber

            For j = i To i + 5
                If Not j = i + (RandomNumber - 1) Then
                    Diary(j).Skate = True
                End If
            Next

            Do
                Randomize()
                RandomNumber = Rnd() * 6 + 1
            Loop Until RandomNumber <> FirstNumber

            Diary(i + (RandomNumber - 1)).Activities = Diary(i + (RandomNumber - 1)).Activities & "Gym Session,"

            Select Case NumberExtra
                Case Is = 0
                    NumberExtra = 1
                Case Is = 1
                    NumberExtra = 2
                Case Is = 2
                    NumberExtra = 3
                Case Is = 3
                    NumberExtra = 4
                Case Is = 4
                    NumberExtra = 1
            End Select

            DayCounter = i

            Do

                If Diary(DayCounter).Skate = False Then
                    Select Case NumberExtra
                        Case Is = 1
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                        Case Is = 2
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                        Case Is = 3
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                        Case Is = 4
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                    End Select
                End If

                DayCounter = DayCounter + 1
                Iterations = Iterations + 1
            Loop Until Iterations = 6 Or ScheduledType1 = 3

            DayCounter = i
            Iterations = 0

            Do

                If DayCounter <> i + (RandomNumber - 1) Then
                    Select Case NumberExtra
                        Case Is = 1
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                        Case Is = 2
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Strength Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                        Case Is = 3
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Flexibility Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                        Case Is = 4
                            Select Case ScheduledType1
                                Case Is < 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Endurance Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                                Case Is = 2
                                    Diary(DayCounter).Activities = Diary(DayCounter).Activities & "Jumping Training Session,"
                                    ScheduledType1 = ScheduledType1 + 1
                            End Select
                    End Select
                End If

                DayCounter = DayCounter + 1
                Iterations = Iterations + 1
            Loop Until Iterations = 6 Or ScheduledType1 = 3

        Next



    End Sub
    Private Sub PlanElementsToAchieve()

        Dim CurrentElements As New ArrayList
        Dim ElementsAdded As Integer
        Dim CurrentDate As Integer

        For i = 0 To 3
            CurrentElements.Clear()
            For j = 0 To Elements.Count - 1
                If CInt(Mid(Elements(j), Len(Elements(j)) - 1, 1)) = i Then
                    CurrentElements.Add(Mid(Elements(j), 1, Len(Elements(j)) - 3))
                End If
            Next

            Select Case i
                Case Is = 0
                    For k = OffSeason.StartIndex To OffSeason.EndIndex Step 7
                        For l = 0 To CurrentElements.Count - 1
                            Diary(k).Activities = Diary(k).Activities & "Practice " & CurrentElements(l) & "Lots During Week, "
                        Next
                    Next
                Case Is = 1
                    For k = OffSeason.StartIndex To OffSeason.EndIndex Step 7
                        For l = 0 To CurrentElements.Count - 1
                            Diary(k).Activities = Diary(k).Activities & "Practice " & CurrentElements(l) & "A Couple Of Times During Week, "
                        Next
                    Next
                Case Is = 2
                    For k = OffSeason.StartIndex To OffSeason.EndIndex Step 7
                        For l = 0 To CurrentElements.Count - 1
                            Diary(k).Activities = Diary(k).Activities & "Practice " & CurrentElements(l) & "Sparingly During Week, "
                        Next
                    Next
                Case Is = 3
                    For k = OffSeason.StartIndex To OffSeason.EndIndex Step 7
                        For l = 0 To CurrentElements.Count - 1
                            Diary(k).Activities = Diary(k).Activities & "Practice " & CurrentElements(l) & "One Day In The Week, "
                        Next
                    Next
            End Select

        Next

        CurrentElements.Clear()

        For i = 0 To Elements.Count - 1
            CurrentElements.Add(Mid(Elements(i), 1, Len(Elements(i)) - 3))
        Next

        ElementsAdded = 0
        CurrentDate = Preseason.StartIndex

        Do

            Diary(CurrentDate).Activities = Diary(CurrentDate).Activities & "Focus On Practicing " & CurrentElements(ElementsAdded) & "During The Week, "
            For j = 0 To CurrentElements.Count - 1
                If j <> ElementsAdded Then
                    Diary(CurrentDate).Activities = Diary(CurrentDate).Activities & "Practice " & CurrentElements(ElementsAdded) & "During The Week, "
                End If
            Next

            ElementsAdded = ElementsAdded + 1
            CurrentDate = CurrentDate + 7

        Loop Until ElementsAdded = CurrentElements.Count Or CurrentDate >= Preseason.EndIndex

        ElementsAdded = 0
        CurrentDate = Inseason.StartIndex

        Do

            For j = 0 To CurrentElements.Count - 1

                Diary(CurrentDate).Activities = Diary(CurrentDate).Activities & "Practice " & CurrentElements(ElementsAdded) & "During The Week, "

            Next

            ElementsAdded = ElementsAdded + 1
            CurrentDate = CurrentDate + 7

        Loop Until ElementsAdded = CurrentElements.Count Or CurrentDate >= Inseason.EndIndex

    End Sub
    Private Sub AddCompetitionsAndTests()

        Dim StartIndex As Integer
        Dim EventLength As Integer
        Dim CurrentIndex As Integer
        Dim RequiredIndex As Integer

        For i = 0 To Competitions.Count - 1

            CurrentIndex = Mid(Competitions(i), Len(Competitions(i)) - 1, 1)

            For j = 0 To CompetitionDates.Count - 1

                If CompetitionDates(j).ID = CurrentIndex Then
                    RequiredIndex = j
                End If

            Next

            StartIndex = DateDiff(DateInterval.Day, DiaryStartDate, CompetitionDates(RequiredIndex).StartDate) + 1
            EventLength = DateDiff(DateInterval.Day, CompetitionDates(RequiredIndex).StartDate, CompetitionDates(RequiredIndex).EndDate)

            For j = StartIndex To StartIndex + EventLength

                Diary(j).Activities = "COMPETITION - " & CompetitionDates(RequiredIndex).Name
                Diary(j).Skate = False

            Next

        Next

        For i = 0 To Tests.Count - 1

            CurrentIndex = Mid(Tests(i), Len(Tests(i)) - 1, 1)

            For j = 0 To TestDates.Count - 1

                If TestDates(j).ID = CurrentIndex Then
                    RequiredIndex = j
                End If

            Next

            StartIndex = DateDiff(DateInterval.Day, DiaryStartDate, TestDates(RequiredIndex).StartDate) + 1

            Diary(StartIndex).Activities = "TEST - ID=" & TestDates(RequiredIndex).ID
            Diary(StartIndex).Skate = False

        Next

    End Sub

    Private Sub OpenResultsForm(ByRef Diary() As TDiary)

        FRMDiaryScreen3.MdiParent = FRMParent
        FRMDiaryScreen2.Hide()
        FRMDiaryScreen3.WindowState = FormWindowState.Maximized
        FRMDiaryScreen3.Show()
        FRMDiaryScreen3.Main(Diary, Transition, OffSeason, Preseason, Inseason)

    End Sub

End Module
