using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SIPENA.konfigurasi
{
    // Inheritance & Abstraction: Mewarisi dan wajib mengimplementasikan class Konfigurasi
    internal class Koneksi : Konfigurasi
    {
        // Encapsulation: Variabel disembunyikan (private) untuk mengamankan string koneksi
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string link = "server=localhost;port=3306;database=sipena;uid=root;pwd=";

        // Konstruktor: Inisialisasi objek saat class Koneksi pertama kali dipanggil
        public Koneksi()
        {
            conn = new MySqlConnection(link);
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        // Encapsulation: Method private murni untuk kebutuhan internal class
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

        // Encapsulation: Menutup koneksi secara internal
        private void tutupKoneksi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Polymorphism (Overriding): Menimpa method abstract untuk INSERT, UPDATE, DELETE  
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

        // Polymorphism (Overriding): Menimpa method abstract untuk operasi SELECT
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

        // Polymorphism (Overloading): Nama method sama, parameter berbeda (Anti SQL Injection)
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

        // Polymorphism (Overloading): Menangani SELECT ber-parameter untuk keamanan ekstra
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
