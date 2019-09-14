Imports System.Data.Odbc
Public Class ST
    Dim simpan, ubah, hapus, cari As String
    Sub disableField()
        txtbox_nopkp2t.Enabled = False
        txtbox_noSP.Enabled = False
        dtp_tglSP.Enabled = False
        txtbox_noST.Enabled = False
        dtp_tglST.Enabled = False
        dtp_mulaiST.Enabled = False
        dtp_selesaiST.Enabled = False
        txtbox_lamaST.Enabled = False
        dtp_mulaiDL.Enabled = False
        dtp_selesaiDL.Enabled = False
        txtbox_lamaDL.Enabled = False
        txtbox_perihal.Enabled = False
        txtbox_namaTIm.Enabled = False
        txtbox_keterangan.Enabled = False
        rbo_pkp2t.Enabled = False
        rbo_nonpkp2t.Enabled = False
        txtbox_asalFileLampiran.Enabled = False
        txtbox_simpanKeLampiran.Enabled = False
        btn_browseDariLampiran.Enabled = False
        btn_browseSimpanKeLampiran.Enabled = False
        btn_unggahLampiran.Enabled = False
    End Sub
    Sub enableField()
        txtbox_noSP.Enabled = True
        dtp_tglSP.Enabled = True
        txtbox_noST.Enabled = True
        dtp_tglST.Enabled = True
        dtp_mulaiST.Enabled = True
        dtp_selesaiST.Enabled = True
        txtbox_lamaST.Enabled = True
        dtp_mulaiDL.Enabled = True
        dtp_selesaiDL.Enabled = True
        txtbox_lamaDL.Enabled = True
        txtbox_perihal.Enabled = True
        txtbox_namaTIm.Enabled = True
        txtbox_keterangan.Enabled = True
        rbo_pkp2t.Enabled = True
        rbo_nonpkp2t.Enabled = True
        txtbox_asalFileLampiran.Enabled = True
        txtbox_simpanKeLampiran.Enabled = True
        btn_browseDariLampiran.Enabled = True
        btn_browseSimpanKeLampiran.Enabled = True
        btn_unggahLampiran.Enabled = True
    End Sub
    Sub clearField()
        rbo_nonpkp2t.Checked = True
        txtbox_nopkp2t.Clear()
        txtbox_noSP.Clear()
        dtp_tglST.ResetText()
        txtbox_noST.Clear()
        dtp_tglST.ResetText()
        dtp_mulaiST.ResetText()
        dtp_selesaiST.ResetText()
        txtbox_lamaST.Clear()
        dtp_mulaiDL.ResetText()
        dtp_selesaiDL.ResetText()
        txtbox_lamaDL.Clear()
        txtbox_perihal.Clear()
        txtbox_namaTIm.Clear()
        txtbox_keterangan.Clear()
        txtbox_cari.Clear()
        txtbox_asalFileLampiran.Clear()
        txtbox_simpanKeLampiran.Clear()
    End Sub
    Sub tampilData()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM st", conn)
        ds = New DataSet
        da.Fill(ds, "st")
        dgv_tampil.DataSource = ds.Tables("st")
    End Sub
    Sub simpanData()
        Dim pkp2t As String
        koneksi()
        If rbo_pkp2t.Checked = True Then
            pkp2t = "PKP2T"
            txtbox_nopkp2t.Enabled = True
        Else
            pkp2t = "NonPKP2T"
        End If
        simpan = "INSERT INTO st VALUES('','" & pkp2t & "','" & txtbox_nopkp2t.Text & "'
