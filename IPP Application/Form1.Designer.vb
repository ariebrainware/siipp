<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.btn_asm = New System.Windows.Forms.Button()
        Me.btn_st = New System.Windows.Forms.Button()
        Me.btn_lnh = New System.Windows.Forms.Button()
        Me.btn_kka = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_pegawai = New System.Windows.Forms.Button()
        Me.btn_mak = New System.Windows.Forms.Button()
        Me.btn_ppm = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_asm
        '
        Me.btn_asm.Location = New System.Drawing.Point(10, 68)
        Me.btn_asm.Name = "btn_asm"
        Me.btn_asm.Size = New System.Drawing.Size(122, 43)
        Me.btn_asm.TabIndex = 0
        Me.btn_asm.Text = "Agenda Surat Masuk"
        Me.btn_asm.UseVisualStyleBackColor = True
        '
        'btn_st
        '
        Me.btn_st.Location = New System.Drawing.Point(140, 68)
        Me.btn_st.Name = "btn_st"
        Me.btn_st.Size = New System.Drawing.Size(122, 43)
        Me.btn_st.TabIndex = 1
        Me.btn_st.Text = "Surat Tugas"
        Me.btn_st.UseVisualStyleBackColor = True
        '
        'btn_lnh
        '
        Me.btn_lnh.Location = New System.Drawing.Point(268, 68)
        Me.btn_lnh.Name = "btn_lnh"
        Me.btn_lnh.Size = New System.Drawing.Size(122, 43)
        Me.btn_lnh.TabIndex = 2
        Me.btn_lnh.Text = "Laporan Norma Hasil"
        Me.btn_lnh.UseVisualStyleBackColor = True
        '
        'btn_kka
        '
        Me.btn_kka.Location = New System.Drawing.Point(396, 68)
        Me.btn_kka.Name = "btn_kka"
        Me.btn_kka.Size = New System.Drawing.Size(122, 43)
        Me.btn_kka.TabIndex = 3
        Me.btn_kka.Text = "Kertas Kerja Audit"
        Me.btn_kka.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem, Me.AgendaToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(530, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuratMasukToolStripMenuItem})
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AgendaToolStripMenuItem.Text = "agenda"
        '
        'SuratMasukToolStripMenuItem
        '
        Me.SuratMasukToolStripMenuItem.Name = "SuratMasukToolStripMenuItem"
        Me.SuratMasukToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SuratMasukToolStripMenuItem.Text = "surat masuk"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'btn_pegawai
        '
        Me.btn_pegawai.Location = New System.Drawing.Point(74, 122)
        Me.btn_pegawai.Name = "btn_pegawai"
        Me.btn_pegawai.Size = New System.Drawing.Size(122, 43)
        Me.btn_pegawai.TabIndex = 6
        Me.btn_pegawai.Text = "Data Pegawai"
        Me.btn_pegawai.UseVisualStyleBackColor = True
        '
        'btn_mak
        '
        Me.btn_mak.Location = New System.Drawing.Point(202, 122)
        Me.btn_mak.Name = "btn_mak"
        Me.btn_mak.Size = New System.Drawing.Size(122, 43)
        Me.btn_mak.TabIndex = 7
        Me.btn_mak.Text = "Matriks Angka Kredit"
        Me.btn_mak.UseVisualStyleBackColor = True
        '
        'btn_ppm
        '
        Me.btn_ppm.Location = New System.Drawing.Point(330, 122)
        Me.btn_ppm.Name = "btn_ppm"
        Me.btn_ppm.Size = New System.Drawing.Size(122, 43)
        Me.btn_ppm.TabIndex = 8
        Me.btn_ppm.Text = "Monitoring PPM"
        Me.btn_ppm.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 177)
        Me.Controls.Add(Me.btn_ppm)
        Me.Controls.Add(Me.btn_mak)
        Me.Controls.Add(Me.btn_pegawai)
        Me.Controls.Add(Me.btn_kka)
        Me.Controls.Add(Me.btn_lnh)
        Me.Controls.Add(Me.btn_st)
        Me.Controls.Add(Me.btn_asm)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainForm"
        Me.Text = "SIIPP"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_asm As Button
    Friend WithEvents btn_st As Button
    Friend WithEvents btn_lnh As Button
    Friend WithEvents btn_kka As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_pegawai As Button
    Friend WithEvents btn_mak As Button
    Friend WithEvents btn_ppm As Button
    Friend WithEvents AgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuratMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
