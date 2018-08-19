<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminAccess
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OfficeDataSet = New Office.OfficeDataSet()
        Me.AccountsTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Accounts_TblTableAdapter = New Office.OfficeDataSetTableAdapters.Accounts_TblTableAdapter()
        Me.UsernameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(51, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(51, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(12, 195)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(130, 20)
        Me.txtUser.TabIndex = 5
        '
        'txtPass
        '
        Me.txtPass.Enabled = False
        Me.txtPass.Location = New System.Drawing.Point(12, 240)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(130, 20)
        Me.txtPass.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(51, 143)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn1, Me.PasswordDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.AccountsTblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(203, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(526, 248)
        Me.DataGridView1.TabIndex = 11
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
        'UsernameDataGridViewTextBoxColumn1
        '
        Me.UsernameDataGridViewTextBoxColumn1.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn1.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn1.Name = "UsernameDataGridViewTextBoxColumn1"
        Me.UsernameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn1
        '
        Me.PasswordDataGridViewTextBoxColumn1.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn1.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn1.Name = "PasswordDataGridViewTextBoxColumn1"
        Me.PasswordDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'AdminAccess
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OfficeDataSet As OfficeDataSet
    Friend WithEvents AccountsTblBindingSource As BindingSource
    Friend WithEvents Accounts_TblTableAdapter As OfficeDataSetTableAdapters.Accounts_TblTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
