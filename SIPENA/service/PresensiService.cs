using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SIPENA.konfigurasi;
using SIPENA.model;

namespace SIPENA.service
{
    internal class PresensiService
    {
        
        Koneksi koneksi = new Koneksi();

        // Fungsi untuk mengambil data presensi lengkap dengan Nama Mahasiswa dan Nama MK
        public DataTable TampilkanSemua()
        {
            
            
            string query = "SELECT p.id_presensi, p.tanggal, p.nim, m.nama_mahasiswa, mk.nama_mk, p.status_hadir " +
                           "FROM presensi p " +
                           "JOIN mahasiswa m ON p.nim = m.nim " +
                           "JOIN mata_kuliah mk ON p.kode_mk = mk.kode_mk";

            return koneksi.eksekusiQuery(query);
        }

        // Fungsi untuk menyimpan data presensi baru
        public int Simpan(Presensi p)
        {
            
            string query = "INSERT INTO presensi (tanggal, nim, kode_mk, status_hadir) VALUES " +
                           "('" + p.Tanggal.ToString("yyyy-MM-dd") + "', '" +
                           p.Nim + "', '" +
                           p.KodeMk + "', '" +
                           p.StatusHadir + "')";

            return koneksi.eksekusiBukanQuery(query);
        }

        // Fungsi untuk menghapus data presensi berdasarkan ID
        public int Hapus(int id)
        {
            // Menggunakan id_presensi sebagai kunci utama penghapusan
            string query = "DELETE FROM presensi WHERE id_presensi = " + id;
            return koneksi.eksekusiBukanQuery(query);
        }
    }
}