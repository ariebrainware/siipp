<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonPPM
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
        Me.dtp_tglPPM = New System.Windows.Forms.DateTimePicker()
        Me.txtbox_lamaPPM = New System.Windows.Forms.TextBox()
        Me.txtbox_jumlahPeserta = New System.Windows.Forms.TextBox()
        Me.txtbox_notulis = New System.Windows.Forms.TextBox()
        Me.txtbox_penyaji = New System.Windows.Forms.TextBox()
        Me.txtbox_waktu = New System.Windows.Forms.TextBox()
        Me.txtbox_judulPPM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_tampil = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.txtbox_cari = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.txtbox_idPPM = New System.Windows.Forms.TextBox()
        CType(Me.dgv_tampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal PPM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lama PPM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Waktu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Judul PPM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Penyaji"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Notulis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jumlah Peserta"
        '
        'dtp_tglPPM
        '
        Me.dtp_tglPPM.Location = New System.Drawing.Point(106, 14)
        Me.dtp_tglPPM.Name = "dtp_tglPPM"
        Me.dtp_tglPPM.Size = New System.Drawing.Size(200, 20)
        Me.dtp_tglPPM.TabIndex = 7
        '
        'txtbox_lamaPPM
        '
        Me.txtbox_lamaPPM.Location = New System.Drawing.Point(106, 40)
        Me.txtbox_lamaPPM.Name = "txtbox_lamaPPM"
        Me.txtbox_lamaPPM.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_lamaPPM.TabIndex = 8
        '
        'txtbox_jumlahPeserta
        '
        Me.txtbox_jumlahPeserta.Location = New System.Drawing.Point(106, 192)
        Me.txtbox_jumlahPeserta.Name = "txtbox_jumlahPeserta"
        Me.txtbox_jumlahPeserta.Size = New System.Drawing.Size(52, 20)
        Me.txtbox_jumlahPeserta.TabIndex = 9
        '
        'txtbox_notulis
        '
        Me.txtbox_notulis.Location = New System.Drawing.Point(106, 166)
        Me.txtbox_notulis.Name = "txtbox_notulis"
        Me.txtbox_notulis.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_notulis.TabIndex = 10
        '
        'txtbox_penyaji
        '
        Me.txtbox_penyaji.Location = New System.Drawing.Point(106, 140)
        Me.txtbox_penyaji.Name = "txtbox_penyaji"
        Me.txtbox_penyaji.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_penyaji.TabIndex = 11
        '
        'txtbox_waktu
        '
        Me.txtbox_waktu.Location = New System.Drawing.Point(106, 66)
        Me.txtbox_waktu.Name = "txtbox_waktu"
        Me.txtbox_waktu.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_waktu.TabIndex = 12
        '
        'txtbox_judulPPM
        '
        Me.txtbox_judulPPM.Location = New System.Drawing.Point(106, 92)
        Me.txtbox_judulPPM.Multiline = True
        Me.txtbox_judulPPM.Name = "txtbox_judulPPM"
        Me.txtbox_judulPPM.Size = New System.Drawing.Size(200, 39)
        Me.txtbox_judulPPM.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(164, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Orang"
        '
        'dgv_tampil
        '
        Me.dgv_tampil.AllowUserToAddRows = False
        Me.dgv_tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tampil.Location = New System.Drawing.Point(312, 14)
        Me.dgv_tampil.Name = "dgv_tampil"
        Me.dgv_tampil.Size = New System.Drawing.Size(506, 251)
        Me.dgv_tampil.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(634, 302)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(144, 13)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "*cari berdasarkan Judul PPM"
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(556, 273)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari.TabIndex = 64
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'txtbox_cari
        '
        Me.txtbox_cari.Location = New System.Drawing.Point(637, 275)
        Me.txtbox_cari.Name = "txtbox_cari"
        Me.txtbox_cari.Size = New System.Drawing.Size(181, 20)
        Me.txtbox_cari.TabIndex = 63
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(142, 275)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 62
        Me.btn_cancel.Text = "Batal"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(61, 275)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 61
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(142, 243)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 60
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(61, 242)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 59
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'txtbox_idPPM
        '
        Me.txtbox_idPPM.Location = New System.Drawing.Point(556, 302)
        Me.txtbox_idPPM.Name = "txtbox_idPPM"
        Me.txtbox_idPPM.ReadOnly = True
        Me.txtbox_idPPM.Size = New System.Drawing.Size(52, 20)
        Me.txtbox_idPPM.TabIndex = 66
        Me.txtbox_idPPM.Visible = False
        '
        'MonPPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 325)
        Me.Controls.Add(Me.txtbox_idPPM)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.txtbox_cari)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.dgv_tampil)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbox_judulPPM)
        Me.Controls.Add(Me.txtbox_waktu)
        Me.Controls.Add(Me.txtbox_penyaji)
        Me.Controls.Add(Me.txtbox_notulis)
        Me.Controls.Add(Me.txtbox_jumlahPeserta)
        Me.Controls.Add(Me.txtbox_lamaPPM)
        Me.Controls.Add(Me.dtp_tglPPM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MonPPM"
        Me.Text = "MonPPM"
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
    Friend WithEvents dtp_tglPPM As DateTimePicker
    Friend WithEvents txtbox_lamaPPM As TextBox
    Friend WithEvents txtbox_jumlahPeserta As TextBox
    Friend WithEvents txtbox_notulis As TextBox
    Friend WithEvents txtbox_penyaji As TextBox
    Friend WithEvents txtbox_waktu As TextBox
    Friend WithEvents txtbox_judulPPM As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_tampil As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_cari As Button
    Friend WithEvents txtbox_cari As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents txtbox_idPPM As TextBox
End Class
