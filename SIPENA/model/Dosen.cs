using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // Class: Blueprint (cetakan) murni untuk merepresentasikan entitas data Dosen
    public class Dosen
    {
        // Encapsulation: Menggunakan { get; set; } untuk membaca (get) dan mengisi (set) data secara aman
        public string Nidn { get; set; }
        public string NamaDosen { get; set; }
        public string Gelar { get; set; }
        public string Email { get; set; }
        public string JenisKelamin { get; set; }
        public string ProgramStudi { get; set; }
    }
}
