# Visual Programming Repository

Kumpulan tugas, praktikum, dan latihan **Visual Basic .NET (Windows Forms)** pada mata kuliah Visual Programming.

> **Referensi Materi Dosen:** [USU Digital Class — Visual Programming](https://kelas.usu.ac.id/course/index.php?categoryid=1530) *(memerlukan login akun SSO USU; ringkasan deskripsi dan teori di bawah disusun berdasarkan implementasi kode pada masing-masing folder)*.

---

## Deskripsi & Teori Setiap Pertemuan

### 1. Pertemuan 2 — Pengenalan Windows Forms & Kontrol Dasar (`pertemuan2/vispro1`)
- **Implementasi:** Form input data mahasiswa sederhana (Nama, NIM, KOM) dengan tombol tampilkan pesan (`MessageBox.Show`) dan tombol reset/clear input.
- **Teori & Konsep:**
  - Struktur dasar aplikasi **Windows Forms** (`Form`, event `Click` pada `Button`).
  - Penggunaan kontrol input dasar: `TextBox`, `ComboBox`, dan `Label`.
  - Pengaturan fokus kursor (`Focus()`), pengosongan input (`Clear()`, `SelectedIndex = -1`), serta dialog pesan `MessageBox.Show`.

### 2. Pertemuan 3 — Validasi Input & Event Handling (`vispro3/vispro3`)
- **Implementasi:** Form validasi input angka menggunakan `Integer.TryParse` dan pembatasan karakter pada event `KeyPress`.
- **Teori & Konsep:**
  - **Event-driven programming:** menangani event `KeyPress` untuk memfilter karakter secara *real-time* (`Char.IsControl`, `Char.IsDigit`, `e.Handled = True`).
  - Validasi tipe data aman menggunakan `Integer.TryParse` agar aplikasi tidak *crash* saat input bukan angka.

### 3. Pertemuan 5 — Prosedur, Fungsi, Module & Array (`pertemuan5/pertemuan5`)
- **Implementasi:** Penggunaan `Module` (`ModArray.vb`) berisi `Sub` (`TampilkanPesan`), `Function` (`hitung`), array 1 dimensi (`nilai()`), dan array 2 dimensi (`nilai2D(,)`), serta form `FrmArray`.
- **Teori & Konsep:**
  - Modularisasi kode dengan `Module`, perbedaan `Sub` (tanpa nilai balik) dan `Function` (mengembalikan nilai dengan `Return`).
  - Percabangan `If...Else` di dalam fungsi.
  - Struktur data **Array 1D** dan **Array 2D** beserta pengaksesan elemen berdasarkan indeks baris dan kolom.

### 4. Pertemuan 6 — Koneksi Database PostgreSQL & CRUD (`pertemuan6/pertemuan6`)
- **Implementasi:** Aplikasi manajemen data mahasiswa terhubung ke **PostgreSQL** menggunakan `Npgsql` dan konfigurasi `appsettings.json` (`modDatabase.vb`, `modFunction.vb`, `ModQuery.vb`, `Form1.vb`).
- **Teori & Konsep:**
  - Konfigurasi *connection string* eksternal menggunakan `Microsoft.Extensions.Configuration` (`appsettings.json`).
  - Koneksi database ADO.NET (`NpgsqlConnection`, `NpgsqlCommand`, `NpgsqlDataAdapter`) dan penggunaan `Using` block untuk manajemen resource otomatis.
  - **Parameterized Query** (`@nim`, `@nama`, `@jurusan`) untuk mencegah *SQL Injection*.
  - Menampilkan data dari `DataTable` ke kontrol `DataGridView`.

### 5. Pertemuan 7 — Konversi Tipe Data & Penanganan Error (`pertemuan7/pertemuan7`)
- **Implementasi:** Form utama (`FrmUtama`) yang membuka `FrmUjiKonversi` untuk membandingkan perilaku `CInt`, `Val`, dan konversi yang aman.
- **Teori & Konsep:**
  - Pengaktifan `Option Strict On` untuk menegakkan *type safety* pada waktu kompilasi.
  - Perbandingan metode konversi: `CInt()` (melempar `InvalidCastException` jika gagal), `Val()` (mengembalikan `0` atau angka parsial tanpa error), dan `TryParse`.
  - Navigasi antar-form menggunakan `ShowDialog()` (modal form).

### 6. Pertemuan 8 — Koleksi Data: Array, `List(Of T)`, `DataTable` & Pencarian (`pertemuan8/DataMahasiswa`)
- **Implementasi:** Aplikasi `DataMahasiswa` dengan beberapa form demonstrasi: `FrmDariArray`, `FrmDariList`, `FrmCariList`, `FrmDataTable`, class model `Mahasiswa`, serta modul `ModDataContoh` dan `ModPencarian`.
- **Teori & Konsep:**
  - Pemodelan data berbasis objek (**OOP dasar**: class `Mahasiswa` dengan `Property` dan `Constructor`).
  - Perbandingan sumber data untuk `DataGridView`: **Array 2D**, **`List(Of Mahasiswa)`**, dan **`DataTable`**.
  - Penggunaan `BindingSource` sebagai perantara data dan UI.
  - Teknik pencarian/filtering: perulangan manual pada `List(Of T)` vs `BindingSource.Filter` pada `DataTable` (termasuk sanitasi karakter khusus filter `'`, `[`, `]`, `*`, `%` di `ModPencarian`).

### 7. Pertemuan 11 — Windows API (P/Invoke), Global Hotkey & Asisten Presentasi
- **Implementasi:**
  - `Pertemuan11/Pertemuan11`: Project WinForms berisi `frmAsistenPresentasi`, `FrmDemoApi`, dan `ModWindowsApi`.
  - `Pertemuan11/DemoWindowsApi`: Project standalone timer/asisten presentasi dengan `Program.vb` dan pemanggilan Windows API.
- **Teori & Konsep:**
  - **Platform Invoke (P/Invoke):** memanggil fungsi native Windows API (DLL eksternal) melalui `System.Runtime.InteropServices`.
  - Pendaftaran **Global Hotkey** (`RegisterHotKey`, pesan `WM_HOTKEY`, konstanta modifier `MOD_CONTROL`, `MOD_ALT`, `MOD_NOREPEAT`, virtual key `VK_F9`, `VK_F10`).
  - Pengaturan posisi jendela (*Always on Top* / `SWP_NOSIZE`, `SWP_NOMOVE`) dan pengelolaan state timer menggunakan `ULong` / `IntPtr`.

### 8. Pertemuan 12 — Multiple Document Interface / MDI (`Pertemuan12/kode/AdministrasiMahasiswaMdi`)
- **Implementasi:** Aplikasi **Administrasi Mahasiswa MDI** dengan form induk `FrmUtama` serta form anak `FrmMahasiswa` (tabel `DataGridView`), `FrmJurusan` (`ListBox`), dan `FrmTentang`. *(Folder `Pertemuan11/Pertemuan12` berisi template form awal).*
- **Teori & Konsep:**
  - Arsitektur **MDI (Multiple Document Interface)**: satu form induk (`IsMdiContainer = True`) yang menampung beberapa child form (`MdiParent = Me`).
  - Manajemen instance child form (`Me.MdiChildren`, `TypeOf ... Is ...`, mengembalikan window yang diminimalkan dengan `WindowState = FormWindowState.Normal`, dan `Activate()`).

---

## Deskripsi Tugas & Praktikum

| Folder | Topik & Teori yang Diterapkan |
|---|---|
| `PrakT2/Tugas2` | **Peminjaman Buku:** Validasi input terpisah di `ModuleValidasi`, pengelolaan daftar kode buku dengan `List(Of String)`, dan penyimpanan/pembacaan data CSV (`System.IO`, `peminjaman.csv`). |
| `PrakT3/T3` | **Inventaris Buku:** Pengelolaan data buku menggunakan `DataTable` di memori (tambah, tampil, dan manipulasi baris data buku). |
| `T5/T5` | **Penyewaan Mobil:** Penggunaan `ComboBox` untuk memilih jenis mobil, pemuatan gambar dinamis dari folder `assets/` ke `PictureBox` (`Image.FromFile`), serta perhitungan tarif sewa di `ModSewa`. |
| `T7/Perulangan` | **Perulangan (`For...Next`):** Penerapan loop naik dan mundur untuk menghasilkan tabel perkalian dan deret ke dalam `ListBox`, disertai validasi `Integer.TryParse`. |
| `remedial/Remedial_UTS` | **Peminjaman Alat Lab:** Kombinasi OOP (`AlatLab`), `List(Of AlatLab)`, array & `Select Case` pada `ModInventaris`, serta manajemen stok tersedia dan dipinjam pada `FrmPeminjamanAlat`. |

---

## Langkah Pengerjaan & Perapian Repository

1. **Pemeriksaan & Perbaikan Kode (Build Check):**
   - Seluruh project (15 `.vbproj`) diuji menggunakan `dotnet build`.
   - Ditemukan konflik pada `Pertemuan11`: folder `DemoWindowsApi` berada di dalam folder `Pertemuan11.vbproj` sehingga file `AssemblyInfo.vb` terkompilasi ganda (`BC30663`), dan `Program.vb` bentrok dengan `My.MyApplication.Main` (`BC30738`), sedangkan `DemoWindowsApi.vbproj` kehilangan file sumbernya (`BC30420`).
   - **Perbaikan:** Memindahkan `DemoWindowsApi` ke `Pertemuan11/DemoWindowsApi/`, menyalin file sumber `FrmDemoApi.*`, `ModWindowsApi.vb`, dan `Program.vb` ke `Pertemuan11/DemoWindowsApi/`, serta menghapus `Program.vb` duplikat dari `Pertemuan11/Pertemuan11/Pertemuan11/My Project/`. Setelah perbaikan, seluruh 15 project berhasil di-build tanpa error maupun warning.
2. **Konfigurasi `.gitignore` & Pembersihan Cache Git:**
   - Menambahkan `.gitignore` di root untuk mengabaikan `.vs/`, `bin/`, `obj/`, `*.user`, `*.suo`, `*.zip`, `archives/`, serta folder lokal `Visual Studio 18/` dan `Visual Studio 2022/`.
   - Mengeluarkan 158 file cache/build yang sebelumnya terlanjur ter-track menggunakan `git rm --cached` tanpa menghapus file lokal.
3. **Perapian Nama & Struktur File:**
   - Mengganti nama `README (2).md` menjadi `README.md`.
   - Menghapus folder kosong `pertemuan1/` dan file duplikat `pertemuan6.slnx` di root.
   - Memindahkan seluruh arsip `.zip` di root ke folder `archives/` (diabaikan Git).
   - Mengelompokkan file screenshot pengujian di `PrakT2/`, `PrakT3/`, dan `remedial/` ke subfolder `screenshots/` masing-masing.

## Cara Menjalankan Project

1. Buka file `.slnx` / `.sln` di masing-masing folder menggunakan **Visual Studio**, atau build lewat CLI:
   ```powershell
   dotnet build "<path-ke-project>.vbproj"
   ```
2. Tekan **F5** di Visual Studio untuk menjalankan aplikasi.
