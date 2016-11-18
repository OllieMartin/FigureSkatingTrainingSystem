Option Explicit On
Imports System.Data
Imports System.Xml
Imports System.Environment

Public Module RoutinePlanning
    Private DS As New DataSet 'Dataset
    Private CN As New OleDb.OleDbConnection 'Database Connection
    Private DA As New OleDb.OleDbDataAdapter 'Database Adaptor

    Private CurrentTime As Integer 'Contains the current location in the planned routine in seconds after the start of the routine
    Private Const MaxNumberOfElements As Integer = 13
    Private CurrentRemovals As Integer 'Stores the number of elements removed from the routine in the current iteration of the recursive loop
    Private TotalRemovals As Integer 'Stores the number of elements removed from the routine in total
    Private RoutineComplete As Boolean = False 'Stores True or False depending on if the routine planning is complete
    Public FinalRoutine(13) As TRoutine 'Stores the completed routine

    Private SkatingHR As Integer 'Stores the skating HR value for the current pupil
    Private RestingHR As Integer 'Stores the resting HR value for the current pupil
    Private MaxHR As Integer 'Stores the Max HR value for the current pupil
    Private HRDecreaseRate As Single 'Stores the HR decrease rate for the current pupil
    Private AerobicLimit As Integer 'The HR value above which the pupil will enter anaerobic respiration. This is used to test if an element is acceptable in a specific location.
    <Serializable()> _
    Structure TElement
        Dim Code As String
        Dim Type As Integer
        Dim RestTime As Integer
        Dim BaseScore As Single
        Dim HeartRate As Integer
        Dim CompetencyLevel As Integer
        Dim V As Single
        Dim V1 As Single
    End Structure
    <Serializable()> _
    Structure TRoutine
        Dim Element As TElement
        Dim HeartRate As Integer
        Dim Location As Integer
        Dim NextPointer As Integer
        Dim PreviousPointer As Integer
        Dim Score As TScore
    End Structure
    Structure TChosenElement
        Dim Element As TElement
        Dim NextPointer As Integer
        Dim PreviousPointer As Integer
    End Structure
    <Serializable()> _
    Structure TScore
        Dim PredictedBase As Single
        Dim PredictedGOE As Integer
        Dim CleanBase As Single
        Dim CleanGOE As Integer
        Dim BadBase As Single
        Dim BadGOE As Integer
    End Structure

    Enum ElementType
        Jump = 1
        Spin = 2
        StSq = 3
        ChSq = 4
    End Enum
    Enum Pointers
        Start = 1
        EndOf = 2
        NextFree = 3
    End Enum

    Public Sub Main(ByRef ChosenElements As ArrayList, ByRef RoutineLength As Integer)

        'The main subroutine, calls all other procedures in the routine planning module

        Dim Elements(13) As TChosenElement
        Dim NumberOfElements As Integer = ChosenElements.Count
        Dim HRRT As Integer
        Dim Routine(13) As TRoutine
        Dim TriedSoFar As New ArrayList
        Dim ElementsAdded As Integer = 0
        Dim PickedBest As Boolean = False
        Dim PresentationScore As Single

        SkatingHR = FRMRoutineScreen2.GetSkatingHR
        MaxHR = FRMRoutineScreen2.GetMaxHR
        RestingHR = FRMRoutineScreen2.GetRestingHR
        HRDecreaseRate = FRMRoutineScreen2.GetHRDecreaseRate
        PresentationScore = FRMRoutineScreen2.GetPresentationScore
        AerobicLimit = ((MaxHR - RestingHR) / 100) * 80 + RestingHR

        Dim EListPointers(3) As Integer 'An array of integers storing the pointers needed for managing the elements linked list.
        Dim RListPointers(3) As Integer 'An array of integers storing the pointers needed for managing the routine linked list.

        InitialiseElementsList(Elements, EListPointers)
        ConvertToTChosenElement(ChosenElements, Elements, EListPointers)

        GetSOVAndHR(Elements, NumberOfElements, HRRT)
        CalculateRestTimes(Elements, NumberOfElements, HRRT, RoutineLength)

        InitialiseRoutine(NumberOfElements, Routine, RListPointers)

        CurrentTime = 5

        CreateRoutine(NumberOfElements, Routine, RListPointers, Elements, EListPointers, TriedSoFar, ElementsAdded, PickedBest)

        PredictScores(NumberOfElements, RoutineLength, PresentationScore)

        AdvanceForm()

        FRMRoutineScreen3.Main(NumberOfElements, FinalRoutine, PresentationScore, FRMRoutineScreen1.GetPupilID)

    End Sub

    Private Sub ConvertToTChosenElement(ByRef ChosenElements As ArrayList, ByRef Elements() As TChosenElement, ByRef EListPointers() As Integer)

        'This procedure converts a given list of element identifiers as strings into the data type TChosenElement 

        Dim ElementToAdd As TElement 'Stores the information for the newly converted element temporarily so that it can be added to the Elements linked list.

        For i = 0 To ChosenElements.Count - 1

            ElementToAdd.Code = Mid(ChosenElements(i), 1, Len(ChosenElements(i)) - 3)
            ElementToAdd.CompetencyLevel = Mid(ChosenElements(i), Len(ChosenElements(i)) - 1, 1)

            If Len(ChosenElements(i)) < 8 Then
                ElementToAdd.Type = ElementType.Jump
            ElseIf Mid(ChosenElements(i), 1, 4) = "ChSq" Then
                ElementToAdd.Type = ElementType.ChSq
            ElseIf Mid(ChosenElements(i), 1, 4) = "StSq" Then
                ElementToAdd.Type = ElementType.StSq
            Else
                ElementToAdd.Type = ElementType.Spin
            End If

            AddElementToList(Elements, ElementToAdd, EListPointers)

        Next

    End Sub
    'List of chosen elements operations
    Private Sub InitialiseElementsList(ByRef Elements() As TChosenElement, ByRef EListPointers() As Integer)

        'This procedure initialises the Elements array to act as a linked list.

        Elements(0).NextPointer = 0
        Elements(0).PreviousPointer = 0
        For counter = 1 To (MaxNumberOfElements - 1)
            Elements(counter).NextPointer = counter + 1
            Elements(counter).PreviousPointer = counter - 1
        Next
        Elements(MaxNumberOfElements).NextPointer = 0
        Elements(MaxNumberOfElements).PreviousPointer = MaxNumberOfElements - 1

        EListPointers(Pointers.Start) = 0
        EListPointers(Pointers.EndOf) = 0
        EListPointers(Pointers.NextFree) = 1
    End Sub
    Private Sub AddElementToList(ByRef Elements() As TChosenElement, ByVal ElementToAdd As TElement, ByRef EListPointers() As Integer)

        'This procedure adds an element to the end of the elements linked list.

        Dim Temp As Integer
        Elements(EListPointers(Pointers.NextFree)).Element = ElementToAdd
        If EListPointers(Pointers.Start) = 0 Then
            Temp = Elements(EListPointers(Pointers.NextFree)).NextPointer
            Elements(EListPointers(Pointers.NextFree)).NextPointer = 0
            Elements(EListPointers(Pointers.NextFree)).PreviousPointer = EListPointers(Pointers.EndOf)
            EListPointers(Pointers.NextFree) = Temp
            Elements(Temp).PreviousPointer = 0
            EListPointers(Pointers.Start) = 1
            EListPointers(Pointers.EndOf) = 1
        Else
            Temp = Elements(EListPointers(Pointers.NextFree)).NextPointer
            Elements(EListPointers(Pointers.NextFree)).NextPointer = 0
            Elements(EListPointers(Pointers.NextFree)).PreviousPointer = EListPointers(Pointers.EndOf)
            Elements(EListPointers(Pointers.EndOf)).NextPointer = EListPointers(Pointers.NextFree)
            EListPointers(Pointers.EndOf) = EListPointers(Pointers.NextFree)
            EListPointers(Pointers.NextFree) = Temp
            Elements(Temp).PreviousPointer = 0
        End If

    End Sub
    Private Sub RemoveElementFromList(ByRef Elements() As TChosenElement, ByRef EListPointers() As Integer, ByVal ElementToRemove As Integer)

        'This procedure removes a specified element from the elements linked list.
 
        Dim Temp As Integer
        Dim PreviousNode As Integer
        If ElementToRemove = EListPointers(Pointers.EndOf) Then
            EListPointers(Pointers.EndOf) = Elements(EListPointers(Pointers.EndOf)).PreviousPointer
        End If
        If ElementToRemove = EListPointers(Pointers.Start) Then
            EListPointers(Pointers.Start) = Elements(EListPointers(Pointers.Start)).NextPointer
        End If
        Temp = EListPointers(Pointers.NextFree)
        EListPointers(Pointers.NextFree) = ElementToRemove
        PreviousNode = Elements(ElementToRemove).PreviousPointer
        Elements(PreviousNode).NextPointer = Elements(ElementToRemove).NextPointer
        Elements(Elements(ElementToRemove).NextPointer).PreviousPointer = Elements(ElementToRemove).PreviousPointer
        Elements(ElementToRemove).NextPointer = Temp
        Elements(ElementToRemove).PreviousPointer = 0
        Elements(Elements(ElementToRemove).NextPointer).PreviousPointer = ElementToRemove

    End Sub

    'Getting Element Information
    Private Sub GetSOVAndHR(ByRef Elements() As TChosenElement, ByVal NumberOfElements As Integer, ByRef HRRT As Integer)

        'This subroutine gets all the HR values and score information for the elements that are to be included in the routine.

        Dim i As Integer 'Stepper variable for FOR loops
        Dim sql As String 'SQL command to execute
        Dim RecordCount As Integer ' Number of records in database
        Dim DataBaseVersion As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
        Dim DataBasePath As String = GetFolderPath(SpecialFolder.MyDocuments) & "\FigureSkatingTrainingSystem\Databases\FigureSkatingTrainingSystem.accdb;"

        For i = 0 To NumberOfElements - 1

            sql = "SELECT * FROM [SOVHR] WHERE Element_ID = '" & Elements(i + 1).Element.Code & "'"
            CN.ConnectionString = DataBaseVersion & DataBasePath
            DA = New OleDb.OleDbDataAdapter(sql, CN)
            CN.Open()
            DA.Fill(DS, "SOVHR")
            CN.Close()

            RecordCount = DS.Tables("SOVHR").Rows.Count

            Elements(i + 1).Element.HeartRate = DS.Tables("SOVHR").Rows(i).Item(11)
            HRRT = HRRT + Elements(i + 1).Element.HeartRate
            Elements(i + 1).Element.BaseScore = DS.Tables("SOVHR").Rows(i).Item(5)

            If Not IsDBNull(DS.Tables("SOVHR").Rows(i).Item(6)) Then
                Elements(i + 1).Element.V = DS.Tables("SOVHR").Rows(i).Item(6)
            Else
                Elements(i + 1).Element.V = 0
            End If

            If Not IsDBNull(DS.Tables("SOVHR").Rows(i).Item(7)) Then
                Elements(i + 1).Element.V1 = DS.Tables("SOVHR").Rows(i).Item(7)
            Else
                Elements(i + 1).Element.V1 = 0
            End If

        Next

    End Sub
    Private Sub CalculateRestTimes(ByRef Elements() As TChosenElement, ByVal NumberOfElements As Integer, ByRef HRRT As Integer, ByVal RoutineLength As Integer)

        'This procedure calculates the amount of rest time each element will have

        For i = 0 To NumberOfElements - 1

            Elements(i + 1).Element.RestTime = Math.Round((Elements(i + 1).Element.HeartRate / HRRT) * (RoutineLength - 10))
            FRMRoutineScreen2.CLBNeeded.Items.Add(Elements(i + 1).Element.RestTime)

        Next

    End Sub

    'List of routine operations
    Private Sub InitialiseRoutine(ByVal NumberOfElements As Integer, ByRef Routine() As TRoutine, ByRef RListPointers() As Integer)

        'This procedure initialises the Routine array to act as a linked list.

        For counter = 0 To NumberOfElements
            Routine(counter).HeartRate = 0
            Routine(counter).Location = 0
        Next
        Routine(0).NextPointer = 0
        Routine(0).PreviousPointer = 0
        For counter = 1 To (NumberOfElements - 1)
            Routine(counter).NextPointer = counter + 1
            Routine(counter).PreviousPointer = counter - 1
        Next
        Routine(NumberOfElements).NextPointer = 0
        Routine(NumberOfElements).PreviousPointer = NumberOfElements - 1
        RListPointers(Pointers.Start) = 0
        RListPointers(Pointers.EndOf) = 0
        RListPointers(Pointers.NextFree) = 1
    End Sub
    Private Sub AddToRoutine(ByRef NumberOfElements As Integer, ByRef Routine() As TRoutine, ByRef RListPointers() As Integer, ByRef ElementToAdd As TRoutine)

        'This procedure adds an element to the end of the routine linked list.

        Dim Temp As Integer

        Routine(RListPointers(Pointers.NextFree)).Element = ElementToAdd.Element
        Routine(RListPointers(Pointers.NextFree)).Location = ElementToAdd.Location
        Routine(RListPointers(Pointers.NextFree)).HeartRate = ElementToAdd.HeartRate

        If RListPointers(Pointers.Start) = 0 Then
            Temp = Routine(RListPointers(Pointers.NextFree)).NextPointer
            Routine(RListPointers(Pointers.NextFree)).NextPointer = 0
            Routine(RListPointers(Pointers.NextFree)).PreviousPointer = RListPointers(Pointers.EndOf)
            RListPointers(Pointers.NextFree) = Temp
            Routine(Temp).PreviousPointer = 0
            RListPointers(Pointers.Start) = 1
            RListPointers(Pointers.EndOf) = 1
        Else
            Temp = Routine(RListPointers(Pointers.NextFree)).NextPointer
            Routine(RListPointers(Pointers.NextFree)).NextPointer = 0
            Routine(RListPointers(Pointers.NextFree)).PreviousPointer = RListPointers(Pointers.EndOf)
            Routine(RListPointers(Pointers.EndOf)).NextPointer = RListPointers(Pointers.NextFree)
            RListPointers(Pointers.EndOf) = RListPointers(Pointers.NextFree)
            RListPointers(Pointers.NextFree) = Temp
            Routine(Temp).PreviousPointer = 0
        End If

    End Sub
    Private Sub RemoveFromRoutine(ByRef NumberOfElements As Integer, ByRef Routine() As TRoutine, ByRef RListPointers() As Integer)

        'This procedure removes an element from the end of the routine linked list

        Dim Temp As Integer

        If Not RListPointers(Pointers.Start) = 0 Then
            Routine(RListPointers(Pointers.EndOf)).NextPointer = RListPointers(Pointers.NextFree)
            Routine(RListPointers(Pointers.NextFree)).PreviousPointer = RListPointers(Pointers.EndOf)
            Routine(Routine(RListPointers(Pointers.EndOf)).PreviousPointer).NextPointer = 0
            Temp = RListPointers(Pointers.EndOf)
            RListPointers(Pointers.EndOf) = Routine(RListPointers(Pointers.EndOf)).PreviousPointer
            Routine(Temp).PreviousPointer = 0
            RListPointers(Pointers.NextFree) = Temp
        End If

    End Sub

    'Create the routine
    Private Sub CreateRoutine(ByVal NumberOfElements As Integer, ByVal Routine() As TRoutine, ByVal RListPointers() As Integer, ByVal Elements() As TChosenElement, ByVal EListPointers() As Integer, ByVal TriedSoFar As ArrayList, ByVal ElementsAdded As Integer, ByVal PickedBest As Boolean)

        'This is the main recursive routine planning algorithm that attempts to place elements in the routine according to HR and scores. It will iterate back and forth until a solution is found.

        Dim JustPicked As Boolean
        Dim NextElement As TRoutine
        Dim PreviousElement As TRoutine

        If Not TriedSoFar.Count = 0 Then
            For i = 0 To TriedSoFar.Count - 1
                AddElementToList(Elements, TriedSoFar(i).Element, EListPointers)
            Next
            TriedSoFar.Clear()
        End If

        Do

            If Not JustPicked And Not ElementsAdded = NumberOfElements Then 'If they haven't already chosen an element in this iteration then...

                NextElement = GetNextPossibleElement(Elements, EListPointers, Routine, RListPointers) 'Get the next element to consider

            End If
            If Routine(RListPointers(Pointers.EndOf)).HeartRate = 0 Then
                NextElement.HeartRate = SkatingHR + NextElement.Element.HeartRate 'Increase the skaters HR at this element
            Else
                NextElement.HeartRate = Routine(RListPointers(Pointers.EndOf)).HeartRate + NextElement.Element.HeartRate 'Increase the skaters HR at this element
                NextElement.HeartRate = NextElement.HeartRate - (Routine(RListPointers(Pointers.EndOf)).Element.RestTime * HRDecreaseRate)
            End If

            If NextElement.HeartRate < SkatingHR Then
                NextElement.HeartRate = SkatingHR
            ElseIf NextElement.HeartRate > MaxHR Then
                NextElement.HeartRate = MaxHR
            End If

            If ((NextElement.HeartRate < AerobicLimit Or JustPicked) And (Not ElementsAdded = NumberOfElements)) Then 'If the HR of the element is acceptable or an element has already been chosen...

                JustPicked = False 'Reset the "element already chosen" indicator
                NextElement.Location = CurrentTime
                CurrentTime = CurrentTime + NextElement.Element.RestTime
                AddToRoutine(NumberOfElements, Routine, RListPointers, NextElement) 'Add the new element to the routine
                ElementsAdded = ElementsAdded + 1 'Increase the elements added counter
                'MsgBox("ElementsAdded = " & ElementsAdded)
                PreviousElement = NextElement 'Previous Element is now the element just added.
                CreateRoutine(NumberOfElements, Routine, RListPointers, Elements, EListPointers, TriedSoFar, ElementsAdded, PickedBest) 'Call this procedure again
                If Not RoutineComplete Then 'If they routine isn't complete then the element needs to be removed that was just added
                    'MsgBox("Removed: " & Routine(RListPointers(Pointers.EndOf)).Element.Code)
                    RemoveFromRoutine(NumberOfElements, Routine, RListPointers) 'Remove the element from the routine
                    TriedSoFar.Add(PreviousElement) 'Add the element to the list of those tried so far
                    CurrentRemovals = CurrentRemovals + 1 'Increase the current removals counter
                    TotalRemovals = TotalRemovals + 1 'Increase the total removals by 1
                    ElementsAdded = ElementsAdded - 1
                    CurrentTime = CurrentTime - PreviousElement.Element.RestTime
                End If
            ElseIf Not RoutineComplete Then
                TriedSoFar.Add(NextElement) 'If HR unacceptable add this element to those tried so far.
            End If
            If Not RoutineComplete Then 'If Not Routine Complete
                If (((CurrentRemovals > 2 Or TotalRemovals > 13) Or PickedBest) And TriedSoFar.Count = NumberOfElements - ElementsAdded) Or (TriedSoFar.Count = NumberOfElements - ElementsAdded And ElementsAdded = 0) Then 'If the routine isn't complete and 2 have already been tried this time around, or over 13 have been tried and failed in total...
                    'MsgBox("Current Removals = " & CurrentRemovals)
                    'MsgBox("Total Removals = " & TotalRemovals)
                    NextElement = PickBestElementOfThoseTriedSoFar(TriedSoFar) 'Make Next element the best of all those tried so far
                    PickedBest = True
                    'AllElementsTried = False 'Set all elements tried to false.
                    For i = 0 To TriedSoFar.Count - 1
                        AddElementToList(Elements, TriedSoFar(i).Element, EListPointers)
                    Next
                    TriedSoFar.Clear() 'Clear elements in the tried so far list?
                    JustPicked = True 'Set the indicator to say we have just picked an element
                    CurrentRemovals = 0 'Reset the current removals counter
                    'ElseIf TriedSoFar.Count = NumberOfElements - ElementsAdded Then

                End If
            End If
            If ElementsAdded = NumberOfElements Then
                RoutineComplete = True
                FinalRoutine = Routine
            End If

        Loop Until TriedSoFar.Count = NumberOfElements - ElementsAdded Or RoutineComplete

    End Sub
    Private Function GetNextPossibleElement(ByRef Elements() As TChosenElement, ByRef EListPointers() As Integer, ByRef Routine() As TRoutine, ByRef RListPointers() As Integer) As TRoutine

        'This function gets the next possible element to try and add to the routine based from the scores of all elements that are left to be added.

        Dim RoutineElement As TRoutine
        Dim PreviousElement As TRoutine
        Dim FirstElementLocation As Integer = EListPointers(Pointers.Start)
        Dim NextElementIndex As Integer
        Dim ChosenIndex As Integer
        Dim ChosenScore As Single



        If RListPointers(Pointers.Start) = 0 Then

            NextElementIndex = FirstElementLocation

            Do

                If Elements(NextElementIndex).Element.BaseScore > ChosenScore Then

                    ChosenIndex = NextElementIndex
                    ChosenScore = Elements(ChosenIndex).Element.BaseScore

                End If

                NextElementIndex = Elements(NextElementIndex).NextPointer

            Loop Until NextElementIndex = 0

        Else

            NextElementIndex = FirstElementLocation

            PreviousElement = Routine(RListPointers(Pointers.EndOf))

            ChosenIndex = 0

            Do

                If Not Elements(NextElementIndex).Element.Type = PreviousElement.Element.Type Then

                    ChosenIndex = NextElementIndex

                End If

                NextElementIndex = Elements(NextElementIndex).NextPointer

            Loop Until NextElementIndex = 0 Or Not ChosenIndex = 0

            If ChosenIndex = 0 Then

                ChosenIndex = EListPointers(Pointers.EndOf)

            End If

        End If

        RoutineElement.Element = Elements(ChosenIndex).Element
        RoutineElement.HeartRate = 0
        RoutineElement.Location = 0
        RoutineElement.NextPointer = 0
        RoutineElement.PreviousPointer = 0
        RemoveElementFromList(Elements, EListPointers, ChosenIndex)

        Return RoutineElement

    End Function
    Private Function PickBestElementOfThoseTriedSoFar(ByRef TriedSoFar As ArrayList)

        'This function returns the best possible option of all the previously rejected elements when planning the routine so that it can be added to the routine

        Dim BestOption As Integer = 0
        Dim BestHR As Integer

        For i = 0 To TriedSoFar.Count - 1
            If TriedSoFar(i).HeartRate < BestHR Then

                BestOption = i
                BestHR = TriedSoFar(i).HeartRate

            End If
        Next

        Return TriedSoFar(BestOption)

    End Function

    'Predicted Scores
    Private Sub PredictScores(ByVal NumberOfElements As Integer, ByVal RoutineLength As Integer, ByVal PresentationScore As Single)

        'This procedure predicts the scores for each element in the routine based from the pupil’s competency level and heartrate at that point in the routine.

        Dim Code As String
        Dim Type As Integer
        Dim Location As Integer
        Dim HeartRate As Integer
        Dim BaseScore As Single
        Dim VScore As Single
        Dim V1Score As Single
        Dim Competency As Integer

        For i = 1 To NumberOfElements

            Code = FinalRoutine(i).Element.Code
            Location = FinalRoutine(i).Location
            HeartRate = FinalRoutine(i).HeartRate
            BaseScore = FinalRoutine(i).Element.BaseScore
            VScore = FinalRoutine(i).Element.V
            V1Score = FinalRoutine(i).Element.V1
            Type = FinalRoutine(i).Element.Type
            Competency = FinalRoutine(i).Element.CompetencyLevel

            FinalRoutine(i).Score.CleanBase = BaseScore

            Select Case Type
                Case Is = ElementType.Jump
                    Select Case Competency
                        Case Is = 0
                            FinalRoutine(i).Score.BadBase = 0
                            FinalRoutine(i).Score.BadGOE = 0
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = 0
                            FinalRoutine(i).Score.PredictedGOE = 0
                        Case Is = 1
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.BadBase = V1Score - 0.4
                            FinalRoutine(i).Score.PredictedBase = V1Score - 0.4
                            If FinalRoutine(i).Score.PredictedBase < 0 Then
                                FinalRoutine(i).Score.PredictedBase = 0
                                FinalRoutine(i).Score.BadBase = 0
                            End If
                            FinalRoutine(i).Score.BadGOE = -3
                            FinalRoutine(i).Score.PredictedGOE = -3
                        Case Is = 2
                            FinalRoutine(i).Score.BadBase = V1Score
                            FinalRoutine(i).Score.BadGOE = -3
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = V1Score
                            FinalRoutine(i).Score.PredictedGOE = -3
                        Case Is = 3
                            FinalRoutine(i).Score.BadBase = VScore
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = VScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = -2
                                FinalRoutine(i).Score.BadGOE = -3
                            Else
                                FinalRoutine(i).Score.PredictedGOE = -1
                                FinalRoutine(i).Score.BadGOE = -2
                            End If
                        Case Is = 4
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = -1
                                FinalRoutine(i).Score.BadGOE = -2
                            Else
                                FinalRoutine(i).Score.PredictedGOE = 0
                                FinalRoutine(i).Score.BadGOE = -1
                            End If
                        Case Is = 5
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.BadGOE = -2
                                FinalRoutine(i).Score.PredictedGOE = 0
                                FinalRoutine(i).Score.CleanGOE = 0
                            Else
                                FinalRoutine(i).Score.BadGOE = -1
                                FinalRoutine(i).Score.PredictedGOE = 1
                                FinalRoutine(i).Score.CleanGOE = 1
                            End If
                        Case Is = 6
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.BadGOE = -1
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = 2
                                FinalRoutine(i).Score.CleanGOE = 2
                            Else
                                FinalRoutine(i).Score.PredictedGOE = 3
                                FinalRoutine(i).Score.CleanGOE = 3
                            End If
                    End Select
                Case Is = ElementType.Spin
                    Select Case Competency
                        Case Is = 0
                            FinalRoutine(i).Score.BadBase = 0
                            FinalRoutine(i).Score.BadGOE = 0
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = 0
                            FinalRoutine(i).Score.PredictedGOE = 0
                        Case Is = 1
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.BadGOE = -3
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            FinalRoutine(i).Score.PredictedGOE = -3
                        Case Is = 2
                            FinalRoutine(i).Score.BadBase = VScore
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = VScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = -2
                                FinalRoutine(i).Score.BadGOE = -3
                            Else
                                FinalRoutine(i).Score.PredictedGOE = -1
                                FinalRoutine(i).Score.BadGOE = -2
                            End If
                        Case Is = 3
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = -1
                                FinalRoutine(i).Score.BadGOE = -2
                            Else
                                FinalRoutine(i).Score.PredictedGOE = 0
                                FinalRoutine(i).Score.BadGOE = -1
                            End If
                        Case Is = 4
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.BadGOE = -2
                                FinalRoutine(i).Score.PredictedGOE = 1
                                FinalRoutine(i).Score.CleanGOE = 1
                            Else
                                FinalRoutine(i).Score.BadGOE = -1
                                FinalRoutine(i).Score.PredictedGOE = 2
                                FinalRoutine(i).Score.CleanGOE = 2
                            End If
                        Case Is = 5
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.BadGOE = -1
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = 2
                                FinalRoutine(i).Score.CleanGOE = 2
                            Else
                                FinalRoutine(i).Score.PredictedGOE = 3
                                FinalRoutine(i).Score.CleanGOE = 3
                            End If
                    End Select
                Case Is = ElementType.StSq
                    Select Case Competency
                        Case Is = 0
                            FinalRoutine(i).Score.BadBase = 0
                            FinalRoutine(i).Score.BadGOE = 0
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = 0
                            FinalRoutine(i).Score.PredictedGOE = 0
                        Case Is = 1
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.BadGOE = -3
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            FinalRoutine(i).Score.PredictedGOE = -3
                        Case Is = 2
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = -2
                                FinalRoutine(i).Score.BadGOE = -3
                            Else
                                FinalRoutine(i).Score.PredictedGOE = -1
                                FinalRoutine(i).Score.BadGOE = -2
                            End If
                        Case Is = 3
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.BadGOE = -2
                                FinalRoutine(i).Score.PredictedGOE = 0
                                FinalRoutine(i).Score.CleanGOE = 0
                            Else
                                FinalRoutine(i).Score.BadGOE = -1
                                FinalRoutine(i).Score.PredictedGOE = 1
                                FinalRoutine(i).Score.CleanGOE = 1
                            End If
                        Case Is = 4
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.BadGOE = -1
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = 2
                                FinalRoutine(i).Score.CleanGOE = 2
                            Else
                                FinalRoutine(i).Score.PredictedGOE = 3
                                FinalRoutine(i).Score.CleanGOE = 3
                            End If
                    End Select
                Case Is = ElementType.ChSq
                    Select Case Competency
                        Case Is = 0
                            FinalRoutine(i).Score.BadBase = 0
                            FinalRoutine(i).Score.BadGOE = 0
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = 0
                            FinalRoutine(i).Score.PredictedGOE = 0
                        Case Is = 1
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.BadGOE = -3
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            FinalRoutine(i).Score.PredictedGOE = -3
                        Case Is = 2
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = -2
                                FinalRoutine(i).Score.BadGOE = -3
                            Else
                                FinalRoutine(i).Score.PredictedGOE = -1
                                FinalRoutine(i).Score.BadGOE = -2
                            End If
                        Case Is = 3
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.CleanGOE = 0
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = -1
                                FinalRoutine(i).Score.BadGOE = -2
                            Else
                                FinalRoutine(i).Score.PredictedGOE = 0
                                FinalRoutine(i).Score.BadGOE = -1
                            End If
                        Case Is = 4
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.BadGOE = -2
                                FinalRoutine(i).Score.PredictedGOE = 0
                                FinalRoutine(i).Score.CleanGOE = 0
                            Else
                                FinalRoutine(i).Score.BadGOE = -1
                                FinalRoutine(i).Score.PredictedGOE = 1
                                FinalRoutine(i).Score.CleanGOE = 1
                            End If
                        Case Is = 5
                            FinalRoutine(i).Score.BadGOE = -1
                            FinalRoutine(i).Score.BadBase = BaseScore
                            FinalRoutine(i).Score.PredictedBase = BaseScore
                            If FinalRoutine(i).HeartRate >= AerobicLimit Then
                                FinalRoutine(i).Score.PredictedGOE = 2
                                FinalRoutine(i).Score.CleanGOE = 2
                            Else
                                FinalRoutine(i).Score.PredictedGOE = 3
                                FinalRoutine(i).Score.CleanGOE = 3
                            End If
                    End Select
            End Select

        Next

    End Sub

    'Go to the next form to display results
    Sub AdvanceForm()

        'Switches the currently displayed form (FRMRoutineScreen2) for FRMRoutineScreen3 to display the results of the routine planning.

        FRMRoutineScreen3.MdiParent = FRMParent
        FRMRoutineScreen2.Hide()
        FRMRoutineScreen3.WindowState = FormWindowState.Maximized
        FRMRoutineScreen3.Show()

    End Sub

End Module
