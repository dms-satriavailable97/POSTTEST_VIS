Public Class Form2

    Public Sub TampilKartu(
        nama As String,
        id As String,
        komunitas As String,
        kontak As String,
        alamat As String,
        peran As String,
        hobby As String,
        foto As Image
    )

        lblNama.Text = "Nama : " & nama
        lblID.Text = "ID : " & id
        lblKomunitas.Text = "Komunitas : " & komunitas
        lblKontak.Text = "Kontak : " & kontak
        lblPeran.Text = "Peran : " & peran
        lblHobby.Text = "Hobby : " & hobby

        If foto IsNot Nothing Then
            picFoto.Image = foto
        End If

    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class