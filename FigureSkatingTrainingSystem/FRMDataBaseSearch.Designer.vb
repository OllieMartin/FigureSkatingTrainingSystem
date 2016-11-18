<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDataBaseSearch
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
        Me.CMBSearchTypes = New System.Windows.Forms.ComboBox()
        Me.LBLKindOfSearch = New System.Windows.Forms.Label()
        Me.LBLSearchField = New System.Windows.Forms.Label()
        Me.CMBField = New System.Windows.Forms.ComboBox()
        Me.LBLSearchItem = New System.Windows.Forms.Label()
        Me.TXTSearchItem = New System.Windows.Forms.TextBox()
        Me.CMDSearch = New System.Windows.Forms.Button()
        Me.CMDCancel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CMDDelete = New System.Windows.Forms.Button()
        Me.CMDEdit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMBSearchTypes
        '
        Me.CMBSearchTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBSearchTypes.FormattingEnabled = True
        Me.CMBSearchTypes.Location = New System.Drawing.Point(12, 34)
        Me.CMBSearchTypes.Name = "CMBSearchTypes"
        Me.CMBSearchTypes.Size = New System.Drawing.Size(247, 21)
        Me.CMBSearchTypes.TabIndex = 2
        '
        'LBLKindOfSearch
        '
        Me.LBLKindOfSearch.AutoSize = True
        Me.LBLKindOfSearch.Location = New System.Drawing.Point(10, 10)
        Me.LBLKindOfSearch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLKindOfSearch.Name = "LBLKindOfSearch"
        Me.LBLKindOfSearch.Size = New System.Drawing.Size(165, 13)
        Me.LBLKindOfSearch.TabIndex = 3
        Me.LBLKindOfSearch.Text = "What would you like to search for"
        '
        'LBLSearchField
        '
        Me.LBLSearchField.AutoSize = True
        Me.LBLSearchField.Location = New System.Drawing.Point(11, 67)
        Me.LBLSearchField.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLSearchField.Name = "LBLSearchField"
        Me.LBLSearchField.Size = New System.Drawing.Size(186, 13)
        Me.LBLSearchField.TabIndex = 4
        Me.LBLSearchField.Text = "What field would you like to search by"
        '
        'CMBField
        '
        Me.CMBField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBField.FormattingEnabled = True
        Me.CMBField.Location = New System.Drawing.Point(12, 92)
        Me.CMBField.Name = "CMBField"
        Me.CMBField.Size = New System.Drawing.Size(247, 21)
        Me.CMBField.TabIndex = 5
        '
        'LBLSearchItem
        '
        Me.LBLSearchItem.AutoSize = True
        Me.LBLSearchItem.Location = New System.Drawing.Point(322, 31)
        Me.LBLSearchItem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLSearchItem.Name = "LBLSearchItem"
        Me.LBLSearchItem.Size = New System.Drawing.Size(112, 13)
        Me.LBLSearchItem.TabIndex = 6
        Me.LBLSearchItem.Text = "Enter your search item"
        '
        'TXTSearchItem
        '
        Me.TXTSearchItem.Location = New System.Drawing.Point(325, 48)
        Me.TXTSearchItem.Name = "TXTSearchItem"
        Me.TXTSearchItem.Size = New System.Drawing.Size(245, 20)
        Me.TXTSearchItem.TabIndex = 7
        '
        'CMDSearch
        '
        Me.CMDSearch.Location = New System.Drawing.Point(327, 83)
        Me.CMDSearch.Name = "CMDSearch"
        Me.CMDSearch.Size = New System.Drawing.Size(120, 23)
        Me.CMDSearch.TabIndex = 8
        Me.CMDSearch.Text = "Search"
        Me.CMDSearch.UseVisualStyleBackColor = True
        '
        'CMDCancel
        '
        Me.CMDCancel.Location = New System.Drawing.Point(453, 83)
        Me.CMDCancel.Name = "CMDCancel"
        Me.CMDCancel.Size = New System.Drawing.Size(117, 23)
        Me.CMDCancel.TabIndex = 9
        Me.CMDCancel.Text = "Cancel"
        Me.CMDCancel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 131)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(593, 179)
        Me.DataGridView1.TabIndex = 10
        '
        'CMDDelete
        '
        Me.CMDDelete.Location = New System.Drawing.Point(14, 329)
        Me.CMDDelete.Name = "CMDDelete"
        Me.CMDDelete.Size = New System.Drawing.Size(286, 23)
        Me.CMDDelete.TabIndex = 11
        Me.CMDDelete.Text = "Delete"
        Me.CMDDelete.UseVisualStyleBackColor = True
        '
        'CMDEdit
        '
        Me.CMDEdit.Location = New System.Drawing.Point(317, 329)
        Me.CMDEdit.Name = "CMDEdit"
        Me.CMDEdit.Size = New System.Drawing.Size(290, 23)
        Me.CMDEdit.TabIndex = 12
        Me.CMDEdit.Text = "Edit"
        Me.CMDEdit.UseVisualStyleBackColor = True
        '
        'FRMDataBaseSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 385)
        Me.Controls.Add(Me.CMDEdit)
        Me.Controls.Add(Me.CMDDelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CMDCancel)
        Me.Controls.Add(Me.CMDSearch)
        Me.Controls.Add(Me.TXTSearchItem)
        Me.Controls.Add(Me.LBLSearchItem)
        Me.Controls.Add(Me.CMBField)
        Me.Controls.Add(Me.LBLSearchField)
        Me.Controls.Add(Me.LBLKindOfSearch)
        Me.Controls.Add(Me.CMBSearchTypes)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FRMDataBaseSearch"
        Me.Text = "FRMDataBaseSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMBSearchTypes As System.Windows.Forms.ComboBox
    Friend WithEvents LBLKindOfSearch As System.Windows.Forms.Label
    Friend WithEvents LBLSearchField As System.Windows.Forms.Label
    Friend WithEvents CMBField As System.Windows.Forms.ComboBox
    Friend WithEvents LBLSearchItem As System.Windows.Forms.Label
    Friend WithEvents TXTSearchItem As System.Windows.Forms.TextBox
    Friend WithEvents CMDSearch As System.Windows.Forms.Button
    Friend WithEvents CMDCancel As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CMDDelete As System.Windows.Forms.Button
    Friend WithEvents CMDEdit As System.Windows.Forms.Button
End Class
