Public Class ManageEmployee
    Dim pwd

    Sub Id()
        q = "select * from tb_employee order by id desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "STF" + Format(Microsoft.VisualBasic.Right(dr.Item("id"), 5) + 1, "00000")
        Else
            TbId.Text = "STF000001"
        End If
    End Sub
    Sub Tampilkan()
        clm = "id,name,email,telp,role"
        tbl = "tb_employee"
        Tampil(clm, tbl)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub ManageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Id()
        Tampilkan()
        Kosongkan()
        koneksi()

    End Sub
    Sub Kosongkan()
        TbName.Clear()
        TbEmail.Clear()
        TbTelp.Clear()
        TbPosition.ResetText()
        q = "select distinct role from tb_employee"
        data = "role"
        CB(TbPosition, q, data)

    End Sub
    Sub Insert()
        q = "select * from tb_employee where id = '" & TbId.Text & "'"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_employee set name ='" & TbEmail.Text & "',email = '" & TbEmail.Text & "',telp='" & TbTelp.Text & "',role = '" & TbPosition.Text & "' where id = '" & TbId.Text & "'"
            ENQ(q)
            Kosongkan()
        Else
            pwd = md5(TbTelp.Text)
            q = "insert into tb_employee('" & TbId.Text & "','" & TbName.Text & "','" & TbEmail.Text & "','" & pwd & "','" & TbTelp.Text & "','" & TbPosition.Text & "')"
            ENQ(q)
            Kosongkan()

        End If
    End Sub
    Sub Delete()

        q = "delete from tb_employee where id ='" & TbId.Text & "'"
        ENQ(q)

    End Sub
    Sub Combo()
        q = "select role from tb_employee"
        cmd = New SqlClient.SqlCommand(q, conn)
        dr = cmd.ExecuteReader
        TbPosition.ResetText()
        While dr.Read
            TbPosition.Items.Add(dr.Item(""))
        End While
    End Sub


    Private Sub TbTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbTelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Try
            Insert()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Dim r = MsgBox("Delete This??", vbYesNo)
            If r = vbYes Then
                Delete()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class