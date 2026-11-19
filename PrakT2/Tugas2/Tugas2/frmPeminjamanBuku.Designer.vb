<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPeminjamanBuku
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
        components = New ComponentModel.Container()
        lblJudulForm = New Label()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        cboKategori = New ComboBox()
        txtNamaPeminjam = New TextBox()
        txtLamaPinjam = New TextBox()
        btnPinjam = New Button()
        btnBersihkan = New Button()
        btnEkspor = New Button()
        lblKodeBuku = New Label()
        lblJudulBuku = New Label()
        lblKategori = New Label()
        lblNamaPeminjam = New Label()
        lblLamaPinjam = New Label()
        lblStatus = New Label()
        lstPeminjaman = New ListBox()
        errPinjam = New ErrorProvider(components)
        CType(errPinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(28, 9)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(173, 25)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Peminjaman Buku"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(28, 82)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(243, 23)
        txtKodeBuku.TabIndex = 1
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(28, 146)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(243, 23)
        txtJudul.TabIndex = 2
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Pendidikan", "Sejarah"})
        cboKategori.Location = New Point(28, 206)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(243, 23)
        cboKategori.TabIndex = 3
        ' 
        ' txtNamaPeminjam
        ' 
        txtNamaPeminjam.Location = New Point(28, 264)
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New Size(243, 23)
        txtNamaPeminjam.TabIndex = 5
        ' 
        ' txtLamaPinjam
        ' 
        txtLamaPinjam.Location = New Point(28, 320)
        txtLamaPinjam.Name = "txtLamaPinjam"
        txtLamaPinjam.Size = New Size(243, 23)
        txtLamaPinjam.TabIndex = 6
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(28, 382)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(75, 23)
        btnPinjam.TabIndex = 7
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.DialogResult = DialogResult.Cancel
        btnBersihkan.Location = New Point(196, 382)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(75, 23)
        btnBersihkan.TabIndex = 8
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnEkspor
        ' 
        btnEkspor.Location = New Point(358, 382)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(75, 23)
        btnEkspor.TabIndex = 9
        btnEkspor.Text = "Ekspor CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(28, 64)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(64, 15)
        lblKodeBuku.TabIndex = 10
        lblKodeBuku.Text = "Kode Buku"
        ' 
        ' lblJudulBuku
        ' 
        lblJudulBuku.AutoSize = True
        lblJudulBuku.Location = New Point(28, 128)
        lblJudulBuku.Name = "lblJudulBuku"
        lblJudulBuku.Size = New Size(65, 15)
        lblJudulBuku.TabIndex = 11
        lblJudulBuku.Text = "Judul Buku"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(28, 188)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(51, 15)
        lblKategori.TabIndex = 12
        lblKategori.Text = "Kategori"
        ' 
        ' lblNamaPeminjam
        ' 
        lblNamaPeminjam.AutoSize = True
        lblNamaPeminjam.Location = New Point(28, 246)
        lblNamaPeminjam.Name = "lblNamaPeminjam"
        lblNamaPeminjam.Size = New Size(96, 15)
        lblNamaPeminjam.TabIndex = 13
        lblNamaPeminjam.Text = "Nama Peminjam"
        ' 
        ' lblLamaPinjam
        ' 
        lblLamaPinjam.AutoSize = True
        lblLamaPinjam.Location = New Point(28, 302)
        lblLamaPinjam.Name = "lblLamaPinjam"
        lblLamaPinjam.Size = New Size(109, 15)
        lblLamaPinjam.TabIndex = 14
        lblLamaPinjam.Text = "Lama Pinjam (Hari)"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(28, 426)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(127, 15)
        lblStatus.TabIndex = 15
        lblStatus.Text = "Jumlah peminjaman: 0"
        ' 
        ' lstPeminjaman
        ' 
        lstPeminjaman.FormattingEnabled = True
        lstPeminjaman.Location = New Point(319, 78)
        lstPeminjaman.Name = "lstPeminjaman"
        lstPeminjaman.Size = New Size(451, 274)
        lstPeminjaman.TabIndex = 16
        ' 
        ' errPinjam
        ' 
        errPinjam.ContainerControl = Me
        ' 
        ' frmPeminjamanBuku
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 468)
        Controls.Add(lstPeminjaman)
        Controls.Add(lblStatus)
        Controls.Add(lblLamaPinjam)
        Controls.Add(lblNamaPeminjam)
        Controls.Add(lblKategori)
        Controls.Add(lblJudulBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(btnEkspor)
        Controls.Add(btnBersihkan)
        Controls.Add(btnPinjam)
        Controls.Add(txtLamaPinjam)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(cboKategori)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblJudulForm)
        Name = "frmPeminjamanBuku"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Peminjaman Buku"
        CType(errPinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents txtNamaPeminjam As TextBox
    Friend WithEvents txtLamaPinjam As TextBox
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents lblJudulBuku As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblNamaPeminjam As Label
    Friend WithEvents lblLamaPinjam As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lstPeminjaman As ListBox
    Friend WithEvents errPinjam As ErrorProvider

End Class
