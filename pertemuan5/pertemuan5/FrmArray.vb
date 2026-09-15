Public Class FrmArray
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        'MessageBox.Show("hasil :" & hitung(txtPanjang.Text, txtLebar.Text))

        'For i As Integer = 0 To nilai.Length - 1
        'listbox.Items.Add(nilai(i))
        'Next
        MessageBox.Show("Nilai :" & nilai2D(1, 2))

    End Sub

    Private Sub txtLebar_TextChanged(sender As Object, e As EventArgs) Handles txtLebar.TextChanged

    End Sub

    Private Sub txtPanjang_TextChanged(sender As Object, e As EventArgs) Handles txtPanjang.TextChanged

    End Sub
End Class
