# LoginRoleApp

Aplikasi desktop sederhana berbasis **VB.NET Windows Forms** yang terdiri dari dua form independen: **Form Login** (dengan gambar dinamis sesuai Role) dan **Form Pajak** (kalkulator pajak sederhana berdasarkan bracket pendapatan).

## Deskripsi

Project ini dibuat sebagai latihan Visual Programming, dengan fokus pada:
- Penggunaan event `SelectedIndexChanged`, `KeyPress`, dan `Click`
- Manipulasi tampilan kontrol (PictureBox bulat via `GraphicsPath`)
- Validasi input pengguna secara real-time
- Logika percabangan `If...ElseIf` untuk perhitungan bertingkat (bracket)
- Penggunaan `My.Resources` untuk menyimpan aset gambar di dalam aplikasi

## Fitur

### 1. Form Login (`Form1`)
- Pilih **Role** (Manajer / Staff / Admin) lewat ComboBox
- **PictureBox** berbentuk bulat, gambarnya otomatis berganti sesuai Role yang dipilih
- Input **Nama** (hanya menerima huruf dan spasi) dan **NIM** (hanya menerima angka)
- Validasi: Nama dan NIM wajib diisi sebelum login
- Setelah klik **Login**, muncul pesan "Selamat datang" berisi ringkasan data yang diisi

### 2. Form Pajak (`FrmPajak`)
- Input **Pendapatan** (hanya menerima angka)
- Klik **Hitung** untuk menghitung pajak berdasarkan bracket:
  | Pendapatan | Tarif Pajak |
  |---|---|
  | > Rp 5.000.000 | 10% |
  | > Rp 30.000.000 | 20% |
  | > Rp 100.000.000 | 30% |
- Pajak dihitung **flat per bracket** (bukan progresif) — tarif tertinggi yang terpenuhi berlaku untuk seluruh pendapatan
- Hasil ditampilkan dalam MessageBox "Hasil Perhitungan"

> Kedua form berjalan independen — Form Login tidak membuka Form Pajak secara otomatis.

## Teknologi

- **Bahasa:** Visual Basic .NET
- **Framework:** Windows Forms (.NET Framework)
- **IDE:** Visual Studio

## Struktur Project

```
LoginRoleApp/
├── Form1.vb          # Form Login
├── FrmPajak.vb       # Form Kalkulator Pajak
├── My Project/
│   └── Resources.resx  # Berisi gambar manajer.png, staff.png, admin.png
└── README.md
```

## Cara Menjalankan

1. Buka file `.sln` project menggunakan Visual Studio
2. Klik kanan form yang ingin dijalankan di **Solution Explorer** → **Set as Startup Form**
3. Tekan **F5** untuk menjalankan (Build and Run)

## Catatan Pembelajaran

- Gambar Role disimpan lewat **Project Properties → Resources**, sehingga ikut ter-*compile* ke dalam aplikasi (tidak perlu folder assets terpisah)
- Validasi input karakter memakai event `KeyPress` dengan `e.Handled = True` untuk memblokir karakter yang tidak sesuai
- Urutan pengecekan `If...ElseIf` pada perhitungan pajak disusun dari nilai **terbesar ke terkecil** agar bracket tertinggi yang cocok diprioritaskan
