<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        LblDiagnosa = New Label()
        LblResep = New Label()
        LblTotalBiaya = New Label()
        BtnBayar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        LblBiayaDokter = New Label()
        LblBiayaObat = New Label()
        LblPorsiObat = New Label()
        Label7 = New Label()
        LblStatus = New Label()
        Label9 = New Label()
        LblNamaPasien = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblDiagnosa
        ' 
        LblDiagnosa.AutoSize = True
        LblDiagnosa.Font = New Font("Segoe UI", 14F)
        LblDiagnosa.Location = New Point(195, 115)
        LblDiagnosa.Name = "LblDiagnosa"
        LblDiagnosa.Size = New Size(116, 25)
        LblDiagnosa.TabIndex = 0
        LblDiagnosa.Text = "LblDiagnosa"
        ' 
        ' LblResep
        ' 
        LblResep.AutoSize = True
        LblResep.Font = New Font("Segoe UI", 14F)
        LblResep.Location = New Point(195, 165)
        LblResep.Name = "LblResep"
        LblResep.Size = New Size(86, 25)
        LblResep.TabIndex = 1
        LblResep.Text = "LblResep"
        ' 
        ' LblTotalBiaya
        ' 
        LblTotalBiaya.AutoSize = True
        LblTotalBiaya.Font = New Font("Segoe UI", 14F)
        LblTotalBiaya.Location = New Point(195, 391)
        LblTotalBiaya.Name = "LblTotalBiaya"
        LblTotalBiaya.Size = New Size(122, 25)
        LblTotalBiaya.TabIndex = 2
        LblTotalBiaya.Text = "LblTotalBiaya"
        ' 
        ' BtnBayar
        ' 
        BtnBayar.Font = New Font("Segoe UI", 14F)
        BtnBayar.Location = New Point(566, 551)
        BtnBayar.Name = "BtnBayar"
        BtnBayar.Size = New Size(211, 41)
        BtnBayar.TabIndex = 3
        BtnBayar.Text = "Bayar"
        BtnBayar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(30, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 25)
        Label1.TabIndex = 4
        Label1.Text = "Diagnosa: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(30, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 25)
        Label2.TabIndex = 5
        Label2.Text = "Resep Obat: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F)
        Label3.Location = New Point(30, 391)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 25)
        Label3.TabIndex = 6
        Label3.Text = "Total Biaya:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.Location = New Point(30, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 25)
        Label4.TabIndex = 7
        Label4.Text = "Biaya Obat:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F)
        Label5.Location = New Point(30, 327)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 25)
        Label5.TabIndex = 8
        Label5.Text = "Biaya Dokter:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F)
        Label6.Location = New Point(30, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 25)
        Label6.TabIndex = 9
        Label6.Text = "Porsi Obat:"
        ' 
        ' LblBiayaDokter
        ' 
        LblBiayaDokter.AutoSize = True
        LblBiayaDokter.Font = New Font("Segoe UI", 14F)
        LblBiayaDokter.Location = New Point(195, 327)
        LblBiayaDokter.Name = "LblBiayaDokter"
        LblBiayaDokter.Size = New Size(138, 25)
        LblBiayaDokter.TabIndex = 10
        LblBiayaDokter.Text = "LblBiayaDokter"
        ' 
        ' LblBiayaObat
        ' 
        LblBiayaObat.AutoSize = True
        LblBiayaObat.Font = New Font("Segoe UI", 14F)
        LblBiayaObat.Location = New Point(195, 274)
        LblBiayaObat.Name = "LblBiayaObat"
        LblBiayaObat.Size = New Size(123, 25)
        LblBiayaObat.TabIndex = 11
        LblBiayaObat.Text = "LblBiayaObat"
        ' 
        ' LblPorsiObat
        ' 
        LblPorsiObat.AutoSize = True
        LblPorsiObat.Font = New Font("Segoe UI", 14F)
        LblPorsiObat.Location = New Point(195, 222)
        LblPorsiObat.Name = "LblPorsiObat"
        LblPorsiObat.Size = New Size(119, 25)
        LblPorsiObat.TabIndex = 12
        LblPorsiObat.Text = "LblPorsiObat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14F)
        Label7.Location = New Point(30, 481)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 25)
        Label7.TabIndex = 13
        Label7.Text = "Status:"
        ' 
        ' LblStatus
        ' 
        LblStatus.AutoSize = True
        LblStatus.Font = New Font("Segoe UI", 14F)
        LblStatus.Location = New Point(195, 481)
        LblStatus.Name = "LblStatus"
        LblStatus.Size = New Size(87, 25)
        LblStatus.TabIndex = 14
        LblStatus.Text = "LblStatus"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(172, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(233, 30)
        Label9.TabIndex = 15
        Label9.Text = "Rekam Medis Passien"
        ' 
        ' LblNamaPasien
        ' 
        LblNamaPasien.AutoSize = True
        LblNamaPasien.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        LblNamaPasien.ForeColor = SystemColors.ButtonHighlight
        LblNamaPasien.Location = New Point(411, 19)
        LblNamaPasien.Name = "LblNamaPasien"
        LblNamaPasien.Size = New Size(171, 30)
        LblNamaPasien.TabIndex = 16
        LblNamaPasien.Text = "LblNamaPasien"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.HotTrack
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(LblNamaPasien)
        Panel1.Location = New Point(1, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 67)
        Panel1.TabIndex = 20
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 604)
        Controls.Add(LblStatus)
        Controls.Add(Label7)
        Controls.Add(LblPorsiObat)
        Controls.Add(LblBiayaObat)
        Controls.Add(LblBiayaDokter)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnBayar)
        Controls.Add(LblTotalBiaya)
        Controls.Add(LblResep)
        Controls.Add(LblDiagnosa)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblDiagnosa As Label
    Friend WithEvents LblResep As Label
    Friend WithEvents LblTotalBiaya As Label
    Friend WithEvents BtnBayar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblBiayaDokter As Label
    Friend WithEvents LblBiayaObat As Label
    Friend WithEvents LblPorsiObat As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblNamaPasien As Label
    Friend WithEvents Panel1 As Panel
End Class
