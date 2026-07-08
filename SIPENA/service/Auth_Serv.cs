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
        // Membuat objek dari class Koneksi untuk menghubungkan file service ini ke database
        Koneksi server = new Koneksi();

        // Fungsi untuk mengecek kecocokan Username dan Password saat pengguna mencoba login.
        // Mengembalikan tipe data DataTable agar hasilnya bisa dibaca oleh FrmLogin.
        public DataTable Login(string username, string password)
        {
            // Menyiapkan perintah SQL dengan parameter (@user dan @pass).
            // Ini adalah praktik standar industri untuk mencegah peretasan (Anti SQL Injection).
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(
                "SELECT username, nama_lengkap, role FROM users WHERE username=@user AND password=@pass");

            // Memasukkan nilai yang diketik pengguna di form ke dalam parameter SQL tadi
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            // Melempar perintah yang sudah terenkapsulasi parameter tersebut ke Koneksi untuk dieksekusi
            return server.eksekusiQuery(cmd);
        }
    }
}
