Imports System.Data.Odbc
Public Class ASM
    Dim simpan, ubah, hapus, cari As String
    Sub disableField()
        dtp_suratMasuk.Enabled = False
        txtbox_asalSurat.Enabled = False
        txtbox_noSM.Enabled = False
        dtp_suratDiterima.Enabled = False
        txtbox_sifatSurat.Enabled = False
        txtbox_perihal.Enabled = False
        txtbox_disposisi.Enabled = False
        txtbox_keterangan.Enabled = False

        btn_browseDariLampiran.Enabled = False
        btn_browseSimpanKeLampiran.Enabled = False
        txtbox_asalFileLampiran.Enabled = False
        txtbox_simpanKeLampiran.Enabled = False
    End Sub
    Sub enableField()
        dtp_suratMasuk.Enabled = True
        txtbox_asalSurat.Enabled = True
        txtbox_noSM.Enabled = True
        dtp_suratDiterima.Enabled = True
        txtbox_sifatSurat.Enabled = True
        txtbox_perihal.Enabled = True
        txtbox_disposisi.Enabled = True
        txtbox_keterangan.Enabled = True

        btn_browseDariLampiran.Enabled = True
        btn_browseSimpanKeLampiran.Enabled = True
        txtbox_asalFileLampiran.Enabled = True
        txtbox_simpanKeLampiran.Enabled = True
    End Sub
    Sub clearField()
        dtp_suratMasuk.ResetText()
        txtbox_asalSurat.Clear()
        txtbox_noSM.Clear()
        dtp_suratDiterima.ResetText()
        txtbox_sifatSurat.Clear()
        txtbox_perihal.Clear()
        txtbox_disposisi.Clear()
        txtbox_keterangan.Clear()
        txtbox_cari.Clear()
        txtbox_asalFileLampiran.Clear()
        txtbox_simpanKeLampiran.Clear()
    End Sub
    Sub tampilData()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM asm", conn)
        ds = New DataSet
        da.Fill(ds, "asm")
        dgv_tampil.DataSource = ds.Tables("asm")
    End Sub
    Sub simpanData()
        koneksi()
        simpan = "INSERT INTO asm VALUES('','" & dtp_suratMasuk.Text & "','" & txtbox_asalSurat.Text & "'
