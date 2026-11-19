Public Class Form2
    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        Dim angka As Integer
        If Not Integer.TryParse(txtAngka.Text, angka) Then
            MessageBox.Show("Masukkan angka bilangan bulat.")
            Exit Sub
        End If

        lstHasil.Items.Clear()
        For i As Integer = 1 To 10
            lstHasil.Items.Add(angka & " x " & i & " = " & (angka * i))
        Next
    End Sub

    Private Sub btnMundur_Click(sender As Object, e As EventArgs) Handles btnMundur.Click
        Dim angka As Integer
        If Not Integer.TryParse(txtAngka.Text, angka) OrElse angka < 2 Then
            MessageBox.Show("Masukkan bilangan bulat minimal 2.")
            Exit Sub
        End If

        lstHasil.Items.Clear()
        For i As Integer = angka To 0 Step -2
            lstHasil.Items.Add(i)
        Next
    End Sub

    Private Sub txtAngka_TextChanged(sender As Object, e As EventArgs) Handles txtAngka.TextChanged
        lstHasil.Items.Clear()
    End Sub

    Private Sub btnJumlah_Click(sender As Object, e As EventArgs) Handles btnJumlah.Click
        Dim batas As Integer
        If Not Integer.TryParse(txtAngka.Text, batas) Then
            MessageBox.Show("Masukkan angka bilangan bulat.")
            Exit Sub
        End If

        Dim i As Integer = 1
        Dim total As Integer = 0

        While i <= batas
            total += i
            i += 1
        End While

        MessageBox.Show("Jumlah 1 sampai " & batas & " = " & total)
    End Sub

    Private Sub btnPin_Click(sender As Object, e As EventArgs) Handles btnPin.Click
        Dim pin As String

        Do
            pin = InputBox("Masukkan PIN (1234):", "Login")
        Loop While pin <> "1234"

        MessageBox.Show("Akses diterima!")
    End Sub
End Class