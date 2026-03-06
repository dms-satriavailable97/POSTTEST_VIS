Module Module1
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    ' fungsi untuk mengecek apakah buku dengan judul tertentu sudah ada dalam daftar
    Public Function cekBuku(ByVal judul As String) As Boolean
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judul.ToLower() Then
                Return True ' Fungsi mengembalikan nilai (return)
            End If
        Next
        Return False
    End Function

    ' prosedur untuk menambahkan buku baru ke dalam daftar
    Public Sub tambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        Else
            MsgBox("Kapasitas buku sudah penuh.")
        End If
    End Sub

    ' Prosedur Hapus berdasarkan input judul buku
    Public Sub hapusBuku(ByVal judulHapus As String)
        Dim indexKetemu As Integer = -1

        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judulHapus.ToLower() Then
                indexKetemu = i
                Exit For
            End If
        Next

        If indexKetemu <> -1 Then
            For i As Integer = indexKetemu To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1
            MsgBox("Buku '" & judulHapus & "' berhasil dihapus.")
        Else
            MsgBox("Buku tidak ditemukan.")
        End If
    End Sub

    ' prosedur listbox untuk menampilkan daftar buku yang ada
    Public Sub RefreshTampilan(ByVal lb As ListBox)
        lb.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            ' Format: judulbuku(genre)
            lb.Items.Add(daftarBuku(i, 0) & "(" & daftarBuku(i, 1) & ")")
        Next
    End Sub
End Module