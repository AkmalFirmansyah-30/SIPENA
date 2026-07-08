using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // KONSEP OOP: Class & Access Modifier (internal)
    // Class ProgramStudi berfungsi sebagai cetakan (blueprint) untuk objek data program studi.
    // Modifier 'internal' membatasi hak aksesnya agar eksklusif hanya bisa digunakan 
    // di dalam lingkup project aplikasi SIPENA ini saja.
    internal class ProgramStudi
    {
        // KONSEP OOP: Encapsulation (Auto-Implemented Properties)
        // Sintaks { get; set; } adalah cara praktis menerapkan Encapsulation.
        // Data disembunyikan secara aman di latar belakang, lalu kita menggunakan 
        // 'get' untuk mengambil datanya dan 'set' untuk mengisi/memanipulasi datanya.
        public string IdProdi { get; set; }
        public string NamaProdi { get; set; }
    }
}
