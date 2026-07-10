using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // Static Class: Bersifat global di memori dan tidak perlu diinstansiasi (tanpa 'new') selama aplikasi berjalan
    public static class SesiLogin
    {
        // Encapsulation: Menyimpan data sesi pengguna yang sedang login secara aman menggunakan { get; set; }
        public static string Username { get; set; }
        public static string NamaLengkap { get; set; }
        public static string Role { get; set; }

        // Method: Fungsi untuk membersihkan data memori sesi saat pengguna melakukan logout
        public static void Logout()
        {
            Username = "";
            NamaLengkap = "";
            Role = "";
        }
    }
}
