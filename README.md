# Visual Programming Repository

Kumpulan tugas, praktikum, dan latihan **Visual Basic .NET (Windows Forms)** pada mata kuliah Visual Programming.

## Struktur Folder & Project

| Folder | Isi / Topik Project |
|---|---|
| `pertemuan2/vispro1` | Aplikasi Windows Forms dasar (`vispro1`) |
| `vispro3/vispro3` | Latihan kontrol & gambar (`vispro3`) |
| `pertemuan5/pertemuan5` | Array & modul (`FrmArray`, `ModArray`) |
| `pertemuan6/pertemuan6` | Koneksi database & query (`modDatabase`, `ModQuery`, `appsettings.json`) |
| `pertemuan7/pertemuan7` | Uji konversi & form utama (`FrmUjiKonversi`, `FrmUtama`) |
| `pertemuan8/DataMahasiswa` | Pengolahan data mahasiswa (List & DataTable) |
| `Pertemuan11/Pertemuan11` | Asisten presentasi & Windows API (`frmAsistenPresentasi`, `FrmDemoApi`, `ModWindowsApi`) |
| `Pertemuan11/DemoWindowsApi` | Project standalone demo Windows API (`FrmDemoApi`, `ModWindowsApi`, `Program`) |
| `Pertemuan12/kode/AdministrasiMahasiswaMdi` | Aplikasi MDI Administrasi Mahasiswa (`FrmUtama`, `FrmMahasiswa`, `FrmJurusan`, `FrmTentang`) |
| `PrakT2/Tugas2` | Praktikum Tugas 2 — Peminjaman Buku (`frmPeminjamanBuku`, `ModuleValidasi`, `peminjaman.csv`) |
| `PrakT3/T3` | Praktikum Tugas 3 — Inventaris Buku (`frmInventarisBuku`) |
| `T5/T5` | Tugas 5 — Penyewaan Mobil (`Form1`, `ModSewa`, `assets/`) |
| `T7/Perulangan` | Tugas 7 — Perulangan (`Form1`, `Form2`) |
| `remedial/Remedial_UTS` | Remedial UTS — Peminjaman Alat Lab (`FrmPeminjamanAlat`, `AlatLab`, `ModInventaris`) |

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
