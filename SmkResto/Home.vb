Public Class Home
    Dim pwd
    Dim id

    Sub Login()
        pwd = md5(TbPwd.Text)
        q = "select * from tb_employee where email = '" & TbUsername.Text & "' and password = '" & pwd & "'"
        Cari(q)
        If dr.HasRows Then
            role = dr.Item("role")
            iduser = dr.Item("id")
            If role = "cashier" Then
                Master.Cashier()
                Master.Show()
                Dashboard.LblNama.Text = dr.Item("name")
                Me.Visible = False
            ElseIf role = "chef" Then
                Master.Chef()
                Master.Show()
                Dashboard.LblNama.Text = dr.Item("name")
                Me.Visible = False
            ElseIf role = "admin" Then
                Master.Admin()
                Master.Show()
                Dashboard.LblNama.Text = dr.Item("name")
                Me.Visible = False
            End If
        Else
            MsgBox("Username/Password Salah")
            Kosongkan()
        End If
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan

    End Sub
    Sub Kosongkan()
        TbUsername.Clear()
        TbPwd.Clear()
        TbPwd.PasswordChar = "*"

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TbPwd.Text = "" Or TbUsername.Text = "" Then
            MsgBox("Data Tidak Lengkap", MsgBoxStyle.Critical)
        Else
            Try
                Login()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Class