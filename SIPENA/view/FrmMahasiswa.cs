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
    // Class FrmMahasiswa adalah form untuk mengelola data mahasiswa
    public partial class FrmMahasiswa : Form
    {
        // Instansiasi class Mahasiswa_Serv sebagai otak pemroses data mahasiswa
        Mahasiswa_Serv mhsServ = new Mahasiswa_Serv();
        Mahasiswa mhs = new Mahasiswa();

        string nimLama = "";

        // Konstruktor FrmMahasiswa untuk inisialisasi form mahasiswa
        public FrmMahasiswa()
        {
            InitializeComponent();
        }

        // Fungsi untuk menampilkan data mahasiswa ke dalam DataGridView
        private void TampilData()
        {
            dgvMahasiswa.DataSource = mhsServ.tampilData();
        }

        // Fungsi untuk menampilkan data program studi ke dalam ComboBox
        private void TampilComboBoxProdi()
        {
            ProgramStudi_cmb.DataSource = mhsServ.ambilDataProdi();

            ProgramStudi_cmb.DisplayMember = "nama_prodi";
            ProgramStudi_cmb.ValueMember = "id_prodi";
        }

        // Fungsi untuk membersihkan semua inputan di form mahasiswa
        private void Bersihkan()
        {
            nim_txt.Clear();
            mahasiswa_txt.Clear();
            ProgramStudi_cmb.SelectedIndex = -1;
            Semester_cmb.SelectedIndex = -1; // Semester ikut dibersihkan
            nimLama = "";
            nim_txt.Focus();
        }

        // Tombol Simpan ditekan, maka sistem akan menyimpan data mahasiswa baru ke database
        private void simpan_btn_Click(object sender, EventArgs e)
        {
            // Validasi Mencegah Input Kosong (Tugas View)
            if (nim_txt.Text == "" || mahasiswa_txt.Text == "" || ProgramStudi_cmb.SelectedValue == null || Semester_cmb.Text == "")
            {
                MessageBox.Show("Semua Data Wajib Diisi, Termasuk Program Studi dan Semester!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi NIM harus unik (Tugas View)
            mhs.Nim = nim_txt.Text;
            mhs.NamaMahasiswa = mahasiswa_txt.Text;
            mhs.IdProdi = ProgramStudi_cmb.SelectedValue.ToString();
            mhs.Semester = Semester_cmb.Text; // Semester masuk ke model

            // Validasi NIM harus unik (Tugas View)
            mhsServ.tambahData(mhs);
            MessageBox.Show("Data Mahasiswa berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TampilData();
            Bersihkan();

        }

        // Tombol Ubah ditekan, maka sistem akan memperbarui data mahasiswa yang dipilih di tabel
        private void ubah_btn_Click(object sender, EventArgs e)
        {
            // Validasi Mencegah Input Kosong (Tugas View)
            if (nimLama == "")
            {
                MessageBox.Show("Silahkan klik data pada tabel yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Validasi Mencegah Input Kosong (Tugas View)
            mhs.Nim = nim_txt.Text;
            mhs.NamaMahasiswa = mahasiswa_txt.Text;
            mhs.IdProdi = ProgramStudi_cmb.SelectedValue.ToString();
            mhs.Semester = Semester_cmb.Text; // Semester masuk ke model

            // Validasi NIM harus unik (Tugas View)
            mhsServ.ubahData(mhs, nimLama);
            MessageBox.Show("Data Mahasiswa berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TampilData();
            Bersihkan();
        }

        // Tombol Hapus ditekan, maka sistem akan menghapus data mahasiswa yang dipilih di tabel
        private void hapus_btn_Click(object sender, EventArgs e)
        {
            // Validasi Mencegah Input Kosong (Tugas View)
            if (nim_txt.Text == "")
            {
                MessageBox.Show("Silahkan klik data pada tabel yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data mahasiswa ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jika pengguna mengklik "Yes", maka data mahasiswa akan dihapus dari database
            if (konfirmasi == DialogResult.Yes)
            {
                mhsServ.hapusData(nim_txt.Text);
                MessageBox.Show("Data Mahasiswa berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersihkan();
            }
        }

        // Tombol Batal ditekan, maka sistem akan membersihkan semua inputan di form mahasiswa
        private void batal_btn_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        // Tombol Tutup ditekan, maka sistem akan men
        private void tutup_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler untuk menangani klik pada sel di DataGridView mahasiswa
        private void dgvMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validasi untuk memastikan baris yang diklik valid dan bukan baris baru
            if (e.RowIndex >= 0 && !dgvMahasiswa.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dgvMahasiswa.Rows[e.RowIndex];

                nim_txt.Text = row.Cells[0].Value?.ToString();           // NIM
                mahasiswa_txt.Text = row.Cells[1].Value?.ToString();     // Nama
                Semester_cmb.Text = row.Cells[2].Value?.ToString();      // Semester
                ProgramStudi_cmb.Text = row.Cells[3].Value?.ToString();  // Prodi

                nimLama = nim_txt.Text;
            }
        }

        // Event handler untuk memuat form mahasiswa, menampilkan data mahasiswa dan program studi, serta membersihkan inputan
        private void FrmMahasiswa_Load_1(object sender, EventArgs e)
        {
            TampilData();
            TampilComboBoxProdi();
            Bersihkan();
        }

        // Tombol "Naik Semester" ditekan, maka sistem akan menaikkan semester semua mahasiswa ke semester berikutnya
        private void naikSemester_btn_Click(object sender, EventArgs e)
        {
            // Validasi Konfirmasi Kenaikan Semester (Tugas View)
            DialogResult konfirmasi = MessageBox.Show(
                "Semua mahasiswa akan dinaikkan ke semester berikutnya.\n" +
                "Mahasiswa semester 8 tidak akan berubah.\n\nLanjutkan?",
                "Konfirmasi Kenaikan Semester",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Jika pengguna mengklik "Yes", maka sistem akan memanggil fungsi untuk menaikkan semester semua mahasiswa
            if (konfirmasi == DialogResult.Yes)
            {
                mhsServ.naikSemesterSemua();
                MessageBox.Show("Semester semua mahasiswa berhasil diperbarui!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
            }
        }
    }
}
