Public Class FRMDataBaseAddMenu

    Private Enum Selected
        Pupil = 0
        Coach = 1
        Comp = 2
        Test = 3
    End Enum

    Private Sub FRMDataBaseAddMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CMDNext.Enabled = False
        CMBTypes.Items.AddRange({"Add a new pupil", "Add a new coach", "Add a new competition", "Add a new test"})

    End Sub

    Private Sub CMBTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBTypes.SelectedIndexChanged

        If Not CMDNext.Enabled Then
            CMDNext.Enabled = True
        End If

    End Sub

    Private Sub CMDCancel_Click(sender As Object, e As EventArgs) Handles CMDCancel.Click
        FRMDataBaseMenu.MdiParent = FRMParent
        Me.Close()
        FRMDataBaseMenu.WindowState = FormWindowState.Maximized
        FRMDataBaseMenu.Show()
    End Sub

    Private Sub CMDNext_Click(sender As Object, e As EventArgs) Handles CMDNext.Click

        Select Case CMBTypes.SelectedIndex

            Case Is = Selected.Pupil
                FRMDataBaseAddPupil.MdiParent = FRMParent
                Me.Hide()
                FRMDataBaseAddPupil.WindowState = FormWindowState.Maximized
                FRMDataBaseAddPupil.PreviousForm = Me
                FRMDataBaseAddPupil.Show()
            Case Is = Selected.Coach
                FRMDataBaseAddCoach.MdiParent = FRMParent
                Me.Hide()
                FRMDataBaseAddCoach.WindowState = FormWindowState.Maximized
                FRMDataBaseAddCoach.PreviousForm = Me
                FRMDataBaseAddCoach.Show()
            Case Is = Selected.Comp
                FRMDataBaseAddComp.MdiParent = FRMParent
                Me.Hide()
                FRMDataBaseAddComp.WindowState = FormWindowState.Maximized
                FRMDataBaseAddComp.Show()
            Case Is = Selected.Test
                FRMDataBaseAddTest.MdiParent = FRMParent
                Me.Hide()
                FRMDataBaseAddTest.WindowState = FormWindowState.Maximized
                FRMDataBaseAddTest.Show()
        End Select

    End Sub
End Class