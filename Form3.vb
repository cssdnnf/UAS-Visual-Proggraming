Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanTagihan()
    End Sub

    'Sub TampilkanTagihan()
    '    CMD = New MySqlCommand("SELECT * FROM tb_transaksi WHERE id_transaksi=" & GlobalIDTransaksi, Conn)
    '    RD = CMD.ExecuteReader
    '    If RD.Read Then
    '        LblDiagnosa.Text = "Diagnosa: " & RD("diagnosa")
    '        LblResep.Text = "Resep Obat: " & RD("resep_obat")
    '        LblTotalBiaya.Text = "Total Rp: " & FormatNumber(RD("total_biaya"), 0)
    '    End If
    '    RD.Close()
    'End Sub

    Sub TampilkanTagihan()
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            CMD = New MySqlCommand("SELECT * FROM tb_transaksi WHERE id_transaksi='" & GlobalIDTransaksi & "'", Conn)
            RD = CMD.ExecuteReader

            If RD.Read Then
                ' --- Data Lama ---
                ' Gunakan fungsi If(IsDBNull(...)) untuk mencegah error jika data kosong
                LblDiagnosa.Text = If(IsDBNull(RD("diagnosa")), "-", RD("diagnosa").ToString())
                LblResep.Text = If(IsDBNull(RD("resep_obat")), "-", RD("resep_obat").ToString())

                ' --- Data Baru (Perbaikan Handling Null) ---

                ' 1. Nama Pasien
                LblNamaPasien.Text = If(IsDBNull(RD("nama_pasien")), "Tanpa Nama", RD("nama_pasien").ToString())

                ' 2. Porsi Obat
                LblPorsiObat.Text = If(IsDBNull(RD("porsi_obat")), "-", RD("porsi_obat").ToString())

                ' 3. Rincian Biaya (Cek Null dulu baru convert ke Angka)
                Dim b_obat As Integer = 0
                If Not IsDBNull(RD("biaya_obat")) Then
                    b_obat = Val(RD("biaya_obat"))
                End If

                Dim b_dokter As Integer = 0
                If Not IsDBNull(RD("biaya_dokter")) Then
                    b_dokter = Val(RD("biaya_dokter"))
                End If

                LblBiayaObat.Text = FormatCurrency(b_obat, 0)
                LblBiayaDokter.Text = FormatCurrency(b_dokter, 0)

                ' 4. Total Biaya
                Dim total As Integer = b_obat + b_dokter
                LblTotalBiaya.Text = FormatCurrency(total, 0)

                ' 5. Status Rujukan
                Dim statusRujukan As String = If(IsDBNull(RD("status_rujukan")), "-", RD("status_rujukan").ToString())
                LblStatus.Text = statusRujukan

                ' Logika Warna Form 3
                If statusRujukan.Contains("PERLU RUJUKAN") Then
                    LblStatus.ForeColor = Color.Red
                    LblStatus.Font = New Font(LblStatus.Font, FontStyle.Bold) ' Tebalkan huruf
                ElseIf statusRujukan.Contains("KONTROL") Then
                    LblStatus.ForeColor = Color.OrangeRed
                Else
                    LblStatus.ForeColor = Color.Green
                End If

            End If
            RD.Close()
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data: " & ex.Message)
            If Not RD.IsClosed Then RD.Close()
        End Try
    End Sub


    'Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles BtnBayar.Click
    '    Try
    '        ' Update Status Lunas
    '        CMD = New MySqlCommand("UPDATE tb_transaksi SET status='Lunas' WHERE id_transaksi=" & GlobalIDTransaksi, Conn)
    '        CMD.ExecuteNonQuery()

    '        MsgBox("Pembayaran Berhasil! Obat dapat diambil. Terima kasih.")

    '        ' Reset aplikasi atau tutup
    '        Application.Exit()
    '    Catch ex As Exception
    '        MsgBox("Gagal Bayar")
    '    End Try
    'End Sub

    Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles BtnBayar.Click
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            ' Update Status Pembayaran menjadi Lunas
            ' Kolom 'status' disini adalah status pembayaran, BUKAN status rujukan
            CMD = New MySqlCommand("UPDATE tb_transaksi SET status='Lunas' WHERE id_transaksi='" & GlobalIDTransaksi & "'", Conn)
            CMD.ExecuteNonQuery()

            MsgBox("Pembayaran Berhasil! Obat dapat diambil. Terima kasih.")

            Application.Exit()
        Catch ex As Exception
            MsgBox("Gagal Bayar: " & ex.Message)
        End Try
    End Sub

End Class