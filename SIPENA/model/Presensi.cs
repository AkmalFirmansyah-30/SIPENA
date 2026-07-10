using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // Class & Access Modifier: Blueprint entitas Presensi dengan hak akses terbatas (internal) di dalam project ini saja
    internal class Presensi
    {
        // Encapsulation: Menggunakan { get; set; } untuk membaca (get) dan mengisi (set) data secara aman
        public int IdPresensi { get; set; }
        public DateTime Tanggal { get; set; }
        public string Nim { get; set; }
        public string KodeMk { get; set; }
        public int Pertemuan { get; set; }
        public string StatusHadir { get; set; }
        public int Semester { get; set; }
    }
}