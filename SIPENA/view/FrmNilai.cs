using System;
using System.Windows.Forms;
using SIPENA.service;
using SIPENA.model;

namespace SIPENA.view
{
    public partial class FrmNilai : Form
    {
        private NilaiService service = new NilaiService();

        private bool modeEdit = false;
        private int idEdit = 0;

        public FrmNilai()
        {
            InitializeComponent();
            TampilkanData();
            AturHakAkses();
        }

        private void AturHakAkses()
        {
            // Mengubah role menjadi huruf kecil semua agar kebal dari salah ketik di database
            string roleUser = (SesiLogin.Role ?? string.Empty).ToLower();

            if (roleUser == "mahasiswa")
            {
                // MAHASISWA: Mode Read-Only (Hanya melihat nilai)
                btnSimpan.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnClear.Visible = false;

                txtNim.Enabled = false;
                txtKodeMk.Enabled = false;
                txtTugas.Enabled = false;
                txtUts.Enabled = false;
                txtUas.Enabled = false;
                txtSemester.Enabled = false;
            }
            else if (roleUser == "dosen")
            {
                // DOSEN: Bisa input dan ubah, TAPI tidak bisa hapus
                btnSimpan.Visible = true;
                btnUbah.Visible = true;
                btnHapus.Visible = false;
                btnClear.Visible = true; // Dinyalakan agar dosen bisa membersihkan kotak isian
            }
            else if (roleUser == "admin")
            {
                // ADMIN: Full Control (Bisa menggunakan semua tombol)
                btnSimpan.Visible = true;
                btnUbah.Visible = true;
                btnHapus.Visible = true;
                btnClear.Visible = true;
            }
        }

        private void TampilkanData()
        {
            dgvNilai.DataSource = service.TampilkanSemua();
        }

        private void ClearForm()
        {
            txtNim.Clear();
            txtKodeMk.Clear();
            txtTugas.Clear();
            txtUts.Clear();
            txtUas.Clear();

            txtNim.Enabled = true;
            txtKodeMk.Enabled = true;

            txtNim.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Nilai n = new Nilai();

                n.Nim = txtNim.Text;
                n.KodeMk = txtKodeMk.Text;
                n.NilaiTugas = float.Parse(txtTugas.Text);
                n.NilaiUts = float.Parse(txtUts.Text);
                n.NilaiUas = float.Parse(txtUas.Text);
                n.Semester = Convert.ToInt32(txtSemester.Text);

                int hasil = 0;

                if (modeEdit)
                {
                    n.IdNilai = idEdit;
                    hasil = service.Ubah(n);
                }
                else
                {
                    hasil = service.Simpan(n);
                }

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
                    "Terjadi Kesalahan: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNilai.CurrentRow == null)
                {
                    MessageBox.Show("Pilih data terlebih dahulu!");
                    return;
                }

                idEdit = Convert.ToInt32(
                    dgvNilai.CurrentRow.Cells[0].Value);

                txtNim.Text =
                    dgvNilai.CurrentRow.Cells[1].Value.ToString();

                txtKodeMk.Text =
                    dgvNilai.CurrentRow.Cells[3].Value.ToString();

                txtTugas.Text =
                    dgvNilai.CurrentRow.Cells[4].Value.ToString();

                txtUts.Text =
                    dgvNilai.CurrentRow.Cells[5].Value.ToString();

                txtUas.Text =
                    dgvNilai.CurrentRow.Cells[6].Value.ToString();

                txtNim.Enabled = false;
                txtKodeMk.Enabled = false;

                modeEdit = true;

                MessageBox.Show(
                    "Silakan ubah nilai lalu klik tombol Simpan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dgvNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(
                    dgvNilai.CurrentRow.Cells[0].Value.ToString());

                if (MessageBox.Show(
                    "Hapus data ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
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
                MessageBox.Show(
                    "Pilih baris yang ingin dihapus pada tabel.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            modeEdit = false;
            idEdit = 0;
            ClearForm();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtKodeMk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}