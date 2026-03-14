<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInput))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        picFoto = New PictureBox()
        gbJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobi = New GroupBox()
        cbNongki = New CheckBox()
        cbBelajar = New CheckBox()
        cbMakan = New CheckBox()
        cbTidur = New CheckBox()
        cbGambar = New CheckBox()
        cbNyanyi = New CheckBox()
        cbRenang = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMancing = New CheckBox()
        cbGaming = New CheckBox()
        btnBrowse = New Button()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        dtpLahir = New DateTimePicker()
        txtNoHP = New TextBox()
        txtAlamat = New TextBox()
        btnCetak = New Button()
        PictureBox1 = New PictureBox()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbJenisKelamin.SuspendLayout()
        gbHobi.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic)
        Label1.Location = New Point(316, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic)
        Label2.Location = New Point(316, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 1
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic)
        Label3.Location = New Point(316, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 25)
        Label3.TabIndex = 2
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic)
        Label4.Location = New Point(316, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 25)
        Label4.TabIndex = 3
        Label4.Text = "No HP "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic)
        Label5.Location = New Point(316, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 25)
        Label5.TabIndex = 4
        Label5.Text = "Alamat"
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(12, 12)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(280, 390)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 7
        picFoto.TabStop = False
        ' 
        ' gbJenisKelamin
        ' 
        gbJenisKelamin.BackColor = Color.Transparent
        gbJenisKelamin.Controls.Add(rbPerempuan)
        gbJenisKelamin.Controls.Add(rbLaki)
        gbJenisKelamin.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic)
        gbJenisKelamin.Location = New Point(695, 261)
        gbJenisKelamin.Name = "gbJenisKelamin"
        gbJenisKelamin.Size = New Size(295, 129)
        gbJenisKelamin.TabIndex = 8
        gbJenisKelamin.TabStop = False
        gbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(20, 79)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(133, 29)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(20, 44)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(126, 29)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.BackColor = Color.Transparent
        gbHobi.Controls.Add(cbNongki)
        gbHobi.Controls.Add(cbBelajar)
        gbHobi.Controls.Add(cbMakan)
        gbHobi.Controls.Add(cbTidur)
        gbHobi.Controls.Add(cbGambar)
        gbHobi.Controls.Add(cbNyanyi)
        gbHobi.Controls.Add(cbRenang)
        gbHobi.Controls.Add(cbOlahraga)
        gbHobi.Controls.Add(cbMancing)
        gbHobi.Controls.Add(cbGaming)
        gbHobi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic)
        gbHobi.Location = New Point(316, 261)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(358, 217)
        gbHobi.TabIndex = 9
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbNongki
        ' 
        cbNongki.AutoSize = True
        cbNongki.Location = New Point(222, 170)
        cbNongki.Name = "cbNongki"
        cbNongki.Size = New Size(100, 29)
        cbNongki.TabIndex = 9
        cbNongki.Text = "Nongki"
        cbNongki.UseVisualStyleBackColor = True
        ' 
        ' cbBelajar
        ' 
        cbBelajar.AutoSize = True
        cbBelajar.Location = New Point(53, 170)
        cbBelajar.Name = "cbBelajar"
        cbBelajar.Size = New Size(99, 29)
        cbBelajar.TabIndex = 8
        cbBelajar.Text = "Belajar"
        cbBelajar.UseVisualStyleBackColor = True
        ' 
        ' cbMakan
        ' 
        cbMakan.AutoSize = True
        cbMakan.Location = New Point(222, 135)
        cbMakan.Name = "cbMakan"
        cbMakan.Size = New Size(97, 29)
        cbMakan.TabIndex = 7
        cbMakan.Text = "Makan"
        cbMakan.UseVisualStyleBackColor = True
        ' 
        ' cbTidur
        ' 
        cbTidur.AutoSize = True
        cbTidur.Location = New Point(53, 135)
        cbTidur.Name = "cbTidur"
        cbTidur.Size = New Size(84, 29)
        cbTidur.TabIndex = 6
        cbTidur.Text = "Tidur"
        cbTidur.UseVisualStyleBackColor = True
        ' 
        ' cbGambar
        ' 
        cbGambar.AutoSize = True
        cbGambar.Location = New Point(222, 100)
        cbGambar.Name = "cbGambar"
        cbGambar.Size = New Size(107, 29)
        cbGambar.TabIndex = 5
        cbGambar.Text = "Gambar"
        cbGambar.UseVisualStyleBackColor = True
        ' 
        ' cbNyanyi
        ' 
        cbNyanyi.AutoSize = True
        cbNyanyi.Location = New Point(222, 65)
        cbNyanyi.Name = "cbNyanyi"
        cbNyanyi.Size = New Size(100, 29)
        cbNyanyi.TabIndex = 4
        cbNyanyi.Text = "Nyanyi"
        cbNyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbRenang
        ' 
        cbRenang.AutoSize = True
        cbRenang.Location = New Point(222, 30)
        cbRenang.Name = "cbRenang"
        cbRenang.Size = New Size(103, 29)
        cbRenang.TabIndex = 3
        cbRenang.Text = "Renang"
        cbRenang.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(53, 100)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(120, 29)
        cbOlahraga.TabIndex = 2
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Location = New Point(53, 65)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(112, 29)
        cbMancing.TabIndex = 1
        cbMancing.Text = "Mancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(53, 30)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(106, 29)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.Red
        btnBrowse.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic)
        btnBrowse.Location = New Point(12, 421)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(280, 47)
        btnBrowse.TabIndex = 10
        btnBrowse.Text = "BROWSE"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(481, 12)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(300, 31)
        txtNama.TabIndex = 11
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(481, 55)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(300, 31)
        txtUmur.TabIndex = 12
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(481, 97)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(300, 31)
        dtpLahir.TabIndex = 13
        ' 
        ' txtNoHP
        ' 
        txtNoHP.Location = New Point(481, 149)
        txtNoHP.Name = "txtNoHP"
        txtNoHP.Size = New Size(300, 31)
        txtNoHP.TabIndex = 14
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(481, 201)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(300, 31)
        txtAlamat.TabIndex = 15
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.LimeGreen
        btnCetak.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic)
        btnCetak.Location = New Point(695, 412)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(295, 65)
        btnCetak.TabIndex = 16
        btnCetak.Text = "CETAK KARTU"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(792, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 220)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1014, 509)
        Controls.Add(PictureBox1)
        Controls.Add(btnCetak)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoHP)
        Controls.Add(dtpLahir)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(btnBrowse)
        Controls.Add(gbHobi)
        Controls.Add(gbJenisKelamin)
        Controls.Add(picFoto)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "FormInput"
        Text = "Form2"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        gbJenisKelamin.ResumeLayout(False)
        gbJenisKelamin.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cbGambar As CheckBox
    Friend WithEvents cbNyanyi As CheckBox
    Friend WithEvents cbRenang As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cbNongki As CheckBox
    Friend WithEvents cbBelajar As CheckBox
    Friend WithEvents cbMakan As CheckBox
    Friend WithEvents cbTidur As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
