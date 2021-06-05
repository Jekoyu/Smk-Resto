Public Class Repor
    Sub CustomDTP()
        DTPF.Format = DateTimePickerFormat.Custom
        DTPF.CustomFormat = "MM yyyy"
        DTPT.Format = DateTimePickerFormat.Custom
        DTPT.CustomFormat = "MM yyyy"
    End Sub
    Private Sub Repor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class