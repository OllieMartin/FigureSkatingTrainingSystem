<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDiaryMenu
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
        Me.CMDCreate = New System.Windows.Forms.Button()
        Me.CMDView = New System.Windows.Forms.Button()
        Me.CMDBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = True
        Me.LBLTitle.Font = New System.Drawing.Font("Calibri Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle.Location = New System.Drawing.Point(12, 47)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(613, 78)
        Me.LBLTitle.TabIndex = 1
        Me.LBLTitle.Text = "Training Diary Creation"
        '
        'CMDCreate
        '
        Me.CMDCreate.Location = New System.Drawing.Point(53, 210)
        Me.CMDCreate.Name = "CMDCreate"
        Me.CMDCreate.Size = New System.Drawing.Size(161, 149)
        Me.CMDCreate.TabIndex = 2
        Me.CMDCreate.Text = "Create New Diary"
        Me.CMDCreate.UseVisualStyleBackColor = True
        '
        'CMDView
        '
        Me.CMDView.Location = New System.Drawing.Point(233, 210)
        Me.CMDView.Name = "CMDView"
        Me.CMDView.Size = New System.Drawing.Size(161, 149)
        Me.CMDView.TabIndex = 3
        Me.CMDView.Text = "View Previous Diary"
        Me.CMDView.UseVisualStyleBackColor = True
        '
        'CMDBack
        '
        Me.CMDBack.Location = New System.Drawing.Point(412, 210)
        Me.CMDBack.Name = "CMDBack"
        Me.CMDBack.Size = New System.Drawing.Size(161, 149)
        Me.CMDBack.TabIndex = 4
        Me.CMDBack.Text = "Return to Main Menu"
        Me.CMDBack.UseVisualStyleBackColor = True
        '
        'FRMDiaryMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 459)
        Me.Controls.Add(Me.CMDBack)
        Me.Controls.Add(Me.CMDView)
        Me.Controls.Add(Me.CMDCreate)
        Me.Controls.Add(Me.LBLTitle)
        Me.Name = "FRMDiaryMenu"
        Me.Text = "Training Diary Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLTitle As System.Windows.Forms.Label
    Friend WithEvents CMDCreate As System.Windows.Forms.Button
    Friend WithEvents CMDView As System.Windows.Forms.Button
    Friend WithEvents CMDBack As System.Windows.Forms.Button
End Class
