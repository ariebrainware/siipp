Imports System.Data.Odbc
Public Class KKA
    Dim simpan, ubah, hapus, cari As String
    Dim status_pkp2t = ""
    Sub disableField()
        txtbox_noArsip.Enabled = False
        dtp_tglArsip.Enabled = False
        cbox_suratTugas.Enabled = False
        rbo_pkp2t.Enabled = False
        rbo_pkp2t.Checked = True
        rbo_nonpkp2t.Enabled = False
        txtbox_noPKP2T.Enabled = False
        dtp_suratTugas.Enabled = False
        cbox_noLaporan.Enabled = False
        dtp_laporan.Enabled = False
        txtbox_namaLaporan.Enabled = False
        txtbox_judul.Enabled = False
        txtbox_namaTim.Enabled = False
        txtbox_keterangan.Enabled = False
        txtbox_asalFileLampiran.Enabled = False
        txtbox_simpanKeLampiran.Enabled = False
    End Sub
    Sub enableField()
        txtbox_noArsip.Enabled = True
        dtp_tglArsip.Enabled = True
        cbox_suratTugas.Enabled = True
        cbox_noLaporan.Enabled = True
        txtbox_keterangan.Enabled = True
        txtbox_asalFileLampiran.Enabled = True
        txtbox_simpanKeLampiran.Enabled = True
    End Sub
    Sub clearField()
        txtbox_noArsip.Clear()
        dtp_tglArsip.ResetText()
        cbox_suratTugas.ResetText()
        rbo_pkp2t.Checked = True
        dtp_suratTugas.ResetText()
        cbox_noLaporan.ResetText()
        dtp_laporan.ResetText()
        txtbox_namaLaporan.Clear()
        txtbox_judul.Clear()
        txtbox_namaTim.Clear()
        txtbox_keterangan.Clear()
        txtbox_asalFileLampiran.Clear()
        txtbox_simpanKeLampiran.Clear()
    End Sub
    Sub tampilData()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM kka", conn)
        ds = New DataSet
        da.Fill(ds, "kka")
        dgv_tampil.DataSource = ds.Tables("kka")
    End Sub
    Sub simpanData()
        koneksi()
        Dim rbo_StatusPKP2T
        If rbo_pkp2t.Checked = True Then
            rbo_StatusPKP2T = "PKP2T"
        Else
            rbo_StatusPKP2T = "NonPKP2T"
        End If
        simpan = "INSERT INTO kka VALUES('" & txtbox_noArsip.Text & "','" & dtp_tglArsip.Text & "'
,'" & cbox_suratTugas.Text & "','" & rbo_StatusPKP2T & "','" & txtbox_noPKP2T.Text & "'
,'" & dtp_suratTugas.Text & "','" & cbox_noLaporan.Text & "','" & dtp_laporan.Text & "'
,'" & txtbox_namaLaporan.Text & "','" & txtbox_judul.Text & "','" & txtbox_namaTim.Text & "'
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
        Dim rbo_StatusPKP2T
        If rbo_pkp2t.Checked = True Then
            rbo_StatusPKP2T = "PKP2T"
        Else
            rbo_StatusPKP2T = "NonPKP2T"
        End If
        ubah = "UPDATE kka SET `Tanggal Arsip KKA` ='" & dtp_tglArsip.Text & "',`No Surat Tugas` ='" & cbox_suratTugas.Text & "'
