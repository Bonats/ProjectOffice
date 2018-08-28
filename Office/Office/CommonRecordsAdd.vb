Public Class CommonRecordsAdd
    Dim choice As Integer
    Dim user As String
    Private Sub CommonRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OfficeDataSet1.Daily_Tbl' table. You can move, or remove it, as needed.
        Me.Daily_TblTableAdapter.Fill(Me.OfficeDataSet1.Daily_Tbl)
        'TODO: This line of code loads data into the 'OfficeDataSet1.Com_AffSupport_Tbl' table. You can move, or remove it, as needed.
        Me.Com_AffSupport_TblTableAdapter1.Fill(Me.OfficeDataSet1.Com_AffSupport_Tbl)
        'TODO: This line of code loads data into the 'OfficeDataSet1.Com_AffLoss_Tbl' table. You can move, or remove it, as needed.
        Me.Com_AffLoss_TblTableAdapter1.Fill(Me.OfficeDataSet1.Com_AffLoss_Tbl)
        'TODO: This line of code loads data into the 'OfficeDataSet1.Com_AffInc_Tbl' table. You can move, or remove it, as needed.
        Me.Com_AffInc_TblTableAdapter1.Fill(Me.OfficeDataSet1.Com_AffInc_Tbl)
        'TODO: This line of code loads data into the 'OfficeDataSet1.Com_AffDmg_Tbl' table. You can move, or remove it, as needed.
        Me.Com_AffDmg_TblTableAdapter1.Fill(Me.OfficeDataSet1.Com_AffDmg_Tbl)
        'TODO: This line of code loads data into the 'OfficeDataSet1.Com_AffDisc_Tbl' table. You can move, or remove it, as needed.
        Me.Com_AffDisc_TblTableAdapter1.Fill(Me.OfficeDataSet1.Com_AffDisc_Tbl)
        user = login.user
        TextBox3.Text = login.user
        TextBox3.Enabled = False
        choice = 0
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


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If choice = 1 Then
            Try
                Com_AffLoss_TblTableAdapter1.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, Date.Now)
                Com_AffLoss_TblTableAdapter1.Fill(OfficeDataSet1.Com_AffLoss_Tbl)
                Daily_TblTableAdapter.Insert(TextBox1.Text, "Affidavit Of Loss", TextBox7.Text, TextBox8.Text, Date.Now)
                Daily_TblTableAdapter.Fill(OfficeDataSet1.Daily_Tbl)
                MsgBox("Success")
            Catch ex As Exception
                MsgBox("Wrong Input")
            End Try
        ElseIf choice = 2 Then
            Try
                Com_AffDisc_TblTableAdapter1.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, Date.Now)
                Com_AffDisc_TblTableAdapter1.Fill(OfficeDataSet1.Com_AffDisc_Tbl)
                Daily_TblTableAdapter.Insert(TextBox1.Text, "Affidavit Of Discrepancy", TextBox7.Text, TextBox8.Text, Date.Now)
                Daily_TblTableAdapter.Fill(OfficeDataSet1.Daily_Tbl)
                MsgBox("Success")
            Catch ex As Exception
                MsgBox("Wrong Input")
            End Try
        ElseIf choice = 3 Then
            Try
                Com_AffSupport_TblTableAdapter1.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, Date.Now)
                Com_AffSupport_TblTableAdapter1.Fill(OfficeDataSet1.Com_AffSupport_Tbl)
                Daily_TblTableAdapter.Insert(TextBox1.Text, "Affidavit of Support", TextBox7.Text, TextBox8.Text, Date.Now)
                Daily_TblTableAdapter.Fill(OfficeDataSet1.Daily_Tbl)
                MsgBox("Success")
            Catch ex As Exception
                MsgBox("Wrong Input")
            End Try
        ElseIf choice = 4 Then
            Try
                Com_AffDmg_TblTableAdapter1.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, Date.Now)
                Com_AffDmg_TblTableAdapter1.Fill(OfficeDataSet1.Com_AffDmg_Tbl)
                Daily_TblTableAdapter.Insert(TextBox1.Text, "Affidavit Of Damage", TextBox7.Text, TextBox8.Text, Date.Now)
                Daily_TblTableAdapter.Fill(OfficeDataSet1.Daily_Tbl)
                MsgBox("Success")
            Catch ex As Exception
                MsgBox("Wrong Input")
            End Try
        ElseIf choice = 5 Then
            Try
                Com_AffInc_TblTableAdapter1.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, Date.Now)
                Com_AffInc_TblTableAdapter1.Fill(OfficeDataSet1.Com_AffInc_Tbl)
                Daily_TblTableAdapter.Insert(TextBox1.Text, "Affidavit Of Income", TextBox7.Text, TextBox8.Text, Date.Now)
                Daily_TblTableAdapter.Fill(OfficeDataSet1.Daily_Tbl)
                MsgBox("Success")
            Catch ex As Exception
                MsgBox("Wrong input")
            End Try
        Else
            MsgBox("Please choose document type")
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        SensitiveRecordsAdd.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Visible() = False
        TextBox2.Visible() = True
        Label2.Text = "Income:"
        choice = 5
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OpenFileDialog1.ShowDialog()
        TextBox8.Text = OpenFileDialog1.FileName
    End Sub
End Class