<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDataBaseAddPupil2
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CMDDone = New System.Windows.Forms.Button()
        Me.LBLEditCL = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LBLCL = New System.Windows.Forms.Label()
        Me.LBLTL = New System.Windows.Forms.Label()
        Me.LBLEditTL = New System.Windows.Forms.Label()
        Me.CMBCompLevel = New System.Windows.Forms.ComboBox()
        Me.CMBTechLevel = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 61)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(451, 91)
        Me.DataGridView1.TabIndex = 0
        '
        'CMDDone
        '
        Me.CMDDone.Location = New System.Drawing.Point(12, 315)
        Me.CMDDone.Name = "CMDDone"
        Me.CMDDone.Size = New System.Drawing.Size(152, 41)
        Me.CMDDone.TabIndex = 1
        Me.CMDDone.Text = "Quit"
        Me.CMDDone.UseVisualStyleBackColor = True
        '
        'LBLEditCL
        '
        Me.LBLEditCL.AutoSize = True
        Me.LBLEditCL.Location = New System.Drawing.Point(472, 80)
        Me.LBLEditCL.Name = "LBLEditCL"
        Me.LBLEditCL.Size = New System.Drawing.Size(121, 13)
        Me.LBLEditCL.TabIndex = 9
        Me.LBLEditCL.Text = "Edit Competency Levels"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 210)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(451, 91)
        Me.DataGridView2.TabIndex = 11
        '
        'LBLCL
        '
        Me.LBLCL.AutoSize = True
        Me.LBLCL.Location = New System.Drawing.Point(12, 29)
        Me.LBLCL.Name = "LBLCL"
        Me.LBLCL.Size = New System.Drawing.Size(100, 13)
        Me.LBLCL.TabIndex = 12
        Me.LBLCL.Text = "Competency Levels"
        '
        'LBLTL
        '
        Me.LBLTL.AutoSize = True
        Me.LBLTL.Location = New System.Drawing.Point(12, 174)
        Me.LBLTL.Name = "LBLTL"
        Me.LBLTL.Size = New System.Drawing.Size(88, 13)
        Me.LBLTL.TabIndex = 13
        Me.LBLTL.Text = "Technical Levels"
        '
        'LBLEditTL
        '
        Me.LBLEditTL.AutoSize = True
        Me.LBLEditTL.Location = New System.Drawing.Point(472, 232)
        Me.LBLEditTL.Name = "LBLEditTL"
        Me.LBLEditTL.Size = New System.Drawing.Size(109, 13)
        Me.LBLEditTL.TabIndex = 10
        Me.LBLEditTL.Text = "Edit Technical Levels"
        '
        'CMBCompLevel
        '
        Me.CMBCompLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBCompLevel.FormattingEnabled = True
        Me.CMBCompLevel.Location = New System.Drawing.Point(474, 96)
        Me.CMBCompLevel.Name = "CMBCompLevel"
        Me.CMBCompLevel.Size = New System.Drawing.Size(147, 21)
        Me.CMBCompLevel.TabIndex = 14
        '
        'CMBTechLevel
        '
        Me.CMBTechLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBTechLevel.FormattingEnabled = True
        Me.CMBTechLevel.Location = New System.Drawing.Point(474, 253)
        Me.CMBTechLevel.Name = "CMBTechLevel"
        Me.CMBTechLevel.Size = New System.Drawing.Size(147, 21)
        Me.CMBTechLevel.TabIndex = 15
        '
        'FRMDataBaseAddPupil2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 381)
        Me.Controls.Add(Me.CMBTechLevel)
        Me.Controls.Add(Me.CMBCompLevel)
        Me.Controls.Add(Me.LBLTL)
        Me.Controls.Add(Me.LBLCL)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.LBLEditTL)
        Me.Controls.Add(Me.LBLEditCL)
        Me.Controls.Add(Me.CMDDone)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FRMDataBaseAddPupil2"
        Me.Text = "FRMDataBaseAddPupil2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CMDDone As System.Windows.Forms.Button
    Friend WithEvents LBLEditCL As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents LBLCL As System.Windows.Forms.Label
    Friend WithEvents LBLTL As System.Windows.Forms.Label
    Friend WithEvents LBLEditTL As System.Windows.Forms.Label
    Friend WithEvents CMBCompLevel As System.Windows.Forms.ComboBox
    Friend WithEvents CMBTechLevel As System.Windows.Forms.ComboBox
End Class
