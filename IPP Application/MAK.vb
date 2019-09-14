Imports System.Data.Odbc
Public Class MAK
    Dim simpan, ubah, hapus, cari As String
    Sub disableField()
        cbox_namaPegawai.Enabled = False
        txtbox_nip.Enabled = False
        txtbox_pangkatGolongan.Enabled = False
        txtbox_jabatan.Enabled = False
        cbox_suratTugas.Enabled = False
        dtp_tglST.Enabled = False
        dtp_mulaiST.Enabled = False
        dtp_selesaiST.Enabled = False
        dtp_mulaiRealisasi.Enabled = False
        dtp_selesaiRealisasi.Enabled = False
        txtbox_lamaRealisasi.Enabled = False
        txtbox_uraian.Enabled = False
        txtbox_noLaporan.Enabled = False
        dtp_tglLaporan.Enabled = False
        txtbox_judulLaporan.Enabled = False
        txtbox_JJK.Enabled = False
    End Sub
    Sub enableField()
        cbox_namaPegawai.Enabled = True
        cbox_suratTugas.Enabled = True
        txtbox_lamaRealisasi.Enabled = True
        dtp_mulaiRealisasi.Enabled = True
        dtp_selesaiRealisasi.Enabled = True
        txtbox_lamaRealisasi.Enabled = True
        txtbox_JJK.Enabled = True
    End Sub
    Sub clearField()
        cbox_namaPegawai.ResetText()
        txtbox_nip.Clear()
        txtbox_pangkatGolongan.Clear()
        txtbox_jabatan.Clear()
        cbox_suratTugas.ResetText()
        dtp_tglST.ResetText()
        dtp_mulaiST.ResetText()
        dtp_selesaiST.ResetText()
        dtp_mulaiRealisasi.ResetText()
        dtp_selesaiRealisasi.ResetText()
        txtbox_lamaRealisasi.Clear()
        txtbox_uraian.Clear()
        txtbox_noLaporan.Clear()
        dtp_tglLaporan.ResetText()
        txtbox_judulLaporan.Clear()
        txtbox_JJK.Clear()
    End Sub
    Sub tampilData()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM mak", conn)
        ds = New DataSet
        da.Fill(ds, "mak")
        dgv_tampil.DataSource = ds.Tables("mak")
    End Sub
    Sub simpanData()
        koneksi()
        simpan = "INSERT INTO mak VALUES('','" & cbox_namaPegawai.Text & "','" & txtbox_nip.Text & "'
,'" & txtbox_pangkatGolongan.Text & "','" & txtbox_jabatan.Text & "','" & cbox_suratTugas.Text & "'
,'" & dtp_tglST.Text & "','" & dtp_mulaiST.Text & "','" & dtp_selesaiST.Text & "','" & txtbox_uraian.Text & "'
,'" & dtp_mulaiRealisasi.Text & "','" & dtp_selesaiRealisasi.Text & "','" & txtbox_lamaRealisasi.Text & "'
,'" & txtbox_noLaporan.Text & "','" & dtp_tglLaporan.Text & "','" & txtbox_judulLaporan.Text & "'
,'" & txtbox_JJK.Text & "')"
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
        ubah = "UPDATE mak SET `Nama Pegawai`='" & cbox_namaPegawai.Text & "'
