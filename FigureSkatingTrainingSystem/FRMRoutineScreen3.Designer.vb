<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMRoutineScreen3
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.CHTHeartRate = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DGVRoutine = New System.Windows.Forms.DataGridView()
        Me.CMDSave = New System.Windows.Forms.Button()
        Me.CMDPrint = New System.Windows.Forms.Button()
        Me.CMDBack = New System.Windows.Forms.Button()
        Me.LBLPredicted = New System.Windows.Forms.Label()
        Me.LBLClean = New System.Windows.Forms.Label()
        Me.LBLBadSkate = New System.Windows.Forms.Label()
        Me.CMDIncreaseGOE = New System.Windows.Forms.Button()
        Me.LBLCurrentGOE = New System.Windows.Forms.Label()
        Me.CMDDecreaseGOE = New System.Windows.Forms.Button()
        Me.LBLGOEInfo = New System.Windows.Forms.Label()
        CType(Me.CHTHeartRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVRoutine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CHTHeartRate
        '
        Me.CHTHeartRate.BackColor = System.Drawing.SystemColors.Control
        ChartArea1.Name = "ChartArea1"
        Me.CHTHeartRate.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CHTHeartRate.Legends.Add(Legend1)
        Me.CHTHeartRate.Location = New System.Drawing.Point(16, 151)
        Me.CHTHeartRate.Name = "CHTHeartRate"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.CHTHeartRate.Series.Add(Series1)
        Me.CHTHeartRate.Size = New System.Drawing.Size(447, 191)
        Me.CHTHeartRate.TabIndex = 0
        Me.CHTHeartRate.Text = "Chart1"
        '
        'DGVRoutine
        '
        Me.DGVRoutine.AllowUserToAddRows = False
        Me.DGVRoutine.AllowUserToDeleteRows = False
        Me.DGVRoutine.AllowUserToOrderColumns = True
        Me.DGVRoutine.AllowUserToResizeColumns = False
        Me.DGVRoutine.AllowUserToResizeRows = False
        Me.DGVRoutine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRoutine.Location = New System.Drawing.Point(12, 12)
        Me.DGVRoutine.MultiSelect = False
        Me.DGVRoutine.Name = "DGVRoutine"
        Me.DGVRoutine.ReadOnly = True
        Me.DGVRoutine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVRoutine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVRoutine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRoutine.Size = New System.Drawing.Size(543, 133)
        Me.DGVRoutine.TabIndex = 1
        '
        'CMDSave
        '
        Me.CMDSave.Location = New System.Drawing.Point(12, 348)
        Me.CMDSave.Name = "CMDSave"
        Me.CMDSave.Size = New System.Drawing.Size(131, 50)
        Me.CMDSave.TabIndex = 2
        Me.CMDSave.Text = "Save"
        Me.CMDSave.UseVisualStyleBackColor = True
        '
        'CMDPrint
        '
        Me.CMDPrint.Location = New System.Drawing.Point(149, 348)
        Me.CMDPrint.Name = "CMDPrint"
        Me.CMDPrint.Size = New System.Drawing.Size(129, 50)
        Me.CMDPrint.TabIndex = 3
        Me.CMDPrint.Text = "Print"
        Me.CMDPrint.UseVisualStyleBackColor = True
        '
        'CMDBack
        '
        Me.CMDBack.Location = New System.Drawing.Point(285, 348)
        Me.CMDBack.Name = "CMDBack"
        Me.CMDBack.Size = New System.Drawing.Size(133, 50)
        Me.CMDBack.TabIndex = 4
        Me.CMDBack.Text = "Back to Menu"
        Me.CMDBack.UseVisualStyleBackColor = True
        '
        'LBLPredicted
        '
        Me.LBLPredicted.AutoSize = True
        Me.LBLPredicted.Location = New System.Drawing.Point(469, 162)
        Me.LBLPredicted.Name = "LBLPredicted"
        Me.LBLPredicted.Size = New System.Drawing.Size(39, 13)
        Me.LBLPredicted.TabIndex = 5
        Me.LBLPredicted.Text = "Label1"
        '
        'LBLClean
        '
        Me.LBLClean.AutoSize = True
        Me.LBLClean.Location = New System.Drawing.Point(469, 187)
        Me.LBLClean.Name = "LBLClean"
        Me.LBLClean.Size = New System.Drawing.Size(39, 13)
        Me.LBLClean.TabIndex = 6
        Me.LBLClean.Text = "Label2"
        '
        'LBLBadSkate
        '
        Me.LBLBadSkate.AutoSize = True
        Me.LBLBadSkate.Location = New System.Drawing.Point(469, 211)
        Me.LBLBadSkate.Name = "LBLBadSkate"
        Me.LBLBadSkate.Size = New System.Drawing.Size(39, 13)
        Me.LBLBadSkate.TabIndex = 7
        Me.LBLBadSkate.Text = "Label3"
        '
        'CMDIncreaseGOE
        '
        Me.CMDIncreaseGOE.Location = New System.Drawing.Point(562, 71)
        Me.CMDIncreaseGOE.Name = "CMDIncreaseGOE"
        Me.CMDIncreaseGOE.Size = New System.Drawing.Size(60, 23)
        Me.CMDIncreaseGOE.TabIndex = 8
        Me.CMDIncreaseGOE.Text = "/\"
        Me.CMDIncreaseGOE.UseVisualStyleBackColor = True
        '
        'LBLCurrentGOE
        '
        Me.LBLCurrentGOE.AutoSize = True
        Me.LBLCurrentGOE.Location = New System.Drawing.Point(585, 97)
        Me.LBLCurrentGOE.Name = "LBLCurrentGOE"
        Me.LBLCurrentGOE.Size = New System.Drawing.Size(13, 13)
        Me.LBLCurrentGOE.TabIndex = 9
        Me.LBLCurrentGOE.Text = "0"
        '
        'CMDDecreaseGOE
        '
        Me.CMDDecreaseGOE.Location = New System.Drawing.Point(562, 113)
        Me.CMDDecreaseGOE.Name = "CMDDecreaseGOE"
        Me.CMDDecreaseGOE.Size = New System.Drawing.Size(60, 23)
        Me.CMDDecreaseGOE.TabIndex = 10
        Me.CMDDecreaseGOE.Text = "\/"
        Me.CMDDecreaseGOE.UseVisualStyleBackColor = True
        '
        'LBLGOEInfo
        '
        Me.LBLGOEInfo.Location = New System.Drawing.Point(562, 16)
        Me.LBLGOEInfo.Name = "LBLGOEInfo"
        Me.LBLGOEInfo.Size = New System.Drawing.Size(60, 52)
        Me.LBLGOEInfo.TabIndex = 11
        Me.LBLGOEInfo.Text = "Alter Predicted GOE Mark"
        Me.LBLGOEInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRMRoutineScreen3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 381)
        Me.Controls.Add(Me.LBLGOEInfo)
        Me.Controls.Add(Me.CMDDecreaseGOE)
        Me.Controls.Add(Me.LBLCurrentGOE)
        Me.Controls.Add(Me.CMDIncreaseGOE)
        Me.Controls.Add(Me.LBLBadSkate)
        Me.Controls.Add(Me.LBLClean)
        Me.Controls.Add(Me.LBLPredicted)
        Me.Controls.Add(Me.CMDBack)
        Me.Controls.Add(Me.CMDPrint)
        Me.Controls.Add(Me.CMDSave)
        Me.Controls.Add(Me.DGVRoutine)
        Me.Controls.Add(Me.CHTHeartRate)
        Me.Name = "FRMRoutineScreen3"
        Me.Text = "Routine Planning"
        CType(Me.CHTHeartRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVRoutine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CHTHeartRate As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents DGVRoutine As System.Windows.Forms.DataGridView
    Friend WithEvents CMDSave As System.Windows.Forms.Button
    Friend WithEvents CMDPrint As System.Windows.Forms.Button
    Friend WithEvents CMDBack As System.Windows.Forms.Button
    Friend WithEvents LBLPredicted As System.Windows.Forms.Label
    Friend WithEvents LBLClean As System.Windows.Forms.Label
    Friend WithEvents LBLBadSkate As System.Windows.Forms.Label
    Friend WithEvents CMDIncreaseGOE As System.Windows.Forms.Button
    Friend WithEvents LBLCurrentGOE As System.Windows.Forms.Label
    Friend WithEvents CMDDecreaseGOE As System.Windows.Forms.Button
    Friend WithEvents LBLGOEInfo As System.Windows.Forms.Label
End Class
