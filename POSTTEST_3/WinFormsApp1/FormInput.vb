Public Class FormInput
    ' Validasi Nama: Hanya Huruf dan Spasi
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi Umur & No HP: Hanya Angka
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtNoHP.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(openFileDialog.FileName)
            picFoto.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' 1. Cek apakah ada TextBox yang kosong
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoHP.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Cek Jenis Kelamin (Radio Button)
        If Not (rbLaki.Checked Or rbPerempuan.Checked) Then
            MessageBox.Show("Inputan tidak boleh kosong (Pilih Jenis Kelamin)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 3. Cek Hobby (Checkbox) - Minimal harus pilih satu
        Dim hobiTerpilih As String = ""
        For Each ctrl As Control In gbHobi.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                hobiTerpilih &= DirectCast(ctrl, CheckBox).Text & ", "
            End If
        Next

        If hobiTerpilih = "" Then
            MessageBox.Show("Inputan tidak boleh kosong (Pilih minimal satu Hobby)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 4. Cek Foto (Picture Box)
        If picFoto.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong (Upload Foto dulu)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- JIKA LOLOS SEMUA VALIDASI, KIRIM KE FORM HASIL ---

        Dim frmHasil As New FormHasil()

        ' Isi data ke Label/TextBox di Form Hasil
        frmHasil.lblNamaHasil.Text = txtNama.Text
        frmHasil.lblUmurHasil.Text = txtUmur.Text & " Tahun"
        frmHasil.lblNoHPHasil.Text = txtNoHP.Text
        frmHasil.lblAlamatHasil.Text = txtAlamat.Text
        frmHasil.lblTglLahirHasil.Text = dtpLahir.Value.ToString("dd MMMM yyyy")
        frmHasil.lblHobiHasil.Text = hobiTerpilih.TrimEnd(", ".ToCharArray())

        If rbLaki.Checked Then
            frmHasil.lblJK.Text = "Laki-laki"
        Else
            frmHasil.lblJK.Text = "Perempuan"
        End If

        ' Kirim fotonya
        frmHasil.picFotoHasil.Image = picFoto.Image
        frmHasil.picFotoHasil.SizeMode = PictureBoxSizeMode.StretchImage

        ' Tampilkan Form Hasil
        frmHasil.Show()
    End Sub
End Class