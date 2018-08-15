Public Class CommonRecordsAdd
    Dim choice As Integer
    Private Sub CommonRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Visible() = False
        TextBox2.Visible() = True
        Label2.Text = "Lost item:"
        choice = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        SensitiveRecordsAdd.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "Part of name:"
        choice = 2
        ComboBox1.Visible() = True
        TextBox2.Visible() = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Visible() = False
        TextBox2.Visible() = True
        Label2.Text = "Name of child/children:"
        choice = 3
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Visible() = False
        TextBox2.Visible() = True
        Label2.Text = "Vehicle:"
        choice = 4
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Visible() = False
        TextBox2.Visible() = True
        Label2.Text = "Income:"
        choice = 5
    End Sub
End Class