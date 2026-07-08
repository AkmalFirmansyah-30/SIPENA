using SIPENA.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIPENA.model;

namespace SIPENA.service
{
    public class Dosen_serv
    {
        // Memanggil jembatan koneksi ke database
        Koneksi kon = new Koneksi();
        string Query;

        // Fungsi Tampil Data
        public DataTable TampilData()
        {
            // Menggunakan SELECT * akan otomatis mengambil seluruh kolom termasuk 2 kolom baru
            string query = "SELECT * FROM dosen";
            return kon.eksekusiQuery(query);
        }

        // Refresh Data
        public DataTable RefreshData()
        {
            return TampilData();
        }

        // Fungsi Simpan (Insert) - SUDAH DIPERBARUI
        public bool Simpan(Dosen dsn)
        {
            // Query disesuaikan dengan urutan kolom database terbaru Anda
            string query = $"INSERT INTO dosen (nidn, nama_dosen, jenis_kelamin, gelar, email, program_studi) " +
                           $"VALUES ('{dsn.Nidn}', '{dsn.NamaDosen}', '{dsn.JenisKelamin}', '{dsn.Gelar}', '{dsn.Email}', '{dsn.ProgramStudi}')";

            int hasil = kon.eksekusiBukanQuery(query);
            return hasil > 0;
        }

        // Fungsi Ubah (Update) - SUDAH DIPERBARUI
        public bool Ubah(Dosen dsn)
        {
            // Query ditambahkan untuk memperbarui jenis_kelamin dan program_studi
            string query = $"UPDATE dosen SET " +
                           $"nama_dosen = '{dsn.NamaDosen}', " +
                           $"jenis_kelamin = '{dsn.JenisKelamin}', " +
                           $"gelar = '{dsn.Gelar}', " +
                           $"email = '{dsn.Email}', " +
                           $"program_studi = '{dsn.ProgramStudi}' " +
                           $"WHERE nidn = '{dsn.Nidn}'";

            int hasil = kon.eksekusiBukanQuery(query);
            return hasil > 0;
        }

        // Fungsi Hapus (Delete)
        public bool Hapus(string nidn)
        {
            string query = $"DELETE FROM dosen WHERE nidn = '{nidn}'";

            int hasil = kon.eksekusiBukanQuery(query);
            return hasil > 0;
        }
    }
}