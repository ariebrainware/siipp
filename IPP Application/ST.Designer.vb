<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ST
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbox_noSP = New System.Windows.Forms.TextBox()
        Me.txtbox_noST = New System.Windows.Forms.TextBox()
        Me.dtp_tglSP = New System.Windows.Forms.DateTimePicker()
        Me.dtp_tglST = New System.Windows.Forms.DateTimePicker()
        Me.dtp_mulaiST = New System.Windows.Forms.DateTimePicker()
        Me.dtp_selesaiST = New System.Windows.Forms.DateTimePicker()
        Me.txtbox_lamaST = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtp_mulaiDL = New System.Windows.Forms.DateTimePicker()
        Me.dtp_selesaiDL = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtbox_lamaDL = New System.Windows.Forms.TextBox()
        Me.txtbox_perihal = New System.Windows.Forms.TextBox()
        Me.txtbox_keterangan = New System.Windows.Forms.TextBox()
        Me.dgv_tampil = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.txtbox_cari = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.txtbox_idPenugasan = New System.Windows.Forms.TextBox()
        Me.txtbox_namaTIm = New System.Windows.Forms.TextBox()
        Me.rbo_pkp2t = New System.Windows.Forms.RadioButton()
        Me.rbo_nonpkp2t = New System.Windows.Forms.RadioButton()
        Me.txtbox_nopkp2t = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtbox_simpanKeLampiran = New System.Windows.Forms.TextBox()
        Me.btn_browseSimpanKeLampiran = New System.Windows.Forms.Button()
        Me.btn_browseDariLampiran = New System.Windows.Forms.Button()
        Me.txtbox_asalFileLampiran = New System.Windows.Forms.TextBox()
        Me.btn_unggahLampiran = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Surat Pengantar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Surat Pengantar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Surat Tugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Surat Tugas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mulai Surat Tugas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Selesai Surat Tugas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Lama Dinas luar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Uraian Surat Tugas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 400)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nama Tim"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 462)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Keterangan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Lama Surat Tugas"
        '
        'txtbox_noSP
        '
        Me.txtbox_noSP.Location = New System.Drawing.Point(142, 72)
        Me.txtbox_noSP.Name = "txtbox_noSP"
        Me.txtbox_noSP.Size = New System.Drawing.Size(170, 20)
        Me.txtbox_noSP.TabIndex = 3
        '
        'txtbox_noST
        '
        Me.txtbox_noST.Location = New System.Drawing.Point(142, 124)
        Me.txtbox_noST.Name = "txtbox_noST"
        Me.txtbox_noST.Size = New System.Drawing.Size(170, 20)
        Me.txtbox_noST.TabIndex = 5
        '
        'dtp_tglSP
        '
        Me.dtp_tglSP.Location = New System.Drawing.Point(142, 98)
        Me.dtp_tglSP.Name = "dtp_tglSP"
        Me.dtp_tglSP.Size = New System.Drawing.Size(200, 20)
        Me.dtp_tglSP.TabIndex = 4
        '
        'dtp_tglST
        '
        Me.dtp_tglST.Location = New System.Drawing.Point(142, 150)
        Me.dtp_tglST.Name = "dtp_tglST"
        Me.dtp_tglST.Size = New System.Drawing.Size(200, 20)
        Me.dtp_tglST.TabIndex = 6
        '
        'dtp_mulaiST
        '
        Me.dtp_mulaiST.Location = New System.Drawing.Point(142, 176)
        Me.dtp_mulaiST.Name = "dtp_mulaiST"
        Me.dtp_mulaiST.Size = New System.Drawing.Size(200, 20)
        Me.dtp_mulaiST.TabIndex = 7
        '
        'dtp_selesaiST
        '
        Me.dtp_selesaiST.Location = New System.Drawing.Point(142, 202)
        Me.dtp_selesaiST.Name = "dtp_selesaiST"
        Me.dtp_selesaiST.Size = New System.Drawing.Size(200, 20)
        Me.dtp_selesaiST.TabIndex = 8
        '
        'txtbox_lamaST
        '
        Me.txtbox_lamaST.Enabled = False
        Me.txtbox_lamaST.Location = New System.Drawing.Point(142, 228)
        Me.txtbox_lamaST.Name = "txtbox_lamaST"
        Me.txtbox_lamaST.Size = New System.Drawing.Size(76, 20)
        Me.txtbox_lamaST.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(224, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Hari"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 287)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Selesai Dinas Luar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 261)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Mulai Dinas Luar"
        '
        'dtp_mulaiDL
        '
        Me.dtp_mulaiDL.Location = New System.Drawing.Point(142, 254)
        Me.dtp_mulaiDL.Name = "dtp_mulaiDL"
        Me.dtp_mulaiDL.Size = New System.Drawing.Size(200, 20)
        Me.dtp_mulaiDL.TabIndex = 10
        '
        'dtp_selesaiDL
        '
        Me.dtp_selesaiDL.Location = New System.Drawing.Point(142, 280)
        Me.dtp_selesaiDL.Name = "dtp_selesaiDL"
        Me.dtp_selesaiDL.Size = New System.Drawing.Size(200, 20)
        Me.dtp_selesaiDL.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(224, 313)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Hari"
        '
        'txtbox_lamaDL
        '
        Me.txtbox_lamaDL.Enabled = False
        Me.txtbox_lamaDL.Location = New System.Drawing.Point(142, 306)
        Me.txtbox_lamaDL.Name = "txtbox_lamaDL"
        Me.txtbox_lamaDL.Size = New System.Drawing.Size(76, 20)
        Me.txtbox_lamaDL.TabIndex = 12
        '
        'txtbox_perihal
        '
        Me.txtbox_perihal.Location = New System.Drawing.Point(142, 335)
        Me.txtbox_perihal.Multiline = True
        Me.txtbox_perihal.Name = "txtbox_perihal"
        Me.txtbox_perihal.Size = New System.Drawing.Size(200, 59)
        Me.txtbox_perihal.TabIndex = 13
        '
        'txtbox_keterangan
        '
        Me.txtbox_keterangan.Location = New System.Drawing.Point(142, 465)
        Me.txtbox_keterangan.Multiline = True
        Me.txtbox_keterangan.Name = "txtbox_keterangan"
        Me.txtbox_keterangan.Size = New System.Drawing.Size(200, 59)
        Me.txtbox_keterangan.TabIndex = 15
        '
        'dgv_tampil
        '
        Me.dgv_tampil.AllowUserToAddRows = False
        Me.dgv_tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tampil.Location = New System.Drawing.Point(350, 18)
        Me.dgv_tampil.Name = "dgv_tampil"
        Me.dgv_tampil.ReadOnly = True
        Me.dgv_tampil.Size = New System.Drawing.Size(472, 494)
        Me.dgv_tampil.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(638, 553)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(192, 26)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "*cari berdasarkan No Surat Pengantar/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No Surat Tugas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(560, 528)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari.TabIndex = 22
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'txtbox_cari
        '
        Me.txtbox_cari.Location = New System.Drawing.Point(641, 530)
        Me.txtbox_cari.Name = "txtbox_cari"
        Me.txtbox_cari.Size = New System.Drawing.Size(181, 20)
        Me.txtbox_cari.TabIndex = 21
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(462, 557)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 20
        Me.btn_cancel.Text = "Batal"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(381, 557)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 35
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(462, 527)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 19
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(381, 528)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 33
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'txtbox_idPenugasan
        '
        Me.txtbox_idPenugasan.Enabled = False
        Me.txtbox_idPenugasan.Location = New System.Drawing.Point(560, 557)
        Me.txtbox_idPenugasan.Name = "txtbox_idPenugasan"
        Me.txtbox_idPenugasan.Size = New System.Drawing.Size(75, 20)
        Me.txtbox_idPenugasan.TabIndex = 43
        Me.txtbox_idPenugasan.Visible = False
        '
        'txtbox_namaTIm
        '
        Me.txtbox_namaTIm.Location = New System.Drawing.Point(142, 400)
        Me.txtbox_namaTIm.Multiline = True
        Me.txtbox_namaTIm.Name = "txtbox_namaTIm"
        Me.txtbox_namaTIm.Size = New System.Drawing.Size(200, 59)
        Me.txtbox_namaTIm.TabIndex = 14
        '
        'rbo_pkp2t
        '
        Me.rbo_pkp2t.AutoSize = True
        Me.rbo_pkp2t.Enabled = False
        Me.rbo_pkp2t.Location = New System.Drawing.Point(52, 14)
        Me.rbo_pkp2t.Name = "rbo_pkp2t"
        Me.rbo_pkp2t.Size = New System.Drawing.Size(59, 17)
        Me.rbo_pkp2t.TabIndex = 0
        Me.rbo_pkp2t.TabStop = True
        Me.rbo_pkp2t.Text = "PKP2T"
        Me.rbo_pkp2t.UseVisualStyleBackColor = True
        '
        'rbo_nonpkp2t
        '
        Me.rbo_nonpkp2t.AutoSize = True
        Me.rbo_nonpkp2t.Enabled = False
        Me.rbo_nonpkp2t.Location = New System.Drawing.Point(227, 14)
        Me.rbo_nonpkp2t.Name = "rbo_nonpkp2t"
        Me.rbo_nonpkp2t.Size = New System.Drawing.Size(79, 17)
        Me.rbo_nonpkp2t.TabIndex = 1
        Me.rbo_nonpkp2t.TabStop = True
        Me.rbo_nonpkp2t.Text = "NonPKP2T"
        Me.rbo_nonpkp2t.UseVisualStyleBackColor = True
        '
        'txtbox_nopkp2t
        '
        Me.txtbox_nopkp2t.CausesValidation = False
        Me.txtbox_nopkp2t.Enabled = False
        Me.txtbox_nopkp2t.Location = New System.Drawing.Point(142, 46)
        Me.txtbox_nopkp2t.Name = "txtbox_nopkp2t"
        Me.txtbox_nopkp2t.Size = New System.Drawing.Size(170, 20)
        Me.txtbox_nopkp2t.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "No PKP2T"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(78, 571)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "Simpan Ke"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(110, 540)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(26, 13)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "Dari"
        '
        'txtbox_simpanKeLampiran
        '
        Me.txtbox_simpanKeLampiran.Location = New System.Drawing.Point(142, 564)
        Me.txtbox_simpanKeLampiran.Name = "txtbox_simpanKeLampiran"
        Me.txtbox_simpanKeLampiran.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_simpanKeLampiran.TabIndex = 72
        '
        'btn_browseSimpanKeLampiran
        '
        Me.btn_browseSimpanKeLampiran.Location = New System.Drawing.Point(300, 562)
        Me.btn_browseSimpanKeLampiran.Name = "btn_browseSimpanKeLampiran"
        Me.btn_browseSimpanKeLampiran.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseSimpanKeLampiran.TabIndex = 17
        Me.btn_browseSimpanKeLampiran.Text = ". . ."
        Me.btn_browseSimpanKeLampiran.UseVisualStyleBackColor = True
        '
        'btn_browseDariLampiran
        '
        Me.btn_browseDariLampiran.Location = New System.Drawing.Point(300, 530)
        Me.btn_browseDariLampiran.Name = "btn_browseDariLampiran"
        Me.btn_browseDariLampiran.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseDariLampiran.TabIndex = 16
        Me.btn_browseDariLampiran.Text = ". . ."
        Me.btn_browseDariLampiran.UseVisualStyleBackColor = True
        '
        'txtbox_asalFileLampiran
        '
        Me.txtbox_asalFileLampiran.Location = New System.Drawing.Point(142, 533)
        Me.txtbox_asalFileLampiran.Name = "txtbox_asalFileLampiran"
        Me.txtbox_asalFileLampiran.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_asalFileLampiran.TabIndex = 69
        '
        'btn_unggahLampiran
        '
        Me.btn_unggahLampiran.Location = New System.Drawing.Point(142, 590)
        Me.btn_unggahLampiran.Name = "btn_unggahLampiran"
        Me.btn_unggahLampiran.Size = New System.Drawing.Size(132, 23)
        Me.btn_unggahLampiran.TabIndex = 18
        Me.btn_unggahLampiran.Text = "Unggah"
        Me.btn_unggahLampiran.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(10, 537)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Lampiran"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 618)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtbox_simpanKeLampiran)
        Me.Controls.Add(Me.btn_browseSimpanKeLampiran)
        Me.Controls.Add(Me.btn_browseDariLampiran)
        Me.Controls.Add(Me.txtbox_asalFileLampiran)
        Me.Controls.Add(Me.btn_unggahLampiran)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtbox_nopkp2t)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.rbo_nonpkp2t)
        Me.Controls.Add(Me.rbo_pkp2t)
        Me.Controls.Add(Me.txtbox_namaTIm)
        Me.Controls.Add(Me.txtbox_idPenugasan)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.txtbox_cari)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.dgv_tampil)
        Me.Controls.Add(Me.txtbox_keterangan)
        Me.Controls.Add(Me.txtbox_perihal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtbox_lamaDL)
        Me.Controls.Add(Me.dtp_selesaiDL)
        Me.Controls.Add(Me.dtp_mulaiDL)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtbox_lamaST)
        Me.Controls.Add(Me.dtp_selesaiST)
        Me.Controls.Add(Me.dtp_mulaiST)
        Me.Controls.Add(Me.dtp_tglST)
        Me.Controls.Add(Me.dtp_tglSP)
        Me.Controls.Add(Me.txtbox_noST)
        Me.Controls.Add(Me.txtbox_noSP)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ST"
        Me.Text = "ST"
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbox_noSP As TextBox
    Friend WithEvents txtbox_noST As TextBox
    Friend WithEvents dtp_tglSP As DateTimePicker
    Friend WithEvents dtp_tglST As DateTimePicker
    Friend WithEvents dtp_mulaiST As DateTimePicker
    Friend WithEvents dtp_selesaiST As DateTimePicker
    Friend WithEvents txtbox_lamaST As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtp_mulaiDL As DateTimePicker
    Friend WithEvents dtp_selesaiDL As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents txtbox_lamaDL As TextBox
    Friend WithEvents txtbox_perihal As TextBox
    Friend WithEvents txtbox_keterangan As TextBox
    Friend WithEvents dgv_tampil As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_cari As Button
    Friend WithEvents txtbox_cari As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents txtbox_idPenugasan As TextBox
    Friend WithEvents txtbox_namaTIm As TextBox
    Friend WithEvents rbo_pkp2t As RadioButton
    Friend WithEvents rbo_nonpkp2t As RadioButton
    Friend WithEvents txtbox_nopkp2t As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtbox_simpanKeLampiran As TextBox
    Friend WithEvents btn_browseSimpanKeLampiran As Button
    Friend WithEvents btn_browseDariLampiran As Button
    Friend WithEvents txtbox_asalFileLampiran As TextBox
    Friend WithEvents btn_unggahLampiran As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
