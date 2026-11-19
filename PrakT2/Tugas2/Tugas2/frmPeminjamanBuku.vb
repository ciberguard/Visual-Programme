Imports System.IO

Public Class frmPeminjamanBuku
    ' Menyimpan kode buku yang sedang dipinjam.
    Private daftarKodeBuku As New List(Of String)
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNamaPeminjam.TextChanged

    End Sub

    Private Sub frmPeminjamanBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' Memeriksa seluruh input peminjaman buku.
    Private Function ValidasiInput() As Boolean

        Dim valid As Boolean = True
        Dim lamaPinjam As Integer

        ' Menghapus pesan kesalahan sebelumnya.
        errPinjam.Clear()

        ' Memeriksa kode buku.
        Dim kodeBuku As String = txtKodeBuku.Text.Trim().ToUpper()

        If Not KodeBukuValid(kodeBuku) Then
            errPinjam.SetError(txtKodeBuku,
                               "Kode buku harus BK diikuti 4 digit, contoh BK0012.")
            valid = False
        End If

        ' Memeriksa apakah buku sudah dipinjam.
        If KodeBukuValid(kodeBuku) AndAlso daftarKodeBuku.Contains(kodeBuku) Then
            errPinjam.SetError(txtKodeBuku,
                               "Buku ini sedang dipinjam.")
            valid = False
        End If

        ' Memeriksa judul buku.
        If txtJudul.Text.Trim() = "" Then
            errPinjam.SetError(txtJudul,
                               "Judul buku wajib diisi.")
            valid = False
        End If

        ' Memeriksa kategori buku.
        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori,
                               "Silakan pilih kategori buku.")
            valid = False
        End If

        ' Memeriksa nama peminjam.
        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam,
                               "Nama peminjam minimal 3 karakter.")
            valid = False
        End If

        ' Memeriksa lama peminjaman.
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lamaPinjam) Then
            errPinjam.SetError(txtLamaPinjam,
                               "Lama pinjam harus berupa bilangan bulat.")
            valid = False

        ElseIf lamaPinjam < 1 OrElse lamaPinjam > 14 Then
            errPinjam.SetError(txtLamaPinjam,
                               "Lama pinjam harus antara 1 sampai 14 hari.")
            valid = False
        End If

        Return valid

    End Function


    ' Memproses peminjaman buku ketika tombol Pinjam diklik.
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click

        ' Memeriksa seluruh input.
        If Not ValidasiInput() Then
            Return
        End If

        ' Mengambil data dari form.
        Dim kodeBuku As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim judul As String = txtJudul.Text.Trim()
        Dim kategori As String = cboKategori.Text
        Dim namaPeminjam As String = txtNamaPeminjam.Text.Trim()

        Dim lamaPinjam As Integer
        Integer.TryParse(txtLamaPinjam.Text.Trim(), lamaPinjam)

        ' Menghitung tanggal kembali.
        Dim tanggalKembali As String =
            Date.Today.AddDays(lamaPinjam).ToString("dd/MM/yyyy")

        ' Membuat format data peminjaman.
        Dim dataPeminjaman As String =
            kodeBuku & " | " &
            judul & " | " &
            kategori & " | " &
            namaPeminjam & " | " &
            lamaPinjam.ToString() & " hari | kembali " &
            tanggalKembali

        ' Menambahkan data ke ListBox.
        lstPeminjaman.Items.Add(dataPeminjaman)

        ' Menyimpan kode buku ke dalam List.
        daftarKodeBuku.Add(kodeBuku)

        ' Memperbarui jumlah peminjaman.
        lblStatus.Text =
            "  peminjaman: " & lstPeminjaman.Items.Count.ToString()

        ' Mengosongkan form setelah peminjaman berhasil.
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()

        ' Menghapus tanda kesalahan.
        errPinjam.Clear()

        ' Mengembalikan fokus ke kode buku.
        txtKodeBuku.Focus()

    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click

        ' Mengosongkan semua TextBox.
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()

        ' Mengembalikan ComboBox ke kondisi awal.
        cboKategori.SelectedIndex = -1

        ' Menghapus semua ikon ErrorProvider.
        errPinjam.Clear()

        ' Mengembalikan fokus ke TextBox Kode Buku.
        txtKodeBuku.Focus()

    End Sub


    ' Mengekspor daftar peminjaman ke file CSV.
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click

        ' Memeriksa apakah daftar peminjaman kosong.
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Belum ada data peminjaman untuk diekspor.",
                            "Informasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Return
        End If

        ' Menentukan lokasi file di folder Documents.
        Dim lokasiFile As String =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                         "peminjaman.csv")

        ' Menyiapkan StreamWriter.
        Dim writer As StreamWriter = Nothing

        Try

            ' Membuat file CSV.
            writer = New StreamWriter(lokasiFile, False)

            ' Menuliskan judul kolom.
            writer.WriteLine("Kode Buku;Judul Buku;Kategori;Nama Peminjam;Lama Pinjam;Tanggal Kembali")

            ' Menuliskan seluruh data peminjaman.
            For Each item As Object In lstPeminjaman.Items

                ' Memisahkan data berdasarkan tanda pemisah ListBox.
                Dim bagian() As String =
                    item.ToString().Split(New String() {" | "},
                                          StringSplitOptions.None)

                ' Mengambil tanggal kembali.
                Dim tanggalKembali As String =
                    bagian(5).Replace("kembali ", "")

                ' Menuliskan data dengan pemisah titik koma.
                writer.WriteLine(
                    bagian(0) & ";" &
                    bagian(1) & ";" &
                    bagian(2) & ";" &
                    bagian(3) & ";" &
                    bagian(4) & ";" &
                    tanggalKembali)

            Next

            MessageBox.Show("Data peminjaman berhasil diekspor ke:" &
                            Environment.NewLine & lokasiFile,
                            "Ekspor Berhasil",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch ex As IOException

            MessageBox.Show("File CSV sedang digunakan atau mengalami masalah." &
                            Environment.NewLine &
                            "Tutup file peminjaman.csv jika sedang dibuka di Excel, lalu coba ekspor kembali.",
                            "Gagal Ekspor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

        Catch ex As UnauthorizedAccessException

            MessageBox.Show("Program tidak memiliki izin untuk menyimpan file." &
                            Environment.NewLine &
                            "Periksa izin akses folder Documents atau gunakan folder yang dapat ditulisi.",
                            "Akses Ditolak",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

        Finally

            ' Menutup StreamWriter.
            If writer IsNot Nothing Then
                writer.Close()
            End If

        End Try

    End Sub


    ' Memeriksa format kode buku ketika fokus berpindah.
    Private Sub txtKodeBuku_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtKodeBuku.Validating

        ' Mengambil kode buku dan mengubahnya menjadi huruf kapital.
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()

        ' Memeriksa format kode buku.
        If kode = "" OrElse Not KodeBukuValid(kode) Then

            errPinjam.SetError(txtKodeBuku,
                               "Kode buku harus BK diikuti 4 digit, contoh BK0012.")

        Else

            ' Menghapus pesan kesalahan jika kode sudah benar.
            errPinjam.SetError(txtKodeBuku, "")

        End If

    End Sub

End Class

