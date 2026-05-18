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
    public partial class FrmRegister : Form
    {
        // Memanggil class Auth_Serv sebagai otak pemroses data
        Auth_Serv auth = new Auth_Serv();

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

            // 2. Minta Auth_Serv mengecek apakah Username sudah ada di database
            if (auth.CekUsername(txtUsername.Text) == true)
            {
                MessageBox.Show("Username sudah terdaftar! Silakan gunakan username lain.", "Pendaftaran Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus(); // Kembalikan kursor ke kolom username
                return;
            }

            // 3. Minta Auth_Serv menyimpan data user baru
            bool sukses = auth.Register(txtUsername.Text, txtPassword.Text, txtNama.Text, cmbRole.Text);

            // 4. Cek apakah penyimpanan berhasil
            if (sukses == true)
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