,`Status PKP2T` ='" & rbo_StatusPKP2T & "',`No PKP2T` ='" & txtbox_noPKP2T.Text & "',`Tanggal Surat Tugas`='" & dtp_suratTugas.Text & "'
,`No Laporan` ='" & cbox_noLaporan.Text & "',`Tanggal Laporan` ='" & dtp_laporan.Text & "',`Judul Laporan`='" & txtbox_namaLaporan.Text & "'
,`Judul KKA` ='" & txtbox_judul.Text & "',`Nama Tim` ='" & txtbox_namaTim.Text & "',`Keterangan`='" & txtbox_keterangan.Text & "' 
WHERE `No Arsip KKA`='" & txtbox_noArsip.Text & "'"
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
        hapus = "DELETE FROM kka WHERE `No Arsip KKA` ='" & txtbox_noArsip.Text & "'"
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
        da = New OdbcDataAdapter("SELECT * FROM kka WHERE `No Arsip KKA` LIKE '%' '" & txtbox_cari.Text & "' '%' 
OR `Judul KKA` LIKE '%' '" & txtbox_cari.Text & "' '%'", conn)
        ds = New DataSet
        da.Fill(ds, "kka")
        dgv_tampil.DataSource = ds.Tables("kka")
        If dgv_tampil.RowCount > 0 Then
            Dim baris As Integer
            With dgv_tampil
                baris = .CurrentRow.Index
                txtbox_noArsip.Text = .Item(0, baris).Value
                dtp_tglArsip.Value = .Item(1, baris).Value
                cbox_suratTugas.Text = .Item(2, baris).Value
                If .Item(3, baris).Value = "PKP2T" Then
                    rbo_pkp2t.Checked = True
                Else
                    rbo_nonpkp2t.Checked = True
                End If
                txtbox_noPKP2T.Text = .Item(4, baris).Value
                dtp_suratTugas.Value = .Item(5, baris).Value
                cbox_noLaporan.Text = .Item(6, baris).Value
                dtp_laporan.Value = .Item(7, baris).Value
                txtbox_namaLaporan.Text = .Item(8, baris).Value
                txtbox_judul.Text = .Item(9, baris).Value
                txtbox_namaTim.Text = .Item(10, baris).Value
                txtbox_keterangan.Text = .Item(11, baris).Value

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
    Private Sub KKA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        disableField()

        btn_tambah.Enabled = True
        btn_simpan.Enabled = False
        btn_cancel.Enabled = False
        btn_hapus.Enabled = False
        btn_unggahLampiran.Enabled = False
        btn_browseDariLampiran.Enabled = False
        btn_browseSimpanKeLampiran.Enabled = False

        da = New OdbcDataAdapter("SELECT `No Surat Tugas` FROM st", conn)
        ds = New DataSet
        da.Fill(ds, "st")
        cbox_suratTugas.DataSource = (ds.Tables("st"))
        cbox_suratTugas.ValueMember = "No Surat Tugas"

        da = New OdbcDataAdapter("SELECT `No Laporan` FROM lnh", conn)
        ds = New DataSet
        da.Fill(ds, "lnh")
        cbox_noLaporan.DataSource = (ds.Tables("lnh"))
        cbox_noLaporan.ValueMember = "No Laporan"
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        tampilData()
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
        System.IO.Directory.CreateDirectory("A:\Documents\Visual Studio 2017\Projects\IPP Application\Lampiran Server\KERTAS KERJA AUDIT\LAMPIRAN")
        SaveFileDialog1.Title = "Simpan lampiran ke"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.Filter = "*.zip|*.zip"
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.DefaultExt = ".zip"
        SaveFileDialog1.CreatePrompt = False
        SaveFileDialog1.InitialDirectory = "A:\Documents\Visual Studio 2017\Projects\IPP Application\Lampiran Server\KERTAS KERJA AUDIT\LAMPIRAN"
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
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Simpan" Then
            koneksi()
            'Validasi No Arsip & Judul
            Dim no_arsip, judul
            Dim lihat As String = "SELECT * FROM kka WHERE `No Arsip KKA` ='" & txtbox_noArsip.Text & "'"
            Dim perintah As New OdbcCommand(lihat, conn)
            Dim reader As OdbcDataReader = perintah.ExecuteReader()

            While reader.Read()
                no_arsip = reader(0)
                judul = reader(8)
            End While
            reader.Close()
            If txtbox_noArsip.Text = "" Then
                MsgBox("Kolom no Arsip wajib diisi", vbExclamation, "WARNING")
                txtbox_noArsip.Select()
            ElseIf no_arsip = txtbox_noArsip.Text Then
                MsgBox("No Arsip KKA sudah terdaftar diDatabase", vbCritical, "ERROR")
                txtbox_noArsip.Select()
            ElseIf judul = txtbox_judul.Text Then
                MsgBox("Judul sudah terdaftar diDatabase", vbCritical, "ERROR")
                txtbox_judul.Select()
            Else
                simpanData()
                disableField()
                btn_tambah.Enabled = True
                btn_simpan.Enabled = False
                btn_hapus.Enabled = False
                btn_cancel.Enabled = False
            End If
        ElseIf btn_simpan.Text = "Perbarui" Then
            If txtbox_noArsip.Text = "" Then
                MsgBox("Kolom no Arsip wajib diisi", vbExclamation, "WARNING")
                txtbox_noArsip.Select()
            Else
                ubahData()
                disableField()
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
                txtbox_noArsip.Text = .Item(0, baris).Value
                dtp_tglArsip.Value = .Item(1, baris).Value
                cbox_suratTugas.Text = .Item(2, baris).Value
                If .Item(3, baris).Value = "PKP2T" Then
                    rbo_pkp2t.Checked = True
                Else
                    rbo_nonpkp2t.Checked = True
                End If
                txtbox_noPKP2T.Text = .Item(4, baris).Value
                dtp_suratTugas.Value = .Item(5, baris).Value
                cbox_noLaporan.Text = .Item(6, baris).Value
                dtp_laporan.Value = .Item(7, baris).Value
                txtbox_namaLaporan.Text = .Item(8, baris).Value
                txtbox_judul.Text = .Item(9, baris).Value
                txtbox_namaTim.Text = .Item(10, baris).Value
                txtbox_keterangan.Text = .Item(11, baris).Value
            End With
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        hapusData()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        cariData()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If btn_tambah.Text = "Tambah" Then
            enableField()
            btn_tambah.Enabled = False
            btn_simpan.Enabled = True
            btn_cancel.Enabled = True
            btn_browseDariLampiran.Enabled = True
            btn_browseSimpanKeLampiran.Enabled = True

        Else
            enableField()
            btn_tambah.Enabled = False
            btn_simpan.Enabled = True
            btn_cancel.Enabled = True

            txtbox_noArsip.Enabled = False
            txtbox_asalFileLampiran.Enabled = False
            txtbox_simpanKeLampiran.Enabled = False
            btn_browseDariLampiran.Enabled = False
            btn_browseSimpanKeLampiran.Enabled = False
            btn_unggahLampiran.Enabled = False
        End If
    End Sub
    Private Sub cbox_suratTugas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbox_suratTugas.SelectedValueChanged
        koneksi()
        'status pkp2t dan tanggal surat tugas
        Dim lihat As String = "SELECT * FROM st WHERE `No Surat Tugas` ='" & cbox_suratTugas.Text & "'"
        Dim perintah As New OdbcCommand(lihat, conn)
        Dim reader As OdbcDataReader = perintah.ExecuteReader()

        While reader.Read()
            status_pkp2t = reader(1)
            txtbox_noPKP2T.Text = reader(2)
            dtp_suratTugas.Value = reader(6)
            txtbox_namaTim.Text = reader(14)
            txtbox_judul.Text = reader(13)

        End While
        reader.Close()

        If status_pkp2t = "PKP2T" Then
            rbo_pkp2t.Checked = True
        ElseIf status_pkp2t = "NonPKP2T" Then
            rbo_nonpkp2t.Checked = True
        End If
    End Sub

    Private Sub cbox_noLaporan_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbox_noLaporan.SelectedValueChanged
        koneksi()
        'tanggal laporan dan judul laporan
        Dim lihat As String = "SELECT * FROM lnh WHERE `No Laporan` ='" & cbox_noLaporan.Text & "'"
        Dim perintah As New OdbcCommand(lihat, conn)
        Dim reader As OdbcDataReader = perintah.ExecuteReader()

        While reader.Read()
            dtp_laporan.Value = reader(4)
            txtbox_namaLaporan.Text = reader(5)
        End While
    End Sub

    Private Sub dgv_tampil_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv_tampil.RowsRemoved
        If dgv_tampil.RowCount = 0 Then
            btn_tambah.Enabled = True
            btn_tambah.Text = "Tambah"
            btn_simpan.Enabled = False
            btn_simpan.Text = "Simpan"
            btn_hapus.Enabled = False
            btn_cancel.Enabled = False

            txtbox_noPKP2T.Clear()
            clearField()
            disableField()
        End If
    End Sub

End Class