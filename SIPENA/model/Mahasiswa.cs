using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // Class & Access Modifier: Blueprint entitas Mahasiswa dengan hak akses terbatas (internal) di dalam project ini saja
    internal class Mahasiswa
    {
        // Encapsulation: Menggunakan { get; set; } untuk membaca (get) dan mengisi (set) data secara aman
        public string Nim
        {
            get; set;
        }
        public string NamaMahasiswa
        {
            get; set;
        }

        public string IdProdi
        {
            get; set;
        }

        public string Semester
        {
            get; set;
        }
    }
}
