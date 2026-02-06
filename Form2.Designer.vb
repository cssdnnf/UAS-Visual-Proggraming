<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        LblNoAntrian = New Label()
        LblDokter = New Label()
        LblStatus = New Label()
        TxtDiagnosa = New TextBox()
        TxtResep = New TextBox()
        TxtBiaya = New TextBox()
        BtnPeriksa = New Button()
        GroupBox1 = New GroupBox()
        Label00 = New Label()
        TxtPorsi = New TextBox()
        TxtStatusRujukan = New TextBox()
        Label5 = New Label()
        LabelNull = New Label()
        Btn_SimpanMedis = New Button()
        Tampil_NamaPasien = New Label()
        Txt_NamaPasien = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label_Keluhan = New Label()
        TxtKeluhan = New TextBox()
        Label_Poli = New Label()
        Label_StatusAntrian = New Label()
        Label_NamaDokter = New Label()
        TxtNamaPasien = New TextBox()
        Label_NamaPasien = New Label()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.HotTrack
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(164, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 32)
        Label1.TabIndex = 0
        Label1.Text = "Selamat Datang di"
        ' 
        ' LblNoAntrian
        ' 
        LblNoAntrian.AutoSize = True
        LblNoAntrian.BackColor = SystemColors.Window
        LblNoAntrian.Font = New Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblNoAntrian.ForeColor = SystemColors.HotTrack
        LblNoAntrian.Location = New Point(231, 68)
        LblNoAntrian.Name = "LblNoAntrian"
        LblNoAntrian.Size = New Size(264, 86)
        LblNoAntrian.TabIndex = 2
        LblNoAntrian.Text = "antrian"
        ' 
        ' LblDokter
        ' 
        LblDokter.AutoSize = True
        LblDokter.BackColor = SystemColors.Window
        LblDokter.Font = New Font("Segoe UI", 14F)
        LblDokter.Location = New Point(174, 183)
        LblDokter.Name = "LblDokter"
        LblDokter.Size = New Size(66, 25)
        LblDokter.TabIndex = 3
        LblDokter.Text = "dokter"
        ' 
        ' LblStatus
        ' 
        LblStatus.AutoSize = True
        LblStatus.BackColor = SystemColors.Window
        LblStatus.Font = New Font("Segoe UI", 14F)
        LblStatus.Location = New Point(174, 216)
        LblStatus.Name = "LblStatus"
        LblStatus.Size = New Size(61, 25)
        LblStatus.TabIndex = 4
        LblStatus.Text = "status"
        ' 
        ' TxtDiagnosa
        ' 
        TxtDiagnosa.Font = New Font("Segoe UI", 14F)
        TxtDiagnosa.Location = New Point(176, 135)
        TxtDiagnosa.Name = "TxtDiagnosa"
        TxtDiagnosa.Size = New Size(418, 32)
        TxtDiagnosa.TabIndex = 5
        ' 
        ' TxtResep
        ' 
        TxtResep.Font = New Font("Segoe UI", 14F)
        TxtResep.Location = New Point(176, 181)
        TxtResep.Name = "TxtResep"
        TxtResep.Size = New Size(418, 32)
        TxtResep.TabIndex = 6
        ' 
        ' TxtBiaya
        ' 
        TxtBiaya.Font = New Font("Segoe UI", 14F)
        TxtBiaya.Location = New Point(176, 272)
        TxtBiaya.Name = "TxtBiaya"
        TxtBiaya.Size = New Size(418, 32)
        TxtBiaya.TabIndex = 7
        ' 
        ' BtnPeriksa
        ' 
        BtnPeriksa.BackColor = SystemColors.HotTrack
        BtnPeriksa.Cursor = Cursors.Hand
        BtnPeriksa.Font = New Font("Segoe UI", 14F)
        BtnPeriksa.ForeColor = SystemColors.Window
        BtnPeriksa.Location = New Point(517, 311)
        BtnPeriksa.Name = "BtnPeriksa"
        BtnPeriksa.Size = New Size(210, 40)
        BtnPeriksa.TabIndex = 8
        BtnPeriksa.Text = "Periksa"
        BtnPeriksa.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label00)
        GroupBox1.Controls.Add(TxtPorsi)
        GroupBox1.Controls.Add(TxtStatusRujukan)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(LabelNull)
        GroupBox1.Controls.Add(Btn_SimpanMedis)
        GroupBox1.Controls.Add(Tampil_NamaPasien)
        GroupBox1.Controls.Add(Txt_NamaPasien)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TxtDiagnosa)
        GroupBox1.Controls.Add(TxtResep)
        GroupBox1.Controls.Add(TxtBiaya)
        GroupBox1.Location = New Point(-2, 435)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(747, 438)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label00
        ' 
        Label00.AutoSize = True
        Label00.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label00.Location = New Point(22, 230)
        Label00.Name = "Label00"
        Label00.Size = New Size(89, 21)
        Label00.TabIndex = 26
        Label00.Text = "Porsi Obat"
        ' 
        ' TxtPorsi
        ' 
        TxtPorsi.Font = New Font("Segoe UI", 14F)
        TxtPorsi.Location = New Point(176, 224)
        TxtPorsi.Name = "TxtPorsi"
        TxtPorsi.Size = New Size(418, 32)
        TxtPorsi.TabIndex = 25
        ' 
        ' TxtStatusRujukan
        ' 
        TxtStatusRujukan.Font = New Font("Segoe UI", 14F)
        TxtStatusRujukan.Location = New Point(176, 338)
        TxtStatusRujukan.Name = "TxtStatusRujukan"
        TxtStatusRujukan.Size = New Size(418, 32)
        TxtStatusRujukan.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(25, 344)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 21)
        Label5.TabIndex = 23
        Label5.Text = "Status Pasien"
        ' 
        ' LabelNull
        ' 
        LabelNull.AutoSize = True
        LabelNull.BackColor = SystemColors.Window
        LabelNull.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelNull.ForeColor = SystemColors.HotTrack
        LabelNull.Location = New Point(201, 19)
        LabelNull.Name = "LabelNull"
        LabelNull.Size = New Size(364, 45)
        LabelNull.TabIndex = 22
        LabelNull.Text = "Informasi Dari Dokter"
        ' 
        ' Btn_SimpanMedis
        ' 
        Btn_SimpanMedis.BackColor = SystemColors.HotTrack
        Btn_SimpanMedis.Cursor = Cursors.Hand
        Btn_SimpanMedis.Font = New Font("Segoe UI", 14F)
        Btn_SimpanMedis.ForeColor = SystemColors.Window
        Btn_SimpanMedis.Location = New Point(517, 392)
        Btn_SimpanMedis.Name = "Btn_SimpanMedis"
        Btn_SimpanMedis.Size = New Size(210, 40)
        Btn_SimpanMedis.TabIndex = 13
        Btn_SimpanMedis.Text = "Simpan Medis"
        Btn_SimpanMedis.UseVisualStyleBackColor = False
        ' 
        ' Tampil_NamaPasien
        ' 
        Tampil_NamaPasien.AutoSize = True
        Tampil_NamaPasien.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Tampil_NamaPasien.Location = New Point(22, 93)
        Tampil_NamaPasien.Name = "Tampil_NamaPasien"
        Tampil_NamaPasien.Size = New Size(60, 21)
        Tampil_NamaPasien.TabIndex = 12
        Tampil_NamaPasien.Text = "Pasien"
        ' 
        ' Txt_NamaPasien
        ' 
        Txt_NamaPasien.Font = New Font("Segoe UI", 14F)
        Txt_NamaPasien.Location = New Point(176, 87)
        Txt_NamaPasien.Name = "Txt_NamaPasien"
        Txt_NamaPasien.Size = New Size(418, 32)
        Txt_NamaPasien.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(22, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 21)
        Label4.TabIndex = 10
        Label4.Text = "Biaya Obat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(22, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 21)
        Label3.TabIndex = 9
        Label3.Text = "Resep Obat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(22, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 21)
        Label2.TabIndex = 8
        Label2.Text = "Diagnosa"
        ' 
        ' Label_Keluhan
        ' 
        Label_Keluhan.AutoSize = True
        Label_Keluhan.BackColor = SystemColors.Window
        Label_Keluhan.Font = New Font("Segoe UI", 14F)
        Label_Keluhan.Location = New Point(17, 327)
        Label_Keluhan.Name = "Label_Keluhan"
        Label_Keluhan.Size = New Size(140, 25)
        Label_Keluhan.TabIndex = 11
        Label_Keluhan.Text = "Keluhan Pasien"
        ' 
        ' TxtKeluhan
        ' 
        TxtKeluhan.BackColor = SystemColors.Control
        TxtKeluhan.Cursor = Cursors.IBeam
        TxtKeluhan.Font = New Font("Segoe UI", 14F)
        TxtKeluhan.Location = New Point(174, 324)
        TxtKeluhan.Name = "TxtKeluhan"
        TxtKeluhan.Size = New Size(418, 32)
        TxtKeluhan.TabIndex = 12
        ' 
        ' Label_Poli
        ' 
        Label_Poli.AutoSize = True
        Label_Poli.BackColor = SystemColors.HotTrack
        Label_Poli.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label_Poli.ForeColor = SystemColors.Window
        Label_Poli.Location = New Point(383, 17)
        Label_Poli.Name = "Label_Poli"
        Label_Poli.Size = New Size(234, 32)
        Label_Poli.TabIndex = 13
        Label_Poli.Text = "Nama Polikliniknya"
        ' 
        ' Label_StatusAntrian
        ' 
        Label_StatusAntrian.AutoSize = True
        Label_StatusAntrian.BackColor = SystemColors.Window
        Label_StatusAntrian.Font = New Font("Segoe UI", 14F)
        Label_StatusAntrian.Location = New Point(17, 216)
        Label_StatusAntrian.Name = "Label_StatusAntrian"
        Label_StatusAntrian.Size = New Size(141, 25)
        Label_StatusAntrian.TabIndex = 16
        Label_StatusAntrian.Text = "Status               :"
        ' 
        ' Label_NamaDokter
        ' 
        Label_NamaDokter.AutoSize = True
        Label_NamaDokter.BackColor = SystemColors.Window
        Label_NamaDokter.Font = New Font("Segoe UI", 14F)
        Label_NamaDokter.Location = New Point(17, 183)
        Label_NamaDokter.Name = "Label_NamaDokter"
        Label_NamaDokter.Size = New Size(142, 25)
        Label_NamaDokter.TabIndex = 15
        Label_NamaDokter.Text = "Nama Dokter   :"
        ' 
        ' TxtNamaPasien
        ' 
        TxtNamaPasien.BackColor = SystemColors.Control
        TxtNamaPasien.Cursor = Cursors.IBeam
        TxtNamaPasien.Font = New Font("Segoe UI", 14F)
        TxtNamaPasien.Location = New Point(174, 280)
        TxtNamaPasien.Name = "TxtNamaPasien"
        TxtNamaPasien.Size = New Size(418, 32)
        TxtNamaPasien.TabIndex = 18
        ' 
        ' Label_NamaPasien
        ' 
        Label_NamaPasien.AutoSize = True
        Label_NamaPasien.BackColor = SystemColors.Window
        Label_NamaPasien.Font = New Font("Segoe UI", 14F)
        Label_NamaPasien.Location = New Point(17, 283)
        Label_NamaPasien.Name = "Label_NamaPasien"
        Label_NamaPasien.Size = New Size(121, 25)
        Label_NamaPasien.TabIndex = 17
        Label_NamaPasien.Text = "Nama Pasien"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.HotTrack
        Panel1.Location = New Point(-2, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(747, 67)
        Panel1.TabIndex = 19
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Window
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(BtnPeriksa)
        Panel3.Location = New Point(-2, 66)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(747, 363)
        Panel3.TabIndex = 21
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.HotTrack
        Panel4.Location = New Point(25, 191)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(702, 10)
        Panel4.TabIndex = 20
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(749, 885)
        Controls.Add(TxtNamaPasien)
        Controls.Add(Label_NamaPasien)
        Controls.Add(Label_StatusAntrian)
        Controls.Add(Label_NamaDokter)
        Controls.Add(Label_Poli)
        Controls.Add(TxtKeluhan)
        Controls.Add(Label_Keluhan)
        Controls.Add(GroupBox1)
        Controls.Add(LblStatus)
        Controls.Add(LblDokter)
        Controls.Add(LblNoAntrian)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Name = "Form2"
        Text = "Antrian"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblNoAntrian As Label
    Friend WithEvents LblDokter As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents TxtDiagnosa As TextBox
    Friend WithEvents TxtResep As TextBox
    Friend WithEvents TxtBiaya As TextBox
    Friend WithEvents BtnPeriksa As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_Keluhan As Label
    Friend WithEvents TxtKeluhan As TextBox
    Friend WithEvents Label_Poli As Label
    Friend WithEvents Label_StatusAntrian As Label
    Friend WithEvents Label_NamaDokter As Label
    Friend WithEvents TxtNamaPasien As TextBox
    Friend WithEvents Label_NamaPasien As Label
    Friend WithEvents Tampil_NamaPasien As Label
    Friend WithEvents Txt_NamaPasien As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_SimpanMedis As Button
    Friend WithEvents LabelNull As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label00 As Label
    Friend WithEvents TxtPorsi As TextBox
    Friend WithEvents TxtStatusRujukan As TextBox
End Class
