Imports System.Data.SqlClient
Module Control
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public iduser
    Public data, pwd, clm, tbl, role, q As String

    Public Function md5(pwd As String) As String
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(pwd)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Sub koneksi()
        Try
            q = "Data Source=DESKTOP-VOQEHKC\SQLEXPRESS;Initial Catalog=db_smkresto;Integrated Security=True;MultipleActiveResultSets=True"
            conn = New SqlConnection(q)
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ENQ(ByVal q As String) As Boolean
        Try
            koneksi()
            cmd = New SqlCommand(q, conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

    Public Function Cari(ByVal q As String) As Boolean
        Try
            koneksi()
            cmd = New SqlCommand(q, conn)
            dr = cmd.ExecuteReader
            dr.Read()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return True
    End Function
    Public Function Tampil(ByVal clm As String, tbl As String) As Boolean
        Try
            koneksi()
            da = New SqlDataAdapter("select " + clm + " from " + tbl, conn)
            ds = New DataSet
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
    Public Function CB(ByVal Combo As ComboBox, q As String, data As String) As Boolean
        Try
            koneksi()
            cmd = New SqlCommand(q, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Combo.Items.Add(dr.Item(data))
            End While
        Catch ex As Exception

        End Try
        Return True
    End Function
End Module
