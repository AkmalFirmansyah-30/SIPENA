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
            catch (Exception) { }
        }

        private void tutupKoneksi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // 1. EKSEKUSI QUERY STRING BIASA (TIDAK AMAN UNTUK LOGIN)
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

        // 2. EKSEKUSI QUERY PARAMETER (SANGAT AMAN) - HASIL OVERLOADING
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
