Public Class SensitiveRecordsAdd
    Dim choice As Integer
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        CommonRecordsAdd.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "Name of buyer:"
        Label7.Text = "Title no:"
        Label8.Text = "Sale price:"
        Label9.Text = "N/A"
        choice = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "Name of buyer:"
        Label7.Text = "Vehicle COR no:"
        Label8.Text = "Vehicle:"
        Label9.Text = "Sale price:"
        choice = 2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = "Name of leasee:"
        Label7.Text = "Monthly payment"
        Label8.Text = "Contract period"
        Label9.Text = "N/A"
        choice = 3
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label2.Text = "Title no:"
        Label7.Text = "Heirs:"
        Label8.Text = "N/A"
        Label9.Text = "N/A"
        choice = 4
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label2.Text = "First party:"
        Label7.Text = "Second party:"
        Label8.Text = "Purpose of document:"
        Label9.Text = "N/A"
        choice = 5
    End Sub

    Private Sub SensitiveRecordsAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Text = login.user
        TextBox3.Enabled = False
    End Sub
End Class