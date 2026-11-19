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
        lblJenis = New Label()
        lblLama = New Label()
        lblHasil = New Label()
        cboJenis = New ComboBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnHitung = New Button()
        PictureBox1 = New PictureBox()
        nudLama = New NumericUpDown()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudLama, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJenis.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        lblJenis.Location = New Point(3, 101)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(78, 17)
        lblJenis.TabIndex = 0
        lblJenis.Text = "Jenis Mobil:"
        ' 
        ' lblLama
        ' 
        lblLama.AutoSize = True
        lblLama.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLama.ForeColor = Color.Indigo
        lblLama.Location = New Point(3, 157)
        lblLama.Name = "lblLama"
        lblLama.Size = New Size(78, 17)
        lblLama.TabIndex = 1
        lblLama.Text = "Lama Sewa:"
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.BackColor = Color.White
        lblHasil.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHasil.Location = New Point(61, 277)
        lblHasil.MaximumSize = New Size(400, 100)
        lblHasil.MinimumSize = New Size(250, 20)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(250, 20)
        lblHasil.TabIndex = 2
        ' 
        ' cboJenis
        ' 
        cboJenis.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        cboJenis.ForeColor = Color.Black
        cboJenis.FormattingEnabled = True
        cboJenis.Items.AddRange(New Object() {"Avanza", "", "Innova", "", "Alphard"})
        cboJenis.Location = New Point(80, 98)
        cboJenis.Name = "cboJenis"
        cboJenis.Size = New Size(211, 23)
        cboJenis.TabIndex = 3
        ' 
        ' btnHitung
        ' 
        btnHitung.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnHitung.ForeColor = Color.Black
        btnHitung.Location = New Point(122, 218)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(126, 34)
        btnHitung.TabIndex = 4
        btnHitung.Text = "Totalkan"
        btnHitung.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(369, 61)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(127, 119)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' nudLama
        ' 
        nudLama.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        nudLama.ForeColor = Color.Black
        nudLama.Location = New Point(80, 157)
        nudLama.Name = "nudLama"
        nudLama.Size = New Size(211, 23)
        nudLama.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ClientSize = New Size(825, 461)
        Controls.Add(nudLama)
        Controls.Add(PictureBox1)
        Controls.Add(btnHitung)
        Controls.Add(cboJenis)
        Controls.Add(lblHasil)
        Controls.Add(lblLama)
        Controls.Add(lblJenis)
        ForeColor = Color.Black
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudLama, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJenis As Label
    Friend WithEvents lblLama As Label
    Friend WithEvents lblHasil As Label
    Friend WithEvents cboJenis As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnHitung As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nudLama As NumericUpDown

End Class