,'" & txtbox_noSP.Text & "','" & dtp_tglSP.Text & "','" & txtbox_noST.Text & "','" & dtp_tglST.Text & "'
,'" & dtp_mulaiST.Text & "','" & dtp_selesaiST.Text & "','" & txtbox_lamaST.Text & "','" & dtp_mulaiDL.Text & "'
,'" & dtp_selesaiDL.Text & "','" & txtbox_lamaDL.Text & "','" & txtbox_perihal.Text & "'
,'" & txtbox_namaTIm.Text & "','" & txtbox_keterangan.Text & "')"
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
        Dim pkp2t As String
        If rbo_pkp2t.Checked = True Then
            pkp2t = "Sudah"
        Else
            pkp2t = "Belum"
        End If
        ubah = "UPDATE st SET `Status PKP2T` ='" & pkp2t & "',`No PKP2T` ='" & txtbox_nopkp2t.Text &
            "',`No Surat Pengantar` ='" & txtbox_noSP.Text & "',`Tanggal Surat Pengantar` ='" & dtp_tglSP.Text &
            "',`No Surat Tugas` ='" & txtbox_noST.Text & "',`Tanggal Surat Tugas` ='" & dtp_tglST.Text &
            "',`Mulai Surat Tugas` ='" & dtp_mulaiST.Text & "',`Selesai Surat Tugas` ='" & dtp_selesaiST.Text &
            "',`Lama Surat Tugas` ='" & txtbox_lamaST.Text & "',`Mulai Dinas Luar` ='" & dtp_mulaiDL.Text &
            "',`Selesai Dinas Luar` ='" & dtp_selesaiDL.Text & "',`Lama Dinas Luar` ='" & txtbox_lamaDL.Text &
            "',`Uraian Surat Tugas` ='" & txtbox_perihal.Text & "',`Nama Tim` ='" & txtbox_namaTIm.Text &
            "',`Keterangan` ='" & txtbox_keterangan.Text & "' WHERE `ID Penugasan` ='" & txtbox_idPenugasan.Text & "'"
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
        hapus = "DELETE FROM st WHERE `ID Penugasan` ='" & txtbox_idPenugasan.Text & "'"
        queri = New OdbcCommand(hapus, conn)
        queri.ExecuteNonQuery()
        If MessageBox.Show("Data berhasil dihapus", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            tampilData()
            clearField()
            disableField()
        End If
    End Sub
    Sub cariData()
        da = New OdbcDataAdapter("SELECT * FROM st WHERE `No Surat Pengantar` LIKE '%' '" & txtbox_cari.Text & "' '%' 
OR `No Surat Tugas` LIKE '%' '" & txtbox_cari.Text & "' '%'", conn)
        ds = New DataSet
        da.Fill(ds, "st")
        dgv_tampil.DataSource = ds.Tables("st")
        If dgv_tampil.RowCount > 0 Then
            Dim baris As Integer
            With dgv_tampil
                baris = .CurrentRow.Index
                txtbox_idPenugasan.Text = .Item(0, baris).Value
                If .Item(1, baris).Value = "Sudah" Then
                    rbo_pkp2t.Checked = True
                    txtbox_nopkp2t.Enabled = False
                ElseIf .Item(1, baris).Value = "Belum" Then
                    rbo_nonpkp2t.Checked = True
                End If
                txtbox_nopkp2t.Text = .Item(2, baris).Value
                txtbox_noSP.Text = .Item(3, baris).Value
                dtp_tglSP.Value = .Item(4, baris).Value
                txtbox_noST.Text = .Item(5, baris).Value
                dtp_tglST.Value = .Item(6, baris).Value
                dtp_mulaiST.Value = .Item(7, baris).Value
                dtp_selesaiST.Value = .Item(8, baris).Value
                txtbox_lamaST.Text = .Item(9, baris).Value
                dtp_mulaiDL.Value = .Item(10, baris).Value
                dtp_selesaiDL.Value = .Item(11, baris).Value
                txtbox_lamaDL.Text = .Item(12, baris).Value
                txtbox_perihal.Text = .Item(13, baris).Value
                txtbox_namaTIm.Text = .Item(14, baris).Value
                txtbox_keterangan.Text = .Item(15, baris).Value

                disableField()
                btn_tambah.Text = "Ubah"
                btn_tambah.Enabled = True
                btn_simpan.Text = "Perbarui"
                btn_simpan.Enabled = False
                btn_cancel.Enabled = True
                btn_hapus.Enabled = True
                MsgBox("Data berhasil ditemukan", vbInformation, "INFORMATION")
            End With
        Else
            MsgBox("Data tidak ditemukan", vbCritical, "INFORMATION")
        End If
    End Sub
    Private Sub rbo_nonpkp2t_CheckedChanged(sender As Object, e As EventArgs) Handles rbo_nonpkp2t.CheckedChanged
        txtbox_nopkp2t.Enabled = False
    End Sub
    Private Sub rbo_pkp2t_CheckedChanged(sender As Object, e As EventArgs) Handles rbo_pkp2t.CheckedChanged
        txtbox_nopkp2t.Enabled = True
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
                txtbox_idPenugasan.Text = .Item(0, baris).Value
                If .Item(1, baris).Value = "Sudah" Then
                    rbo_pkp2t.Checked = True
                    txtbox_nopkp2t.Enabled = False
                ElseIf .Item(1, baris).Value = "Belum" Then
                    rbo_nonpkp2t.Checked = True
                End If
                txtbox_nopkp2t.Text = .Item(2, baris).Value
                txtbox_noSP.Text = .Item(3, baris).Value
                dtp_tglSP.Value = .Item(4, baris).Value
                txtbox_noST.Text = .Item(5, baris).Value
                dtp_tglST.Value = .Item(6, baris).Value
                dtp_mulaiST.Value = .Item(7, baris).Value
                dtp_selesaiST.Value = .Item(8, baris).Value
                txtbox_lamaST.Text = .Item(9, baris).Value
                dtp_mulaiDL.Value = .Item(10, baris).Value
                dtp_selesaiDL.Value = .Item(11, baris).Value
                txtbox_lamaDL.Text = .Item(12, baris).Value
                txtbox_perihal.Text = .Item(13, baris).Value
                txtbox_namaTIm.Text = .Item(14, baris).Value
                txtbox_keterangan.Text = .Item(15, baris).Value
            End With
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        disableField()
        clearField()
        rbo_nonpkp2t.Checked = True
        btn_tambah.Text = "Tambah"
        btn_tambah.Enabled = True
        btn_simpan.Text = "Simpan"
        btn_simpan.Enabled = False
        btn_cancel.Enabled = False
        btn_hapus.Enabled = False
        btn_unggahLampiran.Enabled = False
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
        System.IO.Directory.CreateDirectory("A:\Documents\Visual Studio 2017\Projects\IPP Application\Lampiran Server\SURAT TUGAS\LAMPIRAN")
        SaveFileDialog1.Title = "Simpan lampiran ke"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.Filter = "*.zip|*.zip"
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.DefaultExt = ".zip"
        SaveFileDialog1.CreatePrompt = False
        SaveFileDialog1.InitialDirectory = "A:\Documents\Visual Studio 2017\Projects\IPP Application\Lampiran Server\SURAT TUGAS\LAMPIRAN"
        SaveFileDialog1.ShowDialog()

        txtbox_simpanKeLampiran.Text = SaveFileDialog1.FileName
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

    Private Sub txtbox_asalFileLampiran_TextChanged(sender As Object, e As EventArgs) Handles txtbox_asalFileLampiran.TextChanged
        btn_unggahLampiran.Enabled = True
    End Sub
    Private Sub ST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        disableField()
        rbo_nonpkp2t.Checked = True
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
            dgv_tampil.Select()
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
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Simpan" Then
            koneksi()
            'Validasi No Surat Tugas & Uraian
            Dim no_st, uraian
            Dim lihat As String = "SELECT * FROM st WHERE `ID Penugasan` ='" & txtbox_idPenugasan.Text & "'"
            Dim perintah As New OdbcCommand(lihat, conn)
            Dim reader As OdbcDataReader = perintah.ExecuteReader()

            While reader.Read()
                no_st = reader(5)
                uraian = reader(13)
            End While
            reader.Close()
            If rbo_pkp2t.Checked = True And txtbox_nopkp2t.Text = "" Then
                MsgBox("Kolom No PKP2T masih kosong", vbExclamation, "WARNING")
                txtbox_nopkp2t.Select()
            ElseIf txtbox_noSP.Text = "" Then
                MsgBox("Kolom No Surat Pengantar masih kosong", vbExclamation, "WARNING")
                txtbox_noSP.Select()
            ElseIf txtbox_noST.Text = "" Then
                MsgBox("Kolom No Surat Tugas masih kosong", vbExclamation, "WARNING")
                txtbox_noST.Select()
            ElseIf txtbox_lamaST.Text = "" Then
                MsgBox("Kolom lama surat tugas masih kosong", vbExclamation, "WARNING")
                txtbox_lamaST.Select()
            ElseIf txtbox_lamaDL.Text = "" Then
                MsgBox("Kolom lama dinas luar masih kosong", vbExclamation, "WARNING")
                txtbox_lamaDL.Select()
            ElseIf txtbox_perihal.Text = "" Then
                MsgBox("Kolom Uraian surat tugas masih kosong", vbExclamation, "WARNING")
                txtbox_perihal.Select()
            ElseIf txtbox_namaTIm.Text = "" Then
                MsgBox("Kolom No Surat Pengantar masih kosong", vbExclamation, "WARNING")
                txtbox_namaTIm.Select()
            ElseIf no_st = txtbox_noST.Text Then
                MsgBox("No Surat Tugas sudah ada diDatabase", vbCritical, "ERROR")
                txtbox_noST.Select()
            ElseIf uraian = txtbox_perihal.Text Then
                MsgBox("Uraian Surat Tugas sudah ada diDatabase", vbCritical, "ERROR")
                txtbox_perihal.Select()
            Else
                simpanData()
                disableField()
                btn_tambah.Enabled = True
                btn_simpan.Enabled = False
                btn_hapus.Enabled = False
                btn_cancel.Enabled = False
            End If

        ElseIf btn_simpan.Text = "Perbarui" Then
            If rbo_pkp2t.Checked = True And txtbox_nopkp2t.Text = "" Then
                MsgBox("Kolom No PKP2T masih kosong", vbExclamation, "WARNING")
                txtbox_nopkp2t.Select()
            ElseIf txtbox_noSP.Text = "" Then
                MsgBox("Kolom No Surat Pengantar masih kosong", vbExclamation, "WARNING")
                txtbox_noSP.Select()
            ElseIf txtbox_noST.Text = "" Then
                MsgBox("Kolom No Surat Tugas masih kosong", vbExclamation, "WARNING")
                txtbox_noST.Select()
            ElseIf txtbox_lamaST.Text = "" Then
                MsgBox("Kolom lama surat tugas masih kosong", vbExclamation, "WARNING")
                txtbox_lamaST.Select()
            ElseIf txtbox_lamaDL.Text = "" Then
                MsgBox("Kolom lama dinas luar masih kosong", vbExclamation, "WARNING")
                txtbox_lamaDL.Select()
            ElseIf txtbox_perihal.Text = "" Then
                MsgBox("Kolom Uraian surat tugas masih kosong", vbExclamation, "WARNING")
                txtbox_perihal.Select()
            ElseIf txtbox_namaTIm.Text = "" Then
                MsgBox("Kolom No Surat Pengantar masih kosong", vbExclamation, "WARNING")
                txtbox_namaTIm.Select()
            Else
                ubahData()
                disableField()
            End If
        End If
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