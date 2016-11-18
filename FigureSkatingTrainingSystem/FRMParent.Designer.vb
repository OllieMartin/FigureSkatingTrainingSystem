<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMParent
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoutinePlanningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainingDiariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.RoutinePlanningToolStripMenuItem, Me.TrainingDiariesToolStripMenuItem, Me.DatabaseManagementToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseSystemToolStripMenuItem})
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'RoutinePlanningToolStripMenuItem
        '
        Me.RoutinePlanningToolStripMenuItem.Name = "RoutinePlanningToolStripMenuItem"
        Me.RoutinePlanningToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.RoutinePlanningToolStripMenuItem.Text = "Routine Planning"
        '
        'TrainingDiariesToolStripMenuItem
        '
        Me.TrainingDiariesToolStripMenuItem.Name = "TrainingDiariesToolStripMenuItem"
        Me.TrainingDiariesToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.TrainingDiariesToolStripMenuItem.Text = "Training Diaries"
        '
        'DatabaseManagementToolStripMenuItem
        '
        Me.DatabaseManagementToolStripMenuItem.Name = "DatabaseManagementToolStripMenuItem"
        Me.DatabaseManagementToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.DatabaseManagementToolStripMenuItem.Text = "Database Management"
        '
        'CloseSystemToolStripMenuItem
        '
        Me.CloseSystemToolStripMenuItem.Name = "CloseSystemToolStripMenuItem"
        Me.CloseSystemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseSystemToolStripMenuItem.Text = "Close System"
        '
        'FRMParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 462)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "FRMParent"
        Me.Text = "Figure Skating Training System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoutinePlanningToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainingDiariesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
