using SIPENA.konfigurasi;
using SIPENA.model;
using System;
using System.Data;
using System.Globalization;

namespace SIPENA.service
{
    internal class NilaiService
    {
        private Koneksi koneksi = new Koneksi();

        // MENAMPILKAN DATA NILAI
        public DataTable TampilkanSemua()
        {
            string query =
                "SELECT n.id_nilai, n.nim, m.nama_mahasiswa, mk.nama_mk, " +
                "n.semester, " +
                "n.nilai_tugas, n.nilai_uts, n.nilai_uas, n.nilai_akhir, n.grade " +
                "FROM nilai n " +
                "JOIN mahasiswa m ON n.nim = m.nim " +
                "JOIN mata_kuliah mk ON n.kode_mk = mk.kode_mk";

            return koneksi.eksekusiQuery(query);
        }

        // MENYIMPAN DATA NILAI
        public int Simpan(Nilai n)
        {
            // Hitung nilai akhir
            n.NilaiAkhir = (float)Math.Round(
                (n.NilaiTugas * 0.3f) +
                (n.NilaiUts * 0.3f) +
                (n.NilaiUas * 0.4f),
                2);

            // Menentukan grade
            if (n.NilaiAkhir >= 80)
                n.Grade = "A";
            else if (n.NilaiAkhir >= 70)
                n.Grade = "B";
            else if (n.NilaiAkhir >= 60)
                n.Grade = "C";
            else if (n.NilaiAkhir >= 50)
                n.Grade = "D";
            else
                n.Grade = "E";

            string query =
                "INSERT INTO nilai " +
                "(nim, kode_mk, semester, nilai_tugas, nilai_uts, nilai_uas, nilai_akhir, grade) VALUES (" +
                "'" + n.Nim + "', " +
                "'" + n.KodeMk + "', " +
                n.Semester + ", " +
                n.NilaiTugas.ToString(CultureInfo.InvariantCulture) + ", " +
                n.NilaiUts.ToString(CultureInfo.InvariantCulture) + ", " +
                n.NilaiUas.ToString(CultureInfo.InvariantCulture) + ", " +
                n.NilaiAkhir.ToString(CultureInfo.InvariantCulture) + ", " +
                "'" + n.Grade + "')";

            return koneksi.eksekusiBukanQuery(query);
        }

        // MENGUBAH DATA NILAI
        public int Ubah(Nilai n)
        {
            // Hitung ulang nilai akhir
            n.NilaiAkhir = (float)Math.Round(
                (n.NilaiTugas * 0.3f) +
                (n.NilaiUts * 0.3f) +
                (n.NilaiUas * 0.4f),
                2);

            // Menentukan grade
            if (n.NilaiAkhir >= 80)
                n.Grade = "A";
            else if (n.NilaiAkhir >= 70)
                n.Grade = "B";
            else if (n.NilaiAkhir >= 60)
                n.Grade = "C";
            else if (n.NilaiAkhir >= 50)
                n.Grade = "D";
            else
                n.Grade = "E";

            string query =
                "UPDATE nilai SET " +
                "nilai_tugas = " + n.NilaiTugas.ToString(CultureInfo.InvariantCulture) + ", " +
                "nilai_uts = " + n.NilaiUts.ToString(CultureInfo.InvariantCulture) + ", " +
                "nilai_uas = " + n.NilaiUas.ToString(CultureInfo.InvariantCulture) + ", " +
                "nilai_akhir = " + n.NilaiAkhir.ToString(CultureInfo.InvariantCulture) + ", " +
                "grade = '" + n.Grade + "' " +
                "WHERE id_nilai = " + n.IdNilai;

            return koneksi.eksekusiBukanQuery(query);
        }

        // MENGHAPUS DATA NILAI
        public int Hapus(int id)
        {
            string query =
                "DELETE FROM nilai WHERE id_nilai = " + id;

            return koneksi.eksekusiBukanQuery(query);
        }
    }
}