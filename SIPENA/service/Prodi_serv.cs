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
    internal class Prodi_serv
    {
        Koneksi kon = new Koneksi();

        public DataTable tampilData()
        {
            string query = "SELECT * FROM program_studi ORDER BY id_prodi ASC";
            return kon.eksekusiQuery(query);
        }

        public void tambahData(ProgramStudi prodi)
        {
            // Sudah tidak ada jenjang dan id_jurusan
            string query = $"INSERT INTO program_studi (id_prodi, nama_prodi) VALUES ('{prodi.IdProdi}', '{prodi.NamaProdi}')";
            kon.eksekusiBukanQuery(query);
        }

        public void ubahData(ProgramStudi prodi, string idLama)
        {
            // Sudah tidak ada jenjang dan id_jurusan
            string query = $"UPDATE program_studi SET id_prodi='{prodi.IdProdi}', nama_prodi='{prodi.NamaProdi}' WHERE id_prodi='{idLama}'";
            kon.eksekusiBukanQuery(query);
        }

        public void hapusData(string idProdi)
        {
            //string query = $"DELETE FROM program_studi WHERE id_prodi='{idProdi}'";
            //kon.eksekusiBukanQuery(query);

            string queryNilai = $"DELETE FROM nilai WHERE nim IN (SELECT nim FROM mahasiswa WHERE id_prodi='{idProdi}')";
            string queryPresensi = $"DELETE FROM presensi WHERE nim IN (SELECT nim FROM mahasiswa WHERE id_prodi='{idProdi}')";
            string queryMahasiswa = $"DELETE FROM mahasiswa WHERE id_prodi='{idProdi}'";
            string queryProdi = $"DELETE FROM program_studi WHERE id_prodi='{idProdi}'";

            kon.eksekusiBukanQuery(queryNilai);
            kon.eksekusiBukanQuery(queryPresensi);
            kon.eksekusiBukanQuery(queryMahasiswa);
            kon.eksekusiBukanQuery(queryProdi);
        }

        public string buatIdOtomatis()
        {
            string query = "SELECT MAX(id_prodi) FROM program_studi";
            DataTable dt = kon.eksekusiQuery(query);

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                string idTerbesar = dt.Rows[0][0].ToString();
                int angkaBaru = int.Parse(idTerbesar) + 1;
                return angkaBaru.ToString("D2");
            }
            else
            {
                return "01";
            }
        }
    }
}