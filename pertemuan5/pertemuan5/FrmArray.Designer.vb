<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArray
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
        btnTampil = New Button()
        txtLebar = New TextBox()
        txtPanjang = New TextBox()
        lblLebar = New Label()
        lblPanjang = New Label()
        listbox = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(347, 246)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(158, 44)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' txtLebar
        ' 
        txtLebar.Location = New Point(336, 201)
        txtLebar.Name = "txtLebar"
        txtLebar.Size = New Size(169, 23)
        txtLebar.TabIndex = 1
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(335, 134)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(169, 23)
        txtPanjang.TabIndex = 2
        ' 
        ' lblLebar
        ' 
        lblLebar.AutoSize = True
        lblLebar.Location = New Point(336, 183)
        lblLebar.Name = "lblLebar"
        lblLebar.Size = New Size(36, 15)
        lblLebar.TabIndex = 3
        lblLebar.Text = "Lebar"
        ' 
        ' lblPanjang
        ' 
        lblPanjang.AutoSize = True
        lblPanjang.Location = New Point(336, 116)
        lblPanjang.Name = "lblPanjang"
        lblPanjang.Size = New Size(50, 15)
        lblPanjang.TabIndex = 4
        lblPanjang.Text = "Panjang"
        ' 
        ' listbox
        ' 
        listbox.FormattingEnabled = True
        listbox.Location = New Point(335, 326)
        listbox.Name = "listbox"
        listbox.Size = New Size(178, 94)
        listbox.TabIndex = 5
        ' 
        ' FrmArray
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(listbox)
        Controls.Add(lblPanjang)
        Controls.Add(lblLebar)
        Controls.Add(txtPanjang)
        Controls.Add(txtLebar)
        Controls.Add(btnTampil)
        Name = "FrmArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents lblLebar As Label
    Friend WithEvents lblPanjang As Label
    Friend WithEvents listbox As ListBox

End Class
