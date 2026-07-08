using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPENA.model;
using SIPENA.service;

namespace SIPENA.view
{
    // Class FrmProdi adalah form untuk mengelola data program studi
    public partial class FrmProdi : Form
    {
        // Instansiasi class Prodi_serv sebagai otak pemroses data program studi
        Prodi_serv prodiServ = new Prodi_serv();
        ProgramStudi prodi = new ProgramStudi();

        string idProdiLama = "";

        // Konstruktor FrmProdi untuk inisialisasi form program studi
        public FrmProdi()
        {
            InitializeComponent();
        }

        // Fungsi untuk menampilkan data program studi ke dalam DataGridView
        private void TampilData()
        {
            dgvProdi.AutoGenerateColumns = false;
            dgvProdi.DataSource = prodiServ.tampilData();
        }

        // Fungsi untuk membersihkan semua inputan di form program studi
        private void Bersihkan()
        {
            IdProdi_txt.Text = prodiServ.buatIdOtomatis();
            IdProdi_txt.Enabled = false;
            NamaProdi_txt.Clear();
            idProdiLama = "";
            NamaProdi_txt.Focus();
        }

        // Tombol Simpan ditekan, maka sistem akan menyimpan data program studi baru ke database
        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (IdProdi_txt.Text == "" || NamaProdi_txt.Text == "")
            {
                MessageBox.Show("Data Harus Diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            prodi.IdProdi = IdProdi_txt.Text;
            prodi.NamaProdi = NamaProdi_txt.Text;

            prodiServ.tambahData(prodi);
            MessageBox.Show("Data Prodi Berhasil Disimpan!", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TampilData();
            Bersihkan();
        }

        // Tombol Ubah ditekan, maka sistem akan mengubah data program studi yang dipilih di DataGridView
        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (idProdiLama == "")
            {
                MessageBox.Show("Silahkan klik data pada tabel yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            prodi.IdProdi = IdProdi_txt.Text;
            prodi.NamaProdi = NamaProdi_txt.Text;

            prodiServ.ubahData(prodi, idProdiLama);
            MessageBox.Show("Data Prodi Berhasil Diubah!", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TampilData();
            Bersihkan();
        }

        // Tombol Hapus ditekan, maka sistem akan menghapus data program studi yang dipilih di DataGridView
        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (IdProdi_txt.Text == "")
            {
                MessageBox.Show("Silahkan klik data pada tabel yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data prodi ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                prodiServ.hapusData(IdProdi_txt.Text);
                MessageBox.Show("Data Prodi Berhasil Dihapus!", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersihkan();
            }
        }

        // Tombol Batal ditekan, maka sistem akan membersihkan semua inputan di form program studi
        private void batal_btn_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        // Tombol Tutup ditekan, maka sistem akan menutup form program studi
        private void tutup_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler
        private void FrmProdi_Load(object sender, EventArgs e)
        {
            TampilData();
            Bersihkan();
        }

        // Event handler untuk menangani klik pada sel di DataGridView program studi
        private void dgvProdi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvProdi.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dgvProdi.Rows[e.RowIndex];

                // Index sesuaikan dengan sisa kolom di tabelmu (0 dan 1)
                IdProdi_txt.Text = row.Cells[0].Value?.ToString();
                NamaProdi_txt.Text = row.Cells[1].Value?.ToString();

                idProdiLama = IdProdi_txt.Text;
            }
        }
    }
}
