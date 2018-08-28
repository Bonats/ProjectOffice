Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.Show()
        login.MdiParent = Me
        CommonRecordsAdd.MdiParent = Me
        SensitiveRecordsAdd.MdiParent = Me
        AdminAccess.MdiParent = Me
        View.MdiParent = Me
    End Sub
End Class