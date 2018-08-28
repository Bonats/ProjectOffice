
Public Class View
    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OfficeDataSet.Daily_Tbl' table. You can move, or remove it, as needed.
        Me.Daily_TblTableAdapter.Fill(Me.OfficeDataSet.Daily_Tbl)

    End Sub

    Private Sub ClientNameToolStripTextBox_TextChanged(sender As Object, e As EventArgs) Handles ClientNameToolStripTextBox.TextChanged
        Me.Daily_TblTableAdapter.SearchFinal(Me.OfficeDataSet.Daily_Tbl, ClientNameToolStripTextBox.Text)
    End Sub
End Class