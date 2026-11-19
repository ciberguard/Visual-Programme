<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPeminjamanAlat
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
        lblJudul = New Label()
        lblAlat = New Label()
        lblJumlah = New Label()
        btnPinjam = New Button()
        btnKembalikan = New Button()
        btnReset = New Button()
        lblTotalKeterangan = New Label()
        lblCatatan = New Label()
        lblTotalDipinjam = New Label()
        dgvAlat = New DataGridView()
        txtJumlah = New TextBox()
        cboAlat = New ComboBox()
        errInput = New ErrorProvider(components)
        bsAlat = New BindingSource(components)
        CType(dgvAlat, ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsAlat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(12, 19)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(289, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Peminjaman Alat Laboratorium"
        ' 
        ' lblAlat
        ' 
        lblAlat.AutoSize = True
        lblAlat.Location = New Point(17, 64)
        lblAlat.Name = "lblAlat"
        lblAlat.Size = New Size(85, 15)
        lblAlat.TabIndex = 1
        lblAlat.Text = "Alat                  :"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(17, 108)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(86, 15)
        lblJumlah.TabIndex = 2
        lblJumlah.Text = "Jumlah (unit)  :"
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(372, 108)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(75, 23)
        btnPinjam.TabIndex = 3
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnKembalikan
        ' 
        btnKembalikan.Location = New Point(527, 108)
        btnKembalikan.Name = "btnKembalikan"
        btnKembalikan.Size = New Size(92, 23)
        btnKembalikan.TabIndex = 4
        btnKembalikan.Text = "Kembalikan"
        btnKembalikan.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(685, 105)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset Data"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblTotalKeterangan
        ' 
        lblTotalKeterangan.AutoSize = True
        lblTotalKeterangan.Location = New Point(12, 391)
        lblTotalKeterangan.Name = "lblTotalKeterangan"
        lblTotalKeterangan.Size = New Size(107, 15)
        lblTotalKeterangan.TabIndex = 6
        lblTotalKeterangan.Text = "Total unit dipinjam"
        ' 
        ' lblCatatan
        ' 
        lblCatatan.AutoSize = True
        lblCatatan.Location = New Point(12, 426)
        lblCatatan.Name = "lblCatatan"
        lblCatatan.Size = New Size(297, 15)
        lblCatatan.TabIndex = 7
        lblCatatan.Text = "Stok tersedia + dipinjam selalu sama dengan stok awal."
        ' 
        ' lblTotalDipinjam
        ' 
        lblTotalDipinjam.AutoSize = True
        lblTotalDipinjam.Location = New Point(634, 391)
        lblTotalDipinjam.Name = "lblTotalDipinjam"
        lblTotalDipinjam.Size = New Size(37, 15)
        lblTotalDipinjam.TabIndex = 8
        lblTotalDipinjam.Text = "0 unit"
        ' 
        ' dgvAlat
        ' 
        dgvAlat.AllowUserToAddRows = False
        dgvAlat.AllowUserToDeleteRows = False
        dgvAlat.AllowUserToResizeColumns = False
        dgvAlat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlat.Location = New Point(17, 147)
        dgvAlat.Name = "dgvAlat"
        dgvAlat.ReadOnly = True
        dgvAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAlat.Size = New Size(743, 241)
        dgvAlat.TabIndex = 9
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(100, 105)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(124, 23)
        txtJumlah.TabIndex = 10
        ' 
        ' cboAlat
        ' 
        cboAlat.DropDownStyle = ComboBoxStyle.DropDownList
        cboAlat.FormattingEnabled = True
        cboAlat.Location = New Point(100, 64)
        cboAlat.Name = "cboAlat"
        cboAlat.Size = New Size(261, 23)
        cboAlat.TabIndex = 11
        ' 
        ' errInput
        ' 
        errInput.BlinkStyle = ErrorBlinkStyle.NeverBlink
        errInput.ContainerControl = Me
        ' 
        ' FrmPeminjamanAlat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cboAlat)
        Controls.Add(txtJumlah)
        Controls.Add(dgvAlat)
        Controls.Add(lblTotalDipinjam)
        Controls.Add(lblCatatan)
        Controls.Add(lblTotalKeterangan)
        Controls.Add(btnReset)
        Controls.Add(btnKembalikan)
        Controls.Add(btnPinjam)
        Controls.Add(lblJumlah)
        Controls.Add(lblAlat)
        Controls.Add(lblJudul)
        Name = "FrmPeminjamanAlat"
        Text = "Peminjaman Alat Laboratorium"
        CType(dgvAlat, ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        CType(bsAlat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblAlat As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnKembalikan As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblTotalKeterangan As Label
    Friend WithEvents lblCatatan As Label
    Friend WithEvents lblTotalDipinjam As Label
    Friend WithEvents dgvAlat As DataGridView
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents cboAlat As ComboBox
    Friend WithEvents errInput As ErrorProvider
    Friend WithEvents bsAlat As BindingSource

End Class
