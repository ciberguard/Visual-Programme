
Public Class FrmPeminjamanAlat

    Private daftarInventaris As New List(Of AlatLab)

    Private Sub FrmPeminjamanAlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengisi ComboBox dan daftar inventaris dengan data awal.

        For Each nama As String In daftarAlat
            cboAlat.Items.Add(nama)

            Dim alatBaru As New AlatLab With {
                .NamaAlat = nama,
                .StokAwal = StokAwal(nama),
                .Tersedia = StokAwal(nama),
                .Dipinjam = 0
            }

            daftarInventaris.Add(alatBaru)
        Next

        bsAlat.DataSource = daftarInventaris
        dgvAlat.DataSource = bsAlat

        cboAlat.SelectedIndex = -1
        txtJumlah.Clear()

        dgvAlat.ReadOnly = True
        dgvAlat.AllowUserToAddRows = False
        dgvAlat.AllowUserToDeleteRows = False
        dgvAlat.AutoGenerateColumns = True
        dgvAlat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAlat.RowHeadersVisible = False
        dgvAlat.MultiSelect = False
        dgvAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAlat.AllowUserToOrderColumns = False

        dgvAlat.Columns("NamaAlat").HeaderText = "Nama Alat"
        dgvAlat.Columns("StokAwal").HeaderText = "Stok Awal"

        dgvAlat.Columns("StokAwal").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight

        dgvAlat.Columns("Tersedia").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight

        dgvAlat.Columns("Dipinjam").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight

        PerbaruiTotalDipinjam()
    End Sub

    Private Sub PerbaruiTotalDipinjam()
        ' Menghitung seluruh unit alat yang sedang dipinjam.

        Dim total As Integer = 0

        For Each alat As AlatLab In daftarInventaris
            total += alat.Dipinjam
        Next

        lblTotalDipinjam.Text = total.ToString() & " unit"
    End Sub


    Private Function ValidasiInput() As Boolean
        ' Memeriksa pilihan alat dan jumlah unit.

        Dim jumlah As Integer
        Dim valid As Boolean = True

        errInput.Clear()

        If cboAlat.SelectedIndex = -1 Then
            errInput.SetError(cboAlat, "Pilih alat terlebih dahulu.")
            valid = False
        End If

        If Not Integer.TryParse(txtJumlah.Text.Trim(), jumlah) Then
            errInput.SetError(txtJumlah, "Jumlah harus berupa bilangan bulat.")
            valid = False
        ElseIf jumlah <= 0 Then
            errInput.SetError(txtJumlah, "Jumlah harus lebih dari 0.")
            valid = False
        End If

        Return valid
    End Function


    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        ' Mencatat peminjaman alat sesuai jumlah yang dimasukkan.

        Try
            If Not ValidasiInput() Then
                Return
            End If

            Dim nama As String = cboAlat.Text
            Dim jumlah As Integer
            Integer.TryParse(txtJumlah.Text.Trim(), jumlah)

            For Each alat As AlatLab In daftarInventaris
                If alat.NamaAlat = nama Then

                    If jumlah > alat.Tersedia Then
                        errInput.SetError(txtJumlah, "Jumlah melebihi stok tersedia.")
                        Return
                    End If

                    alat.Tersedia -= jumlah
                    alat.Dipinjam += jumlah

                    bsAlat.ResetBindings(False)
                    PerbaruiTotalDipinjam()

                    cboAlat.SelectedIndex = -1
                    txtJumlah.Clear()
                    errInput.Clear()

                    MessageBox.Show("Peminjaman berhasil dicatat.",
                                    "Informasi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                    Return
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message,
                            "Kesalahan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKembalikan_Click(sender As Object, e As EventArgs) Handles btnKembalikan.Click
        ' Mencatat pengembalian alat sesuai jumlah yang dimasukkan.

        Try
            If Not ValidasiInput() Then
                Return
            End If

            Dim nama As String = cboAlat.Text
            Dim jumlah As Integer
            Integer.TryParse(txtJumlah.Text.Trim(), jumlah)

            For Each alat As AlatLab In daftarInventaris
                If alat.NamaAlat = nama Then

                    If jumlah > alat.Dipinjam Then
                        errInput.SetError(txtJumlah, "Jumlah melebihi alat yang sedang dipinjam.")
                        Return
                    End If

                    alat.Tersedia += jumlah
                    alat.Dipinjam -= jumlah

                    bsAlat.ResetBindings(False)
                    PerbaruiTotalDipinjam()

                    cboAlat.SelectedIndex = -1
                    txtJumlah.Clear()
                    errInput.Clear()

                    MessageBox.Show("Pengembalian berhasil dicatat.",
                                    "Informasi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                    Return
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message,
                            "Kesalahan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Mengembalikan seluruh data alat ke kondisi awal.

        Dim jawaban As DialogResult

        jawaban = MessageBox.Show(
            "Kembalikan seluruh stok ke kondisi awal?",
            "Reset Data",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If jawaban = DialogResult.Yes Then
            For Each alat As AlatLab In daftarInventaris
                alat.Tersedia = alat.StokAwal
                alat.Dipinjam = 0
            Next

            bsAlat.ResetBindings(False)

            cboAlat.SelectedIndex = -1
            txtJumlah.Clear()
            errInput.Clear()

            PerbaruiTotalDipinjam()
        End If
    End Sub

End Class
