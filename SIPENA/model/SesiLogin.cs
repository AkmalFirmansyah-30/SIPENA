using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // KONSEP OOP: Static Class
    // Class 'static' tidak bisa diinstansiasi (tidak bisa dibuat objeknya dengan keyword 'new').
    // Nilai di dalam class ini bersifat global dan tetap utuh di memori selama aplikasi berjalan.
    public static class SesiLogin
    {
        // KONSEP OOP: Encapsulation (Static Properties)
        // Menggunakan { get; set; } untuk mengkapsulasi data sesi pengguna yang sedang login.
        public static string Username { get; set; }
        public static string NamaLengkap { get; set; }
        public static string Role { get; set; }

        // KONSEP OOP: Method / Behavior
        // Fungsi untuk mereset atau membersihkan data sesi kembali ke kondisi kosong saat pengguna keluar.
        public static void Logout()
        {
            Username = "";
            NamaLengkap = "";
            Role = "";
        }
    }
}
