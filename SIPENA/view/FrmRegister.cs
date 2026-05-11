using SIPENA.konfigurasi;
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
    public partial class FrmRegister : Form
    {
        // Membuat jembatan koneksi ke database
        Koneksi server = new Koneksi();

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Validasi: Pastikan tidak ada kolom yang kosong
            if (txtNama.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || cmbRole.Text == "")
            {
                MessageBox.Show("Semua kolom (Nama, Role, Username, Password) wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validasi: Cek apakah Username sudah pernah dipakai di database
            string cekQuery = "SELECT * FROM users WHERE username='" + txtUsername.Text + "'";
            DataTable dt = server.eksekusiQuery(cekQuery);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username sudah terdaftar! Silakan gunakan username lain.", "Pendaftaran Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus(); // Kembalikan kursor ke kolom username
                return;
            }

            // 3. Eksekusi: Masukkan data baru ke tabel users
            string insertQuery = "INSERT INTO users (username, password, nama_lengkap, role) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtNama.Text + "', '" + cmbRole.Text + "')";

            int hasil = server.eksekusiBukanQuery(insertQuery);

            // 4. Cek apakah penyimpanan berhasil
            if (hasil > 0)
            {
                MessageBox.Show("Akun berhasil dibuat! Silakan login menggunakan akun baru Anda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Langsung arahkan kembali ke halaman Login
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblKembaliLogin_Click(object sender, EventArgs e)
        {
            // Fungsi untuk kembali ke halaman Login tanpa mendaftar
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
