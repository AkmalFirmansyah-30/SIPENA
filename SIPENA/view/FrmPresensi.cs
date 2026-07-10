using System;
using System.Linq;
using System.Windows.Forms;
using SIPENA.service;
using SIPENA.model;

namespace SIPENA.view
{
    // Class FrmPresensi adalah form untuk mengelola data presensi mahasiswa
    public partial class FrmPresensi : Form
    {
        private PresensiService service = new PresensiService();

        // Konstruktor FrmPresensi untuk inisialisasi form presensi
        public FrmPresensi()
        {
            InitializeComponent();

            dgvPresensi.AutoGenerateColumns = false;

            // Atur hak akses dulu agar NIM terisi jika mahasiswa
            AturHakAkses();

            // Baru tampilkan data sesuai role
            TampilkanData();
        }

        // Metode untuk menampilkan data presensi di DataGridView sesuai dengan role pengguna
        private void TampilkanData()
        {
            string roleUser = (SesiLogin.Role ?? string.Empty).ToLower();

            if (roleUser == "mahasiswa")
            {
                // Jika Mahasiswa, tampilkan hanya data miliknya berdasarkan NIM (Username)
                dgvPresensi.DataSource = service.TampilkanBerdasarkanNim(SesiLogin.Username);
            }
            else
            {
                // Jika Dosen, tampilkan semua
                dgvPresensi.DataSource = service.TampilkanSemua();
            }
        }

        // Metode untuk membersihkan form inputan presensi
        private void ClearForm()
        {
            // Kosongkan semua inputan di form presensi
            dtpTanggal.Value = DateTime.Now;
            txtKodeMk.Clear();
            txtPertemuan.Clear();

            // Kosongkan semua radio button status kehadiran
            rbHadir.Checked = false;
            rbIzin.Checked = false;
            rbSakit.Checked = false;
            rbAlpha.Checked = false;

            string roleUser = (SesiLogin.Role ?? string.Empty).ToLower();
            if (roleUser != "mahasiswa")
            {
                // Hanya hapus isi kolom NIM jika yang login BUKAN mahasiswa
                txtNim.Clear();
                txtNim.Focus();
            }
            else
            {
                txtKodeMk.Focus(); // Fokus ke mata kuliah langsung untuk mahasiswa
            }
        }

        // Metode untuk mengatur hak akses pengguna berdasarkan role (Mahasiswa atau Dosen)
        private void AturHakAkses()
        {
            string roleUser = (SesiLogin.Role ?? string.Empty).ToLower();

            if (roleUser == "mahasiswa")
            {
                // MAHASISWA: Bisa melakukan input (Simpan), tidak bisa Ubah/Hapus
                btnSimpan.Visible = true;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnClear.Visible = true;

                // NIM otomatis terisi dari akun login mahasiswa & tidak bisa diedit manual
                txtNim.Text = SesiLogin.Username;
                txtNim.Enabled = false;

                // Buka semua inputan lainnya agar mahasiswa bisa mengisi data presensinya
                txtKodeMk.Enabled = true;
                txtSemester.Enabled = true;
                txtPertemuan.Enabled = true;
                dtpTanggal.Enabled = true;
                rbHadir.Enabled = true;
                rbIzin.Enabled = true;
                rbSakit.Enabled = true;
                rbAlpha.Enabled = true;

                // Ambil data semester otomatis berdasarkan NIM mahasiswa yang login
                txtNim_Leave(null, null);
            }
            else if (roleUser == "dosen")
            {
                // DOSEN: Tidak bisa melakukan input (Simpan), Ubah, atau Hapus data presensi
                btnSimpan.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;

                // Kunci/Disable semua form inputan agar dosen tidak bisa mengisi/mengubah
                txtNim.Enabled = false;
                txtKodeMk.Enabled = false;
                txtSemester.Enabled = false;
                txtPertemuan.Enabled = false;
                dtpTanggal.Enabled = false;
                rbHadir.Enabled = false;
                rbIzin.Enabled = false;
                rbSakit.Enabled = false;
                rbAlpha.Enabled = false;
            }
        }

        // Event handler untuk tombol Simpan, menyimpan data presensi ke database
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi inputan sebelum menyimpan data presensi
                Presensi p = new Presensi();

                p.Tanggal = dtpTanggal.Value;
                p.Nim = txtNim.Text;
                p.KodeMk = txtKodeMk.Text;
                p.Pertemuan = Convert.ToInt32(txtPertemuan.Text);

                if (rbHadir.Checked) p.StatusHadir = "Hadir";
                else if (rbIzin.Checked) p.StatusHadir = "Izin";
                else if (rbSakit.Checked) p.StatusHadir = "Sakit";
                else if (rbAlpha.Checked) p.StatusHadir = "Alpha";

                int hasil = service.Simpan(p);

                // Jika berhasil, tampilkan pesan sukses dan refresh data di DataGridView
                if (hasil > 0)
                {
                    MessageBox.Show(
                        "Data Presensi Berhasil Disimpan!",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    TampilkanData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi Kesalahan: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Event handler
        private void btnUbah_Click(object sender, EventArgs e)
        {
            // Tombol Ubah ditekan, tetapi karena mahasiswa tidak bisa mengubah data presensi, tampilkan pesan informasi
            MessageBox.Show("Silakan pilih data pada tabel di bawah untuk melakukan perubahan.", "Informasi");
        }

        // Event handler untuk tombol Hapus, menghapus data presensi yang dipilih dari DataGridView
        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvPresensi.CurrentRow.Cells[0].Value.ToString());

                // Konfirmasi sebelum menghapus data presensi
                if (MessageBox.Show("Yakin ingin menghapus data presensi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int hasil = service.Hapus(id);

                    if (hasil > 0)
                    {
                        TampilkanData();
                        MessageBox.Show("Data Berhasil Dihapus!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus pada tabel.");
            }
        }

        // Event handler untuk tombol Clear, membersihkan semua inputan di form presensi
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Event handler untuk tombol Tutup
        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler untuk validasi input Pertemuan agar hanya menerima angka
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPertemuan.Text.Length > 0 && !txtPertemuan.Text.All(char.IsDigit))
            {
                MessageBox.Show("Pertemuan hanya boleh angka!");
                txtPertemuan.Clear();
            }
        }

        // Event handler untuk mengambil nilai semester mahasiswa secara otomatis saat NIM diisi
        private void txtNim_Leave(object sender, EventArgs e)
        {
            if (txtNim.Text.Trim() != "")
            {
                int semester = service.AmbilSemester(txtNim.Text.Trim());

                if (semester > 0)
                    txtSemester.Text = semester.ToString();
                else
                    txtSemester.Text = "";
            }
        }

        // Biarkan event yang kosong agar Designer form tidak error
        private void label6_Click(object sender, EventArgs e) { }
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void rbHadir_CheckedChanged(object sender, EventArgs e) { }
        private void rbIzin_CheckedChanged(object sender, EventArgs e) { }
        private void rbSakit_CheckedChanged(object sender, EventArgs e) { }
        private void rbAlpha_CheckedChanged(object sender, EventArgs e) { }
    }
}