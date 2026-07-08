using System;
using System.Windows.Forms;
using SIPENA.service;
using SIPENA.model;

namespace SIPENA.view
{
    // Class FrmNilai adalah form untuk mengelola data nilai mahasiswa
    public partial class FrmNilai : Form
    {
        // Instansiasi class NilaiService sebagai otak pemroses data nilai
        private NilaiService service = new NilaiService();

        private bool modeEdit = false;
        private int idEdit = 0;

        // Konstruktor FrmNilai untuk inisialisasi form nilai
        public FrmNilai()
        {
            InitializeComponent();

            // Aktifkan scroll otomatis agar form bisa di-scroll ke bawah
            this.AutoScroll = true;

            TampilkanData();
            AturHakAkses();
        }

        // Metode AturHakAkses mengatur hak akses pengguna berdasarkan peran mereka
        private void AturHakAkses()
        {
            // Ambil peran pengguna dari sesi login dan ubah menjadi huruf kecil untuk perbandingan
            string roleUser = (SesiLogin.Role ?? string.Empty).ToLower();

            if (roleUser == "mahasiswa")
            {
                // MAHASISWA: Read-Only (Hanya melihat nilai diri sendiri)
                btnSimpan.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnClear.Visible = false;

                // Nonaktifkan semua input form agar mahasiswa tidak bisa mengubah data
                txtNim.Enabled = false;
                txtKodeMk.Enabled = false;
                txtTugas.Enabled = false;
                txtUts.Enabled = false;
                txtUas.Enabled = false;
                txtSemester.Enabled = false;
            }
            else if (roleUser == "dosen")
            {
                // DOSEN: Hanya bisa input baru (Simpan). Edit jika salah, urusan Admin.
                btnSimpan.Visible = true;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnClear.Visible = true;

                // Aktifkan input form agar dosen bisa mengisi data nilai baru
                txtNim.Enabled = true;
                txtKodeMk.Enabled = true;
                txtTugas.Enabled = true;
                txtUts.Enabled = true;
                txtUas.Enabled = true;
                txtSemester.Enabled = true;
            }
            else if (roleUser == "admin")
            {
                // ADMIN: Full Control (Bisa menggunakan semua tombol)
                btnSimpan.Visible = true;
                btnUbah.Visible = true;
                btnHapus.Visible = true;
                btnClear.Visible = true;

                // Semua input form diaktifkan agar admin bisa mengubah data
                txtNim.Enabled = true;
                txtKodeMk.Enabled = true;
                txtTugas.Enabled = true;
                txtUts.Enabled = true;
                txtUas.Enabled = true;
                txtSemester.Enabled = true;
            }
        }

        // Metode TampilkanData menampilkan data nilai berdasarkan peran pengguna
        private void TampilkanData()
        {
            // Ambil peran pengguna dari sesi login dan ubah menjadi huruf kecil untuk perbandingan
            string roleUser = (SesiLogin.Role ?? string.Empty).ToLower();

            if (roleUser == "mahasiswa")
            {
                // Mahasiswa hanya bisa melihat nilainya sendiri (NIM = Username saat login)
                dgvNilai.DataSource = service.TampilkanBerdasarkanNim(SesiLogin.Username);
            }
            else
            {
                // Dosen dan Admin melihat semua nilai
                dgvNilai.DataSource = service.TampilkanSemua();
            }
        }

        // Metode ClearForm membersihkan semua inputan di form nilai
        private void ClearForm()
        {
            txtNim.Clear();
            txtKodeMk.Clear();
            txtTugas.Clear();
            txtUts.Clear();
            txtUas.Clear();
            txtSemester.Clear();

            // Aktifkan kembali inputan NIM dan Kode MK agar bisa diisi untuk data baru
            txtNim.Enabled = true;
            txtKodeMk.Enabled = true;

            txtNim.Focus();
        }

