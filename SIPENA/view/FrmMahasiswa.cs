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
    public partial class FrmMahasiswa : Form
    {
        Mahasiswa_Serv mhsServ = new Mahasiswa_Serv();
        Mahasiswa mhs = new Mahasiswa();

        string nimLama = "";
        public FrmMahasiswa()
        {
            InitializeComponent();
        }

        private void TampilData()
        {
            dgvMahasiswa.DataSource = mhsServ.tampilData();
        }

        private void TampilComboBoxProdi()
        {
            ProgramStudi_cmb.DataSource = mhsServ.ambilDataProdi();

            ProgramStudi_cmb.DisplayMember = "nama_prodi";
            ProgramStudi_cmb.ValueMember = "id_prodi";
        }

        private void Bersihkan()
        {
            nim_txt.Clear();
            mahasiswa_txt.Clear();
            ProgramStudi_cmb.SelectedIndex = -1;
            Semester_cmb.SelectedIndex = -1; // Semester ikut dibersihkan
            nimLama = "";
            nim_txt.Focus();
        }


        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (nim_txt.Text == "" || mahasiswa_txt.Text == "" || ProgramStudi_cmb.SelectedValue == null || Semester_cmb.Text == "")
            {
                MessageBox.Show("Semua Data Wajib Diisi, Termasuk Program Studi dan Semester!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mhs.Nim = nim_txt.Text;
            mhs.NamaMahasiswa = mahasiswa_txt.Text;
            mhs.IdProdi = ProgramStudi_cmb.SelectedValue.ToString();
            mhs.Semester = Semester_cmb.Text; // Semester masuk ke model

            mhsServ.tambahData(mhs);
            MessageBox.Show("Data Mahasiswa berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TampilData();
            Bersihkan();

        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (nimLama == "")
            {
                MessageBox.Show("Silahkan klik data pada tabel yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mhs.Nim = nim_txt.Text;
            mhs.NamaMahasiswa = mahasiswa_txt.Text;
            mhs.IdProdi = ProgramStudi_cmb.SelectedValue.ToString();
            mhs.Semester = Semester_cmb.Text; // Semester masuk ke model

            mhsServ.ubahData(mhs, nimLama);
            MessageBox.Show("Data Mahasiswa berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TampilData();
            Bersihkan();
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (nim_txt.Text == "")
            {
                MessageBox.Show("Silahkan klik data pada tabel yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menghapus data mahasiswa ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                mhsServ.hapusData(nim_txt.Text);
                MessageBox.Show("Data Mahasiswa berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                Bersihkan();
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void FrmMahasiswa_Load_1(object sender, EventArgs e)
        {
            TampilData();
            TampilComboBoxProdi();
            Bersihkan();
        }

        private void naikSemester_btn_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "Semua mahasiswa akan dinaikkan ke semester berikutnya.\n" +
                "Mahasiswa semester 8 tidak akan berubah.\n\nLanjutkan?",
                "Konfirmasi Kenaikan Semester",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

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
