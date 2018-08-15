<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAccess
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OfficeDataSet = New Office.OfficeDataSet()
        Me.AccountsTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Accounts_TblTableAdapter = New Office.OfficeDataSetTableAdapters.Accounts_TblTableAdapter()
        Me.OfficeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsTblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsTblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AccountsTblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(160, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(586, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OfficeDataSet
        '
        Me.OfficeDataSet.DataSetName = "OfficeDataSet"
        Me.OfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsTblBindingSource
        '
        Me.AccountsTblBindingSource.DataMember = "Accounts_Tbl"
        Me.AccountsTblBindingSource.DataSource = Me.OfficeDataSet
        '
        'Accounts_TblTableAdapter
        '
        Me.Accounts_TblTableAdapter.ClearBeforeFill = True
        '
        'OfficeDataSetBindingSource
        '
        Me.OfficeDataSetBindingSource.DataSource = Me.OfficeDataSet
        Me.OfficeDataSetBindingSource.Position = 0
        '
        'AccountsTblBindingSource1
        '
        Me.AccountsTblBindingSource1.DataMember = "Accounts_Tbl"
        Me.AccountsTblBindingSource1.DataSource = Me.OfficeDataSetBindingSource
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'AdminAccess
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminAccess"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Law Office Management System"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsTblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents OfficeDataSet As OfficeDataSet
    Friend WithEvents AccountsTblBindingSource As BindingSource
    Friend WithEvents Accounts_TblTableAdapter As OfficeDataSetTableAdapters.Accounts_TblTableAdapter
    Friend WithEvents OfficeDataSetBindingSource As BindingSource
    Friend WithEvents AccountsTblBindingSource1 As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
