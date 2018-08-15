Public Class login
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

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        AdminAccess.Show()
    End Sub
End Class
