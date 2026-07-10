using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // Class & Access Modifier: Blueprint entitas Mata Kuliah dengan hak akses terbatas (internal) di dalam project ini saja
    internal class Matkul
    {
        // Encapsulation: Menggunakan { get; set; } untuk membaca (get) dan mengisi (set) data secara aman
        public string KodeMk { get; set; }
        public string NamaMk { get; set; }
        public int Sks { get; set; }
        public string Semester { get; set; }
        public string Nidn { get; set; }
        public string ProgramStudi {  get; set; }
    }
}
