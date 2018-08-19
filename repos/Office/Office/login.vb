Imports System.Data.OleDb
Public Class login
    Public loggedin As Boolean
    Public user As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button5.Visible = True
        Button6.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        CommonRecordsAdd.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        SensitiveRecordsAdd.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim t_user As String = ""
        Dim t_pass As String
        Dim pass As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Wrong input")
        Else
            t_user = TextBox1.Text
            t_pass = TextBox2.Text
            Dim querry As String = "Select Password from Accounts_tbl where Username = '" & t_user & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\Bonats\source\repos\Office\Office\bin\Debug\Office.accdb""Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\Bonats\source\repos\Office\Office\bin\Debug\Office.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar.ToString()
            Catch ex As Exception
                MsgBox("Username doesn't exist")
            End Try
            If (t_pass = pass) Then
                MsgBox("Login Success")
                Me.loggedin = True
                Me.user = TextBox1.Text
            Else
                MsgBox("Login Failed")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If user = "Admin" Then
            Me.Hide()
            AdminAccess.Show()
        Else
            MsgBox("Not Admin Account")
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loggedin = 0
    End Sub
End Class
