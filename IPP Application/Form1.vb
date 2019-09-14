Public Class mainForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_st.Click
        ST.MdiParent = Me
        ST.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_lnh.Click
        LNH.Show()
    End Sub

    Private Sub btn_asm_Click(sender As Object, e As EventArgs) Handles btn_asm.Click
        ASM.Show()
    End Sub

    Private Sub btn_kka_Click(sender As Object, e As EventArgs) Handles btn_kka.Click
        KKA.Show()
    End Sub

    Private Sub btn_pegawai_Click(sender As Object, e As EventArgs) Handles btn_pegawai.Click
        DP.Show()

    End Sub

    Private Sub btn_mak_Click(sender As Object, e As EventArgs) Handles btn_mak.Click
        MAK.Show()
    End Sub

    Private Sub btn_ppm_Click(sender As Object, e As EventArgs) Handles btn_ppm.Click
        MonPPM.Show()
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SuratMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratMasukToolStripMenuItem.Click
        Dim surattugas As New ST
        surattugas.MdiParent = Me
        surattugas.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SplashScreen1.Close()
    End Sub
End Class
