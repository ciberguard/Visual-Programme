<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblAngka = New Label()
        txtAngka = New TextBox()
        btnKali = New Button()
        btnMundur = New Button()
        btnJumlah = New Button()
        btnPin = New Button()
        lstHasil = New ListBox()
        SuspendLayout()
        ' 
        ' lblAngka
        ' 
        lblAngka.AutoSize = True
        lblAngka.Location = New Point(84, 43)
        lblAngka.Name = "lblAngka"
        lblAngka.Size = New Size(98, 15)
        lblAngka.TabIndex = 0
        lblAngka.Text = "Masukkan Angka"
        ' 
        ' txtAngka
        ' 
        txtAngka.Location = New Point(86, 69)
        txtAngka.Name = "txtAngka"
        txtAngka.Size = New Size(298, 23)
        txtAngka.TabIndex = 1
        ' 
        ' btnKali
        ' 
        btnKali.Location = New Point(84, 108)
        btnKali.Name = "btnKali"
        btnKali.Size = New Size(143, 37)
        btnKali.TabIndex = 2
        btnKali.Text = "Perkalian"
        btnKali.UseVisualStyleBackColor = True
        ' 
        ' btnMundur
        ' 
        btnMundur.Location = New Point(84, 151)
        btnMundur.Name = "btnMundur"
        btnMundur.Size = New Size(143, 37)
        btnMundur.TabIndex = 3
        btnMundur.Text = "Hitung Mundur"
        btnMundur.UseVisualStyleBackColor = True
        ' 
        ' btnJumlah
        ' 
        btnJumlah.Location = New Point(233, 108)
        btnJumlah.Name = "btnJumlah"
        btnJumlah.Size = New Size(151, 37)
        btnJumlah.TabIndex = 4
        btnJumlah.Text = "Jumlah Deret"
        btnJumlah.UseVisualStyleBackColor = True
        ' 
        ' btnPin
        ' 
        btnPin.Location = New Point(233, 151)
        btnPin.Name = "btnPin"
        btnPin.Size = New Size(151, 37)
        btnPin.TabIndex = 5
        btnPin.Text = "Validasi Pin"
        btnPin.UseVisualStyleBackColor = True
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(424, 43)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(157, 199)
        lstHasil.TabIndex = 6
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstHasil)
        Controls.Add(btnPin)
        Controls.Add(btnJumlah)
        Controls.Add(btnMundur)
        Controls.Add(btnKali)
        Controls.Add(txtAngka)
        Controls.Add(lblAngka)
        Name = "Form2"
        Text = "LatihanPerulangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAngka As Label
    Friend WithEvents txtAngka As TextBox
    Friend WithEvents btnKali As Button
    Friend WithEvents btnMundur As Button
    Friend WithEvents btnJumlah As Button
    Friend WithEvents btnPin As Button
    Friend WithEvents lstHasil As ListBox
End Class
