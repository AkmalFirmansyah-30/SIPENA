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


            string query = "SELECT p.id_presensi, p.tanggal, p.pertemuan, p.nim, " +
              "m.nama_mahasiswa, mk.nama_mk, p.status_hadir, p.semester " +
              "FROM presensi p " +
              "JOIN mahasiswa m ON p.nim = m.nim " +
              "JOIN mata_kuliah mk ON p.kode_mk = mk.kode_mk";
            return koneksi.eksekusiQuery(query);
        }

        public int AmbilSemester(string nim)
        {
            string query = "SELECT semester FROM mahasiswa WHERE nim = '" + nim + "'";
            DataTable dt = koneksi.eksekusiQuery(query);
            if (dt.Rows.Count > 0 && dt.Rows[0]["semester"] != System.DBNull.Value)
                return System.Convert.ToInt32(dt.Rows[0]["semester"]);
            return 0;
        }

        // Fungsi untuk menyimpan data presensi baru
        public int Simpan(Presensi p)
        {
            string query = "INSERT INTO presensi (tanggal, nim, kode_mk, pertemuan, status_hadir, semester) " +
                   "VALUES ('" + p.Tanggal.ToString("yyyy-MM-dd") + "', '" +
                   p.Nim + "', '" +
                   p.KodeMk + "', " +
                   p.Pertemuan + ", '" +
                   p.StatusHadir + "', " +
                   "(SELECT semester FROM mahasiswa WHERE nim = '" + p.Nim + "'))";
            return koneksi.eksekusiBukanQuery(query);
            //string query = "INSERT INTO presensi (tanggal, nim, kode_mk, pertemuan, status_hadir) VALUES " +
            //               "('" + p.Tanggal.ToString("yyyy-MM-dd") + "', '" +
            //               p.Nim + "', '" +
            //               p.KodeMk + "', " +
            //               p.Pertemuan + ", '" +
            //               p.StatusHadir + "')";

            //return koneksi.eksekusiBukanQuery(query);
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