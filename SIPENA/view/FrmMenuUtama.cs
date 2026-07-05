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
            // Gunakan nama panggilan (kata pertama dari nama lengkap) untuk tampilan sidebar
            string namaLengkap = SesiLogin.NamaLengkap ?? "User"; // Jaga-jaga jika data kosong
            string[] potonganNama = namaLengkap.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string namaPanggilan = (potonganNama.Length > 0) ? potonganNama[0] : namaLengkap;

            // Tampilkan nama panggilan di Sidebar
            lblNamaUser.Text = "Halo, " + namaPanggilan + "!";
            lblRoleUser.Text = "Role: " + SesiLogin.Role;

            // (Opsional) Biarkan status bar tetap menampilkan nama lengkap
            toolStripStatusLabel1.Text = "User Aktif: " + namaLengkap + " (" + SesiLogin.Role + ")";

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
            if (labelProdi != null) labelProdi.Visible = false;
            if (icnProdi != null) icnProdi.Visible = false;
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
                if (labelProdi != null) labelProdi.Visible = true;
                if (icnProdi != null) icnProdi.Visible = true;
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
                // DOSEN: hanya akses FrmPresensi dan FrmNilai (kategori Transaksi)
                if (label8 != null) label8.Visible = true; // Transaksi

                if (labelPresensi != null) labelPresensi.Visible = true;
                if (icnpresensi != null) icnpresensi.Visible = true;
                if (labelNilai != null) labelNilai.Visible = true;
                if (icnNilai != null) icnNilai.Visible = true;
            }
            else if (roleUser == "mahasiswa")
            {
                // MAHASISWA: hanya akses FrmPresensi (kategori Transaksi)
                if (label8 != null) label8.Visible = true; // Transaksi

                if (labelPresensi != null) labelPresensi.Visible = true;
                if (icnpresensi != null) icnpresensi.Visible = true;
                // Mahasiswa juga dapat melihat Nilai
                if (labelNilai != null) labelNilai.Visible = true;
                if (icnNilai != null) icnNilai.Visible = true;
            }
        }

        private void TampilDataDashboard()
        {
            // Set default values first
            if (lblAngkaMhs != null) lblAngkaMhs.Text = "0";
            if (lblAngkaDosen != null) lblAngkaDosen.Text = "0";
            if (lblAngkaMatkul != null) lblAngkaMatkul.Text = "0";

            // Siapkan koneksi ke database Anda (Sesuaikan string koneksi ini dengan milik Anda)
            string connectionString = "Server=localhost;Database=sipena;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Hitung Total Mahasiswa
                    string queryMhs = "SELECT COUNT(*) FROM mahasiswa";
                    using (MySqlCommand cmd = new MySqlCommand(queryMhs, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int totalMhs = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                        if (lblAngkaMhs != null) lblAngkaMhs.Text = totalMhs.ToString();
                    }

                    // 2. Hitung Total Dosen
                    string queryDosen = "SELECT COUNT(*) FROM dosen";
                    using (MySqlCommand cmd = new MySqlCommand(queryDosen, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int totalDosen = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                        if (lblAngkaDosen != null) lblAngkaDosen.Text = totalDosen.ToString();
                    }

                    // 3. Hitung Total Mata Kuliah
                    string queryMatkul = "SELECT COUNT(*) FROM mata_kuliah";
                    using (MySqlCommand cmd = new MySqlCommand(queryMatkul, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int totalMatkul = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                        if (lblAngkaMatkul != null) lblAngkaMatkul.Text = totalMatkul.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil data dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// Fungsi umum untuk membuka form apapun sebagai child form
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

            // Ketika form child ditutup, refresh data dashboard agar total terupdate
            childForm.FormClosed += (s, ev) =>
            {
                try
                {
                    TampilDataDashboard();
                }
                catch { }
            };
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
            // Refresh data dashboard setelah kembali ke dashboard
            TampilDataDashboard();
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
            // Refresh data dashboard setelah kembali ke dashboard
            TampilDataDashboard();
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

        private void labelProdi_Click(object sender, EventArgs e)
        {
            BukaForm(new FrmProdi());
        }

        private void icnProdi_Click(object sender, EventArgs e)
        {
            BukaForm(new FrmProdi());
        }
    }
}
