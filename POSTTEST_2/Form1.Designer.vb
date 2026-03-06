<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        lstBox = New ListBox()
        Label5 = New Label()
        txtJudulHapus = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        btnHapus = New Button()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SandyBrown
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(txtGenre)
        Panel1.Controls.Add(txtJudulTambah)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(54, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(427, 225)
        Panel1.TabIndex = 0
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Gold
        btnTambah.Font = New Font("Times New Roman", 9.0F)
        btnTambah.Location = New Point(305, 162)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(99, 37)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(181, 103)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(213, 31)
        txtGenre.TabIndex = 4
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Location = New Point(181, 41)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(213, 31)
        txtJudulTambah.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9.0F)
        Label4.Location = New Point(42, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 2
        Label4.Text = "Genre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9.0F)
        Label3.Location = New Point(42, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 1
        Label3.Text = "Judul Buku"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Gold
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Times New Roman", 9.0F)
        Label1.Location = New Point(77, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 22)
        Label1.TabIndex = 0
        Label1.Text = "Tambah Buku"
        ' 
        ' lstBox
        ' 
        lstBox.BackColor = Color.Moccasin
        lstBox.Font = New Font("Times New Roman", 9.0F)
        lstBox.FormattingEnabled = True
        lstBox.Location = New Point(511, 66)
        lstBox.Name = "lstBox"
        lstBox.Size = New Size(265, 364)
        lstBox.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 9.0F)
        Label5.Location = New Point(43, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 3
        Label5.Text = "Judul Buku"
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(182, 38)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(213, 31)
        txtJudulHapus.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gold
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Times New Roman", 9.0F)
        Label2.Location = New Point(77, 267)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 22)
        Label2.TabIndex = 2
        Label2.Text = "Hapus Buku"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Peru
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(txtJudulHapus)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(54, 279)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(427, 152)
        Panel2.TabIndex = 1
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Gold
        btnHapus.Font = New Font("Times New Roman", 9.0F)
        btnHapus.Location = New Point(305, 97)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(99, 37)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Orange
        TextBox1.Font = New Font("Pristina", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(511, 26)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(265, 36)
        TextBox1.TabIndex = 6
        TextBox1.Text = "Buku Tersedia :"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1444973272_1024x1024
        ClientSize = New Size(806, 448)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(lstBox)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHapus As Button
    Friend WithEvents TextBox1 As TextBox

End Class
