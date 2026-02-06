Imports MySql.Data.MySqlClient

Module ModulKoneksi
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter

    Public GlobalIDTransaksi As Integer

    Public Sub KonekDB()
        Try
            Dim strConn As String = "Server=sql.freedb.tech;Database=freedb_db_uasvpro;Uid=freedb_db_uasvpro;Pwd=7@Dmn7PuCDKc$YN;"
            Conn = New MySqlConnection(strConn)
            If Conn.State = ConnectionState.Closed Then Conn.Open()
        Catch ex As Exception
            MsgBox("Gagal Konek Database: " & ex.Message)
        End Try
    End Sub
End Module