using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // Class dibuat 'static' agar nilainya tetap tersimpan selama aplikasi berjalan
    public static class SesiLogin
    {
        public static string Username { get; set; }
        public static string NamaLengkap { get; set; }
        public static string Role { get; set; }

        public static void Logout()
        {
            Username = "";
            NamaLengkap = "";
            Role = "";
        }
    }
}
