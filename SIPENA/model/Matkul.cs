using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // KONSEP OOP: Class & Access Modifier (internal)
    // Class Matkul (Mata Kuliah) berfungsi sebagai cetakan (blueprint) untuk objek mata kuliah.
    // Menggunakan modifier 'internal' agar class ini eksklusif dan hanya bisa digunakan 
    // oleh file-file yang berada di dalam project SIPENA ini saja.
    internal class Matkul
    {
        // KONSEP OOP: Encapsulation (Auto-Implemented Properties)
        // Sintaks { get; set; } mengkapsulasi data dengan menyembunyikan variabel private di latar belakang.
        // 'get' berfungsi sebagai jalan masuk untuk membaca data, 
        // sedangkan 'set' berfungsi sebagai jalan masuk untuk mengubah atau mengisi data.
        public string KodeMk { get; set; }
        public string NamaMk { get; set; }
        public int Sks { get; set; }
        public string Semester { get; set; }
        public string Nidn { get; set; }
        public string ProgramStudi {  get; set; }
    }
}
