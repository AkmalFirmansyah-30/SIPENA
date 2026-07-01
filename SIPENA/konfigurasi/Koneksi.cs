using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SIPENA.konfigurasi
{
    internal class Koneksi : Konfigurasi
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string link = "server=localhost;port=3306;database=sipena;uid=root;pwd=";
        //string link = "server=localhost;port=3306;database=sipena;uid=root;pwd=";

        // Konstruktor
        public Koneksi()
        {
            conn = new MySqlConnection(link);
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        private void bukaKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception)
            {
                // Catatan: Praktik yang baik adalah menampilkan atau mencatat (log) error di sini
            }
        }

        private void tutupKoneksi()
        {
            // Mengecek apakah koneksi sedang terbuka sebelum mencoba menutupnya
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

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
            catch (Exception)
            {
            }
            finally
            {
                tutupKoneksi();
            }
            return nilai;
        }

        public override DataTable eksekusiQuery(string query)
        {
            // Diimplementasikan berdasarkan foto dari layar proyektor
            DataTable nilai = new DataTable();
            try
            {
                bukaKoneksi();
                cmd.Connection = conn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(nilai);
            }
            catch (Exception)
            {
            }
            finally
            {
                tutupKoneksi();
            }

            return nilai;
        }
    }
}
