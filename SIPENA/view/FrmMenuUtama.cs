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
        // 1. REVISI: Gunakan variabel tipe 'Form' umum, bukan khusus FrmPresensi
        private Form activeForm = null;

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
                icnMhs.Image = SIPENA.Properties.Resources.user__2_;
                icnDosen.Image = SIPENA.Properties.Resources.dosen;
                icnMatkul.Image = SIPENA.Properties.Resources.Matkul;
                icnpresensi.Image = SIPENA.Properties.Resources.icon_user;
                icnNilai.Image = SIPENA.Properties.Resources.icon_medal;
                icnLogout.Image = SIPENA.Properties.Resources.icon_logout;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading images: " + ex.Message);
            }

            // Atur visibilitas menu berdasarkan role user
            AturHakAksesMenu();

            // --- 3. PANGGIL FUNGSI HITUNG DATA DASHBOARD ---
            TampilDataDashboard();
        }

        private void AturHakAksesMenu()
        {
            // 1. SEMBUNYIKAN SEMUA MENU TERLEBIH DAHULU (Default Closed)
            // Kategori (Designer names: label11 = Master Data, label8 = Transaksi)
            if (label11 != null) label11.Visible = false;
            if (label8 != null) label8.Visible = false;

            // Menu / ikon
            if (labelMhs != null) labelMhs.Visible = false;
            if (icnMhs != null) icnMhs.Visible = false;
            if (labelDosen != null) labelDosen.Visible = false;
            if (icnDosen != null) icnDosen.Visible = false;
            if (labelMatkul != null) labelMatkul.Visible = false;
            if (icnMatkul != null) icnMatkul.Visible = false;
            if (labelPresensi != null) labelPresensi.Visible = false;
            if (icnpresensi != null) icnpresensi.Visible = false;
            if (labelNilai != null) labelNilai.Visible = false;
            if (icnNilai != null) icnNilai.Visible = false;

            // 2. TAMPILKAN MENU BERDASARKAN ROLE
            string roleUser = (SesiLogin.Role ?? string.Empty).ToLower();

            if (roleUser == "admin")
            {
                // ADMIN: tampilkan semua kategori dan menu
                if (label11 != null) label11.Visible = true;
                if (label8 != null) label8.Visible = true;

                if (labelMhs != null) labelMhs.Visible = true;
                if (icnMhs != null) icnMhs.Visible = true;
                if (labelDosen != null) labelDosen.Visible = true;
                if (icnDosen != null) icnDosen.Visible = true;
                if (labelMatkul != null) labelMatkul.Visible = true;
                if (icnMatkul != null) icnMatkul.Visible = true;
                if (labelPresensi != null) labelPresensi.Visible = true;
                if (icnpresensi != null) icnpresensi.Visible = true;
                if (labelNilai != null) labelNilai.Visible = true;
                if (icnNilai != null) icnNilai.Visible = true;
            }
            else if (roleUser == "dosen")
            {
                // DOSEN: tampilkan kategori yang relevan dan hanya menu matkul, presensi, nilai
                if (label11 != null) label11.Visible = true;
                if (label8 != null) label8.Visible = true;

                if (labelMatkul != null) labelMatkul.Visible = true;
                if (icnMatkul != null) icnMatkul.Visible = true;
                if (labelPresensi != null) labelPresensi.Visible = true;
                if (icnpresensi != null) icnpresensi.Visible = true;
                if (labelNilai != null) labelNilai.Visible = true;
                if (icnNilai != null) icnNilai.Visible = true;

                // Pastikan data Mhs and Dosen tetap tersembunyi
                if (labelMhs != null) labelMhs.Visible = false;
                if (icnMhs != null) icnMhs.Visible = false;
                if (labelDosen != null) labelDosen.Visible = false;
                if (icnDosen != null) icnDosen.Visible = false;
            }
            else if (roleUser == "mahasiswa")
            {
                // MAHASISWA: tampilkan kategori yang relevan dan hanya menu mahasiswa (profil), presensi, nilai
                if (label11 != null) label11.Visible = true;
                if (label8 != null) label8.Visible = true;

                if (labelMhs != null) labelMhs.Visible = true;
                if (icnMhs != null) icnMhs.Visible = true;
                if (labelPresensi != null) labelPresensi.Visible = true;
                if (icnpresensi != null) icnpresensi.Visible = true;
                if (labelNilai != null) labelNilai.Visible = true;
                if (icnNilai != null) icnNilai.Visible = true;

                // Pastikan data Dosen dan Matkul tetap tersembunyi
                if (labelDosen != null) labelDosen.Visible = false;
                if (icnDosen != null) icnDosen.Visible = false;
                if (labelMatkul != null) labelMatkul.Visible = false;
                if (icnMatkul != null) icnMatkul.Visible = false;
            }
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
        /// Fungsi umum untuk membuka form apapun sebagai child form
        /// </summary>
        private void BukaForm(Form childForm)
        {
            // Jika ada form lain yang sedang terbuka, tutup dulu
            if (activeForm != null && !activeForm.IsDisposed)
            {
                activeForm.Close();
            }

            // Set form yang baru diklik sebagai form aktif
            activeForm = childForm;

            // Atur agar form kehilangan border dan siap masuk panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Set AutoScaleMode ke None agar tidak ada scaling issues
            childForm.AutoScaleMode = AutoScaleMode.None;

            // Masukkan ke pnlWadahForm dan tampilkan
            pnlWadahForm.Controls.Clear();
            pnlWadahForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
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
            BukaForm(new FrmPresensi());
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            // Tutup form aktif agar kembali ke dashboard kosong
            if (activeForm != null && !activeForm.IsDisposed)
            {
                activeForm.Close();
            }
        }

        /// <summary>
        /// Event handler untuk icon presensi - klik untuk membuka form presensi
        /// </summary>
        private void icnpresensi_Click(object sender, EventArgs e)
        {
            BukaForm(new FrmPresensi());
        }

        private void icondashboard_Click(object sender, EventArgs e)
        {
            // Tutup form anak yang sedang aktif
            if (activeForm != null && !activeForm.IsDisposed)
            {
                activeForm.Close();
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

        private void labelNilai_Click(object sender, EventArgs e)
        {
            BukaForm(new FrmNilai());
        }

        private void icnNilai_Click(object sender, EventArgs e)
        {
            BukaForm(new FrmNilai());
        }

        private void icnMhs_Click(object sender, EventArgs e)
        {
            // Buka form mahasiswa
            BukaForm(new FrmMahasiswa());
        }

        private void labelMhs_Click(object sender, EventArgs e)
        {
            // Buka form mahasiswa
            BukaForm(new FrmMahasiswa());
        }

        private void icnDosen_Click(object sender, EventArgs e)
        {
            BukaForm(new Dosen_frm());
        }

        private void labelDosen_Click(object sender, EventArgs e)
        {
            BukaForm(new Dosen_frm());
        }

        private void icnMatkul_Click(object sender, EventArgs e)
        {
            BukaForm(new Matkul_frm());
        }

        private void labelMatkul_Click(object sender, EventArgs e)
        {
            BukaForm(new Matkul_frm());
        }
    }
}
