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

        // FITUR REGISTER: Cek ketersediaan Username
        public bool CekUsername(string username)
        {
            string cekQuery = "SELECT * FROM users WHERE username='" + username + "'";
            DataTable dt = server.eksekusiQuery(cekQuery);

            return dt.Rows.Count > 0; // Mengembalikan nilai true jika username sudah dipakai
        }

        // FITUR REGISTER: Simpan data ke database
        public bool Register(string username, string password, string namaLengkap, string role)
        {
            string insertQuery = "INSERT INTO users (username, password, nama_lengkap, role) VALUES ('" + username + "', '" + password + "', '" + namaLengkap + "', '" + role + "')";
            int hasil = server.eksekusiBukanQuery(insertQuery);

            return hasil > 0; // Mengembalikan nilai true jika berhasil disimpan
        }

        // FITUR LOGIN: Cek kecocokan data
        public DataTable Login(string username, string password)
        {
            // Query untuk mencari user yang username dan password-nya cocok
            string loginQuery = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";

            // Kembalikan dalam bentuk DataTable agar form Login bisa membaca Nama dan Role-nya
            return server.eksekusiQuery(loginQuery);
        }
    }
}
