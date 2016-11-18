<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDataBaseSearch2
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
        Me.CMDUpdate = New System.Windows.Forms.Button()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.LBLTitle = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CMDUpdate
        '
        Me.CMDUpdate.Location = New System.Drawing.Point(16, 84)
        Me.CMDUpdate.Name = "CMDUpdate"
        Me.CMDUpdate.Size = New System.Drawing.Size(114, 23)
        Me.CMDUpdate.TabIndex = 0
        Me.CMDUpdate.Text = "Update"
        Me.CMDUpdate.UseVisualStyleBackColor = True
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(133, 84)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(118, 23)
        Me.CMDCancel.TabIndex = 1
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = True
        Me.LBLTitle.Location = New System.Drawing.Point(13, 13)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(55, 13)
        Me.LBLTitle.TabIndex = 2
        Me.LBLTitle.Text = "Edit Value"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 20)
        Me.TextBox1.TabIndex = 3
        '
        'FRMDataBaseSearch2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 122)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LBLTitle)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDUpdate)
        Me.Name = "FRMDataBaseSearch2"
        Me.Text = "FRMDataBaseSearch2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDUpdate As System.Windows.Forms.Button
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
    Friend WithEvents LBLTitle As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
