Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Form2

    Dim BiayaJasaDokter As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        Txt_NamaPasien.Enabled = False

        TampilkanInfo()
    End Sub

    ' --- BAGIAN LOAD DATA (Updated) ---
    Sub TampilkanInfo()
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            ' Join tabel untuk mengambil nama poli dan dokter
            Dim query As String = "SELECT t.*, p.nama_poli, p.nama_dokter, p.biaya_jasa " &
                                  "FROM tb_transaksi t " &
                                  "JOIN tb_poli p ON t.id_poli = p.id_poli " &
                                  "WHERE t.id_transaksi = @id"

            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@id", GlobalIDTransaksi)
            RD = CMD.ExecuteReader

            If RD.Read() Then
                Label_Poli.Text = RD("nama_poli").ToString()
                LblNoAntrian.Text = RD("no_antrian").ToString()
                LblDokter.Text = RD("nama_dokter").ToString()
                LblStatus.Text = RD("status").ToString()

                ' Load Keluhan yang diinput saat pendaftaran
                TxtKeluhan.Text = RD("keluhan").ToString()

                ' Load Nama Pasien (jika pasien lama/sudah ada data)
                TxtNamaPasien.Text = If(IsDBNull(RD("nama_pasien")), "", RD("nama_pasien").ToString())

                BiayaJasaDokter = Val(RD("biaya_jasa"))
            End If
            RD.Close()
        Catch ex As Exception
            MsgBox("Gagal Load Data: " & ex.Message)
        End Try
    End Sub

    ' --- BAGIAN TOMBOL PERIKSA (Sedikit penyesuaian query) ---
    Private Sub BtnPeriksa_Click(sender As Object, e As EventArgs) Handles BtnPeriksa.Click
        LblStatus.Text = "Menganalisa Gejala..."

        If TxtNamaPasien.Text = "" Or TxtKeluhan.Text = "" Then
            MsgBox("Mohon lengkapi Nama Pasien dan Keluhan!")
            Exit Sub
        End If

        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            Txt_NamaPasien.Text = TxtNamaPasien.Text

            ' Query Auto-Diagnosa (Tidak berubah banyak, tapi pastikan field sesuai DB)
            Dim query = "SELECT * FROM tb_kamus_penyakit WHERE @keluhan LIKE CONCAT('%', kata_kunci, '%') LIMIT 1"

            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@keluhan", TxtKeluhan.Text)
            RD = CMD.ExecuteReader

            If RD.Read Then
                TxtDiagnosa.Text = RD("diagnosa_otomatis").ToString()
                TxtResep.Text = RD("resep_otomatis").ToString()
                TxtBiaya.Text = RD("harga_obat_estimasi").ToString()
                TxtPorsi.Text = RD("porsi_standar").ToString()

                Dim keparahan As String = RD("tingkat_keparahan").ToString()

                ' Logika Rujukan
                If keparahan = "Berat" Then
                    TxtStatusRujukan.Text = "PERLU RUJUKAN (IGD/SPESIALIS)"
                    TxtStatusRujukan.BackColor = Color.Red
                    TxtStatusRujukan.ForeColor = Color.White
                    MsgBox("PERINGATAN: Penyakit tergolong BERAT. Disarankan Rujukan.")
                ElseIf keparahan = "Sedang" Then
                    TxtStatusRujukan.Text = "KONTROL ULANG 3 HARI"
                    TxtStatusRujukan.BackColor = Color.Yellow
                    TxtStatusRujukan.ForeColor = Color.Black
                Else
                    TxtStatusRujukan.Text = "RAWAT JALAN (SELESAI)"
                    TxtStatusRujukan.BackColor = Color.LightGreen
                    TxtStatusRujukan.ForeColor = Color.Black
                End If

                MsgBox("Diagnosa AI Ditemukan: " & TxtDiagnosa.Text)
            Else
                ' Fallback jika tidak ditemukan
                TxtDiagnosa.Text = "Observasi Manual Dokter"
                TxtResep.Text = "-"
                TxtPorsi.Text = "-"
                TxtBiaya.Text = "0"
                TxtStatusRujukan.Text = "KONSULTASI DOKTER"
                MsgBox("Data penyakit tidak ditemukan di database.")
            End If
            RD.Close()
            GroupBox1.Enabled = True ' Buka kunci form simpan

        Catch ex As Exception
            MsgBox("Error Auto-Check: " & ex.Message)
            If Not RD.IsClosed Then RD.Close()
        End Try
    End Sub


    ' --- TOMBOL SIMPAN MEDIS ---
    Private Sub Btn_SimpanMedis_Click(sender As Object, e As EventArgs) Handles Btn_SimpanMedis.Click
        Try
            Dim HargaObat As Integer = 0
            If IsNumeric(TxtBiaya.Text) Then HargaObat = Integer.Parse(TxtBiaya.Text)

            Dim TotalBayar As Integer = HargaObat + BiayaJasaDokter

            Dim query As String = "UPDATE tb_transaksi SET " &
                                  "nama_pasien=@nama, keluhan=@kel, diagnosa=@diag, " &
                                  "resep_obat=@resep, porsi_obat=@porsi, " &
                                  "biaya_obat=@bobat, biaya_dokter=@bdokter, " &
                                  "status_rujukan=@rujuk, total_biaya=@total, " &
                                  "status='Selesai Periksa' " &
                                  "WHERE id_transaksi=@id"

            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@nama", TxtNamaPasien.Text)
            CMD.Parameters.AddWithValue("@kel", TxtKeluhan.Text)
            CMD.Parameters.AddWithValue("@diag", TxtDiagnosa.Text)
            CMD.Parameters.AddWithValue("@resep", TxtResep.Text)

            CMD.Parameters.AddWithValue("@porsi", TxtPorsi.Text)
            CMD.Parameters.AddWithValue("@rujuk", TxtStatusRujukan.Text)

            CMD.Parameters.AddWithValue("@bobat", HargaObat)
            CMD.Parameters.AddWithValue("@bdokter", BiayaJasaDokter)
            CMD.Parameters.AddWithValue("@total", TotalBayar)
            CMD.Parameters.AddWithValue("@id", GlobalIDTransaksi)

            CMD.ExecuteNonQuery()

            MsgBox("Rekam Medis Tersimpan." & vbCrLf & "Status: " & TxtStatusRujukan.Text)

            Form3.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtStatusRujukan_TextChanged(sender As Object, e As EventArgs) Handles TxtStatusRujukan.TextChanged

    End Sub

    Private Sub LblNoAntrian_Click(sender As Object, e As EventArgs) Handles LblNoAntrian.Click

    End Sub

    Private Sub Txt_NamaPasien_TextChanged(sender As Object, e As EventArgs) Handles Txt_NamaPasien.TextChanged

    End Sub
End Class