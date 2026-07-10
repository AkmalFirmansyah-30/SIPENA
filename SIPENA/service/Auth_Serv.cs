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
        // Instansiasi objek Koneksi sebagai jembatan komunikasi sistem ke database MySQL
        Koneksi server = new Koneksi();

        // Method otentikasi login yang mengembalikan DataTable untuk divalidasi oleh FrmLogin
        public DataTable Login(string username, string password)
        {
            // Menyiapkan perintah SQL menggunakan parameter (@user, @pass) sebagai perisai dari SQL Injection
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(
                "SELECT username, nama_lengkap, role FROM users WHERE username=@user AND password=@pass");

            // Menyisipkan inputan dari form pengguna ke dalam parameter query secara aman
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            // Mengeksekusi command berparameter melalui metode Polymorphism di class Koneksi
            return server.eksekusiQuery(cmd);
        }
    }
}
