using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.konfigurasi
{
    // KONSEP OOP: Abstraction
    // Class abstrak ini berfungsi sebagai blueprint (kerangka wajib) bagi class turunannya (Koneksi.cs).
    abstract class Konfigurasi
    {
        // KONSEP OOP: Abstract Method (Hanya deklarasi nama fungsi, tanpa isi)
        // Menangani instruksi INSERT, UPDATE, DELETE murni (menggunakan string)
        public abstract int eksekusiBukanQuery(string query);

        // Menangani instruksi SELECT dan mengembalikan data tabel (menggunakan string)
        public abstract DataTable eksekusiQuery(string query);

        // KONSEP OOP: Polymorphism (Overloading)
        // Nama fungsinya sama dengan di atas, tetapi parameternya berbeda (MySqlCommand)

        // Menangani INSERT, UPDATE, DELETE dengan parameter (Anti SQL Injection)
        public abstract int eksekusiBukanQuery(MySqlCommand command);

        // Menangani SELECT dengan parameter (Sangat aman untuk form Login)
        public abstract DataTable eksekusiQuery(MySqlCommand command);
    }
}
