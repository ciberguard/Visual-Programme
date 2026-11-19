Option Strict On
Imports System.Data

Public Class frmInventarisBuku

    Private tabelBuku As New DataTable

    'Mengisi tabel buku dengan data awal saat form dibuka.
    Private Sub frmInventarisBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabelBuku.Columns.Add("KodeBuku", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("Tahun", GetType(Integer))
        tabelBuku.Columns.Add("Stok", GetType(Integer))

        tabelBuku.Rows.Add("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 8)
        tabelBuku.Rows.Add("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 0)
        tabelBuku.Rows.Add("BK0003", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 5)
        tabelBuku.Rows.Add("BK0004", "Kamus Bahasa Indonesia", "Tim Bahasa", "Referensi", 2020, 3)
        tabelBuku.Rows.Add("BK0005", "Majalah Sains Nusantara", "Redaksi Sains", "Majalah", 2024, 0)
        tabelBuku.Rows.Add("BK0006", "Ma'rifat Cahaya", "Ahmad Fauzi", "Nonfiksi", 2019, 4)
        tabelBuku.Rows.Add("BK0007", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 6)
        tabelBuku.Rows.Add("BK0008", "Atlas Indonesia", "Tim Kartografi", "Referensi", 2022, 2)
        tabelBuku.Rows.Add("BK0009", "Majalah Taman Kita", "Redaksi Taman", "Majalah", 2023, 7)
        tabelBuku.Rows.Add("BK0010", "Sejarah Nusantara", "Dewi Lestari", "Nonfiksi", 2021, 0)

        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku

        dgvBuku.AutoGenerateColumns = True
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
        dgvBuku.Columns("Judul").FillWeight = 180

        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        lblJumlah.Text = "Menampilkan 10 dari 10 buku"

        Dim total As Integer = 0

        For Each baris As DataRow In tabelBuku.Rows
            total += CInt(baris("Stok"))
        Next

        lblTotalStok.Text = "Total stok yang tampil: " & total.ToString()

        cboKategori.SelectedIndex = -1
        cboFilterKategori.SelectedIndex = 0
        cboUrut.SelectedIndex = 0
    End Sub

    'Memeriksa semua input buku sebelum ditambahkan.
    Private Function ValidasiInput() As Boolean
        Dim valid As Boolean = True
        Dim tahun As Integer
        Dim stok As Integer
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()

        errBuku.Clear()

        If Not KodeBukuValid(kode) Then
            errBuku.SetError(txtKodeBuku, "Kode harus BK diikuti 4 angka.")
            valid = False
        Else
            For Each baris As DataRow In tabelBuku.Rows
                If baris("KodeBuku").ToString() = kode Then
                    errBuku.SetError(txtKodeBuku, "Kode buku sudah terdaftar.")
                    valid = False
                    Exit For
                End If
            Next
        End If

        If TxtJudul.Text.Trim() = "" Then
            errBuku.SetError(TxtJudul, "Judul buku wajib diisi.")
            valid = False
        End If

        If txtPenulis.Text.Trim() = "" Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            valid = False
        End If

        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Pilih kategori buku.")
            valid = False
        End If

        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) Then
            errBuku.SetError(txtTahun, "Tahun harus berupa angka.")
            valid = False
        ElseIf tahun < 1900 OrElse tahun > Date.Today.Year Then
            errBuku.SetError(txtTahun, "Tahun harus antara 1900 dan tahun sekarang.")
            valid = False
        End If

        If Not Integer.TryParse(txtStok.Text.Trim(), stok) Then
            errBuku.SetError(txtStok, "Stok harus berupa angka.")
            valid = False
        ElseIf stok < 0 Then
            errBuku.SetError(txtStok, "Stok tidak boleh kurang dari 0.")
            valid = False
        End If

        Return valid

    End Function

    'Memeriksa format kode buku BK diikuti 4 angka.
    Private Function KodeBukuValid(kode As String) As Boolean
        If kode.Length <> 6 Then Return False

        If Not kode.StartsWith("BK") Then Return False

        For Each huruf As Char In kode.Substring(2)
            If huruf < "0"c OrElse huruf > "9"c Then
                Return False
            End If
        Next

        Return True
    End Function

    'Menambahkan buku baru ke dalam tabel.
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then
            Return
        End If

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim judul As String = TxtJudul.Text.Trim()
        Dim penulis As String = txtPenulis.Text.Trim()
        Dim kategori As String = cboKategori.Text
        Dim tahun As Integer
        Dim stok As Integer

        Integer.TryParse(txtTahun.Text.Trim(), tahun)
        Integer.TryParse(txtStok.Text.Trim(), stok)

        tabelBuku.Rows.Add(kode, judul, penulis, kategori, tahun, stok)

        bsBuku.ResetBindings(False)

        PerbaruiRingkasan()
        BersihkanInput()

        MessageBox.Show("Buku berhasil ditambahkan.")
    End Sub

    'Menghitung jumlah buku dan total stok yang tampil.
    Private Sub PerbaruiRingkasan()
        lblJumlah.Text = "Menampilkan " & dgvBuku.Rows.Count.ToString() &
                     " dari " & tabelBuku.Rows.Count.ToString() & " buku"

        Dim total As Integer = 0

        For Each baris As DataGridViewRow In dgvBuku.Rows
            total += CInt(baris.Cells("Stok").Value)
        Next

        lblTotalStok.Text = "Total stok yang tampil: " & total.ToString()
    End Sub
    'Mengosongkan semua input buku.
    Private Sub BersihkanInput()
        txtKodeBuku.Clear()
        TxtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()
        errBuku.Clear()
        txtKodeBuku.Focus()
    End Sub
    'Menampilkan buku sesuai kata pencarian dan kategori.
    Private Sub TerapkanFilter()
        Dim kata As String = txtCari.Text.Trim().Replace("'", "''")
        Dim filter As String = ""

        If kata <> "" Then
            filter = "(Judul LIKE '%" & kata & "%' OR Penulis LIKE '%" & kata & "%')"
        End If

        If cboFilterKategori.Text <> "Semua" Then
            If filter <> "" Then
                filter &= " AND "
            End If

            filter &= "Kategori = '" & cboFilterKategori.Text & "'"
        End If

        If chkStokHabis.Checked Then
            If filter <> "" Then
                filter &= " AND "
            End If

            filter &= "Stok = 0"
        End If

        bsBuku.Filter = filter

        PerbaruiRingkasan()
    End Sub

    'Menjalankan filter ketika teks pencarian berubah.
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    'Menjalankan filter ketika kategori dipilih.
    Private Sub cboFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterKategori.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    'Mengurutkan buku sesuai pilihan pengguna.
    Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUrut.SelectedIndexChanged
        Select Case cboUrut.Text
            Case "Urutan awal"
                bsBuku.Sort = "KodeBuku ASC"

            Case "Judul A-Z"
                bsBuku.Sort = "Judul ASC"

            Case "Tahun terbaru"
                bsBuku.Sort = "Tahun DESC"

            Case "Stok terbanyak"
                bsBuku.Sort = "Stok DESC"
        End Select

        PerbaruiRingkasan()
    End Sub

    'Menampilkan buku yang stoknya habis.
    Private Sub chkStokHabis_CheckedChanged(sender As Object, e As EventArgs) Handles chkStokHabis.CheckedChanged
        TerapkanFilter()
    End Sub

    'Mengembalikan input dan filter ke kondisi awal.
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        txtKodeBuku.Clear()
        TxtJudul.Clear()
        txtPenulis.Clear()
        txtTahun.Clear()
        txtStok.Clear()

        cboKategori.SelectedIndex = -1
        txtCari.Clear()
        cboFilterKategori.SelectedIndex = 0
        cboUrut.SelectedIndex = 0

        chkStokHabis.Checked = False

        errBuku.Clear()

        TerapkanFilter()
        txtKodeBuku.Focus()
    End Sub
End Class