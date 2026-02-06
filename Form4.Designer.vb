<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Panel1 = New Panel()
        Label1 = New Label()
        DgvData = New DataGridView()
        TxtNama = New TextBox()
        TxtKeluhan = New TextBox()
        TxtID = New TextBox()
        CmbPoli = New ComboBox()
        DtpTanggal = New DateTimePicker()
        CmbStatus = New ComboBox()
        BtnSimpan = New Button()
        BtnEdit = New Button()
        BtnHapus = New Button()
        BtnRefresh = New Button()
        TxtCari = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(DgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.HotTrack
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1209, 74)
        Panel1.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.HotTrack
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(405, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(423, 37)
        Label1.TabIndex = 0
        Label1.Text = "Selamat datang di Admin RSUD"
        ' 
        ' DgvData
        ' 
        DgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvData.Location = New Point(12, 208)
        DgvData.Name = "DgvData"
        DgvData.Size = New Size(1181, 230)
        DgvData.TabIndex = 12
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(118, 139)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(182, 23)
        TxtNama.TabIndex = 13
        ' 
        ' TxtKeluhan
        ' 
        TxtKeluhan.Location = New Point(306, 139)
        TxtKeluhan.Name = "TxtKeluhan"
        TxtKeluhan.Size = New Size(217, 23)
        TxtKeluhan.TabIndex = 14
        ' 
        ' TxtID
        ' 
        TxtID.Enabled = False
        TxtID.Location = New Point(12, 139)
        TxtID.Name = "TxtID"
        TxtID.Size = New Size(100, 23)
        TxtID.TabIndex = 15
        TxtID.Visible = False
        ' 
        ' CmbPoli
        ' 
        CmbPoli.FormattingEnabled = True
        CmbPoli.Location = New Point(529, 139)
        CmbPoli.Name = "CmbPoli"
        CmbPoli.Size = New Size(121, 23)
        CmbPoli.TabIndex = 16
        ' 
        ' DtpTanggal
        ' 
        DtpTanggal.Location = New Point(656, 139)
        DtpTanggal.Name = "DtpTanggal"
        DtpTanggal.Size = New Size(200, 23)
        DtpTanggal.TabIndex = 17
        ' 
        ' CmbStatus
        ' 
        CmbStatus.FormattingEnabled = True
        CmbStatus.Items.AddRange(New Object() {"Menunggu", "Diperiksa", "Lunas"})
        CmbStatus.Location = New Point(862, 139)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(121, 23)
        CmbStatus.TabIndex = 18
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(989, 139)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(112, 23)
        BtnSimpan.TabIndex = 19
        BtnSimpan.Text = "Simpan / Tambah"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' BtnEdit
        ' 
        BtnEdit.Location = New Point(989, 168)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(112, 23)
        BtnEdit.TabIndex = 20
        BtnEdit.Text = "Update / Edit"
        BtnEdit.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Location = New Point(1107, 139)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(75, 23)
        BtnHapus.TabIndex = 21
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.Location = New Point(1107, 168)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(75, 23)
        BtnRefresh.TabIndex = 22
        BtnRefresh.Text = "Refresh"
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' TxtCari
        ' 
        TxtCari.Font = New Font("Segoe UI", 12F)
        TxtCari.Location = New Point(862, 90)
        TxtCari.Name = "TxtCari"
        TxtCari.Size = New Size(320, 29)
        TxtCari.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(751, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 21)
        Label2.TabIndex = 24
        Label2.Text = "Search Pasien"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1203, 450)
        Controls.Add(Label2)
        Controls.Add(TxtCari)
        Controls.Add(BtnRefresh)
        Controls.Add(BtnHapus)
        Controls.Add(BtnEdit)
        Controls.Add(BtnSimpan)
        Controls.Add(CmbStatus)
        Controls.Add(DtpTanggal)
        Controls.Add(CmbPoli)
        Controls.Add(TxtID)
        Controls.Add(TxtKeluhan)
        Controls.Add(TxtNama)
        Controls.Add(DgvData)
        Controls.Add(Panel1)
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtKeluhan As TextBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents CmbPoli As ComboBox
    Friend WithEvents DtpTanggal As DateTimePicker
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Label2 As Label
End Class
