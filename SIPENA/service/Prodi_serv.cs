using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIPENA.konfigurasi;
using SIPENA.model;

namespace SIPENA.service
{
    // Class service khusus untuk menangani operasi database pada entitas Program Studi
    internal class Prodi_serv
    {
        // Instansiasi class Koneksi untuk membuka jalur komunikasi ke database
        Koneksi kon = new Koneksi();

        // Mengambil seluruh data Program Studi dan mengurutkannya dari ID terkecil (ASC)
        public DataTable tampilData()
        {
            string query = "SELECT * FROM program_studi ORDER BY id_prodi ASC";
            return kon.eksekusiQuery(query);
        }

        // Menyimpan data Program Studi baru ke database
        public void tambahData(ProgramStudi prodi)
        {
            // Sudah tidak ada jenjang dan id_jurusan
            string query = $"INSERT INTO program_studi (id_prodi, nama_prodi) VALUES ('{prodi.IdProdi}', '{prodi.NamaProdi}')";
            kon.eksekusiBukanQuery(query);
        }

        // Memperbarui nama atau ID Program Studi berdasarkan ID lamanya
        public void ubahData(ProgramStudi prodi, string idLama)
        {
            // Sudah tidak ada jenjang dan id_jurusan
            string query = $"UPDATE program_studi SET id_prodi='{prodi.IdProdi}', nama_prodi='{prodi.NamaProdi}' WHERE id_prodi='{idLama}'";
            kon.eksekusiBukanQuery(query);
        }

        // Menghapus data Program Studi secara manual dari bawah ke atas (Manual Cascading Delete)
        // Ini dilakukan agar tidak terjadi error bentrok relasi (Foreign Key Constraint)
        public void hapusData(string idProdi)
        {
            //string query = $"DELETE FROM program_studi WHERE id_prodi='{idProdi}'";
            //kon.eksekusiBukanQuery(query);

            // 1. Hapus nilai milik mahasiswa di prodi tersebut
            string queryNilai = $"DELETE FROM nilai WHERE nim IN (SELECT nim FROM mahasiswa WHERE id_prodi='{idProdi}')";
            // 2. Hapus presensi milik mahasiswa di prodi tersebut
            string queryPresensi = $"DELETE FROM presensi WHERE nim IN (SELECT nim FROM mahasiswa WHERE id_prodi='{idProdi}')";
            // 3. Hapus mahasiswa di prodi tersebut
            string queryMahasiswa = $"DELETE FROM mahasiswa WHERE id_prodi='{idProdi}'";
            // 4. Hapus prodi itu sendiri
            string queryProdi = $"DELETE FROM program_studi WHERE id_prodi='{idProdi}'";

            // Eksekusi query secara berurutan untuk menghindari error relasi
            kon.eksekusiBukanQuery(queryNilai);
            kon.eksekusiBukanQuery(queryPresensi);
            kon.eksekusiBukanQuery(queryMahasiswa);
            kon.eksekusiBukanQuery(queryProdi);
        }

        // Fungsi untuk membuat ID Program Studi secara otomatis berdasarkan ID terbesar yang ada di database
        public string buatIdOtomatis()
        {
            // Mengambil ID terbesar dari tabel program_studi
            string query = "SELECT MAX(id_prodi) FROM program_studi";
            DataTable dt = kon.eksekusiQuery(query);

            // Jika ada data, ambil ID terbesar dan tambahkan 1 untuk membuat ID baru
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                string idTerbesar = dt.Rows[0][0].ToString();
                int angkaBaru = int.Parse(idTerbesar) + 1;
                // Format angka baru menjadi 2 digit (misal 1 menjadi "01")
                return angkaBaru.ToString("D2");
            }
            else
            {
                return "01";
                // Jika tidak ada data, kembalikan ID default "01"
            }
        }
    }
}