<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDataBaseAddMenu
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
        Me.CMBTypes = New System.Windows.Forms.ComboBox()
        Me.CMDNext = New System.Windows.Forms.Button()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = True
        Me.LBLTitle.Location = New System.Drawing.Point(12, 26)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(142, 13)
        Me.LBLTitle.TabIndex = 0
        Me.LBLTitle.Text = "What would you like to add?"
        '
        'CMBTypes
        '
        Me.CMBTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBTypes.FormattingEnabled = True
        Me.CMBTypes.Location = New System.Drawing.Point(12, 65)
        Me.CMBTypes.Name = "CMBTypes"
        Me.CMBTypes.Size = New System.Drawing.Size(247, 21)
        Me.CMBTypes.TabIndex = 1
        '
        'CMDNext
        '
        Me.CMDNext.Location = New System.Drawing.Point(15, 113)
        Me.CMDNext.Name = "CMDNext"
        Me.CMDNext.Size = New System.Drawing.Size(244, 36)
        Me.CMDNext.TabIndex = 2
        Me.CMDNext.Text = "Next"
        Me.CMDNext.UseVisualStyleBackColor = True
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(15, 155)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(244, 36)
        Me.CMDCancel.TabIndex = 3
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'FRMDataBaseAddMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 462)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDNext)
        Me.Controls.Add(Me.CMBTypes)
        Me.Controls.Add(Me.LBLTitle)
        Me.Name = "FRMDataBaseAddMenu"
        Me.Text = "FRMDataBaseAddMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLTitle As System.Windows.Forms.Label
    Friend WithEvents CMBTypes As System.Windows.Forms.ComboBox
    Friend WithEvents CMDNext As System.Windows.Forms.Button
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
End Class
