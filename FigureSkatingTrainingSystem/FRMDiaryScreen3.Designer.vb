<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDiaryScreen3
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
        Me.LBLDiaryCreated = New System.Windows.Forms.Label()
        Me.LBLOffSeason = New System.Windows.Forms.Label()
        Me.LBLPreSeason = New System.Windows.Forms.Label()
        Me.LBLInSeason = New System.Windows.Forms.Label()
        Me.LBLTransition = New System.Windows.Forms.Label()
        Me.CMDViewDiary = New System.Windows.Forms.Button()
        Me.CMDPrint = New System.Windows.Forms.Button()
        Me.CMDSave = New System.Windows.Forms.Button()
        Me.CMDBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLDiaryCreated
        '
        Me.LBLDiaryCreated.AutoSize = True
        Me.LBLDiaryCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDiaryCreated.Location = New System.Drawing.Point(13, 13)
        Me.LBLDiaryCreated.Name = "LBLDiaryCreated"
        Me.LBLDiaryCreated.Size = New System.Drawing.Size(234, 25)
        Me.LBLDiaryCreated.TabIndex = 0
        Me.LBLDiaryCreated.Text = "Training Diary Created!"
        '
        'LBLOffSeason
        '
        Me.LBLOffSeason.AutoSize = True
        Me.LBLOffSeason.Location = New System.Drawing.Point(15, 61)
        Me.LBLOffSeason.Name = "LBLOffSeason"
        Me.LBLOffSeason.Size = New System.Drawing.Size(63, 13)
        Me.LBLOffSeason.TabIndex = 1
        Me.LBLOffSeason.Text = "Off Season:"
        '
        'LBLPreSeason
        '
        Me.LBLPreSeason.AutoSize = True
        Me.LBLPreSeason.Location = New System.Drawing.Point(15, 83)
        Me.LBLPreSeason.Name = "LBLPreSeason"
        Me.LBLPreSeason.Size = New System.Drawing.Size(60, 13)
        Me.LBLPreSeason.TabIndex = 2
        Me.LBLPreSeason.Text = "Preseason:"
        '
        'LBLInSeason
        '
        Me.LBLInSeason.AutoSize = True
        Me.LBLInSeason.Location = New System.Drawing.Point(15, 105)
        Me.LBLInSeason.Name = "LBLInSeason"
        Me.LBLInSeason.Size = New System.Drawing.Size(58, 13)
        Me.LBLInSeason.TabIndex = 3
        Me.LBLInSeason.Text = "In-Season:"
        '
        'LBLTransition
        '
        Me.LBLTransition.AutoSize = True
        Me.LBLTransition.Location = New System.Drawing.Point(15, 127)
        Me.LBLTransition.Name = "LBLTransition"
        Me.LBLTransition.Size = New System.Drawing.Size(56, 13)
        Me.LBLTransition.TabIndex = 4
        Me.LBLTransition.Text = "Transition:"
        '
        'CMDViewDiary
        '
        Me.CMDViewDiary.Location = New System.Drawing.Point(18, 162)
        Me.CMDViewDiary.Name = "CMDViewDiary"
        Me.CMDViewDiary.Size = New System.Drawing.Size(202, 45)
        Me.CMDViewDiary.TabIndex = 5
        Me.CMDViewDiary.Text = "Save and View Diary"
        Me.CMDViewDiary.UseVisualStyleBackColor = True
        '
        'CMDPrint
        '
        Me.CMDPrint.Location = New System.Drawing.Point(18, 222)
        Me.CMDPrint.Name = "CMDPrint"
        Me.CMDPrint.Size = New System.Drawing.Size(202, 45)
        Me.CMDPrint.TabIndex = 6
        Me.CMDPrint.Text = "Save and Print Diary"
        Me.CMDPrint.UseVisualStyleBackColor = True
        '
        'CMDSave
        '
        Me.CMDSave.Location = New System.Drawing.Point(18, 282)
        Me.CMDSave.Name = "CMDSave"
        Me.CMDSave.Size = New System.Drawing.Size(202, 45)
        Me.CMDSave.TabIndex = 7
        Me.CMDSave.Text = "Save Diary"
        Me.CMDSave.UseVisualStyleBackColor = True
        '
        'CMDBack
        '
        Me.CMDBack.Location = New System.Drawing.Point(18, 342)
        Me.CMDBack.Name = "CMDBack"
        Me.CMDBack.Size = New System.Drawing.Size(202, 45)
        Me.CMDBack.TabIndex = 8
        Me.CMDBack.Text = "Return To Menu"
        Me.CMDBack.UseVisualStyleBackColor = True
        '
        'FRMDiaryScreen3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 381)
        Me.Controls.Add(Me.CMDBack)
        Me.Controls.Add(Me.CMDSave)
        Me.Controls.Add(Me.CMDPrint)
        Me.Controls.Add(Me.CMDViewDiary)
        Me.Controls.Add(Me.LBLTransition)
        Me.Controls.Add(Me.LBLInSeason)
        Me.Controls.Add(Me.LBLPreSeason)
        Me.Controls.Add(Me.LBLOffSeason)
        Me.Controls.Add(Me.LBLDiaryCreated)
        Me.Name = "FRMDiaryScreen3"
        Me.Text = "Training Diary Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLDiaryCreated As System.Windows.Forms.Label
    Friend WithEvents LBLOffSeason As System.Windows.Forms.Label
    Friend WithEvents LBLPreSeason As System.Windows.Forms.Label
    Friend WithEvents LBLInSeason As System.Windows.Forms.Label
    Friend WithEvents LBLTransition As System.Windows.Forms.Label
    Friend WithEvents CMDViewDiary As System.Windows.Forms.Button
    Friend WithEvents CMDPrint As System.Windows.Forms.Button
    Friend WithEvents CMDSave As System.Windows.Forms.Button
    Friend WithEvents CMDBack As System.Windows.Forms.Button
End Class
