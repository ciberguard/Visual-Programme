<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventarisBuku
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
        lblKodeBuku = New Label()
        lblJudulBuku = New Label()
        lblPenulis = New Label()
        txtKodeBuku = New TextBox()
        TxtJudul = New TextBox()
        txtPenulis = New TextBox()
        txtStok = New TextBox()
        txtTahun = New TextBox()
        txtCari = New TextBox()
        cboKategori = New ComboBox()
        lblKategori = New Label()
        lblTahun = New Label()
        lblStok = New Label()
        lblFilterKategori = New Label()
        lblCari = New Label()
        cboFilterKategori = New ComboBox()
        btnTambah = New Button()
        btnBersihkan = New Button()
        dgvBuku = New DataGridView()
        bsBuku = New BindingSource(components)
        errBuku = New ErrorProvider(components)
        lblJumlah = New Label()
        lblTotalStok = New Label()
        chkStokHabis = New CheckBox()
        cboUrut = New ComboBox()
        lblUrutkanBuku = New Label()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(22, 18)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(278, 25)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(35, 68)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(64, 15)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode buku"
        ' 
        ' lblJudulBuku
        ' 
        lblJudulBuku.AutoSize = True
        lblJudulBuku.Location = New Point(35, 127)
        lblJudulBuku.Name = "lblJudulBuku"
        lblJudulBuku.Size = New Size(65, 15)
        lblJudulBuku.TabIndex = 2
        lblJudulBuku.Text = "Judul buku"
        ' 
        ' lblPenulis
        ' 
        lblPenulis.AutoSize = True
        lblPenulis.Location = New Point(35, 192)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New Size(45, 15)
        lblPenulis.TabIndex = 3
        lblPenulis.Text = "Penulis"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(35, 86)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(211, 23)
        txtKodeBuku.TabIndex = 4
        ' 
        ' TxtJudul
        ' 
        TxtJudul.Location = New Point(35, 145)
        TxtJudul.Name = "TxtJudul"
        TxtJudul.Size = New Size(211, 23)
        TxtJudul.TabIndex = 5
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(35, 210)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(211, 23)
        txtPenulis.TabIndex = 6
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(35, 393)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(211, 23)
        txtStok.TabIndex = 7
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(35, 332)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(211, 23)
        txtTahun.TabIndex = 8
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(284, 68)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(491, 23)
        txtCari.TabIndex = 9
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Majalah", "Pendidikan", "Sejarah", "Referensi"})
        cboKategori.Location = New Point(35, 270)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(211, 23)
        cboKategori.TabIndex = 10
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(35, 253)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(51, 15)
        lblKategori.TabIndex = 11
        lblKategori.Text = "Kategori"
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Location = New Point(35, 314)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(73, 15)
        lblTahun.TabIndex = 12
        lblTahun.Text = "Tahun Terbit"
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(35, 375)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(30, 15)
        lblStok.TabIndex = 13
        lblStok.Text = "Stok"
        ' 
        ' lblFilterKategori
        ' 
        lblFilterKategori.AutoSize = True
        lblFilterKategori.Location = New Point(284, 106)
        lblFilterKategori.Name = "lblFilterKategori"
        lblFilterKategori.Size = New Size(80, 15)
        lblFilterKategori.TabIndex = 14
        lblFilterKategori.Text = "Filter Kategori"
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(284, 50)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(26, 15)
        lblCari.TabIndex = 15
        lblCari.Text = "cari"
        ' 
        ' cboFilterKategori
        ' 
        cboFilterKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Majalah", "Pendidikan", "Sejarah", "Referensi"})
        cboFilterKategori.Location = New Point(284, 124)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New Size(127, 23)
        cboFilterKategori.TabIndex = 16
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(284, 168)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 17
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(541, 168)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(75, 23)
        btnBersihkan.TabIndex = 18
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AllowUserToResizeColumns = False
        dgvBuku.AllowUserToResizeRows = False
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.BorderStyle = BorderStyle.Fixed3D
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(284, 197)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersVisible = False
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New Size(504, 232)
        dgvBuku.TabIndex = 19
        ' 
        ' errBuku
        ' 
        errBuku.ContainerControl = Me
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(284, 443)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(154, 15)
        lblJumlah.TabIndex = 21
        lblJumlah.Text = "Menampilkan 0 dari 0  buku"
        ' 
        ' lblTotalStok
        ' 
        lblTotalStok.AutoSize = True
        lblTotalStok.Location = New Point(284, 468)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New Size(127, 15)
        lblTotalStok.TabIndex = 22
        lblTotalStok.Text = "Total stok  yang tampil"
        ' 
        ' chkStokHabis
        ' 
        chkStokHabis.AutoSize = True
        chkStokHabis.Location = New Point(429, 126)
        chkStokHabis.Name = "chkStokHabis"
        chkStokHabis.Size = New Size(119, 19)
        chkStokHabis.TabIndex = 23
        chkStokHabis.Text = "Hanya Stok Habis"
        chkStokHabis.UseVisualStyleBackColor = True
        ' 
        ' cboUrut
        ' 
        cboUrut.DropDownStyle = ComboBoxStyle.DropDownList
        cboUrut.FormattingEnabled = True
        cboUrut.Items.AddRange(New Object() {"Urutan awal", "Judul A-Z", "Tahun terbaru", "Stok terbanyak"})
        cboUrut.Location = New Point(554, 122)
        cboUrut.Name = "cboUrut"
        cboUrut.Size = New Size(221, 23)
        cboUrut.TabIndex = 24
        ' 
        ' lblUrutkanBuku
        ' 
        lblUrutkanBuku.AutoSize = True
        lblUrutkanBuku.Location = New Point(554, 104)
        lblUrutkanBuku.Name = "lblUrutkanBuku"
        lblUrutkanBuku.Size = New Size(79, 15)
        lblUrutkanBuku.TabIndex = 25
        lblUrutkanBuku.Text = "Urutkan Buku"
        ' 
        ' frmInventarisBuku
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 492)
        Controls.Add(lblUrutkanBuku)
        Controls.Add(cboUrut)
        Controls.Add(chkStokHabis)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(dgvBuku)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(cboFilterKategori)
        Controls.Add(lblCari)
        Controls.Add(lblFilterKategori)
        Controls.Add(lblStok)
        Controls.Add(lblTahun)
        Controls.Add(lblKategori)
        Controls.Add(cboKategori)
        Controls.Add(txtCari)
        Controls.Add(txtTahun)
        Controls.Add(txtStok)
        Controls.Add(txtPenulis)
        Controls.Add(TxtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblPenulis)
        Controls.Add(lblJudulBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        Name = "frmInventarisBuku"
        Text = "Form Inventaris Buku"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents lblJudulBuku As Label
    Friend WithEvents lblPenulis As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents TxtJudul As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblTahun As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents lblFilterKategori As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents cboFilterKategori As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents bsBuku As BindingSource
    Friend WithEvents errBuku As ErrorProvider
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblUrutkanBuku As Label
    Friend WithEvents cboUrut As ComboBox
    Friend WithEvents chkStokHabis As CheckBox

End Class
