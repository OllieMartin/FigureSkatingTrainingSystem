<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMainMenu
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
        Me.LBLTitle = New System.Windows.Forms.Label()
        Me.CMDRoutine = New System.Windows.Forms.Button()
        Me.CMDDiary = New System.Windows.Forms.Button()
        Me.CMDDBMS = New System.Windows.Forms.Button()
        Me.CMDClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = True
        Me.LBLTitle.Font = New System.Drawing.Font("Calibri Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle.Location = New System.Drawing.Point(157, 28)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(330, 78)
        Me.LBLTitle.TabIndex = 0
        Me.LBLTitle.Text = "Main Menu"
        '
        'CMDRoutine
        '
        Me.CMDRoutine.Location = New System.Drawing.Point(130, 122)
        Me.CMDRoutine.Name = "CMDRoutine"
        Me.CMDRoutine.Size = New System.Drawing.Size(186, 113)
        Me.CMDRoutine.TabIndex = 1
        Me.CMDRoutine.Text = "Routine Planning"
        Me.CMDRoutine.UseVisualStyleBackColor = True
        '
        'CMDDiary
        '
        Me.CMDDiary.Location = New System.Drawing.Point(322, 122)
        Me.CMDDiary.Name = "CMDDiary"
        Me.CMDDiary.Size = New System.Drawing.Size(186, 113)
        Me.CMDDiary.TabIndex = 2
        Me.CMDDiary.Text = "Training Diaries"
        Me.CMDDiary.UseVisualStyleBackColor = True
        '
        'CMDDBMS
        '
        Me.CMDDBMS.Location = New System.Drawing.Point(130, 241)
        Me.CMDDBMS.Name = "CMDDBMS"
        Me.CMDDBMS.Size = New System.Drawing.Size(186, 113)
        Me.CMDDBMS.TabIndex = 3
        Me.CMDDBMS.Text = "Database Management"
        Me.CMDDBMS.UseVisualStyleBackColor = True
        '
        'CMDClose
        '
        Me.CMDClose.Location = New System.Drawing.Point(322, 241)
        Me.CMDClose.Name = "CMDClose"
        Me.CMDClose.Size = New System.Drawing.Size(186, 113)
        Me.CMDClose.TabIndex = 4
        Me.CMDClose.Text = "Close"
        Me.CMDClose.UseVisualStyleBackColor = True
        '
        'FRMMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMDClose)
        Me.Controls.Add(Me.CMDDBMS)
        Me.Controls.Add(Me.CMDDiary)
        Me.Controls.Add(Me.CMDRoutine)
        Me.Controls.Add(Me.LBLTitle)
        Me.Name = "FRMMainMenu"
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLTitle As System.Windows.Forms.Label
    Friend WithEvents CMDRoutine As System.Windows.Forms.Button
    Friend WithEvents CMDDiary As System.Windows.Forms.Button
    Friend WithEvents CMDDBMS As System.Windows.Forms.Button
    Friend WithEvents CMDClose As System.Windows.Forms.Button
End Class
