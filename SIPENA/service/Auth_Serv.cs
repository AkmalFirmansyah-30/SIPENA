using SIPENA.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPENA.service
{
    public class Auth_Serv
    {
        // Panggil jembatan koneksi
        Koneksi server = new Koneksi();

        // FITUR LOGIN: Cek kecocokan data ke tabel users terpusat
        public DataTable Login(string username, string password)
        {
            // Gunakan parameterized query untuk mencegah SQL Injection
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(
                "SELECT username, nama_lengkap, role FROM users WHERE username=@user AND password=@pass");

            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            // Eksekusi parameterized query via Koneksi
            return server.eksekusiQuery(cmd);
        }
    }
}
