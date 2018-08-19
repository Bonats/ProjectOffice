Public Class CommonRecordsAdd
    Dim choice As Integer
    Dim user As String
    Private Sub CommonRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OfficeDataSet.AffLoss_Tbl' table. You can move, or remove it, as needed.
        Me.AffLoss_TblTableAdapter.Fill(Me.OfficeDataSet.AffLoss_Tbl)
        user = login.user
        TextBox3.Text = login.user
        TextBox3.Enabled = False
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
        If choice = 1 Then
            AffLoss_TblTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, Date.Now)
            AffLoss_TblTableAdapter.Fill(OfficeDataSet.AffLoss_Tbl)
            MsgBox("Success")
        End If
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

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class