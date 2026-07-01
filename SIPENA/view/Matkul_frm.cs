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
    public partial class Matkul_frm : Form
    {
        Matkul_serv serv = new Matkul_serv();
        Dosen_serv dsnServ = new Dosen_serv();

        public Matkul_frm()
        {
            InitializeComponent();
        }

        private void Matkul_frm_Load(object sender, EventArgs e)
        {
            // Membuat form langsung otomatis penuh (Maximized) saat dirunning
            this.WindowState = FormWindowState.Maximized;

            LoadDosen();

            // Mengisi pilihan ke dalam ComboBox Semester secara manual
            semester_cmb.Items.Clear();
            semester_cmb.Items.Add("Semester 1");
            semester_cmb.Items.Add("Semester 2");
            semester_cmb.Items.Add("Semester 3");
            semester_cmb.Items.Add("Semester 4");
            semester_cmb.Items.Add("Semester 5");
            semester_cmb.Items.Add("Semester 6");
            semester_cmb.Items.Add("Semester 7");
            semester_cmb.Items.Add("Semester 8");
            semester_cmb.SelectedIndex = -1;

            // TWEAK SINKRONISASI: Mengisi pilihan ke dalam ComboBox Program Studi (prodi_cmb)
            prodi_cmb.Items.Clear();
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
            prodi_cmb.SelectedIndex = -1;

            // Memanggil RefreshGrid dan ClearForm
            RefreshGrid();
            ClearForm();
        }

        private void LoadDosen()
        {
            try
            {
                DataTable dt = dsnServ.TampilData();
                nidn_cmb.DataSource = dt;

                // TWEAK UI/UX: Yang tampil di layar user adalah Nama Dosen
                nidn_cmb.DisplayMember = "nama_dosen";

                // Nilai asli di balik layar yang disimpan tetap NIDN
                nidn_cmb.ValueMember = "nidn";
                nidn_cmb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data dosen : " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RefreshGrid()
        {
            try
            {
                DataTable dt = serv.TampilData();

                // PAKAI KOLOM YANG SUDAH DIBUAT DI DESIGNER
                dataGridView1.AutoGenerateColumns = false;

                // Refresh datasource
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;

                // Atur ukuran kolom otomatis
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Menghilangkan row kosong bawah
                dataGridView1.AllowUserToAddRows = false;

                // Refresh tampilan
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data : " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // TWEAK AMAN: Menggunakan Name Kolom (DataPropertyName) agar tidak rawan bergeser indeksnya
                    kode_txt.Text = row.Cells["kode_mk"].Value.ToString();
                    nama_txt.Text = row.Cells["nama_mk"].Value.ToString();
                    sks_num.Value = Convert.ToDecimal(row.Cells["sks"].Value);
                    nidn_cmb.SelectedValue = row.Cells["nidn"].Value.ToString();
                    semester_cmb.Text = row.Cells["semester"].Value.ToString();

                    // TWEAK SINKRONISASI: Menampilkan kembali nilai prodi saat grid di-klik
                    prodi_cmb.Text = row.Cells["program_studi"].Value.ToString();

                    // Kunci kode_txt agar primary key tidak diubah saat mode edit (Ubah/Hapus)
                    kode_txt.Enabled = false;
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
                // VALIDASI INPUT KOSONG (Ditambahkan prodi_cmb)
                if (string.IsNullOrWhiteSpace(kode_txt.Text) ||
                    string.IsNullOrWhiteSpace(nama_txt.Text) ||
                    nidn_cmb.SelectedIndex == -1 ||
                    semester_cmb.SelectedIndex == -1 ||
                    prodi_cmb.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Semua data termasuk Program Studi wajib diisi!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // MEMBUAT OBJECT
                Matkul mk = new Matkul();
                mk.KodeMk = kode_txt.Text;
                mk.NamaMk = nama_txt.Text;
                mk.Sks = Convert.ToInt32(sks_num.Value);
                mk.Semester = semester_cmb.Text;
                mk.Nidn = nidn_cmb.SelectedValue.ToString();

                // TWEAK SINKRONISASI: Memasukkan nilai prodi ke object Model
                mk.ProgramStudi = prodi_cmb.Text;

                // SIMPAN DATA
                if (serv.Simpan(mk))
                {
                    MessageBox.Show(
                        "Data berhasil disimpan!",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    RefreshGrid();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(
                        "Data gagal disimpan!",
                        "Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat menyimpan : " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(kode_txt.Text))
                {
                    MessageBox.Show(
                        "Pilih data terlebih dahulu melalui tabel bawah!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // VALIDASI INPUT KOSONG SAAT UBAH
                if (string.IsNullOrWhiteSpace(nama_txt.Text) ||
                    nidn_cmb.SelectedIndex == -1 ||
                    semester_cmb.SelectedIndex == -1 ||
                    prodi_cmb.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Data perubahan tidak boleh dikosongkan!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Matkul mk = new Matkul();
                mk.KodeMk = kode_txt.Text;
                mk.NamaMk = nama_txt.Text;
                mk.Sks = Convert.ToInt32(sks_num.Value);
                mk.Semester = semester_cmb.Text;
                mk.Nidn = nidn_cmb.SelectedValue.ToString();

                // TWEAK SINKRONISASI: Memasukkan nilai prodi ke object Model saat update
                mk.ProgramStudi = prodi_cmb.Text;

                if (serv.Ubah(mk))
                {
                    MessageBox.Show(
                        "Data berhasil diubah!",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    RefreshGrid();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(
                        "Data gagal diubah!",
                        "Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat mengubah : " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(kode_txt.Text))
                {
                    MessageBox.Show(
                        "Pilih data terlebih dahulu melalui tabel bawah!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult jawab = MessageBox.Show(
                        "Yakin ingin menghapus data mata kuliah ini?",
                        "Konfirmasi",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (jawab == DialogResult.Yes)
                {
                    if (serv.Hapus(kode_txt.Text))
                    {
                        MessageBox.Show(
                            "Data berhasil dihapus!",
                            "Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        RefreshGrid();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat menghapus : " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            kode_txt.Clear();
            kode_txt.Enabled = true;

            nama_txt.Clear();
            nidn_cmb.SelectedIndex = -1;
            sks_num.Value = 0;
            semester_cmb.SelectedIndex = -1;

            // TWEAK SINKRONISASI: Ikut membersihkan ComboBox prodi
            prodi_cmb.SelectedIndex = -1;

            kode_txt.Focus();
        }

        private void tutup_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}