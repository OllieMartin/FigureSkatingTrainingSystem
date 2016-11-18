<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDataBaseAddCoach
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
        Me.TXTFirstName = New System.Windows.Forms.TextBox()
        Me.LBLFirstName = New System.Windows.Forms.Label()
        Me.LBLSurname = New System.Windows.Forms.Label()
        Me.TXTSurname = New System.Windows.Forms.TextBox()
        Me.CMDAdd = New System.Windows.Forms.Button()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTFirstName
        '
        Me.TXTFirstName.Location = New System.Drawing.Point(225, 20)
        Me.TXTFirstName.Margin = New System.Windows.Forms.Padding(6)
        Me.TXTFirstName.MaxLength = 20
        Me.TXTFirstName.Name = "TXTFirstName"
        Me.TXTFirstName.Size = New System.Drawing.Size(362, 31)
        Me.TXTFirstName.TabIndex = 1
        '
        'LBLFirstName
        '
        Me.LBLFirstName.AutoSize = True
        Me.LBLFirstName.Location = New System.Drawing.Point(25, 23)
        Me.LBLFirstName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLFirstName.Name = "LBLFirstName"
        Me.LBLFirstName.Size = New System.Drawing.Size(116, 25)
        Me.LBLFirstName.TabIndex = 19
        Me.LBLFirstName.Text = "First Name"
        '
        'LBLSurname
        '
        Me.LBLSurname.AutoSize = True
        Me.LBLSurname.Location = New System.Drawing.Point(25, 80)
        Me.LBLSurname.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLSurname.Name = "LBLSurname"
        Me.LBLSurname.Size = New System.Drawing.Size(98, 25)
        Me.LBLSurname.TabIndex = 20
        Me.LBLSurname.Text = "Surname"
        '
        'TXTSurname
        '
        Me.TXTSurname.Location = New System.Drawing.Point(225, 77)
        Me.TXTSurname.Margin = New System.Windows.Forms.Padding(6)
        Me.TXTSurname.MaxLength = 20
        Me.TXTSurname.Name = "TXTSurname"
        Me.TXTSurname.Size = New System.Drawing.Size(362, 31)
        Me.TXTSurname.TabIndex = 21
        '
        'CMDAdd
        '
        Me.CMDAdd.Location = New System.Drawing.Point(30, 142)
        Me.CMDAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.CMDAdd.Name = "CMDAdd"
        Me.CMDAdd.Size = New System.Drawing.Size(269, 66)
        Me.CMDAdd.TabIndex = 22
        Me.CMDAdd.Text = "Add"
        Me.CMDAdd.UseVisualStyleBackColor = True
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(322, 142)
        Me.CMDCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(265, 66)
        Me.CMDCancel.TabIndex = 23
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'FRMDataBaseAddCoach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 888)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDAdd)
        Me.Controls.Add(Me.TXTSurname)
        Me.Controls.Add(Me.LBLSurname)
        Me.Controls.Add(Me.LBLFirstName)
        Me.Controls.Add(Me.TXTFirstName)
        Me.Name = "FRMDataBaseAddCoach"
        Me.Text = "FRMDataBaseAddCoach"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTFirstName As System.Windows.Forms.TextBox
    Friend WithEvents LBLFirstName As System.Windows.Forms.Label
    Friend WithEvents LBLSurname As System.Windows.Forms.Label
    Friend WithEvents TXTSurname As System.Windows.Forms.TextBox
    Friend WithEvents CMDAdd As System.Windows.Forms.Button
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
End Class
