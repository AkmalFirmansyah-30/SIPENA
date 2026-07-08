using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SIPENA.konfigurasi
{
    // KONSEP OOP: Inheritance (Pewarisan) & Abstraction
    // Class Koneksi mewarisi sifat dan struktur dari abstract class 'Konfigurasi'.
    // Class ini wajib mengimplementasikan (override) semua method abstract dari induknya.
    internal class Koneksi : Konfigurasi
    {
        // KONSEP OOP: Encapsulation (Pengkapsulan)
        // Variabel-variabel ini dibiarkan private (default) agar tidak bisa diakses/diubah sembarangan dari luar class.
        // Ini melindungi kerahasiaan string koneksi database.
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string link = "server=localhost;port=3306;database=sipena;uid=root;pwd=";

        // KONSEP OOP: Constructor
        // Method khusus yang otomatis dijalankan pertama kali saat object Koneksi (Instansiasi) dibuat.
        // Digunakan untuk menyiapkan (inisialisasi) objek koneksi dan command.
        public Koneksi()
        {
            conn = new MySqlConnection(link);
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        // KONSEP OOP: Encapsulation (Information Hiding)
        // Method dibuat 'private' karena murni hanya untuk kebutuhan internal class ini saja.
        private void bukaKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception) { }
        }

        // KONSEP OOP: Encapsulation (Information Hiding)
        private void tutupKoneksi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // KONSEP OOP: Polymorphism (Overriding)
        // Method ini menimpa (override) aturan kosong dari abstract class Konfigurasi.
        // Digunakan untuk instruksi INSERT, UPDATE, DELETE murni (mengembalikan jumlah baris yang berubah).
        public override int eksekusiBukanQuery(string query)
        {
            int nilai = -1;
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                nilai = cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally { tutupKoneksi(); }
            return nilai;
        }

        // KONSEP OOP: Polymorphism (Overriding)
        // Digunakan untuk instruksi SELECT (menarik data) dan mengembalikannya dalam bentuk tabel (DataTable).
        public override DataTable eksekusiQuery(string query)
        {
            DataTable nilai = new DataTable();
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(nilai);
            }
            catch (Exception) { }
            finally { tutupKoneksi(); }
            return nilai;
        }

        // KONSEP OOP: Polymorphism (Overloading & Overriding)
        // Overloading: Nama method sama dengan yang di atas, TAPI parameter inputnya berbeda (menerima MySqlCommand).
        // Ini adalah teknik PBO tingkat lanjut untuk menangkal SQL Injection.
        public override int eksekusiBukanQuery(MySqlCommand command)
        {
            int nilai = -1;
            try
            {
                bukaKoneksi();
                command.Connection = conn; // Kaitkan command dengan koneksi
                nilai = command.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally { tutupKoneksi(); }
            return nilai;
        }

        // KONSEP OOP: Polymorphism (Overloading & Overriding)
        // Menangani SELECT yang menggunakan parameter (sangat aman untuk form Login).
        public override DataTable eksekusiQuery(MySqlCommand command)
        {
            DataTable nilai = new DataTable();
            try
            {
                bukaKoneksi();
                command.Connection = conn; // Kaitkan command dengan koneksi
                adapter.SelectCommand = command;
                adapter.Fill(nilai);
            }
            catch (Exception) { }
            finally { tutupKoneksi(); }
            return nilai;
        }
    }
}
