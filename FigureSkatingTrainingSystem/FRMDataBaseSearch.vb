Public Class FRMDataBaseSearch

    Private Sub FRMDataBaseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateComboBoxes()

    End Sub

    Private Sub PopulateComboBoxes()

        CMBSearchTypes.Items.AddRange({"Pupil", "Coach", "Competition", "Test"})

    End Sub

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click
        FRMDataBaseMenu.MdiParent = FRMParent
        Me.Close()
        FRMDataBaseMenu.WindowState = FormWindowState.Maximized
        FRMDataBaseMenu.Show()
    End Sub

    Private Sub CMBSearchTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBSearchTypes.SelectedIndexChanged
        Select Case CMBSearchTypes.SelectedIndex
            Case Is = 0
                CMBField.Items.Clear()
                CMBField.Items.AddRange({"Pupil_ID", "Pupil_Forename", "Pupil_Surname", "Date_Of_Birth", "Field_Moves_Level", "Elements_Level", "Free_Level", "CL1S", "CL1T", "CL1Lo", "CL1F", "CL1Lz", "CL1A", "CL2S", "CL2T", "CL2Lo", "CL2F", "CL2Lz", "CL2A", "CL3S", "CL3T", "CL3Lo", "CL3F", "CL3Lz", "CL3A", "CL4S", "CL4T", "CL4Lo", "CL4F", "CL4Lz", "CL4A", "TLUSp", "TLLSp", "TLCSp", "TLSSp", "CLUSp", "CLLSp", "CLCSp", "CLSSp", "TLFUSp", "TLFLSp", "TLFCSp", "TLFSSp", "CLFUSp", "CLFLSp", "CLFCSp", "CLFSSp", "TL(F)CUSp", "TL(F)CLSp", "TL(F)CCSp", "TL(F)CSSp", "CL(F)CUSp", "CL(F)CLSp", "CL(F)CCSp", "CL(F)CSSp", "TL(F)CoSp2p", "TL(F)CoSp3p", "CL(F)CoSp2p", "CL(F)CoSp3p", "TL(F)CCoSp2p", "TL(F)CCoSp3p", "CL(F)CCoSp2p", "CL(F)CCoSp3p", "TLStSq", "CLStSq", "CLChSq", "Pupil_Coach_ID", "Max_HR", "HR_Decrease_Rate", "Resting_HR", "Skating_HR", "Presentation_Score", "Standing_Jump", "Pike_Reach", "Bleep_Test"})
            Case Is = 1
                CMBField.Items.Clear()
                CMBField.Items.AddRange({"Coach_ID", "Coach_Forename", "Coach_Surname"})
            Case Is = 2
                CMBField.Items.Clear()
                CMBField.Items.AddRange({"Competition_ID", "Competition_Name", "Competition_Start_Date", "Competition_Finish_Date", "Minimum_Level"})
            Case Is = 3
                CMBField.Items.Clear()
                CMBField.Items.AddRange({"Test_ID", "Test_Date"})
        End Select
    End Sub

    Private Sub CMDSearch_Click(sender As Object, e As EventArgs) Handles CMDSearch.Click

        Search()

    End Sub

    Public Sub Search()
        Dim DS As New DataSet

        Try
            DS = FileManagement.QueryDatabase("SELECT * FROM " & "[" & CMBSearchTypes.SelectedItem & "]" & " WHERE [" & CMBField.SelectedItem & "]='" & TXTSearchItem.Text & "'", "queryresults")
            DataGridView1.DataSource = DS.Tables("queryresults")
        Catch
            Try
                DS = FileManagement.QueryDatabase("SELECT * FROM " & "[" & CMBSearchTypes.SelectedItem & "]" & " WHERE [" & CMBField.SelectedItem & "]=" & TXTSearchItem.Text, "queryresults")
                DataGridView1.DataSource = DS.Tables("queryresults")
            Catch
                MsgBox("Invalid Search")
            End Try
        End Try
    End Sub

    Private Sub CMDDelete_Click(sender As Object, e As EventArgs) Handles CMDDelete.Click

        If Not DataGridView1.Rows.Count = 0 Then
            FileManagement.ExecuteDatabaseCommand("DELETE FROM [" & CMBSearchTypes.SelectedItem & "]" & " WHERE [" & DataGridView1.Columns(0).HeaderText & "]=" & DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex).Cells.Item(0).Value)
            Search()
        Else
            MsgBox("Please select a record")
        End If


    End Sub

    Private Sub CMDEdit_Click(sender As Object, e As EventArgs) Handles CMDEdit.Click
        FRMDataBaseSearch2.Show()
    End Sub

    Public Function GetSelectedField() As String
        Return DataGridView1.Columns(DataGridView1.SelectedCells.Item(0).ColumnIndex).HeaderText
    End Function
    Public Function GetSelectedIDFieldName() As String
        Return DataGridView1.Columns(0).HeaderText
    End Function
    Public Function GetSelectedID() As Integer
        Return DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex).Cells.Item(0).Value
    End Function
    Public Function GetSelectedTable() As String
        Return CMBSearchTypes.SelectedItem
    End Function

End Class