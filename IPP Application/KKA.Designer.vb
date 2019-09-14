<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KKA
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
        Me.dtp_tglArsip = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbox_suratTugas = New System.Windows.Forms.ComboBox()
        Me.dtp_suratTugas = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbox_namaLaporan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_laporan = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbox_judul = New System.Windows.Forms.TextBox()
        Me.txtbox_namaTim = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbox_keterangan = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgv_tampil = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.txtbox_cari = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.cbox_noLaporan = New System.Windows.Forms.ComboBox()
        Me.rbo_nonpkp2t = New System.Windows.Forms.RadioButton()
        Me.rbo_pkp2t = New System.Windows.Forms.RadioButton()
        Me.txtbox_noArsip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbox_simpanKeLampiran = New System.Windows.Forms.TextBox()
        Me.btn_browseSimpanKeLampiran = New System.Windows.Forms.Button()
        Me.btn_browseDariLampiran = New System.Windows.Forms.Button()
        Me.txtbox_asalFileLampiran = New System.Windows.Forms.TextBox()
        Me.btn_unggahLampiran = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtbox_noPKP2T = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_tglArsip
        '
        Me.dtp_tglArsip.Location = New System.Drawing.Point(127, 47)
        Me.dtp_tglArsip.Name = "dtp_tglArsip"
        Me.dtp_tglArsip.Size = New System.Drawing.Size(200, 20)
        Me.dtp_tglArsip.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tanggal Arsip KKA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "No Surat Tugas"
        '
        'cbox_suratTugas
        '
        Me.cbox_suratTugas.FormattingEnabled = True
        Me.cbox_suratTugas.Location = New System.Drawing.Point(127, 73)
        Me.cbox_suratTugas.Name = "cbox_suratTugas"
        Me.cbox_suratTugas.Size = New System.Drawing.Size(121, 21)
        Me.cbox_suratTugas.TabIndex = 3
        '
        'dtp_suratTugas
        '
        Me.dtp_suratTugas.Location = New System.Drawing.Point(127, 149)
        Me.dtp_suratTugas.Name = "dtp_suratTugas"
        Me.dtp_suratTugas.Size = New System.Drawing.Size(200, 20)
        Me.dtp_suratTugas.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tanggal Surat Tugas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "No Laporan"
        '
        'txtbox_namaLaporan
        '
        Me.txtbox_namaLaporan.Location = New System.Drawing.Point(127, 227)
        Me.txtbox_namaLaporan.Name = "txtbox_namaLaporan"
        Me.txtbox_namaLaporan.Size = New System.Drawing.Size(200, 20)
        Me.txtbox_namaLaporan.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Judul Laporan"
        '
        'dtp_laporan
        '
        Me.dtp_laporan.Location = New System.Drawing.Point(127, 201)
        Me.dtp_laporan.Name = "dtp_laporan"
        Me.dtp_laporan.Size = New System.Drawing.Size(200, 20)
        Me.dtp_laporan.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Tanggal Laporan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Judul KKA"
        '
        'txtbox_judul
        '
        Me.txtbox_judul.Location = New System.Drawing.Point(127, 256)
        Me.txtbox_judul.Multiline = True
        Me.txtbox_judul.Name = "txtbox_judul"
        Me.txtbox_judul.Size = New System.Drawing.Size(200, 66)
        Me.txtbox_judul.TabIndex = 11
        '
        'txtbox_namaTim
        '
        Me.txtbox_namaTim.Location = New System.Drawing.Point(127, 328)
        Me.txtbox_namaTim.Multiline = True
        Me.txtbox_namaTim.Name = "txtbox_namaTim"
        Me.txtbox_namaTim.Size = New System.Drawing.Size(200, 66)
        Me.txtbox_namaTim.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Nama Tim"
        '
        'txtbox_keterangan
        '
        Me.txtbox_keterangan.Location = New System.Drawing.Point(127, 400)
        Me.txtbox_keterangan.Multiline = True
        Me.txtbox_keterangan.Name = "txtbox_keterangan"
        Me.txtbox_keterangan.Size = New System.Drawing.Size(200, 66)
        Me.txtbox_keterangan.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 400)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Keterangan"
        '
        'dgv_tampil
        '
        Me.dgv_tampil.AllowUserToAddRows = False
        Me.dgv_tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tampil.Location = New System.Drawing.Point(333, 21)
        Me.dgv_tampil.Name = "dgv_tampil"
        Me.dgv_tampil.ReadOnly = True
        Me.dgv_tampil.Size = New System.Drawing.Size(484, 457)
        Me.dgv_tampil.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(633, 509)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 26)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "*cari berdasarkan No Arsip KKA/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Judul KKA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(555, 483)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari.TabIndex = 20
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'txtbox_cari
        '
        Me.txtbox_cari.Location = New System.Drawing.Point(636, 485)
        Me.txtbox_cari.Name = "txtbox_cari"
        Me.txtbox_cari.Size = New System.Drawing.Size(181, 20)
        Me.txtbox_cari.TabIndex = 19
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(423, 516)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 18
        Me.btn_cancel.Text = "Batal"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(343, 515)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 54
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(423, 486)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(342, 486)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 52
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'cbox_noLaporan
        '
        Me.cbox_noLaporan.FormattingEnabled = True
        Me.cbox_noLaporan.Location = New System.Drawing.Point(127, 175)
        Me.cbox_noLaporan.Name = "cbox_noLaporan"
        Me.cbox_noLaporan.Size = New System.Drawing.Size(121, 21)
        Me.cbox_noLaporan.TabIndex = 8
        '
        'rbo_nonpkp2t
        '
        Me.rbo_nonpkp2t.AutoSize = True
        Me.rbo_nonpkp2t.Location = New System.Drawing.Point(232, 100)
        Me.rbo_nonpkp2t.Name = "rbo_nonpkp2t"
        Me.rbo_nonpkp2t.Size = New System.Drawing.Size(79, 17)
        Me.rbo_nonpkp2t.TabIndex = 5
        Me.rbo_nonpkp2t.TabStop = True
        Me.rbo_nonpkp2t.Text = "NonPKP2T"
        Me.rbo_nonpkp2t.UseVisualStyleBackColor = True
        '
        'rbo_pkp2t
        '
        Me.rbo_pkp2t.AutoSize = True
        Me.rbo_pkp2t.Location = New System.Drawing.Point(127, 100)
        Me.rbo_pkp2t.Name = "rbo_pkp2t"
        Me.rbo_pkp2t.Size = New System.Drawing.Size(59, 17)
        Me.rbo_pkp2t.TabIndex = 4
        Me.rbo_pkp2t.TabStop = True
        Me.rbo_pkp2t.Text = "PKP2T"
        Me.rbo_pkp2t.UseVisualStyleBackColor = True
        '
        'txtbox_noArsip
        '
        Me.txtbox_noArsip.Location = New System.Drawing.Point(127, 21)
        Me.txtbox_noArsip.Name = "txtbox_noArsip"
        Me.txtbox_noArsip.Size = New System.Drawing.Size(200, 20)
        Me.txtbox_noArsip.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "No Arsip KKA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 516)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Simpan Ke"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(95, 485)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Dari"
        '
        'txtbox_simpanKeLampiran
        '
        Me.txtbox_simpanKeLampiran.Location = New System.Drawing.Point(127, 509)
        Me.txtbox_simpanKeLampiran.Name = "txtbox_simpanKeLampiran"
        Me.txtbox_simpanKeLampiran.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_simpanKeLampiran.TabIndex = 72
        '
        'btn_browseSimpanKeLampiran
        '
        Me.btn_browseSimpanKeLampiran.Location = New System.Drawing.Point(285, 507)
        Me.btn_browseSimpanKeLampiran.Name = "btn_browseSimpanKeLampiran"
        Me.btn_browseSimpanKeLampiran.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseSimpanKeLampiran.TabIndex = 15
        Me.btn_browseSimpanKeLampiran.Text = ". . ."
        Me.btn_browseSimpanKeLampiran.UseVisualStyleBackColor = True
        '
        'btn_browseDariLampiran
        '
        Me.btn_browseDariLampiran.Location = New System.Drawing.Point(285, 475)
        Me.btn_browseDariLampiran.Name = "btn_browseDariLampiran"
        Me.btn_browseDariLampiran.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseDariLampiran.TabIndex = 14
        Me.btn_browseDariLampiran.Text = ". . ."
        Me.btn_browseDariLampiran.UseVisualStyleBackColor = True
        '
        'txtbox_asalFileLampiran
        '
        Me.txtbox_asalFileLampiran.Location = New System.Drawing.Point(127, 478)
        Me.txtbox_asalFileLampiran.Name = "txtbox_asalFileLampiran"
        Me.txtbox_asalFileLampiran.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_asalFileLampiran.TabIndex = 69
        '
        'btn_unggahLampiran
        '
        Me.btn_unggahLampiran.Location = New System.Drawing.Point(127, 535)
        Me.btn_unggahLampiran.Name = "btn_unggahLampiran"
        Me.btn_unggahLampiran.Size = New System.Drawing.Size(132, 23)
        Me.btn_unggahLampiran.TabIndex = 16
        Me.btn_unggahLampiran.Text = "Unggah"
        Me.btn_unggahLampiran.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 485)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Lampiran"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtbox_noPKP2T
        '
        Me.txtbox_noPKP2T.Location = New System.Drawing.Point(127, 123)
        Me.txtbox_noPKP2T.Name = "txtbox_noPKP2T"
        Me.txtbox_noPKP2T.Size = New System.Drawing.Size(200, 20)
        Me.txtbox_noPKP2T.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "No PKP2T"
        '
        'KKA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 571)
        Me.Controls.Add(Me.txtbox_noPKP2T)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtbox_simpanKeLampiran)
        Me.Controls.Add(Me.btn_browseSimpanKeLampiran)
        Me.Controls.Add(Me.btn_browseDariLampiran)
        Me.Controls.Add(Me.txtbox_asalFileLampiran)
        Me.Controls.Add(Me.btn_unggahLampiran)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtbox_noArsip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbo_nonpkp2t)
        Me.Controls.Add(Me.rbo_pkp2t)
        Me.Controls.Add(Me.cbox_noLaporan)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.txtbox_cari)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.dgv_tampil)
        Me.Controls.Add(Me.txtbox_keterangan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtbox_namaTim)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtbox_judul)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbox_namaLaporan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtp_laporan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_suratTugas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbox_suratTugas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_tglArsip)
        Me.Name = "KKA"
        Me.Text = "KKA"
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_tglArsip As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbox_suratTugas As ComboBox
    Friend WithEvents dtp_suratTugas As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbox_namaLaporan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_laporan As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbox_judul As TextBox
    Friend WithEvents txtbox_namaTim As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbox_keterangan As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dgv_tampil As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_cari As Button
    Friend WithEvents txtbox_cari As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents cbox_noLaporan As ComboBox
    Friend WithEvents rbo_nonpkp2t As RadioButton
    Friend WithEvents rbo_pkp2t As RadioButton
    Friend WithEvents txtbox_noArsip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtbox_simpanKeLampiran As TextBox
    Friend WithEvents btn_browseSimpanKeLampiran As Button
    Friend WithEvents btn_browseDariLampiran As Button
    Friend WithEvents txtbox_asalFileLampiran As TextBox
    Friend WithEvents btn_unggahLampiran As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtbox_noPKP2T As TextBox
    Friend WithEvents Label11 As Label
End Class
