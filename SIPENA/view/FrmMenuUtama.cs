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
    public partial class FrmMenuUtama : Form
    {
        public FrmMenuUtama()
        {
            InitializeComponent();
        }

        private void FrmMenuUtama_Load(object sender, EventArgs e)
        {
            // Set image untuk semua PictureBox dari Resources
            try
            {
                // Logo
                pictureBox1.Image = SIPENA.Properties.Resources.Logo_PNC;

                // Icon Dashboard
                pictureBox2.Image = SIPENA.Properties.Resources.Dashboard;

                // Icon Mahasiswa
                icon_mhs.Image = SIPENA.Properties.Resources.user__2_;

                // Icon Dosen
                icon_dosen.Image = SIPENA.Properties.Resources.dosen;

                // Icon Matkul
                iconmatkul.Image = SIPENA.Properties.Resources.Matkul;

                // Icon Presensi
                icnpresensi.Image = SIPENA.Properties.Resources.icon_user;

                // Icon Nilai
                pictureBox7.Image = SIPENA.Properties.Resources.icon_medal;

                // Icon Logout
                pictureBox8.Image = SIPENA.Properties.Resources.icon_logout;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading images: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
