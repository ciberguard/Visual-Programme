# 💻 Visual Programming — VB.NET Windows Forms

![Language](https://img.shields.io/badge/Language-VB.NET-512BD4?style=flat-square&logo=dotnet)
![Framework](https://img.shields.io/badge/Framework-.NET%2010%20Windows%20Forms-0078D4?style=flat-square)
![IDE](https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=flat-square&logo=visualstudio)

Repository ini berisi kumpulan latihan **pertemuan**, **praktikum**, dan **tugas** mata kuliah **Visual Programming** menggunakan **Visual Basic .NET (Windows Forms)**.

> 📚 **Referensi Materi Dosen:** [USU Digital Class — Visual Programming](https://kelas.usu.ac.id/course/index.php?categoryid=1530)  
> *(Halaman tersebut memerlukan login SSO USU; ringkasan materi & teori di bawah disusun langsung dari implementasi kode di setiap folder).*

---

## 🧭 Daftar Isi

- [Peta Materi Cepat](#-peta-materi-cepat)
- [Materi Setiap Pertemuan](#-materi-setiap-pertemuan)
- [Tugas & Praktikum](#-tugas--praktikum)
- [Cara Menjalankan Project](#-cara-menjalankan-project)
- [Riwayat Perapian Repository](#-riwayat-perapian-repository)

---

## 🗺️ Peta Materi Cepat

| Bagian | Topik Utama | Folder |
|---|---|---|
| **Pertemuan 2** | Form Dasar & Kontrol Input | `pertemuan2/vispro1` |
| **Pertemuan 3** | Validasi Input & Event `KeyPress` | `vispro3/vispro3` |
| **Pertemuan 5** | Module, Fungsi, Prosedur & Array | `pertemuan5/pertemuan5` |
| **Pertemuan 6** | Koneksi Database PostgreSQL & CRUD | `pertemuan6/pertemuan6` |
| **Pertemuan 7** | Konversi Tipe Data & `Option Strict` | `pertemuan7/pertemuan7` |
| **Pertemuan 8** | `List(Of T)`, `DataTable` & Pencarian | `pertemuan8/DataMahasiswa` |
| **Pertemuan 11** | Windows API (P/Invoke) & Global Hotkey | `Pertemuan11/` |
| **Pertemuan 12** | Aplikasi MDI (*Multiple Document Interface*) | `Pertemuan12/kode/AdministrasiMahasiswaMdi` |

---

## 📖 Materi Setiap Pertemuan

### 1. Pertemuan 2 — Pengenalan Windows Forms & Kontrol Dasar
📁 `pertemuan2/vispro1`

- **Yang dibuat:** Form input data mahasiswa sederhana (Nama, NIM, KOM) dengan tombol tampilkan pesan dan tombol reset.
- **Teori inti:**
  - **Windows Forms** bekerja berbasis *event* (misal `Button.Click` dijalankan saat tombol diklik).
  - Kontrol dasar yang dipakai: `TextBox` (input teks), `ComboBox` (pilihan daftar), `Label` (teks keterangan), dan `Button` (aksi).
  - `MessageBox.Show(...)` digunakan untuk menampilkan kotak dialog informasi ke pengguna, sedangkan `.Clear()` dan `.Focus()` dipakai untuk mengosongkan input dan mengarahkan kursor kembali.

---

### 2. Pertemuan 3 — Validasi Input & Event `KeyPress`
📁 `vispro3/vispro3`

- **Yang dibuat:** Form input angka yang otomatis menolak karakter selain angka saat pengguna mengetik.
- **Teori inti:**
  - **Validasi Real-Time (`KeyPress`):** Event `KeyPress` memeriksa setiap tombol yang ditekan. Dengan `Char.IsDigit(e.KeyChar)` dan `Char.IsControl(e.KeyChar)`, karakter non-angka diblokir memakai `e.Handled = True`.
  - **Konversi Aman (`Integer.TryParse`):** Mengubah teks menjadi angka tanpa membuat program *crash* jika input tidak valid.

---

### 3. Pertemuan 5 — Module, Sub/Function & Array
📁 `pertemuan5/pertemuan5`

- **Yang dibuat:** Program perhitungan dan penyimpanan nilai menggunakan `Module` terpisah (`ModArray.vb`) serta array 1D dan 2D.
- **Teori inti:**
  - **Module:** Wadah untuk menyimpan fungsi dan variabel agar kode rapi dan bisa dipakai ulang oleh banyak form.
  - **`Sub` vs `Function`:** `Sub` hanya menjalankan perintah tanpa mengembalikan nilai, sedangkan `Function` mengembalikan hasil menggunakan `Return`.
  - **Array 1D & 2D:** Menyimpan banyak data bertipe sama dalam satu variabel, diakses lewat indeks (misal `nilai(i)` atau `nilai2D(baris, kolom)`).

---

### 4. Pertemuan 6 — Koneksi Database PostgreSQL & CRUD
📁 `pertemuan6/pertemuan6`

- **Yang dibuat:** Aplikasi manajemen data mahasiswa yang terhubung ke database **PostgreSQL** (`Form1`, `modDatabase`, `modFunction`, `ModQuery`, `appsettings.json`).
- **Teori inti:**
  - **Konfigurasi Eksternal (`appsettings.json`):** Menyimpan *connection string* di luar kode program agar mudah diubah tanpa mengompilasi ulang aplikasi.
  - **ADO.NET & Npgsql:** Menggunakan `NpgsqlConnection`, `NpgsqlCommand`, dan `NpgsqlDataAdapter` di dalam blok `Using` agar koneksi otomatis tertutup setelah selesai.
  - **Parameterized Query:** Menggunakan parameter seperti `@nim`, `@nama`, `@jurusan` untuk mencegah celah keamanan **SQL Injection**.
  - **DataGridView:** Menampilkan hasil query `DataTable` langsung ke dalam tabel di layar.

---

### 5. Pertemuan 7 — Konversi Tipe Data & `Option Strict`
📁 `pertemuan7/pertemuan7`

- **Yang dibuat:** Aplikasi uji perbandingan konversi input teks ke angka (`FrmUtama` & `FrmUjiKonversi`).
- **Teori inti:**
  - **`Option Strict On`:** Memaksa tipe data dicek secara ketat saat kompilasi sehingga bug akibat konversi otomatis dapat dicegah lebih awal.
  - **Perbandingan Konversi:**
    - `CInt(teks)` → langsung error (`InvalidCastException`) jika teks bukan angka.
    - `Val(teks)` → tidak error, tetapi bisa menghasilkan angka yang keliru diam-diam (misal `"12abc"` menjadi `12`, `"abc"` menjadi `0`).
    - `TryParse` → cara paling aman karena memberi tahu berhasil atau gagal lewat nilai `Boolean`.
  - **Modal Form (`ShowDialog()`):** Membuka form baru dan menahan interaksi form sebelumnya sampai form baru ditutup.

---

### 6. Pertemuan 8 — Koleksi Data & Pencarian
📁 `pertemuan8/DataMahasiswa`

- **Yang dibuat:** Aplikasi `DataMahasiswa` yang membandingkan 3 cara menyimpan & menampilkan data ke `DataGridView`: **Array 2D**, **`List(Of Mahasiswa)`**, dan **`DataTable`**.
- **Teori inti:**
  - **OOP Dasar (`Class Mahasiswa`):** Membungkus satu baris data mahasiswa menjadi satu objek dengan `Property` (`Nim`, `Nama`, `Jurusan`, `Angkatan`, `Ipk`) dan `Constructor`.
  - **`BindingSource`:** Jembatan antara sumber data dan `DataGridView` agar data mudah diperbarui dan disaring.
  - **Pencarian Data:**
    - Pada `List(Of T)`, pencarian dilakukan dengan perulangan (`For Each`).
    - Pada `DataTable`, pencarian cukup memakai `BindingSource.Filter` dengan sanitasi karakter khusus (`'`, `[`, `]`, `*`, `%`) agar ekspresi filter tidak error.

---

### 7. Pertemuan 11 — Windows API (P/Invoke) & Global Hotkey
📁 `Pertemuan11/Pertemuan11` & `Pertemuan11/DemoWindowsApi`

- **Yang dibuat:** Aplikasi **Asisten Presentasi / Timer** yang mendukung pintasan keyboard global (`Ctrl+Alt+F9` untuk mulai/jeda, `Ctrl+Alt+F10` untuk ulangi) dan mode jendela selalu di atas (*Always on Top*).
- **Teori inti:**
  - **P/Invoke (`System.Runtime.InteropServices`):** Memanggil fungsi bawaan sistem operasi Windows (DLL native) langsung dari kode VB.NET.
  - **Global Hotkey (`RegisterHotKey` & `WM_HOTKEY`):** Menangkap kombinasi tombol keyboard meskipun jendela aplikasi sedang tidak aktif/fokus.
  - **Kontrol Jendela:** Mengatur posisi jendela agar tetap berada di paling depan menggunakan konstanta API (`SWP_NOSIZE`, `SWP_NOMOVE`).

---

### 8. Pertemuan 12 — Multiple Document Interface (MDI)
📁 `Pertemuan12/kode/AdministrasiMahasiswaMdi`

- **Yang dibuat:** Aplikasi **Administrasi Mahasiswa** berarsitektur MDI dengan satu jendela utama (`FrmUtama`) yang menampung form anak (`FrmMahasiswa`, `FrmJurusan`, dan `FrmTentang`).
- **Teori inti:**
  - **MDI (*Multiple Document Interface*):** Satu form induk (`IsMdiContainer = True`) menjadi wadah bagi banyak form anak (`MdiParent = Me`), mirip seperti tab/jendela internal dalam satu aplikasi besar.
  - **Manajemen Child Form:** Mengecek `Me.MdiChildren` agar form yang sama tidak terbuka ganda — jika sudah ada (atau diminimalkan), cukup diaktifkan kembali (`Activate()`).

---

## 📝 Tugas & Praktikum

| Folder | Judul & Ringkasan | Konsep yang Diterapkan |
|---|---|---|
| `PrakT2/Tugas2` | **Peminjaman Buku** — Form peminjaman dengan validasi kode buku dan ekspor/baca data CSV (`peminjaman.csv`). | `ModuleValidasi`, `List(Of String)`, `System.IO` (File CSV) |
| `PrakT3/T3` | **Inventaris Buku** — Pengelolaan daftar buku (kode, judul, penulis, kategori, tahun, stok). | `DataTable`, `Option Strict On`, manipulasi baris tabel |
| `T5/T5` | **Penyewaan Mobil** — Pemilihan jenis mobil dengan gambar otomatis & hitung biaya sewa. | `ComboBox`, `PictureBox` (`Image.FromFile`), `Module` (`ModSewa`) |
| `T7/Perulangan` | **Latihan Perulangan** — Membuat tabel perkalian dan hitungan mundur ke `ListBox`. | Loop `For...Next`, `Integer.TryParse`, `ListBox` |
| `remedial/Remedial_UTS` | **Peminjaman Alat Lab** — Simulasi stok alat lab (tersedia & dipinjam) secara dinamis. | OOP (`Class AlatLab`), `List(Of AlatLab)`, `Select Case` |

---

## ▶️ Cara Menjalankan Project

1. Buka file `.slnx` atau `.sln` di dalam folder project yang ingin dijalankan menggunakan **Visual Studio**.
2. Atau build langsung melalui terminal (PowerShell / CMD):
   ```powershell
   dotnet build "<path-ke-project>.vbproj"
   ```
3. Tekan **F5** di Visual Studio untuk menjalankan aplikasi.

---

<details>
<summary>🛠️ <strong>Riwayat Perapian Repository (Klik untuk melihat detail)</strong></summary>

1. **Perbaikan Build (`Pertemuan11` & `DemoWindowsApi`):**
   - Memisahkan `DemoWindowsApi` ke `Pertemuan11/DemoWindowsApi/` beserta file sumbernya (`FrmDemoApi.*`, `ModWindowsApi.vb`, `Program.vb`) dan menghapus `Program.vb` duplikat di `Pertemuan11/Pertemuan11/Pertemuan11/My Project/`.
   - Seluruh 15 `.vbproj` di repository sudah diverifikasi berhasil build (`0 Error`, `0 Warning`).
2. **Konfigurasi `.gitignore`:**
   - Mengabaikan `.vs/`, `bin/`, `obj/`, `*.user`, `*.suo`, `*.zip`, `archives/`, `Visual Studio 18/`, dan `Visual Studio 2022/`.
   - Mengeluarkan 158 file cache/build dari tracking Git (`git rm --cached`) tanpa menghapus file lokal.
3. **Perapian Struktur File:**
   - Mengganti nama `README (2).md` → `README.md`.
   - Menghapus folder kosong `pertemuan1/` dan file duplikat `pertemuan6.slnx` di root.
   - Memindahkan seluruh arsip `.zip` di root ke folder `archives/` dan screenshot pengujian (`PrakT2`, `PrakT3`, `remedial`) ke subfolder `screenshots/`.

</details>
