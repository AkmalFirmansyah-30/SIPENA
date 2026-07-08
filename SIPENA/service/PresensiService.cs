using System;
using System.Collections.Generic;
using System.Data;
using SIPENA.konfigurasi;
using SIPENA.model;

namespace SIPENA.service
{
    // Class service untuk menangani semua operasi database yang berkaitan dengan Presensi
    internal class PresensiService
    {
        // Memanggil class Koneksi untuk menghubungkan service ini ke database
        Koneksi koneksi = new Koneksi();

        // Fungsi untuk DOSEN: mengambil semua data presensi
        // Menggunakan teknik JOIN untuk menggabungkan data dari tabel presensi, mahasiswa, dan mata_kuliah
        public DataTable TampilkanSemua()
        {
            string query = "SELECT p.id_presensi, p.tanggal, p.pertemuan, p.nim, " +
              "m.nama_mahasiswa, mk.nama_mk, p.status_hadir, p.semester " +
              "FROM presensi p " +
              "JOIN mahasiswa m ON p.nim = m.nim " +
              "JOIN mata_kuliah mk ON p.kode_mk = mk.kode_mk";
            return koneksi.eksekusiQuery(query);
        }

        // FUNGSI UNTUK MAHASISWA: Ambil data berdasarkan NIM saja
        // Logikanya sama dengan TampilkanSemua, tapi difilter (WHERE) agar hanya menampilkan presensi milik 1 NIM saja
        public DataTable TampilkanBerdasarkanNim(string nim)
        {
            string query = "SELECT p.id_presensi, p.tanggal, p.pertemuan, p.nim, " +
              "m.nama_mahasiswa, mk.nama_mk, p.status_hadir, p.semester " +
              "FROM presensi p " +
              "JOIN mahasiswa m ON p.nim = m.nim " +
              "JOIN mata_kuliah mk ON p.kode_mk = mk.kode_mk " +
              "WHERE p.nim = '" + nim + "'";
            return koneksi.eksekusiQuery(query);
        }

        // Fungsi bantuan untuk mengambil nilai semester mahasiswa yang sedang aktif
        public int AmbilSemester(string nim)
        {
            string query = "SELECT semester FROM mahasiswa WHERE nim = '" + nim + "'";
            DataTable dt = koneksi.eksekusiQuery(query);

            // Cek apakah data ditemukan dan nilainya tidak null sebelum dikonversi ke integer
            if (dt.Rows.Count > 0 && dt.Rows[0]["semester"] != System.DBNull.Value)
                return System.Convert.ToInt32(dt.Rows[0]["semester"]);
            return 0; // Kembalikan 0 jika data tidak ditemukan
        }

        // Fungsi untuk menyimpan data presensi baru ke dalam database
        public int Simpan(Presensi p)
        {
            // Nilai semester tidak diinput manual, melainkan ditarik otomatis dari tabel mahasiswa menggunakan sub-query
            string query = "INSERT INTO presensi (tanggal, nim, kode_mk, pertemuan, status_hadir, semester) " +
                   "VALUES ('" + p.Tanggal.ToString("yyyy-MM-dd") + "', '" +
                   p.Nim + "', '" +
                   p.KodeMk + "', " +
                   p.Pertemuan + ", '" +
                   p.StatusHadir + "', " +
                   "(SELECT semester FROM mahasiswa WHERE nim = '" + p.Nim + "'))";
            return koneksi.eksekusiBukanQuery(query);
        }

        // Fungsi untuk menghapus satu baris data presensi berdasarkan ID uniknya
        public int Hapus(int id)
        {
            string query = "DELETE FROM presensi WHERE id_presensi = " + id;
            return koneksi.eksekusiBukanQuery(query);
        }
    }
}