using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIPENA.model;
using SIPENA.konfigurasi;

namespace SIPENA.service
{
    internal class Matkul_serv
    {
        Koneksi kon = new Koneksi();

        // 1. Fungsi Tampil Data
        public DataTable TampilData()
        {
            string query = "SELECT * FROM mata_kuliah";
            return kon.eksekusiQuery(query);
        }
        public DataTable RefreshData()
        {
            return TampilData();
        }

        // 2. Fungsi Simpan (Insert)
        public bool Simpan(Matkul mk)
        {
            string query = "INSERT INTO mata_kuliah (kode_mk, nama_mk, sks, nidn, semester, program_studi) " +
            "VALUES ('" + mk.KodeMk + "', '" + mk.NamaMk + "', " + mk.Sks + ", '" + mk.Nidn + "', '" + mk.Semester + "', '" + mk.ProgramStudi + "')";
            int hasil = kon.eksekusiBukanQuery(query);

            return hasil > 0;
        }

        // 3. Fungsi Ubah (Update)
        public bool Ubah(Matkul mk)
        {
            string nidnValue = string.IsNullOrEmpty(mk.Nidn) ? "NULL" : $"'{mk.Nidn}'";

            string query = "UPDATE mata_kuliah SET nama_mk = '" + mk.NamaMk + "', sks = " + mk.Sks +
                           ", nidn = '" + mk.Nidn + "', semester = '" + mk.Semester +
                           "', program_studi = '" + mk.ProgramStudi + "' WHERE kode_mk = '" + mk.KodeMk + "'";
            int hasil = kon.eksekusiBukanQuery(query);
            return hasil > 0;
        }

        // 4. Fungsi Hapus (Delete)
        public bool Hapus(string kodeMk)
        {
            string query = $"DELETE FROM mata_kuliah WHERE kode_mk = '{kodeMk}'";

            int hasil = kon.eksekusiBukanQuery(query);
            return hasil > 0;
        }

        // Fungsi untuk membuat nomor urut otomatis MK001, MK002, dst.
        public string BuatKodeOtomatis()
        {
            // Mengambil nomor angka terbesar setelah teks 'MK' (misal MK003 diambil angka 3)
            string query = "SELECT MAX(CAST(SUBSTRING(kode_mk, 3) AS UNSIGNED)) FROM mata_kuliah";
            DataTable dt = kon.eksekusiQuery(query);

            int nomorBaru = 1;

            // Jika di database sudah ada data, angka terbesar tadi ditambah 1
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                nomorBaru = Convert.ToInt32(dt.Rows[0][0]) + 1;
            }

            // Mengembalikan teks gabungan MK + angka yang diberi padding 3 digit (Contoh: MK001)
            return "MK" + nomorBaru.ToString("D3");
        }
    }
}
