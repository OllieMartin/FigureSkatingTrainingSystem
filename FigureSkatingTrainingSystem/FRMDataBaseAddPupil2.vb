Public Class FRMDataBaseAddPupil2

    Private DS As New DataSet
    Private JumpCompDict As New Dictionary(Of Integer, String)
    Private SpinCompDict As New Dictionary(Of Integer, String)
    Private StSqCompDict As New Dictionary(Of Integer, String)
    Private ChSqCompDict As New Dictionary(Of Integer, String)
    Private PupilID As Integer
    Private JustClicked As Boolean = False

    Private Sub FRMDataBaseAddPupil2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateDictionary()
        
        PopulateDataGrid1()
        PopulateDataGrid2()
        
        PopulateComboBoxes1()
        PopulateComboBoxes2()

    End Sub

    Private Sub PopulateDictionary()

        JumpCompDict.Add(0, "0: Unable to perform")
        JumpCompDict.Add(1, "1: Working On")
        JumpCompDict.Add(2, "2: Illegal Entry & Under-Rotated")
        JumpCompDict.Add(3, "3: Illegal Entry Or Under-Rotated")
        JumpCompDict.Add(4, "4: Can land but not consistent")
        JumpCompDict.Add(5, "5: Safe Jump")
        JumpCompDict.Add(6, "6: Excellent")
        SpinCompDict.Add(0, "0: Unable to perform")
        SpinCompDict.Add(1, "1: Working On")
        SpinCompDict.Add(2, "2: Under number of revolutions")
        SpinCompDict.Add(3, "3: Safe Spin")
        SpinCompDict.Add(4, "4: Strong Spin")
        SpinCompDict.Add(5, "5: Excellent")
        StSqCompDict.Add(0, "0: Unable to perform")
        StSqCompDict.Add(1, "1: Stumbling")
        StSqCompDict.Add(2, "2: Not in time")
        StSqCompDict.Add(3, "3: Good speed and footwork")
        StSqCompDict.Add(4, "4: Good execution & edges")
        ChSqCompDict.Add(0, "0: Unable to perform")
        ChSqCompDict.Add(1, "1: Stumbling")
        ChSqCompDict.Add(2, "2: Unable to work with music")
        ChSqCompDict.Add(3, "3: Some demonstration of chatacter")
        ChSqCompDict.Add(4, "4: Good speed & energy")
        ChSqCompDict.Add(5, "5: Precise, committed and effortless")

    End Sub

    Private Sub PopulateDataGrid1()

        Dim RecordCount As Integer
        Dim LastCol As Integer
        Dim LastRow As Integer

        If Not DataGridView1.SelectedCells.Count = 0 Then
            LastCol = DataGridView1.SelectedCells.Item(0).ColumnIndex
            LastRow = DataGridView1.SelectedCells.Item(0).RowIndex
        Else
            LastCol = -1
            LastRow = -1
        End If

        DS.Tables.Clear()

        DS = FileManagement.QueryDatabase("SELECT * FROM [Pupil]", "pupilinfo")

        RecordCount = DS.Tables("pupilinfo").Rows.Count

        PupilID = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(0)

        DS.Tables.Add("clevel")

        For i = 7 To 30
            DS.Tables("clevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 35 To 38
            DS.Tables("clevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 43 To 46
            DS.Tables("clevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 51 To 54
            DS.Tables("clevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 57 To 58
            DS.Tables("clevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 61 To 62
            DS.Tables("clevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 64 To 64
            DS.Tables("clevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 65 To 65
            DS.Tables("clevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next

        Dim j As Integer
        j = 0

        DS.Tables("clevel").Rows.Add()

        For i = 7 To 30
            DS.Tables("clevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 35 To 38
            DS.Tables("clevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 43 To 46
            DS.Tables("clevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 51 To 54
            DS.Tables("clevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 57 To 58
            DS.Tables("clevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 61 To 62
            DS.Tables("clevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 64 To 64
            DS.Tables("clevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 65 To 65
            DS.Tables("clevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next

        DataGridView1.DataSource = DS.Tables("clevel")
        DataGridView1.Refresh()

        If Not LastRow = -1 And Not LastCol = -1 Then
            DataGridView1.Item(LastCol, LastRow).Selected = True
        End If


    End Sub
    Private Sub PopulateDataGrid2()

        Dim RecordCount As Integer
        Dim LastCol As Integer
        Dim LastRow As Integer

        If Not DataGridView2.SelectedCells.Count = 0 Then
            LastCol = DataGridView2.SelectedCells.Item(0).ColumnIndex
            LastRow = DataGridView2.SelectedCells.Item(0).RowIndex
        Else
            LastCol = -1
            LastRow = -1
        End If

        DS.Tables.Clear()

        DS = FileManagement.QueryDatabase("SELECT * FROM [Pupil]", "pupilinfo")

        RecordCount = DS.Tables("pupilinfo").Rows.Count

        PupilID = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(0)

        DS.Tables.Add("tlevel")

        For i = 31 To 34
            DS.Tables("tlevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 39 To 42
            DS.Tables("tlevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 47 To 50
            DS.Tables("tlevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 55 To 56
            DS.Tables("tlevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 59 To 60
            DS.Tables("tlevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next
        For i = 63 To 63
            DS.Tables("tlevel").Columns.Add(Mid(DS.Tables("pupilinfo").Columns(i).ColumnName, 3, Len(DS.Tables("pupilinfo").Columns(i).ColumnName)))
        Next

        Dim j As Integer
        j = 0

        DS.Tables("tlevel").Rows.Add()

        For i = 31 To 34
            DS.Tables("tlevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 39 To 42
            DS.Tables("tlevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 47 To 50
            DS.Tables("tlevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 55 To 56
            DS.Tables("tlevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 59 To 60
            DS.Tables("tlevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next
        For i = 63 To 63
            DS.Tables("tlevel").Rows(0).Item(j) = DS.Tables("pupilinfo").Rows(RecordCount - 1).Item(i)
            j += 1
        Next

        DataGridView2.DataSource = DS.Tables("tlevel")
        DataGridView2.Refresh()


        If Not LastRow = -1 And Not LastCol = -1 Then
            DataGridView2.Item(LastCol, LastRow).Selected = True
        End If

    End Sub

    Private Sub PopulateComboBoxes1()
        CMBCompLevel.Items.Clear()
        Try
            Select Case DataGridView1.SelectedCells.Item(0).ColumnIndex

                Case Is < 24
                    For i = 0 To 6
                        CMBCompLevel.Items.Add(JumpCompDict(i))
                    Next
                Case Is < 40
                    For i = 0 To 5
                        CMBCompLevel.Items.Add(SpinCompDict(i))
                    Next
                Case Is < 41
                    For i = 0 To 4
                        CMBCompLevel.Items.Add(StSqCompDict(i))
                    Next
                Case Is < 42
                    For i = 0 To 5
                        CMBCompLevel.Items.Add(ChSqCompDict(i))
                    Next
            End Select
            CMBCompLevel.SelectedIndex = DataGridView1.SelectedCells.Item(0).Value
        Catch
        End Try
    End Sub
    Private Sub PopulateComboBoxes2()
        CMBTechLevel.Items.Clear()
        Try
            For i = 0 To 4
                CMBTechLevel.Items.Add(i)
            Next
            CMBTechLevel.SelectedIndex = DataGridView2.SelectedCells.Item(0).Value
        Catch
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        JustClicked = True
        PopulateComboBoxes1()

    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        JustClicked = True
        PopulateComboBoxes2()

    End Sub

    Private Sub CMBCompLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBCompLevel.SelectedIndexChanged
        If Not JustClicked Then
            FileManagement.ExecuteDatabaseCommand("UPDATE [Pupil] SET [CL" & DataGridView1.Columns(DataGridView1.SelectedCells(0).ColumnIndex).HeaderText & "]=" & CMBCompLevel.SelectedIndex & " WHERE Pupil_ID=" & PupilID)

            PopulateDataGrid1()
        Else
            JustClicked = False
        End If
    End Sub
    Private Sub CMBTechLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBTechLevel.SelectedIndexChanged
        If Not JustClicked Then
            FileManagement.ExecuteDatabaseCommand("UPDATE [Pupil] SET [TL" & DataGridView2.Columns(DataGridView2.SelectedCells(0).ColumnIndex).HeaderText & "]=" & CMBTechLevel.SelectedIndex & " WHERE Pupil_ID=" & PupilID)
            PopulateDataGrid2()
        Else
            JustClicked = False
        End If
    End Sub

    Private Sub CMDDone_Click(sender As Object, e As EventArgs) Handles CMDDone.Click
        
        Dim PreviousForm As Windows.Forms.Form = FRMDataBaseAddPupil.PreviousForm

        If Not PreviousForm.Name = "FRMDataBaseAddMenu" Then
            PreviousForm.MdiParent = FRMParent
            Me.Close()
            FRMDataBaseAddPupil.Close()
            PreviousForm.WindowState = FormWindowState.Maximized
            PreviousForm.Show()
            If PreviousForm.Name = "FRMRoutineScreen1" Then
                FRMRoutineScreen1.PopulateComboBoxes()
            ElseIf PreviousForm.Name = "FRMDiaryScreen1" Then
                FRMDiaryScreen1.PopulateComboBoxes()
            End If
        Else
            FRMDataBaseMenu.MdiParent = FRMParent
            Me.Close()
            FRMDataBaseAddPupil.Close()
            FRMDataBaseAddMenu.Close()
            FRMDataBaseMenu.WindowState = FormWindowState.Maximized
            FRMDataBaseMenu.Show()
        End If
    End Sub

End Class