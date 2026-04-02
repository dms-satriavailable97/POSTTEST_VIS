<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        mnuInput = New ToolStripMenuItem()
        mnuSimpan = New ToolStripMenuItem()
        mnuBukaFile = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        mnuLihat = New ToolStripMenuItem()
        lblJudul = New Label()
        picLogo = New PictureBox()
        tc = New TabControl()
        tcIdentitas = New TabPage()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtNama = New TextBox()
        txtID = New TextBox()
        dtpLahir = New DateTimePicker()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        cmbKomunitas = New ComboBox()
        tcKontak = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        mtxtNoHP = New MaskedTextBox()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        tcRingkasan = New TabPage()
        btnCetak = New Button()
        grpPeran = New GroupBox()
        rbLainnya = New RadioButton()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        rbWakil = New RadioButton()
        rbKetua = New RadioButton()
        picProfil = New PictureBox()
        btnBrowse = New Button()
        cb1 = New CheckBox()
        btnSimpan = New Button()
        cb2 = New CheckBox()
        cb3 = New CheckBox()
        cb4 = New CheckBox()
        cb5 = New CheckBox()
        cb6 = New CheckBox()
        cb7 = New CheckBox()
        cb8 = New CheckBox()
        btnReset = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        tc.SuspendLayout()
        tcIdentitas.SuspendLayout()
        tcKontak.SuspendLayout()
        tcRingkasan.SuspendLayout()
        grpPeran.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.MenuHighlight
        MenuStrip1.Font = New Font("STCaiyun", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuInput, mnuSimpan, mnuBukaFile, mnuKeluar, mnuLihat})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(880, 27)
        MenuStrip1.TabIndex = 0
        ' 
        ' mnuInput
        ' 
        mnuInput.Name = "mnuInput"
        mnuInput.Size = New Size(122, 23)
        mnuInput.Text = "Input Data"
        ' 
        ' mnuSimpan
        ' 
        mnuSimpan.Name = "mnuSimpan"
        mnuSimpan.Size = New Size(138, 23)
        mnuSimpan.Text = "Simpan Data"
        ' 
        ' mnuBukaFile
        ' 
        mnuBukaFile.Name = "mnuBukaFile"
        mnuBukaFile.Size = New Size(120, 23)
        mnuBukaFile.Text = "Buka Data"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(85, 23)
        mnuKeluar.Text = "Keluar"
        ' 
        ' mnuLihat
        ' 
        mnuLihat.Name = "mnuLihat"
        mnuLihat.Size = New Size(123, 23)
        mnuLihat.Text = "Lihat Kartu"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.BackColor = Color.Transparent
        lblJudul.Font = New Font("Showcard Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.Yellow
        lblJudul.Location = New Point(192, 61)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(557, 44)
        lblJudul.TabIndex = 1
        lblJudul.Text = "COMMUNITY MEMBER ID CARD"
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.BorderStyle = BorderStyle.FixedSingle
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(63, 50)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(103, 55)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 2
        picLogo.TabStop = False
        ' 
        ' tc
        ' 
        tc.Controls.Add(tcIdentitas)
        tc.Controls.Add(tcKontak)
        tc.Controls.Add(tcRingkasan)
        tc.Font = New Font("Sitka Heading Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tc.Location = New Point(79, 108)
        tc.Name = "tc"
        tc.SelectedIndex = 0
        tc.Size = New Size(580, 354)
        tc.TabIndex = 3
        ' 
        ' tcIdentitas
        ' 
        tcIdentitas.Controls.Add(Label5)
        tcIdentitas.Controls.Add(Label4)
        tcIdentitas.Controls.Add(Label3)
        tcIdentitas.Controls.Add(Label2)
        tcIdentitas.Controls.Add(Label1)
        tcIdentitas.Controls.Add(txtNama)
        tcIdentitas.Controls.Add(txtID)
        tcIdentitas.Controls.Add(dtpLahir)
        tcIdentitas.Controls.Add(rbLaki)
        tcIdentitas.Controls.Add(rbPerempuan)
        tcIdentitas.Controls.Add(cmbKomunitas)
        tcIdentitas.Location = New Point(4, 35)
        tcIdentitas.Name = "tcIdentitas"
        tcIdentitas.Size = New Size(572, 315)
        tcIdentitas.TabIndex = 0
        tcIdentitas.Text = "Data Utama"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 26)
        Label5.TabIndex = 10
        Label5.Text = "Jenis Komunitas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 26)
        Label4.TabIndex = 9
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 26)
        Label3.TabIndex = 8
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 26)
        Label2.TabIndex = 7
        Label2.Text = "ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 26)
        Label1.TabIndex = 6
        Label1.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(193, 17)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(334, 30)
        txtNama.TabIndex = 0
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(193, 57)
        txtID.Name = "txtID"
        txtID.Size = New Size(334, 30)
        txtID.TabIndex = 1
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(193, 104)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(334, 30)
        dtpLahir.TabIndex = 2
        ' 
        ' rbLaki
        ' 
        rbLaki.Location = New Point(193, 148)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(123, 29)
        rbLaki.TabIndex = 3
        rbLaki.Text = "Laki-Laki"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.Location = New Point(322, 146)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(156, 34)
        rbPerempuan.TabIndex = 4
        rbPerempuan.Text = "Perempuan"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKomunitas.Items.AddRange(New Object() {"Programming", "Design", "Game", "AI", "Networking"})
        cmbKomunitas.Location = New Point(193, 188)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(334, 34)
        cmbKomunitas.TabIndex = 5
        ' 
        ' tcKontak
        ' 
        tcKontak.Controls.Add(Label8)
        tcKontak.Controls.Add(Label7)
        tcKontak.Controls.Add(Label6)
        tcKontak.Controls.Add(mtxtNoHP)
        tcKontak.Controls.Add(txtEmail)
        tcKontak.Controls.Add(txtAlamat)
        tcKontak.Location = New Point(4, 35)
        tcKontak.Name = "tcKontak"
        tcKontak.Size = New Size(572, 315)
        tcKontak.TabIndex = 1
        tcKontak.Text = "Kontak & Info"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(37, 103)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 26)
        Label8.TabIndex = 13
        Label8.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(37, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 26)
        Label7.TabIndex = 12
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(37, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 26)
        Label6.TabIndex = 11
        Label6.Text = "No Telepon"
        ' 
        ' mtxtNoHP
        ' 
        mtxtNoHP.Location = New Point(207, 14)
        mtxtNoHP.Mask = "0000-0000-0000"
        mtxtNoHP.Name = "mtxtNoHP"
        mtxtNoHP.Size = New Size(139, 30)
        mtxtNoHP.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(207, 63)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "JohnDoe@gmail.com"
        txtEmail.Size = New Size(297, 30)
        txtEmail.TabIndex = 1
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(207, 103)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(297, 171)
        txtAlamat.TabIndex = 2
        ' 
        ' tcRingkasan
        ' 
        tcRingkasan.Controls.Add(btnCetak)
        tcRingkasan.Controls.Add(grpPeran)
        tcRingkasan.Controls.Add(picProfil)
        tcRingkasan.Controls.Add(btnBrowse)
        tcRingkasan.Controls.Add(cb1)
        tcRingkasan.Controls.Add(btnSimpan)
        tcRingkasan.Controls.Add(cb2)
        tcRingkasan.Controls.Add(cb3)
        tcRingkasan.Controls.Add(cb4)
        tcRingkasan.Controls.Add(cb5)
        tcRingkasan.Controls.Add(cb6)
        tcRingkasan.Controls.Add(cb7)
        tcRingkasan.Controls.Add(cb8)
        tcRingkasan.Location = New Point(4, 35)
        tcRingkasan.Name = "tcRingkasan"
        tcRingkasan.Size = New Size(572, 315)
        tcRingkasan.TabIndex = 2
        tcRingkasan.Text = "Profil & Aktivitas"
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(445, 245)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(111, 38)
        btnCetak.TabIndex = 11
        btnCetak.Text = "Cetak"
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(rbLainnya)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Controls.Add(rbWakil)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.Location = New Point(204, 20)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(460, 163)
        grpPeran.TabIndex = 7
        grpPeran.TabStop = False
        grpPeran.Text = "Peran"
        ' 
        ' rbLainnya
        ' 
        rbLainnya.AutoSize = True
        rbLainnya.Location = New Point(197, 77)
        rbLainnya.Name = "rbLainnya"
        rbLainnya.Size = New Size(99, 30)
        rbLainnya.TabIndex = 4
        rbLainnya.TabStop = True
        rbLainnya.Text = "Lainnya"
        rbLainnya.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(197, 42)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(100, 30)
        rbAnggota.TabIndex = 3
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(19, 112)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(88, 30)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbWakil
        ' 
        rbWakil.AutoSize = True
        rbWakil.Location = New Point(19, 77)
        rbWakil.Name = "rbWakil"
        rbWakil.Size = New Size(80, 30)
        rbWakil.TabIndex = 1
        rbWakil.TabStop = True
        rbWakil.Text = "Wakil"
        rbWakil.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(19, 42)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(82, 30)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' picProfil
        ' 
        picProfil.BorderStyle = BorderStyle.FixedSingle
        picProfil.Location = New Point(20, 20)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(120, 120)
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(20, 150)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(120, 33)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        ' 
        ' cb1
        ' 
        cb1.Location = New Point(20, 200)
        cb1.Name = "cb1"
        cb1.Size = New Size(104, 47)
        cb1.TabIndex = 3
        cb1.Text = "Coding"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(445, 203)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(111, 38)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        ' 
        ' cb2
        ' 
        cb2.Location = New Point(125, 200)
        cb2.Name = "cb2"
        cb2.Size = New Size(104, 47)
        cb2.TabIndex = 4
        cb2.Text = "Design"
        ' 
        ' cb3
        ' 
        cb3.Location = New Point(230, 200)
        cb3.Name = "cb3"
        cb3.Size = New Size(104, 47)
        cb3.TabIndex = 5
        cb3.Text = "Gaming"
        ' 
        ' cb4
        ' 
        cb4.Location = New Point(335, 200)
        cb4.Name = "cb4"
        cb4.Size = New Size(104, 47)
        cb4.TabIndex = 6
        cb4.Text = "Editing"
        ' 
        ' cb5
        ' 
        cb5.Location = New Point(20, 253)
        cb5.Name = "cb5"
        cb5.Size = New Size(104, 24)
        cb5.TabIndex = 7
        cb5.Text = "Music"
        ' 
        ' cb6
        ' 
        cb6.Location = New Point(125, 245)
        cb6.Name = "cb6"
        cb6.Size = New Size(104, 41)
        cb6.TabIndex = 8
        cb6.Text = "Sports"
        ' 
        ' cb7
        ' 
        cb7.Location = New Point(230, 250)
        cb7.Name = "cb7"
        cb7.Size = New Size(104, 30)
        cb7.TabIndex = 9
        cb7.Text = "Content"
        ' 
        ' cb8
        ' 
        cb8.Location = New Point(335, 249)
        cb8.Name = "cb8"
        cb8.Size = New Size(104, 33)
        cb8.TabIndex = 10
        cb8.Text = "AI"
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(769, 503)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(99, 38)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(880, 560)
        Controls.Add(MenuStrip1)
        Controls.Add(lblJudul)
        Controls.Add(picLogo)
        Controls.Add(tc)
        Controls.Add(btnReset)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form Kartu Komunitas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        tc.ResumeLayout(False)
        tcIdentitas.ResumeLayout(False)
        tcIdentitas.PerformLayout()
        tcKontak.ResumeLayout(False)
        tcKontak.PerformLayout()
        tcRingkasan.ResumeLayout(False)
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tc As TabControl
    Friend WithEvents tcIdentitas As TabPage
    Friend WithEvents tcKontak As TabPage
    Friend WithEvents tcRingkasan As TabPage

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cmbKomunitas As ComboBox

    Friend WithEvents mtxtNoHP As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox

    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnBrowse As Button

    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb8 As CheckBox

    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnReset As Button

    Friend WithEvents lblJudul As Label
    Friend WithEvents picLogo As PictureBox

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

    Friend WithEvents mnuInput As ToolStripMenuItem
    Friend WithEvents mnuLihat As ToolStripMenuItem
    Friend WithEvents mnuSimpan As ToolStripMenuItem
    Friend WithEvents mnuBukaFile As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents rbLainnya As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbWakil As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnCetak As Button

End Class