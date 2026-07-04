using System;
using System.Linq;
using System.Windows.Forms;
using SIPENA.service;
using SIPENA.model;

namespace SIPENA.view
{
    public partial class FrmPresensi : Form
    {
        private PresensiService service = new PresensiService();

        public FrmPresensi()
        {
            InitializeComponent();

            dgvPresensi.AutoGenerateColumns = false;

            TampilkanData();
            // Atur hak akses sesuai role user
            AturHakAkses();
        }

        private void TampilkanData()
        {
            dgvPresensi.DataSource = service.TampilkanSemua();
        }

        private void ClearForm()
        {
            dtpTanggal.Value = DateTime.Now;
            txtNim.Clear();
            txtKodeMk.Clear();
            txtPertemuan.Clear();

            rbHadir.Checked = false;
            rbIzin.Checked = false;
            rbSakit.Checked = false;
            rbAlpha.Checked = false;

            txtNim.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Presensi p = new Presensi();

                p.Tanggal = dtpTanggal.Value;
                p.Nim = txtNim.Text;
                p.KodeMk = txtKodeMk.Text;
                p.Pertemuan = Convert.ToInt32(txtPertemuan.Text);

                if (rbHadir.Checked)
                    p.StatusHadir = "Hadir";
                else if (rbIzin.Checked)
                    p.StatusHadir = "Izin";
                else if (rbSakit.Checked)
                    p.StatusHadir = "Sakit";
                else if (rbAlpha.Checked)
                    p.StatusHadir = "Alpha";

                int hasil = service.Simpan(p);

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

        private void btnUbah_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Silakan pilih data pada tabel di bawah untuk melakukan perubahan.",
                "Informasi");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(
                    dgvPresensi.CurrentRow.Cells[0].Value.ToString());

                if (MessageBox.Show(
                    "Yakin ingin menghapus data presensi ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
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
                MessageBox.Show(
                    "Pilih baris data yang ingin dihapus pada tabel.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AturHakAkses()
        {
            // Set default states
            btnSimpan.Visible = false;
            btnUbah.Visible = false;
            btnHapus.Visible = false;

            txtNim.Enabled = true;
            txtKodeMk.Enabled = true;
            txtSemester.Enabled = true;
            txtPertemuan.Enabled = true;
            dtpTanggal.Enabled = true;
            rbHadir.Enabled = true;
            rbIzin.Enabled = true;
            rbSakit.Enabled = true;
            rbAlpha.Enabled = true;

            string role = (SesiLogin.Role ?? string.Empty).ToLower();

            if (role == "mahasiswa")
            {
                // Mahasiswa dapat input presensi
                btnSimpan.Visible = true;
                btnUbah.Visible = false;
                btnHapus.Visible = false;

                // semester diisi otomatis oleh sistem
                txtSemester.Enabled = false;
            }
            else if (role == "dosen")
            {
                // Dosen hanya melihat rekap
                btnSimpan.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;

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
            else if (role == "admin")
            {
                // Admin dapat melihat dan menghapus
                btnSimpan.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = true;

                // Non-aktifkan input agar admin tidak mengubah data lewat form ini
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPertemuan.Text.Length > 0 &&
                !txtPertemuan.Text.All(char.IsDigit))
            {
                MessageBox.Show("Pertemuan hanya boleh angka!");
                txtPertemuan.Clear();
            }
        }

        private void rbHadir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbIzin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSakit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAlpha_CheckedChanged(object sender, EventArgs e)
        {

        }

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
    }
}