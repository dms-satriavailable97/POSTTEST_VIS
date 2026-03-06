Public Class Form1
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim jdl As String = txtJudulTambah.Text
        Dim gnr As String = txtGenre.Text

        If jdl <> "" And gnr <> "" Then
            If cekBuku(jdl) Then
                MsgBox("Judul buku ini sudah ada!")
                txtJudulTambah.Clear()
                txtGenre.Clear()
            Else
                tambahBuku(jdl, gnr)
                RefreshTampilan(lstBox)
                txtJudulTambah.Clear()
                txtGenre.Clear()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtJudulHapus.Text <> "" Then
            hapusBuku(txtJudulHapus.Text)
            RefreshTampilan(lstBox)
            txtJudulHapus.Clear()
        End If
    End Sub


End Class
