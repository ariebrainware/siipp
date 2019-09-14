<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASM
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
        Me.dtp_suratMasuk = New System.Windows.Forms.DateTimePicker()
        Me.dgv_tampil = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_suratDiterima = New System.Windows.Forms.DateTimePicker()
        Me.txtbox_asalSurat = New System.Windows.Forms.TextBox()
        Me.txtbox_noSM = New System.Windows.Forms.TextBox()
        Me.txtbox_perihal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbox_keterangan = New System.Windows.Forms.TextBox()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txtbox_cari = New System.Windows.Forms.TextBox()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbox_disposisi = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtbox_sifatSurat = New System.Windows.Forms.TextBox()
        Me.txtbox_idSM = New System.Windows.Forms.TextBox()
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
        'dtp_suratMasuk
        '
        Me.dtp_suratMasuk.Location = New System.Drawing.Point(124, 17)
        Me.dtp_suratMasuk.Name = "dtp_suratMasuk"
        Me.dtp_suratMasuk.Size = New System.Drawing.Size(200, 20)
        Me.dtp_suratMasuk.TabIndex = 2
        '
        'dgv_tampil
        '
        Me.dgv_tampil.AllowUserToAddRows = False
        Me.dgv_tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tampil.Location = New System.Drawing.Point(332, 16)
        Me.dgv_tampil.MultiSelect = False
        Me.dgv_tampil.Name = "dgv_tampil"
        Me.dgv_tampil.ReadOnly = True
        Me.dgv_tampil.RowHeadersVisible = False
        Me.dgv_tampil.Size = New System.Drawing.Size(486, 348)
        Me.dgv_tampil.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tanggal Surat Masuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Asal Surat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No Surat Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tanggal Surat Diterima"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Perihal"
        '
        'dtp_suratDiterima
        '
        Me.dtp_suratDiterima.Location = New System.Drawing.Point(124, 95)
        Me.dtp_suratDiterima.Name = "dtp_suratDiterima"
        Me.dtp_suratDiterima.Size = New System.Drawing.Size(200, 20)
        Me.dtp_suratDiterima.TabIndex = 5
        '
        'txtbox_asalSurat
        '
        Me.txtbox_asalSurat.Location = New System.Drawing.Point(124, 43)
        Me.txtbox_asalSurat.Name = "txtbox_asalSurat"
        Me.txtbox_asalSurat.Size = New System.Drawing.Size(200, 20)
        Me.txtbox_asalSurat.TabIndex = 3
        '
        'txtbox_noSM
        '
        Me.txtbox_noSM.Location = New System.Drawing.Point(124, 69)
        Me.txtbox_noSM.Name = "txtbox_noSM"
        Me.txtbox_noSM.Size = New System.Drawing.Size(200, 20)
        Me.txtbox_noSM.TabIndex = 4
        '
        'txtbox_perihal
        '
        Me.txtbox_perihal.Location = New System.Drawing.Point(124, 147)
        Me.txtbox_perihal.Multiline = True
        Me.txtbox_perihal.Name = "txtbox_perihal"
        Me.txtbox_perihal.Size = New System.Drawing.Size(200, 59)
        Me.txtbox_perihal.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Disposisi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Keterangan"
        '
        'txtbox_keterangan
        '
        Me.txtbox_keterangan.Location = New System.Drawing.Point(124, 277)
        Me.txtbox_keterangan.Multiline = True
        Me.txtbox_keterangan.Name = "txtbox_keterangan"
        Me.txtbox_keterangan.Size = New System.Drawing.Size(200, 59)
        Me.txtbox_keterangan.TabIndex = 9
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(350, 385)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 1
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(431, 385)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 13
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(350, 414)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 21
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(431, 414)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Batal"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txtbox_cari
        '
        Me.txtbox_cari.Location = New System.Drawing.Point(637, 382)
        Me.txtbox_cari.Name = "txtbox_cari"
        Me.txtbox_cari.Size = New System.Drawing.Size(181, 20)
        Me.txtbox_cari.TabIndex = 15
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(556, 379)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari.TabIndex = 16
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(634, 408)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 26)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "*cari berdasarkan Asal surat/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "no surat/perihal"
        '
        'txtbox_disposisi
        '
        Me.txtbox_disposisi.Location = New System.Drawing.Point(124, 212)
        Me.txtbox_disposisi.Multiline = True
        Me.txtbox_disposisi.Name = "txtbox_disposisi"
        Me.txtbox_disposisi.Size = New System.Drawing.Size(200, 59)
        Me.txtbox_disposisi.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Sifat Surat"
        '
        'txtbox_sifatSurat
        '
        Me.txtbox_sifatSurat.Location = New System.Drawing.Point(124, 121)
        Me.txtbox_sifatSurat.Name = "txtbox_sifatSurat"
        Me.txtbox_sifatSurat.Size = New System.Drawing.Size(200, 20)
        Me.txtbox_sifatSurat.TabIndex = 6
        '
        'txtbox_idSM
        '
        Me.txtbox_idSM.Enabled = False
        Me.txtbox_idSM.Location = New System.Drawing.Point(568, 414)
        Me.txtbox_idSM.Name = "txtbox_idSM"
        Me.txtbox_idSM.ReadOnly = True
        Me.txtbox_idSM.Size = New System.Drawing.Size(50, 20)
        Me.txtbox_idSM.TabIndex = 4
        Me.txtbox_idSM.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(60, 386)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Simpan Ke"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(92, 355)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(26, 13)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "Dari"
        '
        'txtbox_simpanKeLampiran
        '
        Me.txtbox_simpanKeLampiran.Location = New System.Drawing.Point(124, 379)
        Me.txtbox_simpanKeLampiran.Name = "txtbox_simpanKeLampiran"
        Me.txtbox_simpanKeLampiran.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_simpanKeLampiran.TabIndex = 80
        '
        'btn_browseSimpanKeLampiran
        '
        Me.btn_browseSimpanKeLampiran.Location = New System.Drawing.Point(282, 377)
        Me.btn_browseSimpanKeLampiran.Name = "btn_browseSimpanKeLampiran"
        Me.btn_browseSimpanKeLampiran.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseSimpanKeLampiran.TabIndex = 11
        Me.btn_browseSimpanKeLampiran.Text = ". . ."
        Me.btn_browseSimpanKeLampiran.UseVisualStyleBackColor = True
        '
        'btn_browseDariLampiran
        '
        Me.btn_browseDariLampiran.Location = New System.Drawing.Point(282, 345)
        Me.btn_browseDariLampiran.Name = "btn_browseDariLampiran"
        Me.btn_browseDariLampiran.Size = New System.Drawing.Size(42, 23)
        Me.btn_browseDariLampiran.TabIndex = 10
        Me.btn_browseDariLampiran.Text = ". . ."
        Me.btn_browseDariLampiran.UseVisualStyleBackColor = True
        '
        'txtbox_asalFileLampiran
        '
        Me.txtbox_asalFileLampiran.Location = New System.Drawing.Point(124, 348)
        Me.txtbox_asalFileLampiran.Name = "txtbox_asalFileLampiran"
        Me.txtbox_asalFileLampiran.Size = New System.Drawing.Size(152, 20)
        Me.txtbox_asalFileLampiran.TabIndex = 77
        '
        'btn_unggahLampiran
        '
        Me.btn_unggahLampiran.Location = New System.Drawing.Point(124, 405)
        Me.btn_unggahLampiran.Name = "btn_unggahLampiran"
        Me.btn_unggahLampiran.Size = New System.Drawing.Size(132, 23)
        Me.btn_unggahLampiran.TabIndex = 12
        Me.btn_unggahLampiran.Text = "Unggah"
        Me.btn_unggahLampiran.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 355)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 79
        Me.Label21.Text = "Lampiran"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ASM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 462)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtbox_simpanKeLampiran)
        Me.Controls.Add(Me.btn_browseSimpanKeLampiran)
        Me.Controls.Add(Me.btn_browseDariLampiran)
        Me.Controls.Add(Me.txtbox_asalFileLampiran)
        Me.Controls.Add(Me.btn_unggahLampiran)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtbox_sifatSurat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtbox_disposisi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.txtbox_cari)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.txtbox_keterangan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtbox_perihal)
        Me.Controls.Add(Me.txtbox_noSM)
        Me.Controls.Add(Me.txtbox_asalSurat)
        Me.Controls.Add(Me.dtp_suratDiterima)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbox_idSM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_tampil)
        Me.Controls.Add(Me.dtp_suratMasuk)
        Me.Name = "ASM"
        Me.Text = "Agenda Surat Masuk"
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp_suratMasuk As DateTimePicker
    Friend WithEvents dgv_tampil As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_suratDiterima As DateTimePicker
    Friend WithEvents txtbox_asalSurat As TextBox
    Friend WithEvents txtbox_noSM As TextBox
    Friend WithEvents txtbox_perihal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbox_keterangan As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txtbox_cari As TextBox
    Friend WithEvents btn_cari As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtbox_disposisi As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtbox_sifatSurat As TextBox
    Friend WithEvents txtbox_idSM As TextBox
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
