using SIPENA.konfigurasi;
using SIPENA.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.service
{
    internal class Mahasiswa_Serv
    {
        Koneksi kon = new Koneksi();
        public DataTable tampilData()
        {
            string query = "select m.nim as 'NIM', m.nama_mahasiswa as 'Nama Mahasiswa', " +
               "m.semester as 'Semester', p.nama_prodi as 'Program Studi' " +
               "from mahasiswa m join program_studi p on m.id_prodi = p.id_prodi";
            return kon.eksekusiQuery(query);
        }
        public DataTable ambilDataProdi()
        {
            string query = "select id_prodi, nama_prodi from program_studi";
            return kon.eksekusiQuery(query);
        }
        public void tambahData(Mahasiswa mhs)
        {
            string query = $"insert into mahasiswa (nim, nama_mahasiswa, id_prodi, semester) " +
                $"values ('{mhs.Nim}', '{mhs.NamaMahasiswa}', '{mhs.IdProdi}', {mhs.Semester})";
            kon.eksekusiBukanQuery(query);
        }
        public void ubahData(Mahasiswa mhs, string nimLama)
        {
            string query = $"update mahasiswa set nim='{mhs.Nim}', " +
                $"nama_mahasiswa='{mhs.NamaMahasiswa}', " +
                $"id_prodi='{mhs.IdProdi}', " +
                $"semester={mhs.Semester} " +
                $"where nim='{nimLama}'";
            kon.eksekusiBukanQuery(query);
        }
        public void hapusData(string nim)
        {
            kon.eksekusiBukanQuery($"delete from nilai where nim='{nim}'");
            kon.eksekusiBukanQuery($"delete from presensi where nim='{nim}'");
            kon.eksekusiBukanQuery($"delete from mahasiswa where nim='{nim}'");
        }

        public void naikSemesterSemua()
        {
            string query = "UPDATE mahasiswa SET semester = semester + 1 where semester < 8";
            kon.eksekusiBukanQuery(query);

        }
}}
