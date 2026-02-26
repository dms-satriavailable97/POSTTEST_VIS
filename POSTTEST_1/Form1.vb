Public Class Form1

    Dim IP As Double
    Dim TotalIP As Double = 0
    Dim IPK As Double = 0
    Dim Jumlah As Integer = 0


    Private Function ValidateInput() As Boolean

        If Double.TryParse(txtIP.Text, IP) Then
            If IP >= 0 And IP <= 4 Then
                Return True
            Else
                MessageBox.Show("IP harus antara 0.00 sampai 4.00")
                Return False
            End If
        Else
            MessageBox.Show("Input harus berupa angka desimal!")
            Return False
        End If

    End Function

    ' TAMBAH IP
    Private Sub TambahIP()

        If ValidateInput() = False Then Exit Sub

        ' Tambahkan ke total
        TotalIP += IP
        Jumlah += 1

        ' Hitung IPK (rata-rata)
        IPK = TotalIP / Jumlah

        ' Tampilkan IPK
        txtIPK.Text = IPK.ToString("0.00")

        ' Tentukan Predikat
        If IPK < 2.0 Then
            lblHasil.Text = "-"
        ElseIf IPK <= 2.75 Then
            lblHasil.Text = "Cukup"
        ElseIf IPK <= 3.0 Then
            lblHasil.Text = "Memuaskan"
        Else
            lblHasil.Text = "Sangat Memuaskan"
        End If

        ' Kosongkan input setelah tambah
        ' fokus agar kursor tetap di input tidak perlu klik lagi
        txtIP.Clear()
        txtIP.Focus()

    End Sub

    ' BUTTON TAMBAH
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahIP()
    End Sub

    ' BUTTON RESET
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        TotalIP = 0
        Jumlah = 0
        IPK = 0

        txtIP.Clear()
        txtIPK.Clear()
        lblHasil.Text = "-"

        txtIP.Focus()

    End Sub

End Class