,`NIP`='" & txtbox_nip.Text & "',`Pangkat Golongan`='" & txtbox_pangkatGolongan.Text & "'
,`Jabatan`='" & txtbox_jabatan.Text & "',`No Surat Tugas`='" & cbox_suratTugas.Text & "'
,`Tanggal Surat Tugas`='" & dtp_tglST.Text & "',`Mulai Surat Tugas`='" & dtp_mulaiST.Text & "'
,`Selesai Surat Tugas`='" & dtp_selesaiST.Text & "',`Uraian`='" & txtbox_uraian.Text & "'
,`Realisasi Mulai`='" & dtp_mulaiRealisasi.Text & "',`Realisasi Selesai`='" & dtp_selesaiRealisasi.Text & "'
,`Realisasi Lama Penugasan`='" & txtbox_lamaRealisasi.Text & "',`No Laporan`='" & txtbox_noLaporan.Text & "'
,`Tanggal Laporan`='" & dtp_tglLaporan.Text & "',`Judul Laporan`='" & dtp_tglLaporan.Text & "'
,`Jumlah Jam Kerja`='" & txtbox_JJK.Text & "' WHERE `ID MAK`='" & txtbox_idMAK.Text & "'"
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
        hapus = "DELETE * FROM mak WHERE `ID MAK`='" & txtbox_idMAK.Text & "'"
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
        da = New OdbcDataAdapter("SELECT * FROM mak WHERE `No Laporan` ='" & txtbox_noLaporan.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "mak")
        dgv_tampil.DataSource = ds.Tables("mak")
        If dgv_tampil.RowCount > 0 Then
            Dim baris As Integer
            With dgv_tampil
                baris = .CurrentRow.Index
                cbox_namaPegawai.Text = .Item(0, baris).Value
                cbox_suratTugas.Text = .Item(5, baris).Value
                dtp_mulaiRealisasi.Value = .Item(10, baris).Value
                dtp_selesaiRealisasi.Value = .Item(11, baris).Value
                txtbox_lamaRealisasi.Text = .Item(12, baris).Value
                txtbox_noLaporan.Text = .Item(13, baris).Value
                dtp_tglLaporan.Value = .Item(14, baris).Value
                txtbox_judulLaporan.Text = .Item(15, baris).Value
                txtbox_JJK.Text = .Item(16, baris).Value

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
    Private Sub MAK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()
        disableField()

        btn_tambah.Enabled = True
        btn_simpan.Enabled = False
        btn_cancel.Enabled = False
        btn_hapus.Enabled = False

        'Nama Pegawai
        da = New OdbcDataAdapter("SELECT `Nama Pegawai` FROM data_pegawai", conn)
        ds = New DataSet
        da.Fill(ds, "data_pegawai")
        cbox_namaPegawai.DataSource = (ds.Tables("data_pegawai"))
        cbox_namaPegawai.ValueMember = "Nama Pegawai"

        'No Surat Tugas
        da = New OdbcDataAdapter("SELECT `No Surat Tugas` FROM lnh", conn)
        ds = New DataSet
        da.Fill(ds, "lnh")
        cbox_suratTugas.DataSource = (ds.Tables("lnh"))
        cbox_suratTugas.ValueMember = "No Surat Tugas"
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
                txtbox_idMAK.Text = .Item(0, baris).Value
                cbox_namaPegawai.Text = .Item(1, baris).Value
                txtbox_nip.Text = .Item(2, baris).Value
                txtbox_pangkatGolongan.Text = .Item(3, baris).Value
                txtbox_jabatan.Text = .Item(4, baris).Value
                cbox_suratTugas.Text = .Item(5, baris).Value
                dtp_tglST.Value = .Item(6, baris).Value
                dtp_mulaiST.Value = .Item(7, baris).Value
                dtp_selesaiST.Value = .Item(8, baris).Value
                txtbox_uraian.Text = .Item(9, baris).Value
                dtp_mulaiRealisasi.Value = .Item(10, baris).Value
                dtp_selesaiRealisasi.Value = .Item(11, baris).Value
                txtbox_lamaRealisasi.Text = .Item(12, baris).Value
                txtbox_noLaporan.Text = .Item(13, baris).Value
                dtp_tglLaporan.Value = .Item(14, baris).Value
                txtbox_judulLaporan.Text = .Item(15, baris).Value
                txtbox_JJK.Text = .Item(16, baris).Value
            End With
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Simpan" Then
            koneksi()
            'Validasi No Laporan & Nama Laporan
            Dim nama_pegawai, no_ST
            Dim lihat As String = "SELECT * FROM mak WHERE `ID MAK` ='" & txtbox_idMAK.Text & "'"
            Dim perintah As New OdbcCommand(lihat, conn)
            Dim reader As OdbcDataReader = perintah.ExecuteReader()

            While reader.Read()
                nama_pegawai = reader(1)
                no_ST = reader(5)
            End While
            reader.Close()

            If cbox_namaPegawai.Text = "" Then
                MsgBox("Kolom Nama Pegawai masih kosong", vbExclamation, "WARNING")
                cbox_namaPegawai.Select()
            ElseIf cbox_suratTugas.Text = "" Then
                MsgBox("Kolom Nomor Surat Tugas masih kosong", vbExclamation, "WARNING")
                cbox_suratTugas.Select()
            ElseIf txtbox_lamaRealisasi.Text = "" Then
                MsgBox("Kolom Lama Realisasi Penugasan masih kosong", vbExclamation, "WARNING")
                txtbox_lamaRealisasi.Select()
            ElseIf txtbox_JJK.Text = "" Then
                MsgBox("Kolom Jumlah Jam Kerja masih kosong", vbExclamation, "Warning")
                txtbox_JJK.Select()
            Else
                simpanData()
                disableField()
                btn_tambah.Enabled = True
                btn_simpan.Enabled = False
                btn_hapus.Enabled = False
                btn_cancel.Enabled = False
            End If
        ElseIf btn_simpan.Text = "Perbarui" Then
            If cbox_namaPegawai.Text = "" Then
                MsgBox("Kolom Nama Pegawai masih kosong", vbExclamation, "WARNING")
                cbox_namaPegawai.Select()
            ElseIf cbox_suratTugas.Text = "" Then
                MsgBox("Kolom Nomor Surat Tugas masih kosong", vbExclamation, "WARNING")
                cbox_suratTugas.Select()
            ElseIf txtbox_lamaRealisasi.Text = "" Then
                MsgBox("Kolom Lama Realisasi Penugasan masih kosong", vbExclamation, "WARNING")
                txtbox_lamaRealisasi.Select()
            ElseIf txtbox_JJK.Text = "" Then
                MsgBox("Kolom Jumlah Jam Kerja masih kosong", vbExclamation, "Warning")
                txtbox_JJK.Select()
            Else
                ubahData()
                disableField()
            End If
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
        End If
    End Sub

    Private Sub cbox_namaPegawai_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbox_namaPegawai.SelectedValueChanged
        koneksi()
        'status pkp2t dan tanggal surat tugas
        Dim lihat As String = "SELECT * FROM data_pegawai WHERE `Nama Pegawai` ='" & cbox_namaPegawai.Text & "'"
        Dim perintah As New OdbcCommand(lihat, conn)
        Dim reader As OdbcDataReader = perintah.ExecuteReader()

        While reader.Read()
            txtbox_nip.Text = reader(0)
            txtbox_pangkatGolongan.Text = reader(2)
            txtbox_jabatan.Text = reader(3)

        End While
        reader.Close()
    End Sub

    Private Sub cbox_suratTugas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbox_suratTugas.SelectedValueChanged
        koneksi()
        'Group ST
        Dim lihatST As String = "SELECT * FROM st WHERE `No Surat Tugas` ='" & cbox_suratTugas.Text & "'"
        Dim perintahST As New OdbcCommand(lihatST, conn)
        Dim readerST As OdbcDataReader = perintahST.ExecuteReader()

        While readerST.Read()
            dtp_tglST.Value = readerST(6)
            dtp_mulaiST.Value = readerST(7)
            dtp_selesaiST.Value = readerST(8)
            txtbox_uraian.Text = readerST(13)
        End While
        readerST.Close()

        'Group Laporan
        Dim lihatLNH As String = "SELECT * FROM lnh WHERE `No Surat Tugas` ='" & cbox_suratTugas.Text & "'"
        Dim perintahLNH As New OdbcCommand(lihatLNH, conn)
        Dim readerLNH As OdbcDataReader = perintahLNH.ExecuteReader()

        While readerLNH.Read()
            txtbox_noLaporan.Text = readerLNH(3)
            dtp_tglLaporan.Value = readerLNH(4)
            txtbox_judulLaporan.Text = readerLNH(5)

        End While
        readerLNH.Close()
    End Sub
End Class