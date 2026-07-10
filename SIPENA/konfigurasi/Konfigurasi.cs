using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.konfigurasi
{
    // Abstraction: Class abstrak sebagai blueprint (kerangka wajib) untuk class turunannya
    abstract class Konfigurasi
    {
        // Abstract Method: Deklarasi fungsi tanpa isi untuk INSERT, UPDATE, DELETE (string)
        public abstract int eksekusiBukanQuery(string query);

        // Abstract Method: Deklarasi fungsi tanpa isi untuk SELECT data (string)
        public abstract DataTable eksekusiQuery(string query);

        // Polymorphism (Overloading): Method bernama sama tapi menerima parameter MySqlCommand
        public abstract int eksekusiBukanQuery(MySqlCommand command);

        // Polymorphism (Overloading): Menangani SELECT ber-parameter untuk keamanan ekstra
        public abstract DataTable eksekusiQuery(MySqlCommand command);
    }
}
