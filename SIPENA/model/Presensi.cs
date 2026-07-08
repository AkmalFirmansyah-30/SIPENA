using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // KONSEP OOP: Class & Access Modifier (internal)
    // Class Presensi ini adalah cetakan (blueprint) untuk objek data kehadiran mahasiswa.
    // Modifier 'internal' membatasi hak aksesnya agar eksklusif hanya bisa digunakan 
    // di dalam lingkup project aplikasi SIPENA ini saja.
    internal class Presensi
    {
        // KONSEP OOP: Encapsulation (Auto-Implemented Properties)
        // Sintaks { get; set; } adalah cara praktis menerapkan Encapsulation.
        // Data disembunyikan secara aman di latar belakang, lalu kita menggunakan 
        // 'get' untuk mengambil datanya dan 'set' untuk mengisi/memanipulasi datanya.
        public int IdPresensi { get; set; }
        public DateTime Tanggal { get; set; }
        public string Nim { get; set; }
        public string KodeMk { get; set; }
        public int Pertemuan { get; set; }
        public string StatusHadir { get; set; }
        public int Semester { get; set; }
    }
}