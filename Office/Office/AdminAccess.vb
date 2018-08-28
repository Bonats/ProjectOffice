Imports System.Data.OleDb
Public Class AdminAccess
    Dim Dbcon As New OleDbConnection
    Dim choice As Integer
    Private Sub AdminAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OfficeDataSet.Accounts_Tbl' table. You can move, or remove it, as needed.
        Me.Accounts_TblTableAdapter.Fill(Me.OfficeDataSet.Accounts_Tbl)
        Dbcon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\Bonats\source\repos\Office\Office\bin\Debug\Office.accdb"
        Dbcon.Open()
        'TODO: This line of code loads data into the 'OfficeDataSet.Accounts_Tbl' table. You can move, or remove it, as needed.
        Me.Accounts_TblTableAdapter.Fill(Me.OfficeDataSet.Accounts_Tbl)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As Integer
        x = DataGridView1.CurrentRow.Index
        txtUser.Text = DataGridView1.Item(0, x).Value
        txtPass.Text = DataGridView1.Item(1, x).Value
        txtPass.Enabled = True
        txtUser.Enabled = True
        choice = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Accounts_TblTableAdapter.Fill(Me.OfficeDataSet.Accounts_Tbl)
        txtPass.Enabled = False
        txtUser.Enabled = False
        txtPass.Clear()
        txtUser.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddAccount.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        txtPass.Enabled = True
        txtUser.Enabled = True
        choice = 2
    End Sub
End Class