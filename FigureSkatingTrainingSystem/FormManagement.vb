Module FormManagement

    Enum EMethod

        Hide = 1
        Close = 2
        OpenOnly = 3
        CloseAll = 4

    End Enum

    Public Sub SwitchForm(ByVal StartForm As Windows.Forms.Form, ByVal EndForm As Windows.Forms.Form, ByVal Method As EMethod)

        EndForm.MdiParent = FRMParent
        Select Case Method
            Case Is = EMethod.Close : StartForm.Close()
            Case Is = EMethod.Hide : StartForm.Hide()
            Case Is = EMethod.CloseAll
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
        End Select
        EndForm.WindowState = FormWindowState.Maximized
        EndForm.Show()

    End Sub

End Module
