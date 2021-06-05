Public Class Order
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampilkan()
    End Sub
    Sub Tampilkan()
        clm = "menu,price"
        tbl = "tbl_menu"
        Tampil(clm, tbl)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.Add(1)
    End Sub
End Class