using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            TampilkanData();
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
            cmbStatus.SelectedIndex = -1;
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
                p.StatusHadir = cmbStatus.Text;

                int hasil = service.Simpan(p);

                if (hasil > 0)
                {
                    MessageBox.Show("Data Presensi Berhasil Disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilkanData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silakan pilih data pada tabel di bawah untuk melakukan perubahan.", "Informasi");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvPresensi.CurrentRow.Cells[0].Value.ToString());

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}