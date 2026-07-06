using SIPENA.konfigurasi;
using SIPENA.model;
using SIPENA.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPENA.view
{
    public partial class FrmLogin : Form
    {
        // Memanggil class Auth_Serv sebagai otak pemroses data
        Auth_Serv auth = new Auth_Serv();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validasi Mencegah Input Kosong (Tugas View)
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Minta Auth_Serv mengecek kecocokan data ke database
            DataTable dt = auth.Login(txtUsername.Text, txtPassword.Text);

            // Jika data ditemukan (jumlah baris lebih dari 0)
            if (dt.Rows.Count > 0)
            {
                // Simpan identitas ke class SesiLogin agar diingat sistem
                SesiLogin.Username = dt.Rows[0]["username"].ToString();
                SesiLogin.NamaLengkap = dt.Rows[0]["nama_lengkap"].ToString();
                SesiLogin.Role = dt.Rows[0]["role"].ToString();

                MessageBox.Show("Selamat Datang, " + SesiLogin.NamaLengkap + "!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Buka halaman Menu Utama dan sembunyikan form login
                FrmMenuUtama menu = new FrmMenuUtama();
                menu.Show();
                this.Hide();
            }
            else
            {
                // Jika username/password tidak ada di database
                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus(); // Kembalikan kursor ke kolom password
            }
        }
    }
}
