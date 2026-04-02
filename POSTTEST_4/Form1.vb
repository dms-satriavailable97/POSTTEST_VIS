Public Class Form1

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        If txtNama.Text.Trim = "" Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
        Else
            ErrorProvider1.SetError(txtNama, "")
        End If
    End Sub

    Private Sub mtxtNoHP_TextChanged(sender As Object, e As EventArgs) Handles mtxtNoHP.TextChanged
        If Not mtxtNoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtxtNoHP, "Format nomor belum lengkap")
        Else
            ErrorProvider1.SetError(mtxtNoHP, "")
        End If
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
        If txtAlamat.Text.Trim = "" Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong")
        Else
            ErrorProvider1.SetError(txtAlamat, "")
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            picProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Function AmbilHobby() As String
        Dim hasil As String = ""

        If cb1.Checked Then hasil &= cb1.Text & ", "
        If cb2.Checked Then hasil &= cb2.Text & ", "
        If cb3.Checked Then hasil &= cb3.Text & ", "
        If cb4.Checked Then hasil &= cb4.Text & ", "
        If cb5.Checked Then hasil &= cb5.Text & ", "
        If cb6.Checked Then hasil &= cb6.Text & ", "
        If cb7.Checked Then hasil &= cb7.Text & ", "
        If cb8.Checked Then hasil &= cb8.Text & ", "

        If hasil <> "" Then
            hasil = hasil.Substring(0, hasil.Length - 2)
        End If

        Return hasil
    End Function

    Private Function AmbilPeran() As String
        For Each ctrl As Control In grpPeran.Controls
            If TypeOf ctrl Is RadioButton Then
                If CType(ctrl, RadioButton).Checked Then
                    Return ctrl.Text
                End If
            End If
        Next
        Return ""
    End Function

    Private Function ValidasiSemua() As Boolean
        If txtNama.Text.Trim = "" Then Return False
        If txtID.Text.Trim = "" Then Return False
        If Not mtxtNoHP.MaskCompleted Then Return False
        If txtAlamat.Text.Trim = "" Then Return False
        If cmbKomunitas.Text = "" Then Return False
        If AmbilPeran() = "" Then Return False
        If AmbilHobby() = "" Then Return False

        Return True
    End Function


    Private Sub tc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tc.SelectedIndexChanged
        If tc.SelectedTab Is tcRingkasan Then
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiSemua() Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
            "Simpan data sekarang?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            SaveFileDialog1.Filter = "Text File|*.txt"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)

                sw.WriteLine("Nama:" & txtNama.Text)
                sw.WriteLine("ID:" & txtID.Text)
                sw.WriteLine("TanggalLahir:" & dtpLahir.Value.ToString("dd/MM/yyyy"))

                If rbLaki.Checked Then
                    sw.WriteLine("JK:Laki-Laki")
                ElseIf rbPerempuan.Checked Then
                    sw.WriteLine("JK:Perempuan")
                End If

                sw.WriteLine("Komunitas:" & cmbKomunitas.Text)

                sw.WriteLine("NoHP:" & mtxtNoHP.Text)
                sw.WriteLine("Email:" & txtEmail.Text)
                sw.WriteLine("Alamat:" & txtAlamat.Text)

                sw.WriteLine("Peran:" & AmbilPeran())
                sw.WriteLine("Hobby:" & AmbilHobby())

                sw.Close()

                MessageBox.Show("Data berhasil disimpan")
            End If
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If Not ValidasiSemua() Then
            MessageBox.Show(
            "Inputan tidak boleh kosong",
            "Peringatan",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
        "Tampilkan kartu sekarang?",
        "Konfirmasi Cetak",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If hasil = DialogResult.Yes Then
            Dim f2 As New Form2

            f2.TampilKartu(
            txtNama.Text,
            txtID.Text,
            cmbKomunitas.Text,
            mtxtNoHP.Text,
            txtAlamat.Text,
            AmbilPeran(),
            AmbilHobby(),
            picProfil.Image
        )

            f2.ShowDialog()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If MessageBox.Show("Reset data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            txtNama.Clear()
            txtID.Clear()
            txtAlamat.Clear()
            mtxtNoHP.Clear()
            cmbKomunitas.SelectedIndex = -1
            picProfil.Image = Nothing

            For Each c As Control In grpPeran.Controls
                If TypeOf c Is RadioButton Then CType(c, RadioButton).Checked = False
            Next

            cb1.Checked = False
            cb2.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            cb5.Checked = False
            cb6.Checked = False
            cb7.Checked = False
            cb8.Checked = False

            ErrorProvider1.Clear()
            tc.SelectedTab = tcIdentitas
        End If
    End Sub

    Private Sub mnuBukaFile_Click(sender As Object, e As EventArgs) Handles mnuBukaFile.Click
        OpenFileDialog1.Filter = "Text File|*.txt"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim lines() As String = IO.File.ReadAllLines(OpenFileDialog1.FileName)

            For Each line In lines
                Dim parts = line.Split(New Char() {":"c}, 2)
                If parts.Length < 2 Then Continue For

                Dim key As String = parts(0).Trim()
                Dim value As String = parts(1).Trim()

                Select Case key
                    Case "Nama"
                        txtNama.Text = value

                    Case "ID"
                        txtID.Text = value

                    Case "TanggalLahir"
                        dtpLahir.Value = Date.Parse(value)

                    Case "JK"
                        If value = "Laki-Laki" Then
                            rbLaki.Checked = True
                        ElseIf value = "Perempuan" Then
                            rbPerempuan.Checked = True
                        End If

                    Case "Komunitas"
                        cmbKomunitas.Text = value

                    Case "NoHP"
                        mtxtNoHP.Text = value

                    Case "Email"
                        txtEmail.Text = value

                    Case "Alamat"
                        txtAlamat.Text = value

                    Case "Peran"
                        For Each c As Control In grpPeran.Controls
                            If TypeOf c Is RadioButton Then
                                If c.Text = value Then
                                    CType(c, RadioButton).Checked = True
                                End If
                            End If
                        Next

                    Case "Hobby"
                        cb1.Checked = False
                        cb2.Checked = False
                        cb3.Checked = False
                        cb4.Checked = False
                        cb5.Checked = False
                        cb6.Checked = False
                        cb7.Checked = False
                        cb8.Checked = False

                        Dim arr = value.Split(","c)

                        For Each h In arr
                            Dim val = h.Trim()

                            If val = cb1.Text Then cb1.Checked = True
                            If val = cb2.Text Then cb2.Checked = True
                            If val = cb3.Text Then cb3.Checked = True
                            If val = cb4.Text Then cb4.Checked = True
                            If val = cb5.Text Then cb5.Checked = True
                            If val = cb6.Text Then cb6.Checked = True
                            If val = cb7.Text Then cb7.Checked = True
                            If val = cb8.Text Then cb8.Checked = True
                        Next
                End Select
            Next

            tc.SelectedTab = tcRingkasan

            MessageBox.Show(
            "Data berhasil dibuka",
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
        End If
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        If MessageBox.Show("Keluar aplikasi?",
                           "Konfirmasi",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub mnuInput_Click(sender As Object, e As EventArgs) Handles mnuInput.Click
        tc.SelectedTab = tcIdentitas
    End Sub

    Private Sub mnuLihat_Click(sender As Object, e As EventArgs) Handles mnuLihat.Click
        If Not ValidasiSemua() Then
            MessageBox.Show(
            "Inputan tidak boleh kosong",
            "Peringatan",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
            Exit Sub
        End If

        Dim f2 As New Form2

        f2.TampilKartu(
        txtNama.Text,
        txtID.Text,
        cmbKomunitas.Text,
        mtxtNoHP.Text,
        txtAlamat.Text,
        AmbilPeran(),
        AmbilHobby(),
        picProfil.Image
    )

        f2.ShowDialog()
    End Sub

    Private Sub mnuSimpan_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click
        If Not ValidasiSemua() Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
            "Simpan data sekarang?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            SaveFileDialog1.Filter = "Text File|*.txt"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)

                sw.WriteLine("Nama:" & txtNama.Text)
                sw.WriteLine("ID:" & txtID.Text)
                sw.WriteLine("TanggalLahir:" & dtpLahir.Value.ToString("dd/MM/yyyy"))

                If rbLaki.Checked Then
                    sw.WriteLine("JK:Laki-Laki")
                ElseIf rbPerempuan.Checked Then
                    sw.WriteLine("JK:Perempuan")
                End If

                sw.WriteLine("Komunitas:" & cmbKomunitas.Text)

                sw.WriteLine("NoHP:" & mtxtNoHP.Text)
                sw.WriteLine("Email:" & txtEmail.Text)
                sw.WriteLine("Alamat:" & txtAlamat.Text)

                sw.WriteLine("Peran:" & AmbilPeran())
                sw.WriteLine("Hobby:" & AmbilHobby())

                sw.Close()

                MessageBox.Show("Data berhasil disimpan")
            End If
        End If
    End Sub

End Class