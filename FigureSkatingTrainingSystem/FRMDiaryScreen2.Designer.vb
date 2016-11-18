<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDiaryScreen2
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
        Me.CLBCompetitions = New System.Windows.Forms.CheckedListBox()
        Me.CLBElements = New System.Windows.Forms.CheckedListBox()
        Me.CLBTests = New System.Windows.Forms.CheckedListBox()
        Me.LBLCompetitions = New System.Windows.Forms.Label()
        Me.LBLTests = New System.Windows.Forms.Label()
        Me.LBLElements = New System.Windows.Forms.Label()
        Me.CMDCreate = New System.Windows.Forms.Button()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CLBCompetitions
        '
        Me.CLBCompetitions.CheckOnClick = True
        Me.CLBCompetitions.FormattingEnabled = True
        Me.CLBCompetitions.Location = New System.Drawing.Point(13, 32)
        Me.CLBCompetitions.Name = "CLBCompetitions"
        Me.CLBCompetitions.Size = New System.Drawing.Size(305, 154)
        Me.CLBCompetitions.TabIndex = 0
        '
        'CLBElements
        '
        Me.CLBElements.CheckOnClick = True
        Me.CLBElements.FormattingEnabled = True
        Me.CLBElements.Location = New System.Drawing.Point(328, 32)
        Me.CLBElements.Name = "CLBElements"
        Me.CLBElements.Size = New System.Drawing.Size(294, 154)
        Me.CLBElements.TabIndex = 1
        '
        'CLBTests
        '
        Me.CLBTests.CheckOnClick = True
        Me.CLBTests.FormattingEnabled = True
        Me.CLBTests.Location = New System.Drawing.Point(13, 214)
        Me.CLBTests.Name = "CLBTests"
        Me.CLBTests.Size = New System.Drawing.Size(305, 154)
        Me.CLBTests.TabIndex = 2
        '
        'LBLCompetitions
        '
        Me.LBLCompetitions.AutoSize = True
        Me.LBLCompetitions.Location = New System.Drawing.Point(12, 16)
        Me.LBLCompetitions.Name = "LBLCompetitions"
        Me.LBLCompetitions.Size = New System.Drawing.Size(89, 13)
        Me.LBLCompetitions.TabIndex = 4
        Me.LBLCompetitions.Text = "Add Competitions"
        '
        'LBLTests
        '
        Me.LBLTests.AutoSize = True
        Me.LBLTests.Location = New System.Drawing.Point(16, 195)
        Me.LBLTests.Name = "LBLTests"
        Me.LBLTests.Size = New System.Drawing.Size(55, 13)
        Me.LBLTests.TabIndex = 5
        Me.LBLTests.Text = "Add Tests"
        '
        'LBLElements
        '
        Me.LBLElements.AutoSize = True
        Me.LBLElements.Location = New System.Drawing.Point(325, 15)
        Me.LBLElements.Name = "LBLElements"
        Me.LBLElements.Size = New System.Drawing.Size(132, 13)
        Me.LBLElements.TabIndex = 6
        Me.LBLElements.Text = "Elements want to achieve:"
        '
        'CMDCreate
        '
        Me.CMDCreate.Location = New System.Drawing.Point(328, 214)
        Me.CMDCreate.Name = "CMDCreate"
        Me.CMDCreate.Size = New System.Drawing.Size(294, 71)
        Me.CMDCreate.TabIndex = 7
        Me.CMDCreate.Text = "Create Diary"
        Me.CMDCreate.UseVisualStyleBackColor = True
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(328, 300)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(294, 68)
        Me.CMDCancel.TabIndex = 8
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'FRMDiaryScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 461)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDCreate)
        Me.Controls.Add(Me.LBLElements)
        Me.Controls.Add(Me.LBLTests)
        Me.Controls.Add(Me.LBLCompetitions)
        Me.Controls.Add(Me.CLBTests)
        Me.Controls.Add(Me.CLBElements)
        Me.Controls.Add(Me.CLBCompetitions)
        Me.Name = "FRMDiaryScreen2"
        Me.Text = "Training Diary Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CLBCompetitions As System.Windows.Forms.CheckedListBox
    Friend WithEvents CLBElements As System.Windows.Forms.CheckedListBox
    Friend WithEvents CLBTests As System.Windows.Forms.CheckedListBox
    Friend WithEvents LBLCompetitions As System.Windows.Forms.Label
    Friend WithEvents LBLTests As System.Windows.Forms.Label
    Friend WithEvents LBLElements As System.Windows.Forms.Label
    Friend WithEvents CMDCreate As System.Windows.Forms.Button
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
End Class
