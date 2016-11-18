<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDataBaseAddComp
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
        Me.LBLStartDate = New System.Windows.Forms.Label()
        Me.LBLCompName = New System.Windows.Forms.Label()
        Me.TXTCompName = New System.Windows.Forms.TextBox()
        Me.LBLFinishDate = New System.Windows.Forms.Label()
        Me.DTPStart = New System.Windows.Forms.DateTimePicker()
        Me.DTPFinish = New System.Windows.Forms.DateTimePicker()
        Me.LBLMinLevel = New System.Windows.Forms.Label()
        Me.CMBLevel = New System.Windows.Forms.ComboBox()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.CMDAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLStartDate
        '
        Me.LBLStartDate.AutoSize = True
        Me.LBLStartDate.Location = New System.Drawing.Point(8, 41)
        Me.LBLStartDate.Name = "LBLStartDate"
        Me.LBLStartDate.Size = New System.Drawing.Size(55, 13)
        Me.LBLStartDate.TabIndex = 24
        Me.LBLStartDate.Text = "Start Date"
        '
        'LBLCompName
        '
        Me.LBLCompName.AutoSize = True
        Me.LBLCompName.Location = New System.Drawing.Point(8, 11)
        Me.LBLCompName.Name = "LBLCompName"
        Me.LBLCompName.Size = New System.Drawing.Size(93, 13)
        Me.LBLCompName.TabIndex = 23
        Me.LBLCompName.Text = "Competition Name"
        '
        'TXTCompName
        '
        Me.TXTCompName.Location = New System.Drawing.Point(108, 9)
        Me.TXTCompName.MaxLength = 40
        Me.TXTCompName.Name = "TXTCompName"
        Me.TXTCompName.Size = New System.Drawing.Size(183, 20)
        Me.TXTCompName.TabIndex = 22
        '
        'LBLFinishDate
        '
        Me.LBLFinishDate.AutoSize = True
        Me.LBLFinishDate.Location = New System.Drawing.Point(8, 70)
        Me.LBLFinishDate.Name = "LBLFinishDate"
        Me.LBLFinishDate.Size = New System.Drawing.Size(60, 13)
        Me.LBLFinishDate.TabIndex = 26
        Me.LBLFinishDate.Text = "Finish Date"
        '
        'DTPStart
        '
        Me.DTPStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPStart.Location = New System.Drawing.Point(108, 38)
        Me.DTPStart.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPStart.Name = "DTPStart"
        Me.DTPStart.Size = New System.Drawing.Size(183, 20)
        Me.DTPStart.TabIndex = 27
        Me.DTPStart.Value = New Date(2016, 3, 11, 0, 0, 0, 0)
        '
        'DTPFinish
        '
        Me.DTPFinish.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFinish.Location = New System.Drawing.Point(108, 68)
        Me.DTPFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFinish.Name = "DTPFinish"
        Me.DTPFinish.Size = New System.Drawing.Size(183, 20)
        Me.DTPFinish.TabIndex = 28
        Me.DTPFinish.Value = New Date(2016, 3, 12, 0, 0, 0, 0)
        '
        'LBLMinLevel
        '
        Me.LBLMinLevel.AutoSize = True
        Me.LBLMinLevel.Location = New System.Drawing.Point(8, 98)
        Me.LBLMinLevel.Name = "LBLMinLevel"
        Me.LBLMinLevel.Size = New System.Drawing.Size(77, 13)
        Me.LBLMinLevel.TabIndex = 29
        Me.LBLMinLevel.Text = "Minimum Level"
        '
        'CMBLevel
        '
        Me.CMBLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBLevel.FormattingEnabled = True
        Me.CMBLevel.Location = New System.Drawing.Point(108, 98)
        Me.CMBLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.CMBLevel.Name = "CMBLevel"
        Me.CMBLevel.Size = New System.Drawing.Size(183, 21)
        Me.CMBLevel.TabIndex = 30
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(156, 129)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(132, 34)
        Me.CMDCancel.TabIndex = 32
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'CMDAdd
        '
        Me.CMDAdd.Location = New System.Drawing.Point(10, 129)
        Me.CMDAdd.Name = "CMDAdd"
        Me.CMDAdd.Size = New System.Drawing.Size(134, 34)
        Me.CMDAdd.TabIndex = 31
        Me.CMDAdd.Text = "Add"
        Me.CMDAdd.UseVisualStyleBackColor = True
        '
        'FRMDataBaseAddComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 459)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDAdd)
        Me.Controls.Add(Me.CMBLevel)
        Me.Controls.Add(Me.LBLMinLevel)
        Me.Controls.Add(Me.DTPFinish)
        Me.Controls.Add(Me.DTPStart)
        Me.Controls.Add(Me.LBLFinishDate)
        Me.Controls.Add(Me.LBLStartDate)
        Me.Controls.Add(Me.LBLCompName)
        Me.Controls.Add(Me.TXTCompName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FRMDataBaseAddComp"
        Me.Text = "FRMDataBaseAddComp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLStartDate As System.Windows.Forms.Label
    Friend WithEvents LBLCompName As System.Windows.Forms.Label
    Friend WithEvents TXTCompName As System.Windows.Forms.TextBox
    Friend WithEvents LBLFinishDate As System.Windows.Forms.Label
    Friend WithEvents DTPStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFinish As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLMinLevel As System.Windows.Forms.Label
    Friend WithEvents CMBLevel As System.Windows.Forms.ComboBox
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
    Friend WithEvents CMDAdd As System.Windows.Forms.Button
End Class
