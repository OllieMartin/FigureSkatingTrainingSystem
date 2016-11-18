Imports System.Windows.Forms
Public Class FRMParent

    Private Answer As Integer 'Stores message box enumerated result

    Private Sub FRMParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This procedure manages the startup of the system.
        'The file management start up routine is called and FRMMainMenu is loaded as a child form.

        FileManagement.StartUp()
        FormManagement.SwitchForm(Me, FRMMainMenu, EMethod.OpenOnly)

    End Sub

    Private Sub RoutinePlanningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoutinePlanningToolStripMenuItem.Click

        'This procedure executes when the Routine Planning tab is clicked on in the navigation bar.
        'It asks the user if they wish to abandon their current task and switches to the Routine Planning Menu.

        Answer = MsgBox("Are you sure you want abandon your current task?", MsgBoxStyle.YesNo)
        If Answer = vbYes Then
            CloseAll()
            FRMRoutineMenu.MdiParent = Me
            FRMRoutineMenu.WindowState = FormWindowState.Maximized
            FRMRoutineMenu.Show()
        End If
    End Sub

    Private Sub CloseAll()

        'Closes all forms in the system

        FRMDataBaseAddCoach.Close()
        FRMDataBaseAddComp.Close()
        FRMDataBaseAddMenu.Close()
        FRMDataBaseAddPupil.Close()
        FRMDataBaseAddPupil2.Close()
        FRMDataBaseAddTest.Close()
        FRMDataBaseAddMenu.Close()
        FRMDataBaseSearch.Close()
        FRMDataBaseSearch2.Close()
        FRMDiaryMenu.Close()
        FRMDiaryScreen1.Close()
        FRMDiaryScreen2.Close()
        FRMDiaryScreen3.Close()
        FRMMainMenu.Close()
        FRMRoutineMenu.Close()
        FRMRoutineScreen1.Close()
        FRMRoutineScreen2.Close()
        FRMRoutineScreen3.Close()
    End Sub

    Private Sub TrainingDiariesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrainingDiariesToolStripMenuItem.Click

        'This procedure executes when the Training Diary tab is clicked on in the navigation bar.
        'It asks the user if they wish to abandon their current task and switches to the Training Diary Menu.

        Answer = MsgBox("Are you sure you want abandon your current task?", MsgBoxStyle.YesNo)
        If Answer = vbYes Then
            CloseAll()
            FRMDiaryMenu.MdiParent = Me
            FRMDiaryMenu.WindowState = FormWindowState.Maximized
            FRMDiaryMenu.Show()
        End If
    End Sub

    Private Sub DatabaseManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseManagementToolStripMenuItem.Click

        'This procedure executes when the Database Management tab is clicked on in the navigation bar.
        'It asks the user if they wish to abandon their current task and switches to the Database Management Menu.

        Answer = MsgBox("Are you sure you want abandon your current task?", MsgBoxStyle.YesNo)
        If Answer = vbYes Then
            CloseAll()
            FRMDataBaseMenu.MdiParent = Me
            FRMDataBaseMenu.WindowState = FormWindowState.Maximized
            FRMDataBaseMenu.Show()
        End If
    End Sub

    Private Sub CloseSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseSystemToolStripMenuItem.Click

        'This procedure executes when the General > Close System tab is clicked on in the navigation bar.
        'It asks the user if they wish to abandon their current task and closes the entire system.

        Answer = MsgBox("Are you sure you want abandon your current task?", MsgBoxStyle.YesNo)
        If Answer = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
