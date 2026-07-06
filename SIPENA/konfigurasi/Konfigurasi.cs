using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.konfigurasi
{
    abstract class Konfigurasi
    {
        // Untuk query biasa (tanpa parameter)
        public abstract int eksekusiBukanQuery(string query);
        public abstract DataTable eksekusiQuery(string query);

        // [BARU] Untuk query aman (menggunakan parameter MySqlCommand)
        public abstract int eksekusiBukanQuery(MySqlCommand command);
        public abstract DataTable eksekusiQuery(MySqlCommand command);
    }
}
