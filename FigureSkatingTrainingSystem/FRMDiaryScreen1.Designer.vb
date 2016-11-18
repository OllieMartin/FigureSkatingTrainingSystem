<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDiaryScreen1
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
        Me.LBLPupil = New System.Windows.Forms.Label()
        Me.CMBPupil = New System.Windows.Forms.ComboBox()
        Me.CMDAddPupil = New System.Windows.Forms.Button()
        Me.LBLStartMonth = New System.Windows.Forms.Label()
        Me.CMBMonth = New System.Windows.Forms.ComboBox()
        Me.CMDCreate = New System.Windows.Forms.Button()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.LBLStartYear = New System.Windows.Forms.Label()
        Me.CMBStartYear = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LBLPupil
        '
        Me.LBLPupil.AutoSize = True
        Me.LBLPupil.Location = New System.Drawing.Point(24, 65)
        Me.LBLPupil.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLPupil.Name = "LBLPupil"
        Me.LBLPupil.Size = New System.Drawing.Size(60, 25)
        Me.LBLPupil.TabIndex = 1
        Me.LBLPupil.Text = "Pupil"
        '
        'CMBPupil
        '
        Me.CMBPupil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBPupil.FormattingEnabled = True
        Me.CMBPupil.Location = New System.Drawing.Point(102, 60)
        Me.CMBPupil.Margin = New System.Windows.Forms.Padding(6)
        Me.CMBPupil.Name = "CMBPupil"
        Me.CMBPupil.Size = New System.Drawing.Size(238, 33)
        Me.CMBPupil.TabIndex = 2
        '
        'CMDAddPupil
        '
        Me.CMDAddPupil.Location = New System.Drawing.Point(30, 140)
        Me.CMDAddPupil.Margin = New System.Windows.Forms.Padding(6)
        Me.CMDAddPupil.Name = "CMDAddPupil"
        Me.CMDAddPupil.Size = New System.Drawing.Size(314, 44)
        Me.CMDAddPupil.TabIndex = 3
        Me.CMDAddPupil.Text = "(Add New)"
        Me.CMDAddPupil.UseVisualStyleBackColor = True
        '
        'LBLStartMonth
        '
        Me.LBLStartMonth.AutoSize = True
        Me.LBLStartMonth.Location = New System.Drawing.Point(24, 231)
        Me.LBLStartMonth.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLStartMonth.Name = "LBLStartMonth"
        Me.LBLStartMonth.Size = New System.Drawing.Size(123, 25)
        Me.LBLStartMonth.TabIndex = 4
        Me.LBLStartMonth.Text = "Start Month"
        '
        'CMBMonth
        '
        Me.CMBMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBMonth.FormattingEnabled = True
        Me.CMBMonth.Location = New System.Drawing.Point(160, 225)
        Me.CMBMonth.Margin = New System.Windows.Forms.Padding(6)
        Me.CMBMonth.Name = "CMBMonth"
        Me.CMBMonth.Size = New System.Drawing.Size(180, 33)
        Me.CMBMonth.TabIndex = 8
        '
        'CMDCreate
        '
        Me.CMDCreate.Location = New System.Drawing.Point(30, 341)
        Me.CMDCreate.Margin = New System.Windows.Forms.Padding(6)
        Me.CMDCreate.Name = "CMDCreate"
        Me.CMDCreate.Size = New System.Drawing.Size(342, 85)
        Me.CMDCreate.TabIndex = 12
        Me.CMDCreate.Text = "Create Diary"
        Me.CMDCreate.UseVisualStyleBackColor = True
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(30, 437)
        Me.CMDCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(342, 85)
        Me.CMDCancel.TabIndex = 13
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'LBLStartYear
        '
        Me.LBLStartYear.AutoSize = True
        Me.LBLStartYear.Location = New System.Drawing.Point(25, 283)
        Me.LBLStartYear.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLStartYear.Name = "LBLStartYear"
        Me.LBLStartYear.Size = New System.Drawing.Size(109, 25)
        Me.LBLStartYear.TabIndex = 14
        Me.LBLStartYear.Text = "Start Year"
        '
        'CMBStartYear
        '
        Me.CMBStartYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBStartYear.FormattingEnabled = True
        Me.CMBStartYear.Location = New System.Drawing.Point(160, 280)
        Me.CMBStartYear.Margin = New System.Windows.Forms.Padding(6)
        Me.CMBStartYear.Name = "CMBStartYear"
        Me.CMBStartYear.Size = New System.Drawing.Size(180, 33)
        Me.CMBStartYear.TabIndex = 15
        '
        'FRMDiaryScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 888)
        Me.Controls.Add(Me.CMBStartYear)
        Me.Controls.Add(Me.LBLStartYear)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDCreate)
        Me.Controls.Add(Me.CMBMonth)
        Me.Controls.Add(Me.LBLStartMonth)
        Me.Controls.Add(Me.CMDAddPupil)
        Me.Controls.Add(Me.CMBPupil)
        Me.Controls.Add(Me.LBLPupil)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FRMDiaryScreen1"
        Me.Text = "Training Diary Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLPupil As System.Windows.Forms.Label
    Friend WithEvents CMBPupil As System.Windows.Forms.ComboBox
    Friend WithEvents CMDAddPupil As System.Windows.Forms.Button
    Friend WithEvents LBLStartMonth As System.Windows.Forms.Label
    Friend WithEvents CMBMonth As System.Windows.Forms.ComboBox
    Friend WithEvents CMDCreate As System.Windows.Forms.Button
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
    Friend WithEvents LBLStartYear As System.Windows.Forms.Label
    Friend WithEvents CMBStartYear As System.Windows.Forms.ComboBox
End Class
