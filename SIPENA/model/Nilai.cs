using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // KONSEP OOP: Class & Access Modifier (internal)
    // Class Nilai berfungsi sebagai entitas data (blueprint) untuk menampung rekaman nilai mahasiswa.
    // Modifier 'internal' memastikan class ini terproteksi dan hanya dikenali 
    // di dalam lingkup project (assembly) aplikasi SIPENA ini saja.
    internal class Nilai
    {
        // KONSEP OOP: Encapsulation (Auto-Implemented Properties)
        // Penggunaan { get; set; } merupakan cara C# menerapkan Encapsulation.
        // Data asli disembunyikan (private di latar belakang), dan kita menggunakan 
        // 'get' (Accessor) untuk membaca serta 'set' (Mutator) untuk mengisi datanya.
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