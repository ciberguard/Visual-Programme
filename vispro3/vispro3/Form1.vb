Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilai As Integer
        If Not Integer.TryParse(txtNilai.Text, nilai) Then
            MessageBox.Show("Masukkan angka")
            txtNilai.Focus()
            Return
        End If

    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNilai_TextChanged(sender As Object, e As EventArgs) Handles txtNilai.TextChanged

    End Sub
End Class
