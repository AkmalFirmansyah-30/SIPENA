using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // Class & Access Modifier: Blueprint entitas Nilai dengan hak akses terbatas (internal) di dalam project ini saja
    internal class Nilai
    {
        // Encapsulation: Menggunakan { get; set; } untuk membaca (get) dan mengisi (set) data secara aman
        public int IdNilai { get; set; }
        public string Nim { get; set; }
        public string KodeMk { get; set; }
        public float NilaiTugas { get; set; }
        public float NilaiUts { get; set; }
        public float NilaiUas { get; set; }
        public float NilaiAkhir { get; set; }
        public string Grade { get; set; }
        public int Semester { get; set; }
    }
}