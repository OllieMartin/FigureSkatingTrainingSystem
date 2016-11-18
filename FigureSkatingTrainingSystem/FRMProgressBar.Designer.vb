<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMProgressBar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LBLText = New System.Windows.Forms.Label()
        Me.PRGBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'LBLText
        '
        Me.LBLText.AutoSize = True
        Me.LBLText.Location = New System.Drawing.Point(6, 7)
        Me.LBLText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLText.Name = "LBLText"
        Me.LBLText.Size = New System.Drawing.Size(39, 13)
        Me.LBLText.TabIndex = 0
        Me.LBLText.Text = "Label1"
        '
        'PRGBar
        '
        Me.PRGBar.Location = New System.Drawing.Point(22, 37)
        Me.PRGBar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PRGBar.Name = "PRGBar"
        Me.PRGBar.Size = New System.Drawing.Size(298, 41)
        Me.PRGBar.TabIndex = 1
        '
        'FRMProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 106)
        Me.Controls.Add(Me.PRGBar)
        Me.Controls.Add(Me.LBLText)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FRMProgressBar"
        Me.Text = "FRMProgressBar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLText As System.Windows.Forms.Label
    Friend WithEvents PRGBar As System.Windows.Forms.ProgressBar
End Class
