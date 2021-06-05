Public Class ChngPwd
    Private Sub ChngPwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TbCPwd.Text = TbNewPwd.Text Then

        Else
            MsgBox("Confirm Password tidak sama")
        End If
    End Sub
    Sub kosongkan()

    End Sub
End Class