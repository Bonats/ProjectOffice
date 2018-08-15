Public Class AdminAccess
    Private Sub AdminAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OfficeDataSet.Accounts_Tbl' table. You can move, or remove it, as needed.
        Me.Accounts_TblTableAdapter.Fill(Me.OfficeDataSet.Accounts_Tbl)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()
    End Sub
End Class