using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // KONSEP OOP: Class (Kelas)
    // Class ini bertindak sebagai blueprint (cetakan) untuk menciptakan objek (instance) Dosen.
    // Class ini HANYA merepresentasikan entitas data, tidak berisi logika koneksi database (Pemisahan Tugas/Model Layer).
    public class Dosen
    {
        // KONSEP OOP: Encapsulation (Properties / Getter & Setter)
        // Sintaks { get; set; } adalah cara C# melakukan Encapsulation (Pengkapsulan) secara otomatis (Auto-Implemented Properties).
        // 'get' berfungsi sebagai Accessor (untuk membaca data), dan 'set' sebagai Mutator (untuk mengisi/mengubah data).
        // Secara tidak terlihat, C# menyembunyikan variabel aslinya (private field) demi keamanan data.
        public string Nidn { get; set; }
        public string NamaDosen { get; set; }
        public string Gelar { get; set; }
        public string Email { get; set; }
        public string JenisKelamin { get; set; }
        public string ProgramStudi { get; set; }
    }
}
