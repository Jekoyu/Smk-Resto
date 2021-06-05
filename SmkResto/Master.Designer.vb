<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnPayment = New System.Windows.Forms.Button()
        Me.BtnViewOrder = New System.Windows.Forms.Button()
        Me.BtnChngPwd = New System.Windows.Forms.Button()
        Me.BtnMember = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnEmployee = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 31)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMK Restaurant"
        '
        'PnlContent
        '
        Me.PnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContent.Location = New System.Drawing.Point(125, 31)
        Me.PnlContent.Name = "PnlContent"
        Me.PnlContent.Size = New System.Drawing.Size(1075, 769)
        Me.PnlContent.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.BtnPayment)
        Me.Panel1.Controls.Add(Me.BtnViewOrder)
        Me.Panel1.Controls.Add(Me.BtnChngPwd)
        Me.Panel1.Controls.Add(Me.BtnMember)
        Me.Panel1.Controls.Add(Me.BtnMenu)
        Me.Panel1.Controls.Add(Me.BtnEmployee)
        Me.Panel1.Controls.Add(Me.BtnDashboard)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 769)
        Me.Panel1.TabIndex = 3
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(0, 455)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(125, 65)
        Me.BtnLogout.TabIndex = 7
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnPayment
        '
        Me.BtnPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BtnPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPayment.FlatAppearance.BorderSize = 0
        Me.BtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPayment.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnPayment.ForeColor = System.Drawing.Color.White
        Me.BtnPayment.Location = New System.Drawing.Point(0, 390)
        Me.BtnPayment.Name = "BtnPayment"
        Me.BtnPayment.Size = New System.Drawing.Size(125, 65)
        Me.BtnPayment.TabIndex = 6
        Me.BtnPayment.Text = "Payment"
        Me.BtnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPayment.UseVisualStyleBackColor = False
        Me.BtnPayment.Visible = False
        '
        'BtnViewOrder
        '
        Me.BtnViewOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BtnViewOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnViewOrder.FlatAppearance.BorderSize = 0
        Me.BtnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewOrder.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnViewOrder.ForeColor = System.Drawing.Color.White
        Me.BtnViewOrder.Location = New System.Drawing.Point(0, 325)
        Me.BtnViewOrder.Name = "BtnViewOrder"
        Me.BtnViewOrder.Size = New System.Drawing.Size(125, 65)
        Me.BtnViewOrder.TabIndex = 5
        Me.BtnViewOrder.Text = "View Order"
        Me.BtnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnViewOrder.UseVisualStyleBackColor = False
        Me.BtnViewOrder.Visible = False
        '
        'BtnChngPwd
        '
        Me.BtnChngPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BtnChngPwd.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnChngPwd.FlatAppearance.BorderSize = 0
        Me.BtnChngPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChngPwd.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnChngPwd.ForeColor = System.Drawing.Color.White
        Me.BtnChngPwd.Location = New System.Drawing.Point(0, 260)
        Me.BtnChngPwd.Name = "BtnChngPwd"
        Me.BtnChngPwd.Size = New System.Drawing.Size(125, 65)
        Me.BtnChngPwd.TabIndex = 4
        Me.BtnChngPwd.Text = "Change Password"
        Me.BtnChngPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChngPwd.UseVisualStyleBackColor = False
        '
        'BtnMember
        '
        Me.BtnMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BtnMember.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMember.FlatAppearance.BorderSize = 0
        Me.BtnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMember.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnMember.ForeColor = System.Drawing.Color.White
        Me.BtnMember.Location = New System.Drawing.Point(0, 195)
        Me.BtnMember.Name = "BtnMember"
        Me.BtnMember.Size = New System.Drawing.Size(125, 65)
        Me.BtnMember.TabIndex = 3
        Me.BtnMember.Text = "Manage Member"
        Me.BtnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMember.UseVisualStyleBackColor = False
        Me.BtnMember.Visible = False
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BtnMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMenu.FlatAppearance.BorderSize = 0
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnMenu.ForeColor = System.Drawing.Color.White
        Me.BtnMenu.Location = New System.Drawing.Point(0, 130)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(125, 65)
        Me.BtnMenu.TabIndex = 2
        Me.BtnMenu.Text = "Manage Menu"
        Me.BtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMenu.UseVisualStyleBackColor = False
        Me.BtnMenu.Visible = False
        '
        'BtnEmployee
        '
        Me.BtnEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BtnEmployee.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmployee.FlatAppearance.BorderSize = 0
        Me.BtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmployee.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnEmployee.ForeColor = System.Drawing.Color.White
        Me.BtnEmployee.Location = New System.Drawing.Point(0, 65)
        Me.BtnEmployee.Name = "BtnEmployee"
        Me.BtnEmployee.Size = New System.Drawing.Size(125, 65)
        Me.BtnEmployee.TabIndex = 1
        Me.BtnEmployee.Text = "Manage Employee"
        Me.BtnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmployee.UseVisualStyleBackColor = False
        Me.BtnEmployee.Visible = False
        '
        'BtnDashboard
        '
        Me.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashboard.FlatAppearance.BorderSize = 0
        Me.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(125, 65)
        Me.BtnDashboard.TabIndex = 0
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.UseVisualStyleBackColor = False
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.PnlContent)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlContent As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents BtnViewOrder As Button
    Friend WithEvents BtnChngPwd As Button
    Friend WithEvents BtnMember As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnEmployee As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnPayment As Button
End Class
