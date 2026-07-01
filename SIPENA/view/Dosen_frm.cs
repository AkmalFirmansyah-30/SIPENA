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
    public partial class Dosen_frm : Form
    {
        Dosen_serv serv = new Dosen_serv();
        public Dosen_frm()
        {
            InitializeComponent();
        }

        private void Dosen_frm_Load(object sender, EventArgs e)
        {
            prodi_cmb.Items.Clear(); // Bersihkan data bawaan jika ada
            prodi_cmb.Items.Add("Teknik Informatika");
            prodi_cmb.Items.Add("Teknik Elektronika");
            prodi_cmb.Items.Add("Teknik Listrik");
            prodi_cmb.Items.Add("Teknik Mesin");
            prodi_cmb.Items.Add("Teknik Pengendalian Pencemaran Lingkungan");
            prodi_cmb.Items.Add("Teknologi Rekayasa Multimedia");
            prodi_cmb.Items.Add("Teknologi Rekayasa Mekatronika");
            prodi_cmb.Items.Add("Teknologi Rekayasa Perangkat Lunak");
            prodi_cmb.Items.Add("Teknologi Rekayasa Kimia Industri");
            prodi_cmb.Items.Add("Teknologi Rekayasa Energi Terbarukan");
            prodi_cmb.Items.Add("Rekayasa Keamanan Syber");
            prodi_cmb.Items.Add("Akutansi Lembaga Keuangan Syariah");

            RefreshGrid();
        }

        // =========================================
        // FUNGSI MENAMPILKAN DATA KE DATAGRIDVIEW
        // =========================================
        private void RefreshGrid()
        {
            try
            {
                DataTable dt = serv.TampilData();

                // Reset datasource
                dataGridView1.DataSource = null;

                // Isi ulang datasource
                dataGridView1.DataSource = dt;

                // Refresh grid
                dataGridView1.Refresh();

                // Atur ukuran kolom
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hilangkan baris kosong bawah
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data : " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================
        // FUNGSI MEMBERSIHKAN FORM
        // =========================================
        private void ClearForm()
        {
            nidn_txt.Clear();
            namdos_txt.Clear();
            gelar_txt.Clear();
            email_txt.Clear();

            // RESET TAMBAHAN: RadioButton & ComboBox
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            prodi_cmb.SelectedIndex = -1; // Mengosongkan pilihan ComboBox

            // Mengaktifkan kembali textbox NIDN
            nidn_txt.Enabled = true;

            // Fokus kembali ke NIDN
            nidn_txt.Focus();
        }

        // =========================================
        // SAAT DATA GRID DIKLIK (EDIT/AMBIL DATA)
        // =========================================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Mengambil data berdasarkan index kolom database terbaru
                    nidn_txt.Text = row.Cells[0].Value.ToString();
                    namdos_txt.Text = row.Cells[1].Value.ToString();

                    // HANDLING TAMBAHAN: Menyesuaikan RadioButton Jenis Kelamin (Index 2)
                    string jk = row.Cells[2].Value.ToString();
                    if (jk == "Laki-Laki") { rbLaki.Checked = true; }
                    else if (jk == "Perempuan") { rbPerempuan.Checked = true; }
                    else { rbLaki.Checked = false; rbPerempuan.Checked = false; }

                    gelar_txt.Text = row.Cells[3].Value.ToString();
                    email_txt.Text = row.Cells[4].Value.ToString();

                    // HANDLING TAMBAHAN: Menyesuaikan ComboBox Prodi (Index 5)
                    prodi_cmb.Text = row.Cells[5].Value.ToString();

                    // Mengunci NIDN saat edit
                    nidn_txt.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data : " + ex.Message);
            }
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nidn_txt.Text) || string.IsNullOrEmpty(namdos_txt.Text))
                {
                    MessageBox.Show("NIDN dan Nama Dosen wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // VALIDASI TAMBAHAN: Jenis Kelamin wajib dipilih
                if (!rbLaki.Checked && !rbPerempuan.Checked)
                {
                    MessageBox.Show("Jenis Kelamin wajib dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dosen dsn = new Dosen();
                dsn.Nidn = nidn_txt.Text;
                dsn.NamaDosen = namdos_txt.Text;
                dsn.Gelar = gelar_txt.Text;
                dsn.Email = email_txt.Text;

                // ISI TAMBAHAN: Mendapatkan string dari RadioButton & ComboBox
                dsn.JenisKelamin = rbLaki.Checked ? "Laki-Laki" : "Perempuan";
                dsn.ProgramStudi = prodi_cmb.Text;

                if (serv.Simpan(dsn))
                {
                    MessageBox.Show("Data Dosen berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nidn_txt.Text))
                {
                    MessageBox.Show("Pilih data dosen yang ingin diubah terlebih dahulu dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dosen dsn = new Dosen();
                dsn.Nidn = nidn_txt.Text;
                dsn.NamaDosen = namdos_txt.Text;
                dsn.Gelar = gelar_txt.Text;
                dsn.Email = email_txt.Text;

                // ISI TAMBAHAN: Mendapatkan string dari RadioButton & ComboBox untuk Update
                dsn.JenisKelamin = rbLaki.Checked ? "Laki-Laki" : "Perempuan";
                dsn.ProgramStudi = prodi_cmb.Text;

                if (serv.Ubah(dsn))
                {
                    MessageBox.Show("Data Dosen berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengubah: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nidn_txt.Text))
                {
                    MessageBox.Show("Pilih data dosen yang ingin dihapus terlebih dahulu dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Apakah Anda yakin ingin menghapus dosen dengan NIDN " + nidn_txt.Text + "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (serv.Hapus(nidn_txt.Text))
                    {
                        MessageBox.Show("Data Dosen berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void namdos_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}