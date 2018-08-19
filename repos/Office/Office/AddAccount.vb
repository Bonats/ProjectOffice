Public Class AddAccount
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminAccess.Accounts_TblTableAdapter.Insert(Me.txtUser.Text, Me.txtPass.Text)
        AdminAccess.Accounts_TblTableAdapter.Fill(AdminAccess.OfficeDataSet.Accounts_Tbl)
        MsgBox("Success")
        txtUser.Clear()
        txtPass.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class