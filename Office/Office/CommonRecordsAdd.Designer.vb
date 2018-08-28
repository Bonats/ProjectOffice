<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CommonRecordsAdd
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OfficeDataSet1 = New Office.OfficeDataSet()
        Me.ComAffDiscTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Com_AffDisc_TblTableAdapter1 = New Office.OfficeDataSetTableAdapters.Com_AffDisc_TblTableAdapter()
        Me.ComAffDmgTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Com_AffDmg_TblTableAdapter1 = New Office.OfficeDataSetTableAdapters.Com_AffDmg_TblTableAdapter()
        Me.ComAffIncTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Com_AffInc_TblTableAdapter1 = New Office.OfficeDataSetTableAdapters.Com_AffInc_TblTableAdapter()
        Me.ComAffLossTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Com_AffLoss_TblTableAdapter1 = New Office.OfficeDataSetTableAdapters.Com_AffLoss_TblTableAdapter()
        Me.ComAffSupportTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Com_AffSupport_TblTableAdapter1 = New Office.OfficeDataSetTableAdapters.Com_AffSupport_TblTableAdapter()
        Me.DailyTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Daily_TblTableAdapter = New Office.OfficeDataSetTableAdapters.Daily_TblTableAdapter()
        CType(Me.OfficeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComAffDiscTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComAffDmgTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComAffIncTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComAffLossTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComAffSupportTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back to Main"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 46)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Loss"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(258, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 46)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Discrepancy"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(338, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 46)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Support"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(418, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 46)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Damage"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(498, 32)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 46)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Income"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name of client:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Purpose of Document:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Made by:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Document no:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Notarized by:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Series of:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(310, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(310, 134)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(310, 156)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(151, 20)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(310, 178)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(151, 20)
        Me.TextBox4.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(310, 200)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(151, 20)
        Me.TextBox5.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(310, 223)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(151, 20)
        Me.TextBox6.TabIndex = 17
        Me.TextBox6.Text = "2018"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(39, 86)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 46)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Sensitive Documents"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(497, 267)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Add"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"First name", "Middle name", "Last name"})
        Me.ComboBox1.Location = New System.Drawing.Point(310, 133)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 20
        Me.ComboBox1.Text = "First name"
        Me.ComboBox1.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(310, 246)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(151, 20)
        Me.TextBox7.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Payment:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(178, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Document Type:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(310, 269)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(151, 20)
        Me.TextBox8.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(178, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "FilePath:"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(310, 295)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 26
        Me.Button9.Text = "Get File"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OfficeDataSet1
        '
        Me.OfficeDataSet1.DataSetName = "OfficeDataSet"
        Me.OfficeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComAffDiscTblBindingSource
        '
        Me.ComAffDiscTblBindingSource.DataMember = "Com_AffDisc_Tbl"
        Me.ComAffDiscTblBindingSource.DataSource = Me.OfficeDataSet1
        '
        'Com_AffDisc_TblTableAdapter1
        '
        Me.Com_AffDisc_TblTableAdapter1.ClearBeforeFill = True
        '
        'ComAffDmgTblBindingSource
        '
        Me.ComAffDmgTblBindingSource.DataMember = "Com_AffDmg_Tbl"
        Me.ComAffDmgTblBindingSource.DataSource = Me.OfficeDataSet1
        '
        'Com_AffDmg_TblTableAdapter1
        '
        Me.Com_AffDmg_TblTableAdapter1.ClearBeforeFill = True
        '
        'ComAffIncTblBindingSource
        '
        Me.ComAffIncTblBindingSource.DataMember = "Com_AffInc_Tbl"
        Me.ComAffIncTblBindingSource.DataSource = Me.OfficeDataSet1
        '
        'Com_AffInc_TblTableAdapter1
        '
        Me.Com_AffInc_TblTableAdapter1.ClearBeforeFill = True
        '
        'ComAffLossTblBindingSource
        '
        Me.ComAffLossTblBindingSource.DataMember = "Com_AffLoss_Tbl"
        Me.ComAffLossTblBindingSource.DataSource = Me.OfficeDataSet1
        '
        'Com_AffLoss_TblTableAdapter1
        '
        Me.Com_AffLoss_TblTableAdapter1.ClearBeforeFill = True
        '
        'ComAffSupportTblBindingSource
        '
        Me.ComAffSupportTblBindingSource.DataMember = "Com_AffSupport_Tbl"
        Me.ComAffSupportTblBindingSource.DataSource = Me.OfficeDataSet1
        '
        'Com_AffSupport_TblTableAdapter1
        '
        Me.Com_AffSupport_TblTableAdapter1.ClearBeforeFill = True
        '
        'DailyTblBindingSource
        '
        Me.DailyTblBindingSource.DataMember = "Daily_Tbl"
        Me.DailyTblBindingSource.DataSource = Me.OfficeDataSet1
        '
        'Daily_TblTableAdapter
        '
        Me.Daily_TblTableAdapter.ClearBeforeFill = True
        '
        'CommonRecordsAdd
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CommonRecordsAdd"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.OfficeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComAffDiscTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComAffDmgTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComAffIncTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComAffLossTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComAffSupportTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents OfficeDataSet As OfficeDataSet
    Friend WithEvents Com_AffDisc_TblTableAdapter As OfficeDataSetTableAdapters.Com_AffDisc_TblTableAdapter
    Friend WithEvents Com_AffDmg_TblTableAdapter As OfficeDataSetTableAdapters.Com_AffDmg_TblTableAdapter
    Friend WithEvents Com_AffInc_TblTableAdapter As OfficeDataSetTableAdapters.Com_AffInc_TblTableAdapter
    Friend WithEvents Com_AffLoss_TblTableAdapter As OfficeDataSetTableAdapters.Com_AffLoss_TblTableAdapter
    Friend WithEvents Com_AffSupport_TblTableAdapter As OfficeDataSetTableAdapters.Com_AffSupport_TblTableAdapter
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OfficeDataSet1 As OfficeDataSet
    Friend WithEvents ComAffDiscTblBindingSource As BindingSource
    Friend WithEvents Com_AffDisc_TblTableAdapter1 As OfficeDataSetTableAdapters.Com_AffDisc_TblTableAdapter
    Friend WithEvents ComAffDmgTblBindingSource As BindingSource
    Friend WithEvents Com_AffDmg_TblTableAdapter1 As OfficeDataSetTableAdapters.Com_AffDmg_TblTableAdapter
    Friend WithEvents ComAffIncTblBindingSource As BindingSource
    Friend WithEvents Com_AffInc_TblTableAdapter1 As OfficeDataSetTableAdapters.Com_AffInc_TblTableAdapter
    Friend WithEvents ComAffLossTblBindingSource As BindingSource
    Friend WithEvents Com_AffLoss_TblTableAdapter1 As OfficeDataSetTableAdapters.Com_AffLoss_TblTableAdapter
    Friend WithEvents ComAffSupportTblBindingSource As BindingSource
    Friend WithEvents Com_AffSupport_TblTableAdapter1 As OfficeDataSetTableAdapters.Com_AffSupport_TblTableAdapter
    Friend WithEvents DailyTblBindingSource As BindingSource
    Friend WithEvents Daily_TblTableAdapter As OfficeDataSetTableAdapters.Daily_TblTableAdapter
End Class
