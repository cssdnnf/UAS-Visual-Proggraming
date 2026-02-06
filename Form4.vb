Imports MySql.Data.MySqlClient

Public Class Form4

    ' --- 1. SAAT FORM DIBUKA ---
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
        IsiComboPoli()
        AturGrid()
    End Sub

    ' --- 2. TAMPILKAN DATA (READ) ---
    Sub TampilkanData()
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            ' Kita JOIN dengan tb_poli agar yang muncul Nama Polinya, bukan angkanya
            Dim query As String = "SELECT t.id_transaksi, t.no_antrian, t.nama_pasien, " &
                                  "p.nama_poli, t.tgl_berobat, t.status, t.keluhan, t.total_biaya " &
                                  "FROM tb_transaksi t " &
                                  "JOIN tb_poli p ON t.id_poli = p.id_poli " &
                                  "ORDER BY t.id_transaksi DESC"

            DA = New MySqlDataAdapter(query, Conn)
            Dim DS As New DataSet
            DA.Fill(DS, "tb_transaksi")
            DgvData.DataSource = DS.Tables("tb_transaksi")
        Catch ex As Exception
            MsgBox("Gagal Tampil Data: " & ex.Message)
        End Try
    End Sub

    Sub AturGrid()
        ' Merapikan tampilan Grid
        DgvData.Columns(0).HeaderText = "ID"
        DgvData.Columns(1).HeaderText = "No Antrian"
        DgvData.Columns(2).HeaderText = "Nama Pasien"
        DgvData.Columns(3).HeaderText = "Poli Tujuan"
        DgvData.Columns(4).HeaderText = "Tanggal"
        DgvData.Columns(6).HeaderText = "Keluhan"

        DgvData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
    End Sub

    ' --- 3. ISI COMBOBOX POLI (Otomatis dari Database) ---
    Sub IsiComboPoli()
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            CMD = New MySqlCommand("SELECT * FROM tb_poli", Conn)
            RD = CMD.ExecuteReader
            CmbPoli.Items.Clear()

            ' Kita pakai Dictionary atau cara manual simpel agar bisa ambil ID-nya
            ' Disini kita isi nama poli saja, nanti pas simpan kita cari ID nya
            While RD.Read
                CmbPoli.Items.Add(RD("nama_poli"))
            End While
            RD.Close()
        Catch ex As Exception
            MsgBox("Gagal Load Poli")
        End Try
    End Sub

    ' --- FUNGSI BANTUAN: Ambil ID Poli berdasarkan Nama ---
    Function AmbilIDPoli(namaPoli As String) As Integer
        Dim id As Integer = 2 ' Default Umum
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Dim cmdCek As New MySqlCommand("SELECT id_poli FROM tb_poli WHERE nama_poli='" & namaPoli & "'", Conn)
            id = Convert.ToInt32(cmdCek.ExecuteScalar())
        Catch ex As Exception
        End Try
        Return id
    End Function

    ' --- 4. TOMBOL SIMPAN (CREATE) ---
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtNama.Text = "" Or CmbPoli.Text = "" Then
            MsgBox("Data Belum Lengkap!")
            Exit Sub
        End If

        Try
            Dim idPoli As Integer = AmbilIDPoli(CmbPoli.Text)
            Dim noAntri As String = "A-" & Format(Now, "HHmmss") ' Generate No Antrian Admin

            Dim query As String = "INSERT INTO tb_transaksi (no_antrian, nama_pasien, id_poli, tgl_berobat, status, keluhan) " &
                                  "VALUES (@no, @nama, @idp, @tgl, @stat, @kel)"

            If Conn.State = ConnectionState.Closed Then Conn.Open()
            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@no", noAntri)
            CMD.Parameters.AddWithValue("@nama", TxtNama.Text)
            CMD.Parameters.AddWithValue("@idp", idPoli)
            CMD.Parameters.AddWithValue("@tgl", DtpTanggal.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("@stat", CmbStatus.Text)
            CMD.Parameters.AddWithValue("@kel", TxtKeluhan.Text)

            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!")
            TampilkanData()
            Bersihkan()
        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        End Try
    End Sub

    ' --- 5. KLIK TABEL (Isi Form untuk Edit) ---
    Private Sub DgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvData.CellClick
        Try
            Dim row As DataGridViewRow = DgvData.Rows(e.RowIndex)
            TxtID.Text = row.Cells(0).Value.ToString()
            TxtNama.Text = row.Cells(2).Value.ToString()
            CmbPoli.Text = row.Cells(3).Value.ToString()
            DtpTanggal.Value = Convert.ToDateTime(row.Cells(4).Value)
            CmbStatus.Text = row.Cells(5).Value.ToString()
            TxtKeluhan.Text = row.Cells(6).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub

    ' --- 6. TOMBOL EDIT (UPDATE) ---
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If TxtID.Text = "" Then
            MsgBox("Pilih data dari tabel dulu!")
            Exit Sub
        End If

        Try
            Dim idPoli As Integer = AmbilIDPoli(CmbPoli.Text)

            Dim query As String = "UPDATE tb_transaksi SET nama_pasien=@nama, id_poli=@idp, " &
                                  "tgl_berobat=@tgl, status=@stat, keluhan=@kel " &
                                  "WHERE id_transaksi=@id"

            If Conn.State = ConnectionState.Closed Then Conn.Open()
            CMD = New MySqlCommand(query, Conn)
            CMD.Parameters.AddWithValue("@nama", TxtNama.Text)
            CMD.Parameters.AddWithValue("@idp", idPoli)
            CMD.Parameters.AddWithValue("@tgl", DtpTanggal.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("@stat", CmbStatus.Text)
            CMD.Parameters.AddWithValue("@kel", TxtKeluhan.Text)
            CMD.Parameters.AddWithValue("@id", TxtID.Text)

            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Diupdate!")
            TampilkanData()
            Bersihkan()
        Catch ex As Exception
            MsgBox("Gagal Update: " & ex.Message)
        End Try
    End Sub

    ' --- 7. TOMBOL HAPUS (DELETE) ---
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtID.Text = "" Then
            MsgBox("Pilih data yang akan dihapus!")
            Exit Sub
        End If

        If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM tb_transaksi WHERE id_transaksi=@id"
                If Conn.State = ConnectionState.Closed Then Conn.Open()
                CMD = New MySqlCommand(query, Conn)
                CMD.Parameters.AddWithValue("@id", TxtID.Text)
                CMD.ExecuteNonQuery()

                MsgBox("Data Dihapus.")
                TampilkanData()
                Bersihkan()
            Catch ex As Exception
                MsgBox("Gagal Hapus: " & ex.Message)
            End Try
        End If
    End Sub

    ' --- 8. SEARCH (PENCARIAN) ---
    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Try
            Dim query As String = "SELECT t.id_transaksi, t.no_antrian, t.nama_pasien, " &
                                  "p.nama_poli, t.tgl_berobat, t.status " &
                                  "FROM tb_transaksi t JOIN tb_poli p ON t.id_poli = p.id_poli " &
                                  "WHERE t.nama_pasien LIKE '%" & TxtCari.Text & "%' OR t.no_antrian LIKE '%" & TxtCari.Text & "%'"

            DA = New MySqlDataAdapter(query, Conn)
            Dim DS As New DataSet
            DA.Fill(DS, "tb_transaksi")
            DgvData.DataSource = DS.Tables("tb_transaksi")
        Catch ex As Exception
        End Try
    End Sub

    Sub Bersihkan()
        TxtID.Clear()
        TxtNama.Clear()
        TxtKeluhan.Clear()
        CmbPoli.Text = ""
        CmbStatus.Text = "Menunggu"
        DtpTanggal.Value = Now
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Bersihkan()
        TampilkanData()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class