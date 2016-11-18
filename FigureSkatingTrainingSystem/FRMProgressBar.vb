Public Class FRMProgressBar

    Public Sub Main(ByVal Text As String)

        Me.Text = Text
        LBLText.Text = Text
        PRGBar.Value = 0
        PRGBar.Minimum = 0
        PRGBar.Maximum = 100

    End Sub

End Class