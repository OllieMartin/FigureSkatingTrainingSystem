<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMRoutineScreen2
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
        Me.CLBNeeded = New System.Windows.Forms.CheckedListBox()
        Me.CLBOther = New System.Windows.Forms.CheckedListBox()
        Me.CMDAuto = New System.Windows.Forms.Button()
        Me.CMDStart = New System.Windows.Forms.Button()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.LBLNeeded = New System.Windows.Forms.Label()
        Me.LBLOther = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CLBNeeded
        '
        Me.CLBNeeded.CheckOnClick = True
        Me.CLBNeeded.FormattingEnabled = True
        Me.CLBNeeded.Location = New System.Drawing.Point(13, 13)
        Me.CLBNeeded.Name = "CLBNeeded"
        Me.CLBNeeded.Size = New System.Drawing.Size(263, 274)
        Me.CLBNeeded.TabIndex = 0
        '
        'CLBOther
        '
        Me.CLBOther.CheckOnClick = True
        Me.CLBOther.FormattingEnabled = True
        Me.CLBOther.Location = New System.Drawing.Point(364, 13)
        Me.CLBOther.Name = "CLBOther"
        Me.CLBOther.Size = New System.Drawing.Size(258, 274)
        Me.CLBOther.TabIndex = 1
        '
        'CMDAuto
        '
        Me.CMDAuto.Location = New System.Drawing.Point(13, 305)
        Me.CMDAuto.Name = "CMDAuto"
        Me.CMDAuto.Size = New System.Drawing.Size(263, 40)
        Me.CMDAuto.TabIndex = 2
        Me.CMDAuto.Text = "Choose Automatically"
        Me.CMDAuto.UseVisualStyleBackColor = True
        '
        'CMDStart
        '
        Me.CMDStart.Location = New System.Drawing.Point(13, 361)
        Me.CMDStart.Name = "CMDStart"
        Me.CMDStart.Size = New System.Drawing.Size(127, 50)
        Me.CMDStart.TabIndex = 3
        Me.CMDStart.Text = "Start Planning"
        Me.CMDStart.UseVisualStyleBackColor = True
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(146, 361)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(130, 50)
        Me.CMDCancel.TabIndex = 5
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'LBLNeeded
        '
        Me.LBLNeeded.Location = New System.Drawing.Point(282, 80)
        Me.LBLNeeded.Name = "LBLNeeded"
        Me.LBLNeeded.Size = New System.Drawing.Size(75, 68)
        Me.LBLNeeded.TabIndex = 6
        Me.LBLNeeded.Text = "Elements Needed in Routine <----------"
        Me.LBLNeeded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLOther
        '
        Me.LBLOther.Location = New System.Drawing.Point(282, 148)
        Me.LBLOther.Name = "LBLOther"
        Me.LBLOther.Size = New System.Drawing.Size(75, 68)
        Me.LBLOther.TabIndex = 7
        Me.LBLOther.Text = "Other Elements ---------->"
        Me.LBLOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRMRoutineScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 462)
        Me.Controls.Add(Me.LBLOther)
        Me.Controls.Add(Me.LBLNeeded)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDStart)
        Me.Controls.Add(Me.CMDAuto)
        Me.Controls.Add(Me.CLBOther)
        Me.Controls.Add(Me.CLBNeeded)
        Me.Name = "FRMRoutineScreen2"
        Me.Text = "Routine Planning"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CLBNeeded As System.Windows.Forms.CheckedListBox
    Friend WithEvents CLBOther As System.Windows.Forms.CheckedListBox
    Friend WithEvents CMDAuto As System.Windows.Forms.Button
    Friend WithEvents CMDStart As System.Windows.Forms.Button
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
    Friend WithEvents LBLNeeded As System.Windows.Forms.Label
    Friend WithEvents LBLOther As System.Windows.Forms.Label
End Class
