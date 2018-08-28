<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilePathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfficeDataSet = New Office.OfficeDataSet()
        Me.ClientNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchFinalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SearchFinalToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Daily_TblTableAdapter = New Office.OfficeDataSetTableAdapters.Daily_TblTableAdapter()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchFinalToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientNameDataGridViewTextBoxColumn, Me.DocumentTypeDataGridViewTextBoxColumn, Me.PaymentDataGridViewTextBoxColumn, Me.FilePathDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DailyTblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(543, 270)
        Me.DataGridView1.TabIndex = 0
        '
        'ClientNameDataGridViewTextBoxColumn
        '
        Me.ClientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName"
        Me.ClientNameDataGridViewTextBoxColumn.HeaderText = "ClientName"
        Me.ClientNameDataGridViewTextBoxColumn.Name = "ClientNameDataGridViewTextBoxColumn"
        Me.ClientNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocumentTypeDataGridViewTextBoxColumn
        '
        Me.DocumentTypeDataGridViewTextBoxColumn.DataPropertyName = "Document Type"
        Me.DocumentTypeDataGridViewTextBoxColumn.HeaderText = "Document Type"
        Me.DocumentTypeDataGridViewTextBoxColumn.Name = "DocumentTypeDataGridViewTextBoxColumn"
        Me.DocumentTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentDataGridViewTextBoxColumn
        '
        Me.PaymentDataGridViewTextBoxColumn.DataPropertyName = "Payment"
        Me.PaymentDataGridViewTextBoxColumn.HeaderText = "Payment"
        Me.PaymentDataGridViewTextBoxColumn.Name = "PaymentDataGridViewTextBoxColumn"
        Me.PaymentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FilePathDataGridViewTextBoxColumn
        '
        Me.FilePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath"
        Me.FilePathDataGridViewTextBoxColumn.HeaderText = "FilePath"
        Me.FilePathDataGridViewTextBoxColumn.Name = "FilePathDataGridViewTextBoxColumn"
        Me.FilePathDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DailyTblBindingSource
        '
        Me.DailyTblBindingSource.DataMember = "Daily_Tbl"
        Me.DailyTblBindingSource.DataSource = Me.OfficeDataSet
        '
        'OfficeDataSet
        '
        Me.OfficeDataSet.DataSetName = "OfficeDataSet"
        Me.OfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientNameToolStripTextBox
        '
        Me.ClientNameToolStripTextBox.Name = "ClientNameToolStripTextBox"
        Me.ClientNameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'SearchFinalToolStripButton
        '
        Me.SearchFinalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchFinalToolStripButton.Name = "SearchFinalToolStripButton"
        Me.SearchFinalToolStripButton.Size = New System.Drawing.Size(23, 22)
        '
        'SearchFinalToolStrip
        '
        Me.SearchFinalToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientNameToolStripTextBox, Me.SearchFinalToolStripButton, Me.ToolStripLabel1})
        Me.SearchFinalToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SearchFinalToolStrip.Name = "SearchFinalToolStrip"
        Me.SearchFinalToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.SearchFinalToolStrip.TabIndex = 6
        Me.SearchFinalToolStrip.Text = "SearchFinalToolStrip"
        '
        'Daily_TblTableAdapter
        '
        Me.Daily_TblTableAdapter.ClearBeforeFill = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Search"
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.SearchFinalToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "View"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchFinalToolStrip.ResumeLayout(False)
        Me.SearchFinalToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OfficeDataSet As OfficeDataSet
    Friend WithEvents DailyTblBindingSource As BindingSource
    Friend WithEvents Daily_TblTableAdapter As OfficeDataSetTableAdapters.Daily_TblTableAdapter
    Friend WithEvents ClientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocumentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilePathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientNameToolStripTextBox As ToolStripTextBox
    Friend WithEvents SearchFinalToolStripButton As ToolStripButton
    Friend WithEvents SearchFinalToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
