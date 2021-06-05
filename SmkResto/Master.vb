Public Class Master
    Sub SP(ByVal p As Form)
        PnlContent.Controls.Clear()
        p.TopLevel = False
        PnlContent.Controls.Add(p)
        p.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        BtnDashboard.BackColor = Color.FromArgb(101, 52, 172)
        SP(Dashboard)
    End Sub

    Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles BtnDashboard.Leave
        BtnDashboard.BackColor = Color.FromArgb(25, 33, 53)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnEmployee.Click
        BtnEmployee.BackColor = Color.FromArgb(101, 52, 172)
        SP(ManageEmployee)
        ManageEmployee.kosongkan
    End Sub

    Private Sub Button2_Leave(sender As Object, e As EventArgs) Handles BtnEmployee.Leave
        BtnEmployee.BackColor = Color.FromArgb(25, 33, 53)
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        BtnLogout.BackColor = Color.FromArgb(101, 52, 172)
        SP(Logout)
    End Sub


    Private Sub BtnLogout_Leave(sender As Object, e As EventArgs) Handles BtnLogout.Leave
        BtnLogout.BackColor = Color.FromArgb(25, 33, 53)
    End Sub

    Private Sub BtnMember_Click(sender As Object, e As EventArgs) Handles BtnMember.Click
        SP(Managemember)
        Managemember.kosongkan
        BtnMember.BackColor = Color.FromArgb(101, 52, 172)
    End Sub

    Private Sub BtnMember_Leave(sender As Object, e As EventArgs) Handles BtnMember.Leave
        BtnMember.BackColor = Color.FromArgb(25, 33, 53)
    End Sub

    Private Sub BtnMenu_Leave(sender As Object, e As EventArgs) Handles BtnMenu.Leave
        BtnMenu.BackColor = Color.FromArgb(25, 33, 53)
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        SP(ManageMenu)
        ManageMenu.kosongkan
        BtnMenu.BackColor = Color.FromArgb(101, 52, 172)
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click
        SP(Payment)
        BtnPayment.BackColor = Color.FromArgb(101, 52, 172)
    End Sub

    Private Sub BtnPayment_Leave(sender As Object, e As EventArgs) Handles BtnPayment.Leave
        BtnPayment.BackColor = Color.FromArgb(25, 33, 53)
    End Sub

    Private Sub BtnViewOrder_Leave(sender As Object, e As EventArgs) Handles BtnViewOrder.Leave

        BtnViewOrder.BackColor = Color.FromArgb(25, 33, 53)
    End Sub

    Private Sub BtnViewOrder_Click(sender As Object, e As EventArgs) Handles BtnViewOrder.Click
        BtnViewOrder.BackColor = Color.FromArgb(101, 52, 172)
        SP(ViewOrder)
    End Sub
    Private Sub BtnChngPwd_Click(sender As Object, e As EventArgs) Handles BtnChngPwd.Click
        BtnChngPwd.BackColor = Color.FromArgb(101, 52, 172)
        SP(ChngPwd)
        ChngPwd.kosongkan
    End Sub

    Private Sub BtnChngPwd_Leave(sender As Object, e As EventArgs) Handles BtnChngPwd.Leave
        BtnChngPwd.BackColor = Color.FromArgb(25, 33, 53)
    End Sub

    Private Sub Master_Load(sender As Object, e As EventArgs) Handles Me.Load
        SP(Dashboard)
    End Sub


    Sub Admin()
        BtnEmployee.Visible = True
        BtnMember.Visible = True
        BtnMenu.Visible = True

    End Sub
    Sub Chef()
        BtnViewOrder.Visible = True
    End Sub
    Sub Cashier()
        BtnPayment.Visible = True
    End Sub

    Private Sub PnlContent_Paint(sender As Object, e As PaintEventArgs) Handles PnlContent.Paint

    End Sub
End Class