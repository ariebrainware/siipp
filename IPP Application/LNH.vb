Imports System.Data.Odbc
Public Class LNH
    Dim simpan, ubah, hapus, cari As String
    Dim status_pkp2t = ""
    Sub disableField()
        cbox_suratTugas.Enabled = False
        rbo_pkp2t.Enabled = False
        rbo_nonpkp2t.Enabled = False
        dtp_suratTugas.Enabled = False
        txtbox_noLaporan.Enabled = False
        dtp_tglLaporan.Enabled = False
        txtbox_namaLaporan.Enabled = False
        txtbox_namaTim.Enabled = False
        txtbox_asalFileTP3.Enabled = False
        btn_browseDariTP3.Enabled = False
        btn_browseSimpanKeTP3.Enabled = False
        txtbox_simpanKeTP3.Enabled = False
        txtbox_asalFileLampiran.Enabled = False
        txtbox_simpanKeLampiran.Enabled = False
        btn_browseDariLampiran.Enabled = False
        btn_browseSimpanKeLampiran.Enabled = False
        btn_unggahLampiran.Enabled = False

        'btn_unggahTP3.Enabled = False
        'btn_unduhTP3.Enabled = False
        txtbox_keterangan.Enabled = False
    End Sub
    Sub enableField()
        cbox_suratTugas.Enabled = True
        rbo_pkp2t.Enabled = False
        rbo_nonpkp2t.Enabled = False
        txtbox_noLaporan.Enabled = True
        dtp_tglLaporan.Enabled = True
        txtbox_namaLaporan.Enabled = True
        btn_browseDariTP3.Enabled = True
        txtbox_asalFileTP3.Enabled = True
        btn_browseDariTP3.Enabled = True
        btn_browseSimpanKeTP3.Enabled = True
        txtbox_simpanKeTP3.Enabled = True

        txtbox_asalFileLampiran.Enabled = True
        txtbox_simpanKeLampiran.Enabled = True
        btn_browseDariLampiran.Enabled = True
        btn_browseSimpanKeLampiran.Enabled = True

        'btn_unggahTP3.Enabled = True
        'btn_unduhTP3.Enabled = True
        txtbox_keterangan.Enabled = True
    End Sub
    Sub clearField()
        rbo_nonpkp2t.Checked = True
        dtp_suratTugas.ResetText()
        txtbox_noLaporan.Clear()
        dtp_tglLaporan.ResetText()
        txtbox_namaLaporan.Clear()
        txtbox_namaTim.Clear()
        txtbox_asalFileTP3.Clear()
        txtbox_simpanKeTP3.Clear()
        txtbox_keterangan.Clear()
        txtbox_asalFileLampiran.Clear()
        txtbox_simpanKeLampiran.Clear()

    End Sub
    Sub tampilData()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM lnh", conn)
        ds = New DataSet
        da.Fill(ds, "lnh")
        dgv_tampil.DataSource = ds.Tables("lnh")
    End Sub
    Sub simpanData()
        koneksi()
        simpan = "INSERT INTO lnh VALUES('" & cbox_suratTugas.Text & "','" & status_pkp2t & "'
    ,'" & dtp_suratTugas.Text & "','" & txtbox_noLaporan.Text & "','" & dtp_tglLaporan.Text & "'
    ,'" & txtbox_namaLaporan.Text & "','" & txtbox_namaTim.Text & "','" & txtbox_keterangan.Text & "')"
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
        ubah = "UPDATE lnh SET `Tanggal Laporan` ='" & dtp_tglLaporan.Text &
            "',`Nama Laporan` ='" & txtbox_namaLaporan.Text & "',`Keterangan` ='" & txtbox_keterangan.Text & "'
            WHERE `No Laporan` ='" & txtbox_noLaporan.Text & "'"
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
        hapus = "DELETE FROM lnh WHERE `No Laporan` ='" & txtbox_noLaporan.Text & "'"
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
        da = New OdbcDataAdapter("SELECT * FROM lnh WHERE `No Laporan` LIKE '%' '" & txtbox_cari.Text & "' '%' 
OR `Nama Laporan` LIKE '%' '" & txtbox_cari.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "lnh")
        dgv_tampil.DataSource = ds.Tables("lnh")
        If dgv_tampil.RowCount > 0 Then
            Dim baris As Integer
            With dgv_tampil
                cbox_suratTugas.SelectedItem = .Item(0, baris).Value
                status_pkp2t = .Item(1, baris).Value
                dtp_suratTugas.Value = .Item(2, baris).Value
                txtbox_noLaporan.Text = .Item(3, baris).Value
                dtp_tglLaporan.Value = .Item(4, baris).Value
                txtbox_namaLaporan.Text = .Item(5, baris).Value
                txtbox_namaTim.Text = .Item(6, baris).Value
                txtbox_keterangan.Text = .Item(7, baris).Value

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

    Private Sub btn_unggahTP3_Click(sender As Object, e As EventArgs) Handles btn_unggahTP3.Click
        If txtbox_asalFileTP3.Text = "" Then
            MsgBox("Kolom File Unggahan masih kosong")
            txtbox_asalFileTP3.Select()
        ElseIf txtbox_simpanKeTP3.Text = "" Then
            MsgBox("Kolom File Unggahan masih kosong")
            txtbox_simpanKeTP3.Select()
        Else
            FileCopy(txtbox_asalFileTP3.Text, txtbox_simpanKeTP3.Text)
            MsgBox("File berhasil diunggah ke Folder Server")
        End If
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browseDariTP3.Click
        OpenFileDialog1.Title = "Cari File yang akan diunggah"
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.Filter = "Zip file|*.zip"
        OpenFileDialog1.DefaultExt = ".zip"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()

        txtbox_asalFileTP3.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_browseSimpanKeTP3_Click(sender As Object, e As EventArgs) Handles btn_browseSimpanKeTP3.Click
        SaveFileDialog1.Title = "Simpan lampiran TP3 ke"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.Filter = "*.zip|*.zip"
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.DefaultExt = ".zip"
        SaveFileDialog1.CreatePrompt = False
        SaveFileDialog1.InitialDirectory = "A:\Documents\Visual Studio 2017\Projects\IPP Application\Lampiran Server\LAPORAN NORMA HASIL\TP3"
        SaveFileDialog1.ShowDialog()

        txtbox_simpanKeTP3.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub LNH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        tampilData()
        disableField()
        btn_tambah.Enabled = True
        btn_simpan.Enabled = False
        btn_cancel.Enabled = False
        btn_hapus.Enabled = False
        btn_unggahTP3.Enabled = False
        btn_unggahLampiran.Enabled = False

        da = New OdbcDataAdapter("SELECT `No Surat Tugas` FROM st", conn)
        ds = New DataSet
        da.Fill(ds, "st")
        cbox_suratTugas.DataSource = (ds.Tables("st"))
        cbox_suratTugas.ValueMember = "No Surat Tugas"
    End Sub

    Private Sub btn_browseDariLampiran_Click(sender As Object, e As EventArgs) Handles btn_browseDariLampiran.Click
        OpenFileDialog2.Title = "Cari File yang akan diunggah"
        OpenFileDialog2.AddExtension = True
        OpenFileDialog2.Filter = "Zip file|*.zip"
        OpenFileDialog2.DefaultExt = ".zip"
        OpenFileDialog2.FileName = ""
        OpenFileDialog2.ShowDialog()

        txtbox_asalFileLampiran.Text = OpenFileDialog2.FileName
    End Sub

    Private Sub btn_browseSimpanKeLampiran_Click(sender As Object, e As EventArgs) Handles btn_browseSimpanKeLampiran.Click
        System.IO.Directory.CreateDirectory("A:\Documents\Visual Studio 2017\Projects\IPP Application\Lampiran Server\LAPORAN NORMA HASIL\LAMPIRAN")
        SaveFileDialog2.Title = "Simpan lampiran ke"
        SaveFileDialog2.AddExtension = True
        SaveFileDialog2.Filter = "*.zip|*.zip"
        SaveFileDialog2.OverwritePrompt = True
        SaveFileDialog2.DefaultExt = ".zip"
        SaveFileDialog2.CreatePrompt = False
        SaveFileDialog2.InitialDirectory = "A:\Documents\Visual Studio 2017\Projects\IPP Application\Lampiran Server\LAPORAN NORMA HASIL\LAMPIRAN"
        SaveFileDialog2.ShowDialog()

        txtbox_simpanKeLampiran.Text = SaveFileDialog2.FileName
    End Sub

    Private Sub btn_unggahLampiran_Click(sender As Object, e As EventArgs) Handles btn_unggahLampiran.Click
        If txtbox_asalFileLampiran.Text = "" Then
            MsgBox("Kolom File Unggahan masih kosong")
            txtbox_asalFileLampiran.Select()
        ElseIf txtbox_simpanKeLampiran.Text = "" Then
            MsgBox("Kolom File Unggahan masih kosong")
            txtbox_simpanKeLampiran.Select()
        Else
            FileCopy(txtbox_asalFileLampiran.Text, txtbox_simpanKeLampiran.Text)
            MsgBox("File berhasil diunggah ke Server")
        End If
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Simpan" Then
            koneksi()
            'Validasi No Laporan & Nama Laporan
            Dim no_laporan, nama_laporan
            Dim lihat As String = "SELECT * FROM lnh WHERE `No Laporan` ='" & txtbox_noLaporan.Text & "'"
            Dim perintah As New OdbcCommand(lihat, conn)
            Dim reader As OdbcDataReader = perintah.ExecuteReader()

            While reader.Read()
                no_laporan = reader(3)
                nama_laporan = reader(5)
            End While
            reader.Close()

            If txtbox_noLaporan.Text = "" Then
                MsgBox("Kolom No Laporan masih kosong", vbExclamation, "WARNING")
                txtbox_noLaporan.Select()
            ElseIf txtbox_namaLaporan.Text = "" Then
                MsgBox("Kolom Nama Laporan masih kosong", vbExclamation, "WARNING")
                txtbox_namaLaporan.Select()
            ElseIf no_laporan = txtbox_noLaporan.Text Then
                MsgBox("No Laporan sudah terdaftar diDatabase", vbCritical, "ERROR")
                txtbox_noLaporan.Select()
            ElseIf nama_laporan = txtbox_namaLaporan.Text Then
                MsgBox("Nama Laporan sudah terdaftar diDatabase", vbCritical, "ERROR")
                txtbox_namaLaporan.Select()
            Else
                simpanData()
                disableField()
                btn_tambah.Enabled = True
                btn_simpan.Enabled = False
                btn_hapus.Enabled = False
                btn_cancel.Enabled = False
            End If

        ElseIf btn_simpan.Text = "Perbarui" Then
            If txtbox_noLaporan.Text = "" Then
                MsgBox("Pilih salah satu data pada tabel untuk diperbarui", vbInformation, "INFORMATION")
            ElseIf txtbox_namaLaporan.Text = "" Then
                MsgBox("Kolom Nama Laporan masih kosong", vbExclamation, "WARNING")
                txtbox_namaLaporan.Select()
            Else
                ubahData()
                disableField()
            End If
        End If
    End Sub
    Private Sub txtbox_asalFileLampiran_TextChanged(sender As Object, e As EventArgs) Handles txtbox_asalFileLampiran.TextChanged
        btn_unggahLampiran.Enabled = True
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        tampilData()
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
        btn_unggahTP3.Enabled = False
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
                cbox_suratTugas.Text = .Item(0, baris).Value
                status_pkp2t = .Item(1, baris).Value
                dtp_suratTugas.Value = .Item(2, baris).Value
                txtbox_noLaporan.Text = .Item(3, baris).Value
                dtp_tglLaporan.Value = .Item(4, baris).Value
                txtbox_namaLaporan.Text = .Item(5, baris).Value
                txtbox_namaTim.Text = .Item(6, baris).Value
                txtbox_keterangan.Text = .Item(7, baris).Value
            End With
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
        Else
            enableField()
            btn_tambah.Enabled = False
            btn_simpan.Enabled = True
            btn_cancel.Enabled = True
            txtbox_noLaporan.Enabled = False
            txtbox_asalFileTP3.Enabled = False
            txtbox_simpanKeTP3.Enabled = False
            btn_browseDariTP3.Enabled = False
            btn_browseSimpanKeTP3.Enabled = False
            btn_unggahTP3.Enabled = False
            txtbox_asalFileLampiran.Enabled = False
            txtbox_simpanKeLampiran.Enabled = False
            btn_browseDariLampiran.Enabled = False
            btn_browseSimpanKeLampiran.Enabled = False
            btn_unggahLampiran.Enabled = False
        End If
    End Sub
    Private Sub cbox_suratTugas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbox_suratTugas.SelectedValueChanged
        koneksi()
        'status pkp2t
        Dim lihat As String = "SELECT * FROM st WHERE `No Surat Tugas` ='" & cbox_suratTugas.Text & "'"
        Dim perintah As New OdbcCommand(lihat, conn)
        Dim reader As OdbcDataReader = perintah.ExecuteReader()

        While reader.Read()
            status_pkp2t = reader(1)
            dtp_suratTugas.Value = reader(6)
            txtbox_namaTim.Text = reader(14)
        End While
        reader.Close()

        If status_pkp2t = "PKP2T" Then
            rbo_pkp2t.Checked = True
        ElseIf status_pkp2t = "NonPKP2T" Then
            rbo_nonpkp2t.Checked = True
        End If
    End Sub

    Private Sub txtbox_asalFileTP3_TextChanged(sender As Object, e As EventArgs) Handles txtbox_asalFileTP3.TextChanged
        btn_unggahTP3.Enabled = True
    End Sub
End Class