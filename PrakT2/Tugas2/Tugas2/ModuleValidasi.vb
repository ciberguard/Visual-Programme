
Option Strict On

Module ModuleValidasi

    ' Fungsi untuk memeriksa format kode buku.
    Public Function KodeBukuValid(kode As String) As Boolean

        ' Memeriksa apakah kode kosong.
        If kode Is Nothing Then
            Return False
        End If

        ' Mengubah kode menjadi huruf kapital.
        Dim kodeNormal As String = kode.Trim().ToUpper()

        ' Memastikan panjang kode adalah 6 karakter.
        If kodeNormal.Length <> 6 Then
            Return False
        End If

        ' Memastikan kode diawali dengan BK.
        If Not kodeNormal.StartsWith("BK") Then
            Return False
        End If

        ' Memeriksa empat karakter setelah BK.
        For Each karakter As Char In kodeNormal.Substring(2)

            ' Memastikan setiap karakter merupakan angka 0 sampai 9.
            If karakter < "0"c OrElse karakter > "9"c Then
                Return False
            End If

        Next

        ' Jika semua pemeriksaan berhasil.
        Return True

    End Function

End Module
