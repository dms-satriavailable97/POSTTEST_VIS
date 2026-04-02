<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        btnTutup = New Button()
        lblHobby = New Label()
        lblPeran = New Label()
        lblKontak = New Label()
        lblKomunitas = New Label()
        lblID = New Label()
        lblNama = New Label()
        picFoto = New PictureBox()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(686, 400)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(100, 36)
        btnTutup.TabIndex = 1
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' lblHobby
        ' 
        lblHobby.BackColor = Color.Transparent
        lblHobby.ForeColor = Color.White
        lblHobby.Location = New Point(365, 363)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(323, 25)
        lblHobby.TabIndex = 8
        lblHobby.Text = "Hobby : -"
        ' 
        ' lblPeran
        ' 
        lblPeran.AutoSize = True
        lblPeran.BackColor = Color.Transparent
        lblPeran.ForeColor = Color.White
        lblPeran.Location = New Point(365, 338)
        lblPeran.Name = "lblPeran"
        lblPeran.Size = New Size(76, 25)
        lblPeran.TabIndex = 7
        lblPeran.Text = "Peran : -"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.BackColor = Color.Transparent
        lblKontak.ForeColor = Color.White
        lblKontak.Location = New Point(365, 313)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(88, 25)
        lblKontak.TabIndex = 6
        lblKontak.Text = "Kontak : -"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.BackColor = Color.Transparent
        lblKomunitas.ForeColor = Color.White
        lblKomunitas.Location = New Point(112, 363)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(117, 25)
        lblKomunitas.TabIndex = 5
        lblKomunitas.Text = "Komunitas : -"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.ForeColor = Color.White
        lblID.Location = New Point(112, 338)
        lblID.Name = "lblID"
        lblID.Size = New Size(51, 25)
        lblID.TabIndex = 4
        lblID.Text = "ID : -"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(112, 313)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(80, 25)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama : -"
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(122, 145)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(133, 140)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 1
        picFoto.TabStop = False
        ' 
        ' Form2
        ' 
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(798, 460)
        Controls.Add(picFoto)
        Controls.Add(lblNama)
        Controls.Add(lblID)
        Controls.Add(btnTutup)
        Controls.Add(lblKomunitas)
        Controls.Add(lblHobby)
        Controls.Add(lblKontak)
        Controls.Add(lblPeran)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Kartu Komunitas"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents btnTutup As Button
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblPeran As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents picFoto As PictureBox

End Class