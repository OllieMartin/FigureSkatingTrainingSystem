<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDataBaseAddPupil
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
        Me.CMBPupilCoach = New System.Windows.Forms.ComboBox()
        Me.CMDAddNewCoach = New System.Windows.Forms.Button()
        Me.TXTMaxHR = New System.Windows.Forms.TextBox()
        Me.TXTRestHR = New System.Windows.Forms.TextBox()
        Me.TXTSkatingHR = New System.Windows.Forms.TextBox()
        Me.TXTStandingJump = New System.Windows.Forms.TextBox()
        Me.TXTBleepTest = New System.Windows.Forms.TextBox()
        Me.TXTPikeReach = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DTPPupilDOB = New System.Windows.Forms.DateTimePicker()
        Me.TXTFirstName = New System.Windows.Forms.TextBox()
        Me.TXTSurname = New System.Windows.Forms.TextBox()
        Me.TXTFMLevel = New System.Windows.Forms.TextBox()
        Me.TXTElementsLevel = New System.Windows.Forms.TextBox()
        Me.TXTFreeLevel = New System.Windows.Forms.TextBox()
        Me.TXTHRDecRate = New System.Windows.Forms.MaskedTextBox()
        Me.TXTPresentationScore = New System.Windows.Forms.TextBox()
        Me.CMDNext = New System.Windows.Forms.Button()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMBPupilCoach
        '
        Me.CMBPupilCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBPupilCoach.FormattingEnabled = True
        Me.CMBPupilCoach.Location = New System.Drawing.Point(119, 165)
        Me.CMBPupilCoach.Name = "CMBPupilCoach"
        Me.CMBPupilCoach.Size = New System.Drawing.Size(183, 21)
        Me.CMBPupilCoach.TabIndex = 6
        '
        'CMDAddNewCoach
        '
        Me.CMDAddNewCoach.Location = New System.Drawing.Point(308, 163)
        Me.CMDAddNewCoach.Name = "CMDAddNewCoach"
        Me.CMDAddNewCoach.Size = New System.Drawing.Size(104, 23)
        Me.CMDAddNewCoach.TabIndex = 17
        Me.CMDAddNewCoach.Text = "(Add New)"
        Me.CMDAddNewCoach.UseVisualStyleBackColor = True
        '
        'TXTMaxHR
        '
        Me.TXTMaxHR.Location = New System.Drawing.Point(119, 192)
        Me.TXTMaxHR.MaxLength = 3
        Me.TXTMaxHR.Name = "TXTMaxHR"
        Me.TXTMaxHR.Size = New System.Drawing.Size(183, 20)
        Me.TXTMaxHR.TabIndex = 7
        '
        'TXTRestHR
        '
        Me.TXTRestHR.Location = New System.Drawing.Point(119, 244)
        Me.TXTRestHR.MaxLength = 3
        Me.TXTRestHR.Name = "TXTRestHR"
        Me.TXTRestHR.Size = New System.Drawing.Size(183, 20)
        Me.TXTRestHR.TabIndex = 9
        '
        'TXTSkatingHR
        '
        Me.TXTSkatingHR.Location = New System.Drawing.Point(119, 270)
        Me.TXTSkatingHR.MaxLength = 3
        Me.TXTSkatingHR.Name = "TXTSkatingHR"
        Me.TXTSkatingHR.Size = New System.Drawing.Size(183, 20)
        Me.TXTSkatingHR.TabIndex = 10
        '
        'TXTStandingJump
        '
        Me.TXTStandingJump.Location = New System.Drawing.Point(119, 322)
        Me.TXTStandingJump.MaxLength = 4
        Me.TXTStandingJump.Name = "TXTStandingJump"
        Me.TXTStandingJump.Size = New System.Drawing.Size(183, 20)
        Me.TXTStandingJump.TabIndex = 12
        '
        'TXTBleepTest
        '
        Me.TXTBleepTest.Location = New System.Drawing.Point(119, 374)
        Me.TXTBleepTest.MaxLength = 4
        Me.TXTBleepTest.Name = "TXTBleepTest"
        Me.TXTBleepTest.Size = New System.Drawing.Size(183, 20)
        Me.TXTBleepTest.TabIndex = 14
        '
        'TXTPikeReach
        '
        Me.TXTPikeReach.Location = New System.Drawing.Point(119, 348)
        Me.TXTPikeReach.MaxLength = 4
        Me.TXTPikeReach.Name = "TXTPikeReach"
        Me.TXTPikeReach.Size = New System.Drawing.Size(183, 20)
        Me.TXTPikeReach.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 26)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "First Name*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Surname*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Date Of Birth*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Field Move Level*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Elements Level*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Free Level*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Pupil's Coach*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Max Heartrate*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "HR Decrease Rate*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Resting HR*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Skating HR*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Presentation Score*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 325)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Standing Jump "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 351)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Pike Reach"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 377)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Bleep Test"
        '
        'DTPPupilDOB
        '
        Me.DTPPupilDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPPupilDOB.Location = New System.Drawing.Point(119, 60)
        Me.DTPPupilDOB.Name = "DTPPupilDOB"
        Me.DTPPupilDOB.Size = New System.Drawing.Size(183, 20)
        Me.DTPPupilDOB.TabIndex = 2
        Me.DTPPupilDOB.Value = New Date(2016, 3, 11, 0, 0, 0, 0)
        '
        'TXTFirstName
        '
        Me.TXTFirstName.Location = New System.Drawing.Point(119, 8)
        Me.TXTFirstName.MaxLength = 20
        Me.TXTFirstName.Name = "TXTFirstName"
        Me.TXTFirstName.Size = New System.Drawing.Size(183, 20)
        Me.TXTFirstName.TabIndex = 0
        '
        'TXTSurname
        '
        Me.TXTSurname.Location = New System.Drawing.Point(119, 34)
        Me.TXTSurname.MaxLength = 20
        Me.TXTSurname.Name = "TXTSurname"
        Me.TXTSurname.Size = New System.Drawing.Size(183, 20)
        Me.TXTSurname.TabIndex = 1
        '
        'TXTFMLevel
        '
        Me.TXTFMLevel.Location = New System.Drawing.Point(119, 86)
        Me.TXTFMLevel.MaxLength = 2
        Me.TXTFMLevel.Name = "TXTFMLevel"
        Me.TXTFMLevel.Size = New System.Drawing.Size(183, 20)
        Me.TXTFMLevel.TabIndex = 3
        '
        'TXTElementsLevel
        '
        Me.TXTElementsLevel.Location = New System.Drawing.Point(119, 112)
        Me.TXTElementsLevel.MaxLength = 2
        Me.TXTElementsLevel.Name = "TXTElementsLevel"
        Me.TXTElementsLevel.Size = New System.Drawing.Size(183, 20)
        Me.TXTElementsLevel.TabIndex = 4
        '
        'TXTFreeLevel
        '
        Me.TXTFreeLevel.Location = New System.Drawing.Point(119, 138)
        Me.TXTFreeLevel.MaxLength = 2
        Me.TXTFreeLevel.Name = "TXTFreeLevel"
        Me.TXTFreeLevel.Size = New System.Drawing.Size(183, 20)
        Me.TXTFreeLevel.TabIndex = 5
        '
        'TXTHRDecRate
        '
        Me.TXTHRDecRate.Location = New System.Drawing.Point(119, 218)
        Me.TXTHRDecRate.Mask = "0.0"
        Me.TXTHRDecRate.Name = "TXTHRDecRate"
        Me.TXTHRDecRate.Size = New System.Drawing.Size(183, 20)
        Me.TXTHRDecRate.TabIndex = 8
        '
        'TXTPresentationScore
        '
        Me.TXTPresentationScore.Location = New System.Drawing.Point(119, 296)
        Me.TXTPresentationScore.MaxLength = 3
        Me.TXTPresentationScore.Name = "TXTPresentationScore"
        Me.TXTPresentationScore.Size = New System.Drawing.Size(183, 20)
        Me.TXTPresentationScore.TabIndex = 11
        '
        'CMDNext
        '
        Me.CMDNext.Location = New System.Drawing.Point(330, 314)
        Me.CMDNext.Name = "CMDNext"
        Me.CMDNext.Size = New System.Drawing.Size(120, 80)
        Me.CMDNext.TabIndex = 15
        Me.CMDNext.Text = "Next"
        Me.CMDNext.UseVisualStyleBackColor = True
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(473, 314)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(120, 80)
        Me.CMDCancel.TabIndex = 16
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'FRMDataBaseAddPupil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 461)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDNext)
        Me.Controls.Add(Me.TXTPresentationScore)
        Me.Controls.Add(Me.TXTHRDecRate)
        Me.Controls.Add(Me.TXTFreeLevel)
        Me.Controls.Add(Me.TXTElementsLevel)
        Me.Controls.Add(Me.TXTFMLevel)
        Me.Controls.Add(Me.TXTSurname)
        Me.Controls.Add(Me.TXTFirstName)
        Me.Controls.Add(Me.DTPPupilDOB)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTPikeReach)
        Me.Controls.Add(Me.TXTBleepTest)
        Me.Controls.Add(Me.TXTStandingJump)
        Me.Controls.Add(Me.TXTSkatingHR)
        Me.Controls.Add(Me.TXTRestHR)
        Me.Controls.Add(Me.TXTMaxHR)
        Me.Controls.Add(Me.CMDAddNewCoach)
        Me.Controls.Add(Me.CMBPupilCoach)
        Me.Name = "FRMDataBaseAddPupil"
        Me.Text = "FRMDataBaseAddPupil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMBPupilCoach As System.Windows.Forms.ComboBox
    Friend WithEvents CMDAddNewCoach As System.Windows.Forms.Button
    Friend WithEvents TXTMaxHR As System.Windows.Forms.TextBox
    Friend WithEvents TXTRestHR As System.Windows.Forms.TextBox
    Friend WithEvents TXTSkatingHR As System.Windows.Forms.TextBox
    Friend WithEvents TXTStandingJump As System.Windows.Forms.TextBox
    Friend WithEvents TXTBleepTest As System.Windows.Forms.TextBox
    Friend WithEvents TXTPikeReach As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DTPPupilDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTFirstName As System.Windows.Forms.TextBox
    Friend WithEvents TXTSurname As System.Windows.Forms.TextBox
    Friend WithEvents TXTFMLevel As System.Windows.Forms.TextBox
    Friend WithEvents TXTElementsLevel As System.Windows.Forms.TextBox
    Friend WithEvents TXTFreeLevel As System.Windows.Forms.TextBox
    Friend WithEvents TXTHRDecRate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TXTPresentationScore As System.Windows.Forms.TextBox
    Friend WithEvents CMDNext As System.Windows.Forms.Button
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
End Class
