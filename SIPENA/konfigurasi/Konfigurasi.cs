using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIPENA.konfigurasi
{
    abstract class Konfigurasi
    {
        // untuk menangani instruksi INSERT, UPDATE dan DELETE
        public abstract int eksekusiBukanQuery(string query);

        // untuk menangani instruksi SELECT
        public abstract DataTable eksekusiQuery(string query);
    }
}
