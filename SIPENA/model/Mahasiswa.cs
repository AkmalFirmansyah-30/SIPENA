using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.model
{
    // KONSEP OOP: Class & Access Modifier
    // Class ini berfungsi sebagai blueprint (cetakan) khusus untuk entitas Mahasiswa.
    // Penggunaan modifier 'internal' (berbeda dengan 'public' pada class Dosen) 
    // berarti class ini hanya bisa diakses oleh file-file yang berada di dalam project SIPENA ini saja.
    internal class Mahasiswa
    {
        // KONSEP OOP: Encapsulation (Auto-Implemented Properties)
        // Menggunakan { get; set; } untuk mengkapsulasi data.
        // C# akan membuat variabel private di latar belakang, dan kita menggunakan 
        // 'get' untuk membaca isinya, serta 'set' untuk mengubah isinya.
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
