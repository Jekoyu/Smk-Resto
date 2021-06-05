Public Class Managemember
    Sub Id()
        q = "select * from tb_member order by id desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "MBR" + Format(Microsoft.VisualBasic.Right(dr.Item("id"), 6) + 1, "000000")
        Else
            TbId.Text = "MBR0000001"
        End If
    End Sub
    Sub Tampilkan()
        clm = "id,name,email,telp,joindate"
        tbl = "tb_member"
        Tampil(clm, tbl)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Managemember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()
    End Sub
    Sub Kosongkan()
        Id()
        Tampilkan()
        TbName.Clear()
        TbEmail.Clear()
        TbTelp.Clear()
    End Sub
    Sub insert()
        q = "select * from tb_member where id = '" & TbId.Text & "'"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_member set name ='" & TbName.Text & "',email = '" & TbEmail.Text & "',telp = '" & TbTelp.Text & "' where id = '" & TbId.Text & "'"




        End If
    End Sub

    Private Sub TbTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbTelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TbInsert_Click(sender As Object, e As EventArgs) Handles TbInsert.Click

    End Sub
End Class