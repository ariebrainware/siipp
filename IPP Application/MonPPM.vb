Imports System.Data.Odbc
Public Class MonPPM
    Dim simpan, ubah, hapus, cari
    Sub disableField()
        dtp_tglPPM.Enabled = False
        txtbox_lamaPPM.Enabled = False
        txtbox_waktu.Enabled = False
        txtbox_judulPPM.Enabled = False
        txtbox_penyaji.Enabled = False
        txtbox_notulis.Enabled = False
        txtbox_jumlahPeserta.Enabled = False
    End Sub
    Sub enableField()
        dtp_tglPPM.Enabled = True
        txtbox_lamaPPM.Enabled = True
        txtbox_waktu.Enabled = True
        txtbox_judulPPM.Enabled = True
        txtbox_penyaji.Enabled = True
        txtbox_notulis.Enabled = True
        txtbox_jumlahPeserta.Enabled = True
    End Sub
    Sub clearField()
        dtp_tglPPM.ResetText()
        txtbox_lamaPPM.Clear()
        txtbox_waktu.Clear()
        txtbox_judulPPM.Clear()
        txtbox_penyaji.Clear()
        txtbox_notulis.Clear()
        txtbox_jumlahPeserta.Clear()
        txtbox_cari.Clear()
    End Sub
    Sub tampilData()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM monppm", conn)
        ds = New DataSet()
        da.Fill(ds, "monppm")
        dgv_tampil.DataSource = ds.Tables("monppm")
    End Sub
    Sub simpanData()
        koneksi()
        simpan = "INSERT INTO monppm VALUES('','" & dtp_tglPPM.Text & "','" & txtbox_lamaPPM.Text & "'
,'" & txtbox_waktu.Text & "','" & txtbox_judulPPM.Text & "','" & txtbox_penyaji.Text & "'
,'" & txtbox_notulis.Text & "','" & txtbox_jumlahPeserta.Text & "')"
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
        ubah = "UPDATE monppm SET `Tanggal PPM`='" & dtp_tglPPM.Text & "'
,`Lama PPM`='" & txtbox_lamaPPM.Text & "',`Waktu`='" & txtbox_waktu.Text & "'
,`Judul PPM`='" & txtbox_judulPPM.Text & "',`Penyaji`='" & txtbox_penyaji.Text & "'
,`Notulis`='" & txtbox_notulis.Text & "',`Jumlah Peserta`='" & txtbox_jumlahPeserta.Text & "' 
WHERE `ID PPM`='" & txtbox_idPPM.Text & "'"
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
        hapus = "DELETE FROM monppm WHERE `ID PPM`='" & txtbox_idPPM.Text & "'"
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
        da = New OdbcDataAdapter("SELECT * FROM monppm WHERE `Judul PPM` LIKE '%' '" & txtbox_cari.Text & "' '%'", conn)
        ds = New DataSet()
        da.Fill(ds, "monppm")
        dgv_tampil.DataSource = ds.Tables("monppm")
        If dgv_tampil.RowCount > 0 Then
            Dim baris As Integer
            With dgv_tampil
                baris = .CurrentRow.Index
                txtbox_idPPM.Text = .Item(0, baris).Value
                dtp_tglPPM.Value = .Item(1, baris).Value
                txtbox_lamaPPM.Text = .Item(2, baris).Value
                txtbox_waktu.Text = .Item(3, baris).Value
                txtbox_judulPPM.Text = .Item(4, baris).Value
                txtbox_penyaji.Text = .Item(5, baris).Value
                txtbox_notulis.Text = .Item(6, baris).Value
                txtbox_jumlahPeserta.Text = .Item(7, baris).Value

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
    Private Sub MonPPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()
        disableField()

        btn_tambah.Enabled = True
        btn_simpan.Enabled = False
        btn_cancel.Enabled = False
        btn_hapus.Enabled = False
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
                txtbox_idPPM.Text = .Item(0, baris).Value
                dtp_tglPPM.Value = .Item(1, baris).Value
                txtbox_lamaPPM.Text = .Item(2, baris).Value
                txtbox_waktu.Text = .Item(3, baris).Value
                txtbox_judulPPM.Text = .Item(4, baris).Value
                txtbox_penyaji.Text = .Item(5, baris).Value
                txtbox_notulis.Text = .Item(6, baris).Value
                txtbox_jumlahPeserta.Text = .Item(7, baris).Value
            End With
        End If
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        cariData()
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
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Simpan" Then
            If txtbox_lamaPPM.Text = "" Then
                MsgBox("Kolom lama PPM masih kosong", vbExclamation, "WARNING")
                txtbox_lamaPPM.Select()
            ElseIf txtbox_waktu.Text = "" Then
                MsgBox("Kolom waktu masih kosong", vbExclamation, "WARNING")
                txtbox_waktu.Select()
            ElseIf txtbox_judulPPM.Text = "" Then
                MsgBox("Kolom Judul PPM masih kosong", vbExclamation, "WARNING")
                txtbox_judulPPM.Select()
            ElseIf txtbox_penyaji.Text = "" Then
                MsgBox("Kolom Penyaji masih kosong", vbExclamation, "WARNING")
                txtbox_penyaji.Select()
            ElseIf txtbox_notulis.Text = "" Then
                MsgBox("Kolom notulis masih kosong", vbExclamation, "WARNING")
                txtbox_notulis.Select()
            ElseIf txtbox_jumlahPeserta.Text = "" Then
                MsgBox("Kolom Jumlah Peserta masih kosong", vbExclamation, "WARNING")
                txtbox_jumlahPeserta.Select()
            Else
                simpanData()
                disableField()
                btn_tambah.Enabled = True
                btn_simpan.Enabled = False
                btn_hapus.Enabled = False
                btn_cancel.Enabled = False
            End If
        ElseIf btn_simpan.Text = "Perbarui" Then
            If txtbox_lamaPPM.Text = "" Then
                MsgBox("Kolom lama PPM masih kosong", vbExclamation, "WARNING")
                txtbox_lamaPPM.Select()
            ElseIf txtbox_waktu.Text = "" Then
                MsgBox("Kolom waktu masih kosong", vbExclamation, "WARNING")
                txtbox_waktu.Select()
            ElseIf txtbox_judulPPM.Text = "" Then
                MsgBox("Kolom Judul PPM masih kosong", vbExclamation, "WARNING")
                txtbox_judulPPM.Select()
            ElseIf txtbox_penyaji.Text = "" Then
                MsgBox("Kolom Penyaji masih kosong", vbExclamation, "WARNING")
                txtbox_penyaji.Select()
            ElseIf txtbox_notulis.Text = "" Then
                MsgBox("Kolom notulis masih kosong", vbExclamation, "WARNING")
                txtbox_notulis.Select()
            ElseIf txtbox_jumlahPeserta.Text = "" Then
                MsgBox("Kolom Jumlah Peserta masih kosong", vbExclamation, "WARNING")
                txtbox_jumlahPeserta.Select()
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
