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
        lblIP = New Label()
        lblIPK = New Label()
        btnTambah = New Button()
        btnReset = New Button()
        txtIP = New TextBox()
        txtIPK = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' lblIP
        ' 
        lblIP.AutoSize = True
        lblIP.ForeColor = SystemColors.Control
        lblIP.Location = New Point(134, 75)
        lblIP.Name = "lblIP"
        lblIP.Size = New Size(105, 25)
        lblIP.TabIndex = 0
        lblIP.Text = "IP Semester"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.ForeColor = SystemColors.Control
        lblIPK.Location = New Point(134, 187)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(107, 25)
        lblIPK.TabIndex = 1
        lblIPK.Text = "IP Kumulatif"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.LightGreen
        btnTambah.Location = New Point(271, 123)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.LightGreen
        btnReset.Location = New Point(389, 123)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' txtIP
        ' 
        txtIP.Location = New Point(271, 75)
        txtIP.Name = "txtIP"
        txtIP.Size = New Size(230, 31)
        txtIP.TabIndex = 4
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(271, 187)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(230, 31)
        txtIPK.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(271, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(347, 213)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 7
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.ForeColor = SystemColors.Control
        lblHasil.Location = New Point(271, 240)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(50, 25)
        lblHasil.TabIndex = 8
        lblHasil.Text = "Hasil"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaGreen
        ClientSize = New Size(800, 450)
        Controls.Add(lblHasil)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(txtIPK)
        Controls.Add(txtIP)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(lblIPK)
        Controls.Add(lblIP)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIP As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHasil As Label

End Class