        // Metode btnSimpan_Click menangani event klik tombol Simpan untuk menyimpan atau mengubah data nilai
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Nilai n = new Nilai();

                // Ambil data dari form dan simpan ke objek Nilai
                n.Nim = txtNim.Text;
                n.KodeMk = txtKodeMk.Text;
                n.NilaiUts = float.Parse(txtUts.Text);
                n.NilaiUas = float.Parse(txtUas.Text);
                n.NilaiTugas = float.Parse(txtTugas.Text);
                n.Semester = Convert.ToInt32(txtSemester.Text);

                int hasil = 0;

                // Jika modeEdit true, berarti kita sedang mengubah data, jadi panggil method Ubah. Jika false, berarti kita menyimpan data baru, jadi panggil method Simpan.
                if (modeEdit)
                {
                    n.IdNilai = idEdit;
                    hasil = service.Ubah(n);
                }
                else
                {
                    hasil = service.Simpan(n);
                }

                // Jika hasil > 0, berarti operasi berhasil, tampilkan pesan sukses dan reset form
                if (hasil > 0)
                {
                    MessageBox.Show(
                        modeEdit ? "Data berhasil diubah!" : "Data berhasil disimpan!",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    modeEdit = false;
                    idEdit = 0;

                    TampilkanData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi Kesalahan: Pastikan form diisi angka dengan benar.\nDetail: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Metode btnUbah_Click menangani event klik tombol Ubah untuk mengisi form dengan data yang dipilih dari tabel
        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi untuk memastikan ada baris yang dipilih di DataGridView sebelum mengubah data
                if (dgvNilai.CurrentRow == null)
                {
                    MessageBox.Show("Pilih data terlebih dahulu di tabel!");
                    return;
                }

                // Penyesuaian Index dengan query di NilaiService
                idEdit = Convert.ToInt32(dgvNilai.CurrentRow.Cells[0].Value);
                txtNim.Text = dgvNilai.CurrentRow.Cells[1].Value.ToString();
                txtKodeMk.Text = dgvNilai.CurrentRow.Cells[3].Value.ToString(); // Index 3: kode_mk
                txtSemester.Text = dgvNilai.CurrentRow.Cells[5].Value.ToString(); // Index 5: semester
                txtUts.Text = dgvNilai.CurrentRow.Cells[6].Value.ToString(); // Index 6: nilai_uts
                txtUas.Text = dgvNilai.CurrentRow.Cells[7].Value.ToString(); // Index 7: nilai_uas
                txtTugas.Text = dgvNilai.CurrentRow.Cells[8].Value.ToString(); // Index 8: nilai_tugas

                txtNim.Enabled = false;
                txtKodeMk.Enabled = false;

                modeEdit = true;

                MessageBox.Show("Data siap diedit. Silakan ubah nilai di form atas, lalu klik Simpan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data dari tabel: " + ex.Message);
            }
        }

        // Metode btnHapus_Click menangani event klik tombol Hapus untuk menghapus data nilai yang dipilih dari tabel
        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvNilai.CurrentRow.Cells[0].Value.ToString());

                // Validasi untuk memastikan ada baris yang dipilih di DataGridView sebelum menghapus data
                if (MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int hasil = service.Hapus(id);

                    if (hasil > 0)
                    {
                        TampilkanData();
                        MessageBox.Show("Data Terhapus!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pilih baris yang ingin dihapus pada tabel.");
            }
        }

        // Metode btnClear_Click menangani event klik tombol Clear untuk membersihkan form dan mengatur ulang mode edit
        private void btnClear_Click(object sender, EventArgs e)
        {
            modeEdit = false;
            idEdit = 0;
            ClearForm();
        }

        // Metode btnTutup_Click menangani event klik tombol Tutup untuk menutup form nilai
        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Dibiarkan kosong agar designer form tidak error saat nge-load
        private void dgvNilai_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void txtKodeMk_TextChanged(object sender, EventArgs e) { }
    }
}