<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDataBaseMenu
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
        Me.CMDBack = New System.Windows.Forms.Button()
        Me.CMDView = New System.Windows.Forms.Button()
        Me.CMDCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = True
        Me.LBLTitle.Font = New System.Drawing.Font("Calibri Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle.Location = New System.Drawing.Point(3, 48)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(630, 78)
        Me.LBLTitle.TabIndex = 2
        Me.LBLTitle.Text = "Database Management"
        '
        'CMDBack
        '
        Me.CMDBack.Location = New System.Drawing.Point(414, 213)
        Me.CMDBack.Name = "CMDBack"
        Me.CMDBack.Size = New System.Drawing.Size(161, 149)
        Me.CMDBack.TabIndex = 7
        Me.CMDBack.Text = "Return to Main Menu"
        Me.CMDBack.UseVisualStyleBackColor = True
        '
        'CMDView
        '
        Me.CMDView.Location = New System.Drawing.Point(235, 213)
        Me.CMDView.Name = "CMDView"
        Me.CMDView.Size = New System.Drawing.Size(161, 149)
        Me.CMDView.TabIndex = 6
        Me.CMDView.Text = "Search Database to View, Edit or Delete records"
        Me.CMDView.UseVisualStyleBackColor = True
        '
        'CMDCreate
        '
        Me.CMDCreate.Location = New System.Drawing.Point(55, 213)
        Me.CMDCreate.Name = "CMDCreate"
        Me.CMDCreate.Size = New System.Drawing.Size(161, 149)
        Me.CMDCreate.TabIndex = 5
        Me.CMDCreate.Text = "Add New Records To Database"
        Me.CMDCreate.UseVisualStyleBackColor = True
        '
        'FRMDataBaseMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 385)
        Me.Controls.Add(Me.CMDBack)
        Me.Controls.Add(Me.CMDView)
        Me.Controls.Add(Me.CMDCreate)
        Me.Controls.Add(Me.LBLTitle)
        Me.Name = "FRMDataBaseMenu"
        Me.Text = "Database Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLTitle As System.Windows.Forms.Label
    Friend WithEvents CMDBack As System.Windows.Forms.Button
    Friend WithEvents CMDView As System.Windows.Forms.Button
    Friend WithEvents CMDCreate As System.Windows.Forms.Button
End Class
