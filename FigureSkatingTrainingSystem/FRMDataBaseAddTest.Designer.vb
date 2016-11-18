<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDataBaseAddTest
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
        Me.DTPStart = New System.Windows.Forms.DateTimePicker()
        Me.LBLDate = New System.Windows.Forms.Label()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.CMDAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DTPStart
        '
        Me.DTPStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPStart.Location = New System.Drawing.Point(112, 10)
        Me.DTPStart.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPStart.Name = "DTPStart"
        Me.DTPStart.Size = New System.Drawing.Size(183, 20)
        Me.DTPStart.TabIndex = 29
        Me.DTPStart.Value = New Date(2016, 3, 11, 0, 0, 0, 0)
        '
        'LBLDate
        '
        Me.LBLDate.AutoSize = True
        Me.LBLDate.Location = New System.Drawing.Point(12, 12)
        Me.LBLDate.Name = "LBLDate"
        Me.LBLDate.Size = New System.Drawing.Size(66, 13)
        Me.LBLDate.TabIndex = 28
        Me.LBLDate.Text = "Date of Test"
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(160, 41)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(132, 34)
        Me.CMDCancel.TabIndex = 34
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'CMDAdd
        '
        Me.CMDAdd.Location = New System.Drawing.Point(14, 41)
        Me.CMDAdd.Name = "CMDAdd"
        Me.CMDAdd.Size = New System.Drawing.Size(134, 34)
        Me.CMDAdd.TabIndex = 33
        Me.CMDAdd.Text = "Add"
        Me.CMDAdd.UseVisualStyleBackColor = True
        '
        'FRMDataBaseAddTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 459)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDAdd)
        Me.Controls.Add(Me.DTPStart)
        Me.Controls.Add(Me.LBLDate)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FRMDataBaseAddTest"
        Me.Text = "FRMDataBaseAddTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTPStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLDate As System.Windows.Forms.Label
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
    Friend WithEvents CMDAdd As System.Windows.Forms.Button
End Class