,'" & txtbox_noSM.Text & "','" & dtp_suratDiterima.Text & "','" & txtbox_sifatSurat.Text & "'
,'" & txtbox_perihal.Text & "','" & txtbox_disposisi.Text & "'
,'" & txtbox_keterangan.Text & "')"
        queri = New OdbcCommand(simpan, conn)
        queri.ExecuteNonQuery()
        If MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            tampilData()
            clearField()
            btn_simpan.Enabled = False
            btn_tambah.Enabled = True
        End If
    End Sub
    Sub ubahData()
        koneksi()
        ubah = "UPDATE asm SET `Tanggal Surat Masuk` ='" & dtp_suratMasuk.Text & "',`Asal Surat` ='" &
            txtbox_asalSurat.Text & "',`No Surat Masuk` ='" & txtbox_noSM.Text & "',`Tanggal Surat Diterima` ='" &
            dtp_suratDiterima.Text & "',`Sifat Surat` ='" & txtbox_sifatSurat.Text & "',`Perihal` ='" &
            txtbox_perihal.Text & "',`Disposisi` ='" & txtbox_disposisi.Text & "',`Keterangan` ='" &
            txtbox_keterangan.Text & "' WHERE `ID Surat Masuk` ='" & txtbox_idSM.Text & "'"
        queri = New OdbcCommand(ubah, conn)
        queri.ExecuteNonQuery()
        If MessageBox.Show("Data berhasil diubah", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            tampilData()
            clearField()
            disableField()
        End If
    End Sub
    Sub hapusData()
        koneksi()
        hapus = "DELETE FROM asm WHERE `ID Surat Masuk` ='" & txtbox_idSM.Text & "'"
        queri = New OdbcCommand(hapus, conn)
        queri.ExecuteNonQuery()
        If MessageBox.Show("Data berhasil dihapus", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            tampilData()
            clearField()
            disableField()
        End If
    End Sub
    Sub cariData()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM asm WHERE `Asal Surat` LIKE '%' '" & txtbox_cari.Text & "' '%'
OR `No Surat Masuk` LIKE '%' '" & txtbox_cari.Text & "' '%'
OR `Perihal` LIKE '%' '" & txtbox_cari.Text & "' '%'", conn)
        ds = New DataSet
        da.Fill(ds, "asm")
        dgv_tampil.DataSource = ds.Tables("asm")
        If dgv_tampil.RowCount > 0 Then
            Dim baris As Integer
            With dgv_tampil
                baris = .CurrentRow.Index
                txtbox_idSM.Text = .Item(0, baris).Value
                dtp_suratMasuk.Value = .Item(1, baris).Value
                txtbox_asalSurat.Text = .Item(2, baris).Value
                txtbox_noSM.Text = .Item(3, baris).Value
                dtp_suratDiterima.Value = .Item(4, baris).Value
                txtbox_sifatSurat.Text = .Item(5, baris).Value
                txtbox_perihal.Text = .Item(6, baris).Value
                txtbox_disposisi.Text = .Item(7, baris).Value
                txtbox_keterangan.Text = .Item(8, baris).Value

                disableField()
                btn_tambah.Text = "Ubah"
                btn_tambah.Enabled = True
                btn_simpan.Text = "Perbarui"
                btn_simpan.Enabled = False
                btn_cancel.Enabled = True
                btn_hapus.Enabled = True
                MsgBox("Data Berhasil ditemukan", vbInformation, "INFORMATION")
            End With
        Else
            MsgBox("Data tidak ditemukan", vbCritical, "INFORMATION")
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Simpan" Then
            koneksi()
            'Validasi Perihal &  No Surat Masuk
            Dim perihal, no_surat
            Dim lihat As String = "SELECT * FROM asm WHERE `ID Surat Masuk` ='" & txtbox_idSM.Text & "'"
            Dim perintah As New OdbcCommand(lihat, conn)
            Dim reader As OdbcDataReader = perintah.ExecuteReader()

            While reader.Read()
                perihal = reader(6)
                no_surat = reader(3)
            End While
            If txtbox_asalSurat.Text = "" Then
                MsgBox("Kolom Asal Surat wajib diisi", vbExclamation, "WARNING")
                txtbox_asalSurat.Select()
            ElseIf txtbox_noSM.Text = "" Then
                MsgBox("Kolom No Surat Masuk wajib diisi", vbExclamation, "WARNING")
                txtbox_noSM.Select()
            ElseIf txtbox_sifatSurat.Text = "" Then
                MsgBox("Kolom Sifat Surat wajib diisi", vbExclamation, "WARNING")
                txtbox_sifatSurat.Select()
            ElseIf txtbox_perihal.Text = "" Then
                MsgBox("Kolom Perihal wajib diisi", vbExclamation, "WARNING")
                txtbox_perihal.Select()
            ElseIf txtbox_disposisi.Text = "" Then
                MsgBox("Kolom Disposisi wajib diisi", vbExclamation, "WARNING")
                txtbox_disposisi.Select()
            ElseIf no_surat = txtbox_noSM.Text Then
                MsgBox("No Surat Masuk sudah ada diDatabase", vbCritical, "ERROR")
                txtbox_noSM.Select()
            ElseIf perihal = txtbox_perihal.Text Then
                MsgBox("Perihal sudah ada diDatabase", vbCritical, "ERROR")
                txtbox_perihal.Select()
            Else
                simpanData()
                clearField()
                disableField()
                btn_unggahLampiran.Enabled = False
                btn_tambah.Enabled = True
                btn_simpan.Enabled = False
                btn_hapus.Enabled = False
                btn_cancel.Enabled = False
            End If
        ElseIf btn_simpan.Text = "Perbarui" Then
            If txtbox_asalSurat.Text = "" Then
                MsgBox("Kolom Asal Surat wajib diisi", vbExclamation, "WARNING")
                txtbox_asalSurat.Select()
            ElseIf txtbox_noSM.Text = "" Then
                MsgBox("Kolom No Surat Masuk wajib diisi", vbExclamation, "WARNING")
                txtbox_noSM.Select()
            ElseIf txtbox_sifatSurat.Text = "" Then
                MsgBox("Kolom Sifat Surat wajib diisi", vbExclamation, "WARNING")
                txtbox_sifatSurat.Select()
            ElseIf txtbox_perihal.Text = "" Then
                MsgBox("Kolom Perihal wajib diisi", vbExclamation, "WARNING")
                txtbox_perihal.Select()
            ElseIf txtbox_disposisi.Text = "" Then
                MsgBox("Kolom Disposisi wajib diisi", vbExclamation, "WARNING")
                txtbox_disposisi.Select()
            Else
                ubahData()
            End If
        End If
    End Sub

    Private Sub dgv_tampil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tampil.CellContentClick
        disableField()
        btn_tambah.Text = "Ubah"
        btn_tambah.Enabled = True
        btn_simpan.Text = "Perbarui"
        btn_simpan.Enabled = False
        btn_cancel.Enabled = True
        btn_hapus.Enabled = True
        If dgv_tampil.RowCount > 0 Then
            Dim baris As Integer
            With dgv_tampil
                baris = .CurrentRow.Index
                txtbox_idSM.Text = .Item(0, baris).Value
                dtp_suratMasuk.Value = .Item(1, baris).Value
                txtbox_asalSurat.Text = .Item(2, baris).Value
                txtbox_noSM.Text = .Item(3, baris).Value
                dtp_suratDiterima.Value = .Item(4, baris).Value
                txtbox_sifatSurat.Text = .Item(5, baris).Value
                txtbox_perihal.Text = .Item(6, baris).Value
                txtbox_disposisi.Text = .Item(7, baris).Value
                txtbox_keterangan.Text = .Item(8, baris).Value
            End With
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        hapusData()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        cariData()
    End Sub

    Private Sub btn_browseDariLampiran_Click(sender As Object, e As EventArgs) Handles btn_browseDariLampiran.Click
        OpenFileDialog1.Title = "Cari File yang akan diunggah"
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.Filter = "Zip file|*.zip"
        OpenFileDialog1.DefaultExt = ".zip"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()

        txtbox_asalFileLampiran.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_browseSimpanKeLampiran_Click(sender As Object, e As EventArgs) Handles btn_browseSimpanKeLampiran.Click
        System.IO.Directory.CreateDirectory("A:\Documents\Visual Studio 2017\Projects\IPP Application\Lampiran Server\ASAL SURAT MASUK\LAMPIRAN")
        SaveFileDialog1.Title = "Simpan lampiran ke"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.Filter = "*.zip|*.zip"
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.DefaultExt = ".zip"
        SaveFileDialog1.CreatePrompt = False
        SaveFileDialog1.InitialDirectory = "A:\Documents\Visual Studio 2017\Projects\IPP Application\Lampiran Server\ASAL SURAT MASUK\LAMPIRAN"
        SaveFileDialog1.ShowDialog()

        txtbox_simpanKeLampiran.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub txtbox_asalFileLampiran_TextChanged(sender As Object, e As EventArgs) Handles txtbox_asalFileLampiran.TextChanged
        btn_unggahLampiran.Enabled = True
    End Sub

    Private Sub btn_unggahLampiran_Click(sender As Object, e As EventArgs) Handles btn_unggahLampiran.Click
        If txtbox_asalFileLampiran.Text = "" Then
            MsgBox("Kolom File Unggahan masih kosong", vbExclamation, "WARNING")
            txtbox_asalFileLampiran.Select()
        ElseIf txtbox_simpanKeLampiran.Text = "" Then
            MsgBox("Kolom File Unggahan masih kosong", vbExclamation, "WARNING")
            txtbox_simpanKeLampiran.Select()
        Else
            FileCopy(txtbox_asalFileLampiran.Text, txtbox_simpanKeLampiran.Text)
            MsgBox("File berhasil diunggah ke Server", vbInformation, "INFORMATION")
        End If
    End Sub

    Private Sub ASM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        disableField()
        btn_tambah.Enabled = True
        btn_simpan.Enabled = False
        btn_cancel.Enabled = False
        btn_hapus.Enabled = False
        btn_unggahLampiran.Enabled = False
        btn_browseDariLampiran.Enabled = False
        btn_browseSimpanKeLampiran.Enabled = False
    End Sub
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If btn_tambah.Text = "Tambah" Then
            enableField()
            btn_tambah.Enabled = False
            btn_simpan.Enabled = True
            btn_cancel.Enabled = True
            btn_unggahLampiran.Enabled = False
            btn_browseDariLampiran.Enabled = True
            btn_browseSimpanKeLampiran.Enabled = True
        Else
            enableField()
            btn_tambah.Enabled = False
            btn_simpan.Enabled = True
            btn_cancel.Enabled = True
            txtbox_asalFileLampiran.Enabled = False
            txtbox_simpanKeLampiran.Enabled = False
            btn_browseDariLampiran.Enabled = False
            btn_browseSimpanKeLampiran.Enabled = False
            btn_unggahLampiran.Enabled = False
        End If
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        disableField()
        clearField()
        btn_tambah.Text = "Tambah"
        btn_tambah.Enabled = True
        btn_simpan.Text = "Simpan"
        btn_simpan.Enabled = False
        btn_cancel.Enabled = False
        btn_hapus.Enabled = False
        btn_browseDariLampiran.Enabled = False
        btn_browseSimpanKeLampiran.Enabled = False
        btn_unggahLampiran.Enabled = False
    End Sub
    Private Sub dgv_tampil_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv_tampil.RowsRemoved
        If dgv_tampil.RowCount = 0 Then
            btn_tambah.Enabled = True
            btn_tambah.Text = "Tambah"
            btn_simpan.Enabled = False
            btn_simpan.Text = "Simpan"
            btn_hapus.Enabled = False
            btn_cancel.Enabled = False

            clearField()
            disableField()
        End If
    End Sub
End Class