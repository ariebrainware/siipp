<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LNH
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_suratTugas = New System.Windows.Forms.DateTimePicker()
        Me.cbox_suratTugas = New System.Windows.Forms.ComboBox()
        Me.txtbox_keterangan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbox_noLaporan = New System.Windows.Forms.TextBox()
        Me.dtp_tglLaporan = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbox_namaLaporan = New System.Windows.Forms.TextBox()
        Me.txtbox_namaTim = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_tampil = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.txtbox_cari = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.rbo_nonpkp2t = New System.Windows.Forms.RadioButton()
        Me.rbo_pkp2t = New System.Windows.Forms.RadioButton()
        Me.btn_unggahLampiran = New System.Windows.Forms.Button()
        Me.txtbox_asalFileTP3 = New System.Windows.Forms.TextBox()
        Me.btn_unggahTP3 = New System.Windows.Forms.Button()
        Me.txtbox_asalFileLampiran = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_browseDariTP3 = New System.Windows.Forms.Button()
        Me.btn_browseSimpanKeTP3 = New System.Windows.Forms.Button()
        Me.txtbox_simpanKeTP3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_browseSimpanKeLampiran = New System.Windows.Forms.Button()
        Me.btn_browseDariLampiran = New System.Windows.Forms.Button()
        Me.txtbox_simpanKeLampiran = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Laporan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Surat Tugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Surat Tugas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Nama Tim"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 420)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Lampiran"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 331)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Keterangan"
        '
        'dtp_suratTugas
        '
        Me.dtp_suratTugas.Enabled = False
        Me.dtp_suratTugas.Location = New System.Drawing.Point(131, 67)
        Me.dtp_suratTugas.Name = "dtp_suratTugas"
        Me.dtp_suratTugas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtp_suratTugas.Size = New System.Drawing.Size(200, 20)
        Me.dtp_suratTugas.TabIndex = 15
        '
        'cbox_suratTugas
        '
        Me.cbox_suratTugas.FormattingEnabled = True
        Me.cbox_suratTugas.Location = New System.Drawing.Point(131, 12)
        Me.cbox_suratTugas.Name = "cbox_suratTugas"
        Me.cbox_suratTugas.Size = New System.Drawing.Size(121, 21)
        Me.cbox_suratTugas.TabIndex = 1
        '
        'txtbox_keterangan
        '
        Me.txtbox_keterangan.Location = New System.Drawing.Point(131, 331)
        Me.txtbox_keterangan.Multiline = True
        Me.txtbox_keterangan.Name = "txtbox_keterangan"
        Me.txtbox_keterangan.Size = New System.Drawing.Size(200, 66)
        Me.txtbox_keterangan.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "No Laporan"
        '
        'txtbox_noLaporan
        '
        Me.txtbox_noLaporan.Location = New System.Drawing.Point(131, 93)
        Me.txtbox_noLaporan.Name = "txtbox_noLaporan"
        Me.txtbox_noLaporan.Size = New System.Drawing.Size(200, 20)
        Me.txtbox_noLaporan.TabIndex = 2
        '
        'dtp_tglLaporan
        '
        Me.dtp_tglLaporan.Location = New System.Drawing.Point(131, 119)
        Me.dtp_tglLaporan.Name = "dtp_tglLaporan"
        Me.dtp_tglLaporan.Size = New System.Drawing.Size(200, 20)
        Me.dtp_tglLaporan.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Nama Laporan"
        '
        'txtbox_namaLaporan
        '
        Me.txtbox_namaLaporan.Location = New System.Drawing.Point(131, 145)
        Me.txtbox_namaLaporan.Name = "txtbox_namaLaporan"
        Me.txtbox_namaLaporan.Size = New System.Drawing.Size(200, 20)
        Me.txtbox_namaLaporan.TabIndex = 4
        '
        'txtbox_namaTim
        '
        Me.txtbox_namaTim.Enabled = False
        Me.txtbox_namaTim.Location = New System.Drawing.Point(131, 173)
        Me.txtbox_namaTim.Multiline = True
        Me.txtbox_namaTim.Name = "txtbox_namaTim"
        Me.txtbox_namaTim.Size = New System.Drawing.Size(200, 66)
        Me.txtbox_namaTim.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "TP3"
        '
        'dgv_tampil
        '
        Me.dgv_tampil.AllowUserToAddRows = False
        Me.dgv_tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tampil.Location = New System.Drawing.Point(339, 12)
        Me.dgv_tampil.Name = "dgv_tampil"
        Me.dgv_tampil.ReadOnly = True
        Me.dgv_tampil.Size = New System.Drawing.Size(504, 398)
        Me.dgv_tampil.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(644, 443)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(149, 26)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "*cari berdasarkan No Laporan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  /Nama Laporan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(566, 418)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari.TabIndex = 21
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'txtbox_cari
        '
        Me.txtbox_cari.Location = New System.Drawing.Point(647, 420)
        Me.txtbox_cari.Name = "txtbox_cari"
        Me.txtbox_cari.Size = New System.Drawing.Size(181, 20)
        Me.txtbox_cari.TabIndex = 20
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(465, 446)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 18
        Me.btn_cancel.Text = "Batal"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(384, 445)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 19
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(465, 417)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(384, 416)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 16
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'rbo_nonpkp2t
        '
        Me.rbo_nonpkp2t.AutoSize = True
        Me.rbo_nonpkp2t.Enabled = False
        Me.rbo_nonpkp2t.Location = New System.Drawing.Point(231, 39)
        Me.rbo_nonpkp2t.Name = "rbo_nonpkp2t"
        Me.rbo_nonpkp2t.Size = New System.Drawing.Size(79, 17)
        Me.rbo_nonpkp2t.TabIndex = 52
        Me.rbo_nonpkp2t.TabStop = True
        Me.rbo_nonpkp2t.Text = "NonPKP2T"
        Me.rbo_nonpkp2t.UseVisualStyleBackColor = True
        '
        'rbo_pkp2t
        '
        Me.rbo_pkp2t.AutoSize = True
        Me.rbo_pkp2t.Enabled = False
        Me.rbo_pkp2t.Location = New System.Drawing.Point(131, 39)
        Me.rbo_pkp2t.Name = "rbo_pkp2t"
        Me.rbo_pkp2t.Size = New System.Drawing.Size(59, 17)
        Me.rbo_pkp2t.TabIndex = 51
        Me.rbo_pkp2t.TabStop = True
        Me.rbo_pkp2t.Text = "PKP2T"
        Me.rbo_pkp2t.UseVisualStyleBackColor = True
        '
        'btn_unggahLampiran
        '
        Me.btn_unggahLampiran.Location = New System.Drawing.Point(131, 470)
        Me.btn_unggahLampiran.Name = "btn_unggahLampiran"
        Me.btn_unggahLampiran.Size = New System.Drawing.Size(132, 23)
        Me.btn_unggahLampiran.TabIndex = 15
        Me.btn_unggahLampiran.Text = "Unggah"
        Me.btn_unggahLampiran.UseVisualStyleBackColor = True
        '
        'txtbox_asalFileTP3
        '
        Me.txtbox_asalFileTP3.Location = New System.Drawing.Point(131, 250)
        Me.txtbox_asalFileTP3.Name = "txtbox_asalFileTP3"
        Me.txtbox_asalFileTP3.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_asalFileTP3.TabIndex = 5
        '
        'btn_unggahTP3
        '
        Me.btn_unggahTP3.Location = New System.Drawing.Point(131, 302)
        Me.btn_unggahTP3.Name = "btn_unggahTP3"
        Me.btn_unggahTP3.Size = New System.Drawing.Size(132, 23)
        Me.btn_unggahTP3.TabIndex = 9
        Me.btn_unggahTP3.Text = "Unggah"
        Me.btn_unggahTP3.UseVisualStyleBackColor = True
        '
        'txtbox_asalFileLampiran
        '
        Me.txtbox_asalFileLampiran.Location = New System.Drawing.Point(131, 413)
        Me.txtbox_asalFileLampiran.Name = "txtbox_asalFileLampiran"
        Me.txtbox_asalFileLampiran.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_asalFileLampiran.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_browseDariTP3
        '
        Me.btn_browseDariTP3.Location = New System.Drawing.Point(289, 248)
        Me.btn_browseDariTP3.Name = "btn_browseDariTP3"
        Me.btn_browseDariTP3.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseDariTP3.TabIndex = 6
        Me.btn_browseDariTP3.Text = ". . ."
        Me.btn_browseDariTP3.UseVisualStyleBackColor = True
        '
        'btn_browseSimpanKeTP3
        '
        Me.btn_browseSimpanKeTP3.Location = New System.Drawing.Point(289, 273)
        Me.btn_browseSimpanKeTP3.Name = "btn_browseSimpanKeTP3"
        Me.btn_browseSimpanKeTP3.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseSimpanKeTP3.TabIndex = 8
        Me.btn_browseSimpanKeTP3.Text = ". . ."
        Me.btn_browseSimpanKeTP3.UseVisualStyleBackColor = True
        '
        'txtbox_simpanKeTP3
        '
        Me.txtbox_simpanKeTP3.Location = New System.Drawing.Point(131, 276)
        Me.txtbox_simpanKeTP3.Name = "txtbox_simpanKeTP3"
        Me.txtbox_simpanKeTP3.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_simpanKeTP3.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Dari"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Simpan Ke"
        '
        'btn_browseSimpanKeLampiran
        '
        Me.btn_browseSimpanKeLampiran.Location = New System.Drawing.Point(289, 442)
        Me.btn_browseSimpanKeLampiran.Name = "btn_browseSimpanKeLampiran"
        Me.btn_browseSimpanKeLampiran.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseSimpanKeLampiran.TabIndex = 14
        Me.btn_browseSimpanKeLampiran.Text = ". . ."
        Me.btn_browseSimpanKeLampiran.UseVisualStyleBackColor = True
        '
        'btn_browseDariLampiran
        '
        Me.btn_browseDariLampiran.Location = New System.Drawing.Point(289, 410)
        Me.btn_browseDariLampiran.Name = "btn_browseDariLampiran"
        Me.btn_browseDariLampiran.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseDariLampiran.TabIndex = 12
        Me.btn_browseDariLampiran.Text = ". . ."
        Me.btn_browseDariLampiran.UseVisualStyleBackColor = True
        '
        'txtbox_simpanKeLampiran
        '
        Me.txtbox_simpanKeLampiran.Location = New System.Drawing.Point(131, 444)
        Me.txtbox_simpanKeLampiran.Name = "txtbox_simpanKeLampiran"
        Me.txtbox_simpanKeLampiran.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_simpanKeLampiran.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 451)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Simpan Ke"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(99, 420)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Dari"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'LNH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 506)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtbox_simpanKeLampiran)
        Me.Controls.Add(Me.btn_browseSimpanKeLampiran)
        Me.Controls.Add(Me.btn_browseDariLampiran)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_browseSimpanKeTP3)
        Me.Controls.Add(Me.txtbox_simpanKeTP3)
        Me.Controls.Add(Me.btn_browseDariTP3)
        Me.Controls.Add(Me.txtbox_asalFileLampiran)
        Me.Controls.Add(Me.txtbox_asalFileTP3)
        Me.Controls.Add(Me.btn_unggahTP3)
        Me.Controls.Add(Me.btn_unggahLampiran)
        Me.Controls.Add(Me.rbo_nonpkp2t)
        Me.Controls.Add(Me.rbo_pkp2t)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.txtbox_cari)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.dgv_tampil)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtbox_namaTim)
        Me.Controls.Add(Me.txtbox_namaLaporan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtp_tglLaporan)
        Me.Controls.Add(Me.txtbox_noLaporan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbox_keterangan)
        Me.Controls.Add(Me.cbox_suratTugas)
        Me.Controls.Add(Me.dtp_suratTugas)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "LNH"
        Me.Text = "LNH"
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dtp_suratTugas As DateTimePicker
    Friend WithEvents cbox_suratTugas As ComboBox
    Friend WithEvents txtbox_keterangan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbox_noLaporan As TextBox
    Friend WithEvents dtp_tglLaporan As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbox_namaLaporan As TextBox
    Friend WithEvents txtbox_namaTim As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_tampil As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_cari As Button
    Friend WithEvents txtbox_cari As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents rbo_nonpkp2t As RadioButton
    Friend WithEvents rbo_pkp2t As RadioButton
    Friend WithEvents btn_unggahLampiran As Button
    Friend WithEvents btn_unggahTP3 As Button
    Friend WithEvents txtbox_asalFileTP3 As TextBox
    Friend WithEvents txtbox_asalFileLampiran As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_browseDariTP3 As Button
    Friend WithEvents btn_browseSimpanKeTP3 As Button
    Friend WithEvents txtbox_simpanKeTP3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_browseSimpanKeLampiran As Button
    Friend WithEvents btn_browseDariLampiran As Button
    Friend WithEvents txtbox_simpanKeLampiran As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
