Imports System.Data.Odbc
Public Class DP
    Dim simpan, ubah, hapus, cari As String
    Sub disableField()
        txtbox_nip.Enabled = False
        txtbox_nama.Enabled = False
        txtbox_pangkatGolongan.Enabled = False
        txtbox_jabatan.Enabled = False
        txtbox_noHP.Enabled = False
        txtbox_email.Enabled = False
    End Sub
    Sub enableField()
        txtbox_nama.Enabled = True
        txtbox_pangkatGolongan.Enabled = True
        txtbox_jabatan.Enabled = True
        txtbox_noHP.Enabled = True
        txtbox_email.Enabled = True
    End Sub
    Sub clearField()
        txtbox_nip.Clear()
        txtbox_nama.Clear()
        txtbox_pangkatGolongan.Clear()
        txtbox_jabatan.Clear()
        txtbox_noHP.Clear()
        txtbox_email.Clear()
    End Sub
    Sub tampilData()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM data_pegawai", conn)
        ds = New DataSet
        da.Fill(ds, "data_pegawai")
        dgv_tampil.DataSource = ds.Tables("data_pegawai")
    End Sub
    Sub simpanData()
        koneksi()
        simpan = "INSERT INTO data_pegawai VALUES('" & txtbox_nip.Text & "','" & txtbox_nama.Text & "'
,'" & txtbox_pangkatGolongan.Text & "','" & txtbox_jabatan.Text & "','" & txtbox_email.Text & "'
,'" & txtbox_noHP.Text & "')"
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
        ubah = "UPDATE data_pegawai SET `Nama Pegawai` ='" & txtbox_nama.Text & "'
,`Pangkat Golongan` ='" & txtbox_pangkatGolongan.Text & "',`Jabatan` ='" & txtbox_jabatan.Text & "'
,`Email` ='" & txtbox_email.Text & "',`No HP` ='" & txtbox_noHP.Text & "' WHERE `NIP` ='" & txtbox_nip.Text & "'"
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
        hapus = "DELETE FROM data_pegawai WHERE `NIP` ='" & txtbox_nip.Text & "'"
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
        da = New OdbcDataAdapter("SELECT * FROM data_pegawai WHERE `NIP` LIKE '%' '" & txtbox_cari.Text & "' '%' 
OR `Nama Pegawai` LIKE '%' '" & txtbox_cari.Text & "' '%'", conn)
        ds = New DataSet
        da.Fill(ds, "data_pegawai")
        dgv_tampil.DataSource = ds.Tables("data_pegawai")
        If dgv_tampil.RowCount > 0 Then
            Dim baris As Integer
            With dgv_tampil
                baris = .CurrentRow.Index
                txtbox_nip.Text = .Item(0, baris).Value
                txtbox_nama.Text = .Item(1, baris).Value
                txtbox_pangkatGolongan.Text = .Item(2, baris).Value
                txtbox_jabatan.Text = .Item(3, baris).Value
                txtbox_email.Text = .Item(4, baris).Value
                txtbox_noHP.Text = .Item(5, baris).Value

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
    Private Sub DP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
        disableField()

        btn_tambah.Enabled = True
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
                txtbox_nip.Text = .Item(0, baris).Value
                txtbox_nama.Text = .Item(1, baris).Value
                txtbox_pangkatGolongan.Text = .Item(2, baris).Value
                txtbox_jabatan.Text = .Item(3, baris).Value
                txtbox_email.Text = .Item(4, baris).Value
                txtbox_noHP.Text = .Item(5, baris).Value
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

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        cariData()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If btn_tambah.Text = "Tambah" Then
            txtbox_nip.Enabled = True
            enableField()
            btn_tambah.Enabled = False
            btn_simpan.Enabled = True
            btn_cancel.Enabled = True
        Else
            txtbox_nip.Enabled = False
            enableField()
            btn_tambah.Enabled = False
            btn_simpan.Enabled = True
            btn_cancel.Enabled = True
        End If
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Simpan" Then
            koneksi()
            'NIK Verifikasi
            Dim nip
            Dim lihat As String = "SELECT * FROM data_pegawai WHERE `NIP` ='" & txtbox_nip.Text & "'"
            Dim perintah As New OdbcCommand(lihat, conn)
            Dim reader As OdbcDataReader = perintah.ExecuteReader()

            While reader.Read()
                nip = reader(0)
            End While
            reader.Close()
            If txtbox_nip.Text = "" Then
                MsgBox("Kolom NIP wajib diisi", vbExclamation, "WARNING")
                txtbox_nip.Select()
            ElseIf txtbox_nama.Text = "" Then
                MsgBox("Kolom Nama Pegawai masih kosong", vbExclamation, "WARNING")
                txtbox_nama.Select()
            ElseIf txtbox_pangkatGolongan.Text = "" Then
                MsgBox("Kolom Pangkat Golongan masih kosong", vbExclamation, "WARNING")
                txtbox_pangkatGolongan.Select()
            ElseIf txtbox_jabatan.Text = "" Then
                MsgBox("Kolom Jabatan masih kosong", vbExclamation, "WARNING")
                txtbox_jabatan.Select()
            ElseIf txtbox_email.Text = "" Then
                MsgBox("Kolom Email masih kosong", vbExclamation, "WARNING")
                txtbox_email.Select()
            ElseIf txtbox_noHP.Text = "" Then
                MsgBox("Kolom Nomor HP masih kosong", vbExclamation, "WARNING")
                txtbox_noHP.Select()
            ElseIf nip = txtbox_nip.Text Then
                MsgBox("Data Sudah ada karena NIP sudah terdatar. Mohon untuk merubah NIP ", vbCritical, "ERROR")
                txtbox_nip.Select()
            Else
                simpanData()
                disableField()
                btn_tambah.Enabled = True
                btn_simpan.Enabled = False
                btn_hapus.Enabled = False
                btn_cancel.Enabled = False
            End If
        ElseIf btn_simpan.Text = "Perbarui" Then
            If txtbox_nama.Text = "" Then
                MsgBox("Kolom Nama Pegawai masih kosong", vbExclamation, "WARNING")
                txtbox_nama.Select()
            ElseIf txtbox_pangkatGolongan.Text = "" Then
                MsgBox("Kolom Pangkat Golongan masih kosong", vbExclamation, "WARNING")
                txtbox_pangkatGolongan.Select()
            ElseIf txtbox_jabatan.Text = "" Then
                MsgBox("Kolom Jabatan masih kosong", vbExclamation, "WARNING")
                txtbox_jabatan.Select()
            ElseIf txtbox_email.Text = "" Then
                MsgBox("Kolom Email masih kosong", vbExclamation, "WARNING")
                txtbox_email.Select()
            ElseIf txtbox_noHP.Text = "" Then
                MsgBox("Kolom Nomor HP masih kosong", vbExclamation, "WARNING")
                txtbox_noHP.Select()
            Else
                ubahData()
                disableField()
            End If
        End If
    End Sub
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        hapusData()
    End Sub
End Class