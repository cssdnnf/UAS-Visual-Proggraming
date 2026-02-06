Imports MySql.Data.MySqlClient

Public Class Form1

    ' --- FORM LOAD ---
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KonekDB()
    End Sub

    ' ==========================================
    ' BAGIAN 1: PENDAFTARAN MANUAL (TOMBOL POLI)
    ' ==========================================
    Private Sub ProsesDaftarManual(namaPoli As String)
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            ' 1. Ambil ID Poli berdasarkan Nama Tombol yang diklik
            Dim idPoli As Integer
            CMD = New MySqlCommand("SELECT id_poli FROM tb_poli WHERE nama_poli='" & namaPoli & "'", Conn)
            Dim hasil = CMD.ExecuteScalar()

            If hasil Is Nothing Then
                MsgBox("Error: Poli '" & namaPoli & "' belum terdaftar di database!")
                Exit Sub
            End If
            idPoli = Convert.ToInt32(hasil)

            ' 2. Generate Nomor Antrian
            Dim kodeDepan As String = namaPoli.Substring(5, 1)
            Dim noAntrian As String = kodeDepan & "-" & Format(Now, "HHmm")

            ' 3. Ambil Keluhan dari Textbox (Jika ada)
            ' Walaupun manual, jika admin sudah ngetik keluhan, kita simpan juga.
            Dim keluhanSimpan As String = TxtInputKeluhan.Text
            If keluhanSimpan = "" Then keluhanSimpan = "-" ' Isi strip jika kosong

            ' 4. Simpan ke Database
            Dim query As String = "INSERT INTO tb_transaksi (no_antrian, id_poli, tgl_berobat, status, keluhan) " &
                                  "VALUES (@no, @idp, @tgl, 'Menunggu', @kel); SELECT LAST_INSERT_ID();"

            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@no", noAntrian)
            CMD.Parameters.AddWithValue("@idp", idPoli)
            CMD.Parameters.AddWithValue("@tgl", Now.Date)
            CMD.Parameters.AddWithValue("@kel", keluhanSimpan) ' Keluhan ikut disimpan

            GlobalIDTransaksi = Convert.ToInt32(CMD.ExecuteScalar())

            MsgBox("Pendaftaran MANUAL Berhasil!" & vbCrLf &
                   "Tujuan: " & namaPoli & vbCrLf &
                   "Nomor Antrian: " & noAntrian)

            Form2.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Terjadi Kesalahan Manual: " & ex.Message)
        End Try
    End Sub

    ' ==========================================
    ' BAGIAN 2: PENDAFTARAN OTOMATIS (BY KELUHAN)
    ' ==========================================

    ' Fungsi Bantu untuk mencari Poli ID dari kata kunci keluhan
    Private Function CariPoliOtomatis(keluhan As String) As Integer
        Dim idPoliDitemukan As Integer = 0
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            ' Mencari poli berdasarkan kata kunci yang cocok di kamus penyakit
            Dim query As String = "SELECT id_poli FROM tb_kamus_penyakit " &
                                  "WHERE @keluhan LIKE CONCAT('%', kata_kunci, '%') LIMIT 1"
            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@keluhan", keluhan)
            Dim hasil = CMD.ExecuteScalar()

            If hasil IsNot Nothing Then
                idPoliDitemukan = Convert.ToInt32(hasil)
            End If
        Catch ex As Exception
        End Try
        Return idPoliDitemukan
    End Function

    Private Sub ProsesDaftarSmart()
        Try
            Dim keluhanAwal As String = TxtInputKeluhan.Text
            If keluhanAwal = "" Then
                MsgBox("Harap isi kolom keluhan terlebih dahulu untuk fitur otomatis!")
                Exit Sub
            End If

            ' 1. Cari Poli secara otomatis
            Dim targetIdPoli As Integer = CariPoliOtomatis(keluhanAwal)

            ' JIKA GAGAL MENEMUKAN POLI YANG COCOK
            If targetIdPoli = 0 Then
                MsgBox("Sistem tidak dapat mendeteksi Poli yang tepat secara otomatis." & vbCrLf &
                       "Silahkan pilih Tombol Poli secara Manual di bawah.")
                Exit Sub
            End If

            ' 2. Ambil Nama Poli untuk Kode Antrian
            CMD = New MySqlCommand("SELECT nama_poli FROM tb_poli WHERE id_poli=" & targetIdPoli, Conn)
            Dim namaPoli As String = CMD.ExecuteScalar().ToString()
            Dim kodeDepan As String = namaPoli.Substring(5, 1)
            Dim noAntrian As String = kodeDepan & "-" & Format(Now, "HHmm")

            ' 3. Simpan
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Dim query As String = "INSERT INTO tb_transaksi (no_antrian, id_poli, tgl_berobat, status, keluhan) " &
                                  "VALUES (@no, @idp, @tgl, 'Menunggu', @kel); SELECT LAST_INSERT_ID();"

            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@no", noAntrian)
            CMD.Parameters.AddWithValue("@idp", targetIdPoli)
            CMD.Parameters.AddWithValue("@tgl", Now.Date)
            CMD.Parameters.AddWithValue("@kel", keluhanAwal)

            GlobalIDTransaksi = Convert.ToInt32(CMD.ExecuteScalar())

            MsgBox("Pendaftaran OTOMATIS Berhasil!" & vbCrLf &
                   "Sistem Mendiagnosa ke: " & namaPoli & vbCrLf &
                   "Nomor Antrian: " & noAntrian)

            Form2.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Terjadi Kesalahan Auto: " & ex.Message)
        End Try
    End Sub

    ' ==========================================
    ' BAGIAN 3: EVENT TOMBOL (ACTIONS)
    ' ==========================================

    ' Tombol DAFTAR OTOMATIS (Pastikan kamu sudah buat tombol ini di Form)
    Private Sub BtnDaftarAuto_Click(sender As Object, e As EventArgs) Handles BtnDaftarAuto.Click
        ProsesDaftarSmart()
    End Sub

    ' --- TOMBOL MANUAL (TETAP ADA) ---
    ' PENTING: Semua tombol ini memanggil ProsesDaftarManual

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProsesDaftarManual("Poli Anak")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProsesDaftarManual("Poli Umum")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ProsesDaftarManual("Poli Jantung")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ProsesDaftarManual("Poli Gigi")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ProsesDaftarManual("Poli THT")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ProsesDaftarManual("Poli Mata")
    End Sub


    ' --- Timer Jam (Tetap) ---
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim idnTime As New System.Globalization.CultureInfo("id-ID")
        lblJam.Text = DateTime.Now.ToString("HH:mm:ss")
        lblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", idnTime)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BtnDaftarAuto_Click_1(sender As Object, e As EventArgs) Handles BtnDaftarAuto.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Opsional: Bisa tambahkan validasi password sederhana
        Dim pass As String = InputBox("Masukkan Password Admin: admin123", "Keamanan")
        If pass = "admin123" Then ' Ganti password sesuai keinginan
            Form4.Show()
            ' Me.Hide() ' Hilangkan tanda kutip jika ingin Form1 tertutup
        Else
            MsgBox("Password Salah!")
        End If
    End Sub
End Class