<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAsistenPresentasi
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
        lblJudul = New Label()
        lblDurasi = New Label()
        Label3 = New Label()
        lblMenit = New Label()
        lblDetik = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        chkTetap = New CheckBox()
        chkBunyi = New CheckBox()
        btnUlangi = New Button()
        btnRingkas = New Button()
        NumericUpDown1 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        lblSiap = New Label()
        lblMulai = New Label()
        lblUlang = New Label()
        lblTimer = New Label()
        lblDurasiPanel = New Label()
        lblAtur = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(12, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(170, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Asisten Presentasi"
        ' 
        ' lblDurasi
        ' 
        lblDurasi.AutoSize = True
        lblDurasi.Location = New Point(12, 34)
        lblDurasi.Name = "lblDurasi"
        lblDurasi.Size = New Size(233, 15)
        lblDurasi.TabIndex = 1
        lblDurasi.Text = "Jaga durasi tanpa meninggalkan slide anda"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(8, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 17)
        Label3.TabIndex = 2
        Label3.Text = "Durasi Presentasi"
        ' 
        ' lblMenit
        ' 
        lblMenit.AutoSize = True
        lblMenit.Location = New Point(12, 58)
        lblMenit.Name = "lblMenit"
        lblMenit.Size = New Size(38, 15)
        lblMenit.TabIndex = 3
        lblMenit.Text = "Menit"
        ' 
        ' lblDetik
        ' 
        lblDetik.AutoSize = True
        lblDetik.Location = New Point(135, 60)
        lblDetik.Name = "lblDetik"
        lblDetik.Size = New Size(34, 15)
        lblDetik.TabIndex = 4
        lblDetik.Text = "Detik"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 103)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 5
        Label6.Text = "Label6"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(lblAtur)
        Panel1.Controls.Add(lblDurasiPanel)
        Panel1.Controls.Add(lblTimer)
        Panel1.ForeColor = SystemColors.ButtonHighlight
        Panel1.Location = New Point(15, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(404, 139)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblUlang)
        Panel2.Controls.Add(lblMulai)
        Panel2.Controls.Add(lblSiap)
        Panel2.Controls.Add(NumericUpDown2)
        Panel2.Controls.Add(NumericUpDown1)
        Panel2.Controls.Add(chkBunyi)
        Panel2.Controls.Add(lblMenit)
        Panel2.Controls.Add(lblDetik)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(12, 299)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(407, 326)
        Panel2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(16, 219)
        Button1.Name = "Button1"
        Button1.Size = New Size(244, 23)
        Button1.TabIndex = 8
        Button1.Text = "Mulai Presentasi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' chkTetap
        ' 
        chkTetap.AutoSize = True
        chkTetap.Location = New Point(17, 258)
        chkTetap.Name = "chkTetap"
        chkTetap.Size = New Size(156, 19)
        chkTetap.TabIndex = 9
        chkTetap.Text = "Tetap di atas aplikasi lain"
        chkTetap.UseVisualStyleBackColor = True
        ' 
        ' chkBunyi
        ' 
        chkBunyi.AutoSize = True
        chkBunyi.Location = New Point(276, 53)
        chkBunyi.Name = "chkBunyi"
        chkBunyi.Size = New Size(119, 19)
        chkBunyi.TabIndex = 6
        chkBunyi.Text = "Bunyi Saat Selesai"
        chkBunyi.UseVisualStyleBackColor = True
        ' 
        ' btnUlangi
        ' 
        btnUlangi.Location = New Point(266, 216)
        btnUlangi.Name = "btnUlangi"
        btnUlangi.Size = New Size(75, 23)
        btnUlangi.TabIndex = 10
        btnUlangi.Text = "Ulangi"
        btnUlangi.UseVisualStyleBackColor = True
        ' 
        ' btnRingkas
        ' 
        btnRingkas.Location = New Point(264, 254)
        btnRingkas.Name = "btnRingkas"
        btnRingkas.Size = New Size(75, 23)
        btnRingkas.TabIndex = 11
        btnRingkas.Text = "Mode Ringkas"
        btnRingkas.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(51, 53)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(69, 23)
        NumericUpDown1.TabIndex = 7
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(172, 56)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(61, 23)
        NumericUpDown2.TabIndex = 8
        ' 
        ' lblSiap
        ' 
        lblSiap.AutoSize = True
        lblSiap.Location = New Point(12, 256)
        lblSiap.Name = "lblSiap"
        lblSiap.Size = New Size(361, 15)
        lblSiap.TabIndex = 9
        lblSiap.Text = "Timer Siap. Aktifkan Tetap di atas agar terlihat saat berganti aplikasi"
        ' 
        ' lblMulai
        ' 
        lblMulai.AutoSize = True
        lblMulai.Location = New Point(36, 146)
        lblMulai.Name = "lblMulai"
        lblMulai.Size = New Size(131, 15)
        lblMulai.TabIndex = 10
        lblMulai.Text = "Ctrl +AltF9 : Mulai/Jeda"
        ' 
        ' lblUlang
        ' 
        lblUlang.AutoSize = True
        lblUlang.Location = New Point(36, 174)
        lblUlang.Name = "lblUlang"
        lblUlang.Size = New Size(283, 15)
        lblUlang.TabIndex = 11
        lblUlang.Text = "Ctrl+Alt+F10: ulangi, Tombol tetap dapat digunakan"
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.Location = New Point(151, 10)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(94, 15)
        lblTimer.TabIndex = 0
        lblTimer.Text = "Timer Presentasi"
        ' 
        ' lblDurasiPanel
        ' 
        lblDurasiPanel.AutoSize = True
        lblDurasiPanel.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDurasiPanel.Location = New Point(147, 39)
        lblDurasiPanel.Name = "lblDurasiPanel"
        lblDurasiPanel.Size = New Size(109, 47)
        lblDurasiPanel.TabIndex = 1
        lblDurasiPanel.Text = "05:00"
        ' 
        ' lblAtur
        ' 
        lblAtur.AutoSize = True
        lblAtur.Location = New Point(96, 97)
        lblAtur.Name = "lblAtur"
        lblAtur.Size = New Size(211, 15)
        lblAtur.TabIndex = 2
        lblAtur.Text = "Atur durasi, lalu mulai Ketika anda siap"
        ' 
        ' frmAsistenPresentasi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(430, 637)
        Controls.Add(btnRingkas)
        Controls.Add(btnUlangi)
        Controls.Add(chkTetap)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblDurasi)
        Controls.Add(lblJudul)
        Name = "frmAsistenPresentasi"
        Text = "Asisten Presentasi|Pertemuan 11"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblDurasi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMenit As Label
    Friend WithEvents lblDetik As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblUlang As Label
    Friend WithEvents lblMulai As Label
    Friend WithEvents lblSiap As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents chkBunyi As CheckBox
    Friend WithEvents chkTetap As CheckBox
    Friend WithEvents btnUlangi As Button
    Friend WithEvents btnRingkas As Button
    Friend WithEvents lblAtur As Label
    Friend WithEvents lblDurasiPanel As Label
    Friend WithEvents lblTimer As Label

End Class
