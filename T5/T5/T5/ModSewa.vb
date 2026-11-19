Module ModSewa
    Public Function HitungHargaPerHari(jenisMobil As String) As Decimal
        Dim harga As Decimal = 0D

        If jenisMobil.ToLower() = "avanza" Then
            harga = 300000D
        ElseIf jenisMobil.ToLower() = "innova" Then
            harga = 500000D
        ElseIf jenisMobil.ToLower() = "alphard" Then
            harga = 1500000D
        Else
            harga = 0D
        End If

        Return harga
    End Function

    ' Function untuk menghitung total biaya
    Public Function HitungTotalBiaya(hargaPerHari As Decimal, lamaSewa As Integer) As Decimal
        Return hargaPerHari * lamaSewa
    End Function

End Module
