Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHasil.Text = ""
    End Sub

    Private Sub cboJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJenis.SelectedIndexChanged
        Dim folderAssets As String = Application.StartupPath & "\assets\"

        Select Case cboJenis.Text.ToLower()
            Case "avanza"
                PictureBox1.Image = Image.FromFile(folderAssets & "Avanza.jpeg")
            Case "innova"
                PictureBox1.Image = Image.FromFile(folderAssets & "innova.jpeg")
            Case "alphard"
                PictureBox1.Image = Image.FromFile(folderAssets & "alphard.jpeg")
        End Select
    End Sub

    ' Saat pilihan mobil berubah, kosongkan hasil lama
    Private Sub cboJenis_SelectedIndexChanged2(sender As Object, e As EventArgs) Handles cboJenis.SelectedIndexChanged
        lblHasil.Text = ""
    End Sub

    ' Saat jumlah hari (NumericUpDown) berubah, kosongkan hasil lama
    Private Sub nudLama_ValueChanged(sender As Object, e As EventArgs) Handles nudLama.ValueChanged
        lblHasil.Text = ""
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim jenisMobil As String = cboJenis.Text.Trim()
        Dim lamaSewa As Integer = CInt(nudLama.Value)

        ' --- VALIDASI INPUT ---
        If jenisMobil = "" Then
            MessageBox.Show("Silakan pilih jenis mobil terlebih dahulu.", "Validasi Gagal")
            Exit Sub
        End If

        If lamaSewa <= 0 Then
            MessageBox.Show("Lama sewa harus lebih dari 0 hari.", "Validasi Gagal")
            Exit Sub
        End If

        ' --- PANGGIL FUNCTION DARI MODULE ModSewa ---
        Dim hargaPerHari As Decimal = HitungHargaPerHari(jenisMobil)

        If hargaPerHari = 0 Then
            MessageBox.Show("Jenis mobil tidak tersedia.", "Info")
            Exit Sub
        End If

        Dim totalBiaya As Decimal = HitungTotalBiaya(hargaPerHari, lamaSewa)

        ' --- OUTPUT ---
        lblHasil.Text = "Mobil: " & jenisMobil & vbCrLf &
                        "Lama Sewa: " & lamaSewa & " hari" & vbCrLf &
                        "Harga/hari: Rp" & hargaPerHari.ToString("N0") & vbCrLf &
                        "Total Biaya: Rp" & totalBiaya.ToString("N0")

    End Sub
End Class