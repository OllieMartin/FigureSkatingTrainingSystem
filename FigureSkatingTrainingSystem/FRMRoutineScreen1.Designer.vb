<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMRoutineScreen1
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
        Me.LBLRoutineFor = New System.Windows.Forms.Label()
        Me.RDBTest = New System.Windows.Forms.RadioButton()
        Me.RDBCompetition = New System.Windows.Forms.RadioButton()
        Me.RDBOther = New System.Windows.Forms.RadioButton()
        Me.CMBLevel = New System.Windows.Forms.ComboBox()
        Me.LBLLevel = New System.Windows.Forms.Label()
        Me.LBLLength = New System.Windows.Forms.Label()
        Me.CMBLength = New System.Windows.Forms.ComboBox()
        Me.CMDPlan = New System.Windows.Forms.Button()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBLPupil
        '
        Me.LBLPupil.AutoSize = True
        Me.LBLPupil.Location = New System.Drawing.Point(28, 77)
        Me.LBLPupil.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLPupil.Name = "LBLPupil"
        Me.LBLPupil.Size = New System.Drawing.Size(60, 25)
        Me.LBLPupil.TabIndex = 0
        Me.LBLPupil.Text = "Pupil"
        '
        'CMBPupil
        '
        Me.CMBPupil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBPupil.FormattingEnabled = True
        Me.CMBPupil.Location = New System.Drawing.Point(102, 71)
        Me.CMBPupil.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CMBPupil.Name = "CMBPupil"
        Me.CMBPupil.Size = New System.Drawing.Size(238, 33)
        Me.CMBPupil.TabIndex = 1
        '
        'CMDAddPupil
        '
        Me.CMDAddPupil.Location = New System.Drawing.Point(30, 123)
        Me.CMDAddPupil.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CMDAddPupil.Name = "CMDAddPupil"
        Me.CMDAddPupil.Size = New System.Drawing.Size(314, 44)
        Me.CMDAddPupil.TabIndex = 2
        Me.CMDAddPupil.Text = "(Add New)"
        Me.CMDAddPupil.UseVisualStyleBackColor = True
        '
        'LBLRoutineFor
        '
        Me.LBLRoutineFor.AutoSize = True
        Me.LBLRoutineFor.Location = New System.Drawing.Point(28, 190)
        Me.LBLRoutineFor.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLRoutineFor.Name = "LBLRoutineFor"
        Me.LBLRoutineFor.Size = New System.Drawing.Size(235, 25)
        Me.LBLRoutineFor.TabIndex = 3
        Me.LBLRoutineFor.Text = "What is the routine for?"
        '
        'RDBTest
        '
        Me.RDBTest.AutoSize = True
        Me.RDBTest.Location = New System.Drawing.Point(34, 242)
        Me.RDBTest.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RDBTest.Name = "RDBTest"
        Me.RDBTest.Size = New System.Drawing.Size(85, 29)
        Me.RDBTest.TabIndex = 4
        Me.RDBTest.TabStop = True
        Me.RDBTest.Text = "Test"
        Me.RDBTest.UseVisualStyleBackColor = True
        '
        'RDBCompetition
        '
        Me.RDBCompetition.AutoSize = True
        Me.RDBCompetition.Location = New System.Drawing.Point(34, 288)
        Me.RDBCompetition.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RDBCompetition.Name = "RDBCompetition"
        Me.RDBCompetition.Size = New System.Drawing.Size(157, 29)
        Me.RDBCompetition.TabIndex = 5
        Me.RDBCompetition.TabStop = True
        Me.RDBCompetition.Text = "Competition"
        Me.RDBCompetition.UseVisualStyleBackColor = True
        '
        'RDBOther
        '
        Me.RDBOther.AutoSize = True
        Me.RDBOther.Location = New System.Drawing.Point(34, 335)
        Me.RDBOther.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RDBOther.Name = "RDBOther"
        Me.RDBOther.Size = New System.Drawing.Size(96, 29)
        Me.RDBOther.TabIndex = 6
        Me.RDBOther.TabStop = True
        Me.RDBOther.Text = "Other"
        Me.RDBOther.UseVisualStyleBackColor = True
        '
        'CMBLevel
        '
        Me.CMBLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBLevel.FormattingEnabled = True
        Me.CMBLevel.Location = New System.Drawing.Point(134, 404)
        Me.CMBLevel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CMBLevel.Name = "CMBLevel"
        Me.CMBLevel.Size = New System.Drawing.Size(238, 33)
        Me.CMBLevel.TabIndex = 7
        '
        'LBLLevel
        '
        Me.LBLLevel.AutoSize = True
        Me.LBLLevel.Location = New System.Drawing.Point(24, 410)
        Me.LBLLevel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLLevel.Name = "LBLLevel"
        Me.LBLLevel.Size = New System.Drawing.Size(64, 25)
        Me.LBLLevel.TabIndex = 8
        Me.LBLLevel.Text = "Level"
        '
        'LBLLength
        '
        Me.LBLLength.AutoSize = True
        Me.LBLLength.Location = New System.Drawing.Point(24, 477)
        Me.LBLLength.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLLength.Name = "LBLLength"
        Me.LBLLength.Size = New System.Drawing.Size(78, 25)
        Me.LBLLength.TabIndex = 9
        Me.LBLLength.Text = "Length"
        '
        'CMBLength
        '
        Me.CMBLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBLength.FormattingEnabled = True
        Me.CMBLength.Location = New System.Drawing.Point(134, 471)
        Me.CMBLength.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CMBLength.Name = "CMBLength"
        Me.CMBLength.Size = New System.Drawing.Size(238, 33)
        Me.CMBLength.TabIndex = 10
        '
        'CMDPlan
        '
        Me.CMDPlan.Location = New System.Drawing.Point(34, 554)
        Me.CMDPlan.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CMDPlan.Name = "CMDPlan"
        Me.CMDPlan.Size = New System.Drawing.Size(342, 85)
        Me.CMDPlan.TabIndex = 11
        Me.CMDPlan.Text = "Plan Routine"
        Me.CMDPlan.UseVisualStyleBackColor = True
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(34, 650)
        Me.CMDCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(342, 85)
        Me.CMDCancel.TabIndex = 12
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'FRMRoutineScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 888)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDPlan)
        Me.Controls.Add(Me.CMBLength)
        Me.Controls.Add(Me.LBLLength)
        Me.Controls.Add(Me.LBLLevel)
        Me.Controls.Add(Me.CMBLevel)
        Me.Controls.Add(Me.RDBOther)
        Me.Controls.Add(Me.RDBCompetition)
        Me.Controls.Add(Me.RDBTest)
        Me.Controls.Add(Me.LBLRoutineFor)
        Me.Controls.Add(Me.CMDAddPupil)
        Me.Controls.Add(Me.CMBPupil)
        Me.Controls.Add(Me.LBLPupil)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FRMRoutineScreen1"
        Me.Text = "Routine Planning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLPupil As System.Windows.Forms.Label
    Friend WithEvents CMBPupil As System.Windows.Forms.ComboBox
    Friend WithEvents CMDAddPupil As System.Windows.Forms.Button
    Friend WithEvents LBLRoutineFor As System.Windows.Forms.Label
    Friend WithEvents RDBTest As System.Windows.Forms.RadioButton
    Friend WithEvents RDBCompetition As System.Windows.Forms.RadioButton
    Friend WithEvents RDBOther As System.Windows.Forms.RadioButton
    Friend WithEvents CMBLevel As System.Windows.Forms.ComboBox
    Friend WithEvents LBLLevel As System.Windows.Forms.Label
    Friend WithEvents LBLLength As System.Windows.Forms.Label
    Friend WithEvents CMBLength As System.Windows.Forms.ComboBox
    Friend WithEvents CMDPlan As System.Windows.Forms.Button
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
End Class
