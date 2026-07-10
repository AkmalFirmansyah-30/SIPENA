using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // Class & Access Modifier: Blueprint entitas Program Studi dengan hak akses terbatas (internal) di dalam project ini saja
    internal class ProgramStudi
    {
        // Encapsulation: Menggunakan { get; set; } untuk membaca (get) dan mengisi (set) data secara aman
        public string IdProdi { get; set; }
        public string NamaProdi { get; set; }
    }
}
