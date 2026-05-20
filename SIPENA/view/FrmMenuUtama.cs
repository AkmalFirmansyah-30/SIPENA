using MySql.Data.MySqlClient;
using SIPENA.model;
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
    public partial class FrmMenuUtama : Form
    {
        // Variable untuk menyimpan reference ke child form yang terbuka
        private FrmPresensi frmPresensiActive = null;

        public FrmMenuUtama()
        {
            InitializeComponent();
        }

        private void FrmMenuUtama_Load(object sender, EventArgs e)
        {
            // --- 1. SET DATA USER AKTIF ---
            // (Sesuaikan nama toolStripStatusLabel1 dengan yang ada di Properties Anda)
            lblNamaUser.Text = "Halo, " + SesiLogin.NamaLengkap + "!";
            lblRoleUser.Text = "Role: " + SesiLogin.Role;
            toolStripStatusLabel1.Text = "User Aktif: " + SesiLogin.NamaLengkap + " (" + SesiLogin.Role + ")";

            // --- 2. LOAD GAMBAR DARI RESOURCES (Kode Anda) ---
            try
            {
                pictureBox1.Image = SIPENA.Properties.Resources.Logo_PNC;
                icondashboard.Image = SIPENA.Properties.Resources.Dashboard;
                icon_mhs.Image = SIPENA.Properties.Resources.user__2_;
                icon_dosen.Image = SIPENA.Properties.Resources.dosen;
                iconmatkul.Image = SIPENA.Properties.Resources.Matkul;
                icnpresensi.Image = SIPENA.Properties.Resources.icon_user;
                pictureBox7.Image = SIPENA.Properties.Resources.icon_medal;
                icnLogout.Image = SIPENA.Properties.Resources.icon_logout;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading images: " + ex.Message);
            }

            // --- 3. PANGGIL FUNGSI HITUNG DATA DASHBOARD ---
            TampilDataDashboard();
        }

        private void TampilDataDashboard()
        {
            // Siapkan koneksi ke database Anda (Sesuaikan string koneksi ini dengan milik Anda)
            string connectionString = "Server=localhost;Database=sipena;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Hitung Total Mahasiswa (Ganti lblAngkaMhs dengan Name label Anda yang tulisan 120)
                    string queryMhs = "SELECT COUNT(*) FROM mahasiswa";
                    using (MySqlCommand cmd = new MySqlCommand(queryMhs, conn))
                    {
                        int totalMhs = Convert.ToInt32(cmd.ExecuteScalar());
                        lblAngkaMhs.Text = totalMhs.ToString();
                    }

                    // 2. Hitung Total Dosen (Ganti lblAngkaDosen dengan Name label Anda yang tulisan 15)
                    string queryDosen = "SELECT COUNT(*) FROM dosen";
                    using (MySqlCommand cmd = new MySqlCommand(queryDosen, conn))
                    {
                        int totalDosen = Convert.ToInt32(cmd.ExecuteScalar());
                        lblAngkaDosen.Text = totalDosen.ToString();
                    }

                    // 3. Hitung Total Mata Kuliah (Ganti lblAngkaMatkul dengan Name label Anda yang tulisan 9)
                    string queryMatkul = "SELECT COUNT(*) FROM mata_kuliah";
                    using (MySqlCommand cmd = new MySqlCommand(queryMatkul, conn))
                    {
                        int totalMatkul = Convert.ToInt32(cmd.ExecuteScalar());
                        lblAngkaMatkul.Text = totalMatkul.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil data dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Membuka Form Presensi sebagai child form di area dashboard bagian bawah
        /// </summary>
        private void BukaFormPresensi()
        {
            // Jika form presensi sudah terbuka, tutup terlebih dahulu
            if (frmPresensiActive != null && !frmPresensiActive.IsDisposed)
            {
                frmPresensiActive.Close();
            }

            // 1. Bersihkan HANYA wadah form-nya saja (jangan panel1 agar kotak info aman)
            pnlWadahForm.Controls.Clear();

            // 2. Buat instance baru dari FrmPresensi
            frmPresensiActive = new FrmPresensi();

            // 3. Set form agar tidak memiliki border (hilangkan tombol X, kotak, min)
            frmPresensiActive.TopLevel = false;
            frmPresensiActive.FormBorderStyle = FormBorderStyle.None;

            // 4. Set agar form menyesuaikan ukuran panel wadah barunya
            frmPresensiActive.Dock = DockStyle.Fill;

            // 5. Masukkan ke pnlWadahForm dan tampilkan
            pnlWadahForm.Controls.Add(frmPresensiActive);
            frmPresensiActive.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPresensi_Click(object sender, EventArgs e)
        {
            BukaFormPresensi();
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            // Cukup tutup form presensi jika sedang terbuka, 
            // otomatis area bawah akan kembali kosong/bersih.
            if (frmPresensiActive != null && !frmPresensiActive.IsDisposed)
            {
                frmPresensiActive.Close();
            }
        }

        /// <summary>
        /// Event handler untuk icon presensi - klik untuk membuka form presensi
        /// </summary>
        private void icnpresensi_Click(object sender, EventArgs e)
        {
            BukaFormPresensi();
        }

        private void icondashboard_Click(object sender, EventArgs e)
        {
            // Tutup saja form anak yang sedang aktif
            if (frmPresensiActive != null && !frmPresensiActive.IsDisposed)
            {
                frmPresensiActive.Close();
            }
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            ProsesLogout();
        }

        private void ProsesLogout()
        {
            // 1. Tampilkan jendela konfirmasi
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi SIPENA?",
                                                 "Konfirmasi Logout",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            // 2. Jika user menekan tombol Yes
            if (hasil == DialogResult.Yes)
            {
                // 3. BERSIHKAN SESI (Panggil method Logout yang Anda buat tadi)
                SesiLogin.Logout();

                // 4. Arahkan kembali ke Form Login
                FrmLogin login = new FrmLogin();
                login.Show();

                // 5. Tutup Form Menu Utama ini
                this.Close();
            }
        }

        private void icnLogout_Click(object sender, EventArgs e)
        {
            ProsesLogout();
        }
    }
}
