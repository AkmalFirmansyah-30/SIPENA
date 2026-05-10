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
    public partial class FrmLogin : Form
    {
        // Deklarasi kontrol UI
        private Panel pnlTopBar;
        private Button btnClose;
        private Panel pnlLeftBranding;
        private Label lblTitleSIPENA;
        private Label lblSubtitle;
        private Label lblFooter;
        private Panel pnlRightLogin;
        private Label lblWelcome;
        private Label lblUsernameLabel;
        private TextBox txtUsername;
        private Label lblPasswordLabel;
        private TextBox txtPassword;
        private Button btnLogin;

        public FrmLogin()
        {
            InitializeComponent();
            SetupUI();
        }

        /// <summary>
        /// Method untuk men-setup UI secara programatis
        /// </summary>
        private void SetupUI()
        {
            // ===== Pengaturan Form =====
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(700, 450);
            this.BackColor = Color.White;

            // ===== Top Bar Panel =====
            pnlTopBar = new Panel();
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Height = 30;
            pnlTopBar.BackColor = Color.LightGray;
            this.Controls.Add(pnlTopBar);

            // Button Close di Top Bar
            btnClose = new Button();
            btnClose.Text = "✕";
            btnClose.Font = new Font("Arial", 12, FontStyle.Bold);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.BackColor = Color.LightGray;
            btnClose.ForeColor = Color.Black;
            btnClose.Size = new Size(30, 30);
            btnClose.Location = new Point(pnlTopBar.Width - 30, 0);
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Click += (s, e) => this.Close();
            pnlTopBar.Controls.Add(btnClose);

            // ===== Left Branding Panel =====
            pnlLeftBranding = new Panel();
            pnlLeftBranding.Dock = DockStyle.Left;
            pnlLeftBranding.Width = 300;
            pnlLeftBranding.BackColor = Color.FromArgb(45, 45, 48); // Charcoal Slate
            this.Controls.Add(pnlLeftBranding);

            // Label Judul SIPENA
            lblTitleSIPENA = new Label();
            lblTitleSIPENA.Text = "S I P E N A";
            lblTitleSIPENA.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitleSIPENA.ForeColor = Color.White;
            lblTitleSIPENA.AutoSize = false;
            lblTitleSIPENA.TextAlign = ContentAlignment.MiddleCenter;
            lblTitleSIPENA.Size = new Size(300, 60);
            lblTitleSIPENA.Location = new Point(0, 100);
            pnlLeftBranding.Controls.Add(lblTitleSIPENA);

            // Label Subtitle
            lblSubtitle = new Label();
            lblSubtitle.Text = "Sistem Presensi & Nilai";
            lblSubtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.AutoSize = false;
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.Size = new Size(300, 40);
            lblSubtitle.Location = new Point(0, 160);
            pnlLeftBranding.Controls.Add(lblSubtitle);

            // Label Footer
            lblFooter = new Label();
            lblFooter.Text = "© Kelompok PBO";
            lblFooter.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblFooter.ForeColor = Color.White;
            lblFooter.AutoSize = false;
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            lblFooter.Size = new Size(300, 30);
            lblFooter.Location = new Point(0, pnlLeftBranding.Height - 40);
            lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLeftBranding.Controls.Add(lblFooter);

            // ===== Right Login Area Panel =====
            pnlRightLogin = new Panel();
            pnlRightLogin.Dock = DockStyle.Fill;
            pnlRightLogin.BackColor = Color.White;
            this.Controls.Add(pnlRightLogin);

            // Label Welcome Header
            lblWelcome = new Label();
            lblWelcome.Text = "Selamat Datang";
            lblWelcome.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.AutoSize = false;
            lblWelcome.Size = new Size(pnlRightLogin.Width - 40, 40);
            lblWelcome.Location = new Point(20, 40);
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            pnlRightLogin.Controls.Add(lblWelcome);

            // ===== Username Input =====
            lblUsernameLabel = new Label();
            lblUsernameLabel.Text = "Username";
            lblUsernameLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblUsernameLabel.AutoSize = true;
            lblUsernameLabel.Location = new Point(20, 100);
            pnlRightLogin.Controls.Add(lblUsernameLabel);

            txtUsername = new TextBox();
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10);
            txtUsername.Size = new Size(pnlRightLogin.Width - 40, 35);
            txtUsername.Location = new Point(20, 125);
            pnlRightLogin.Controls.Add(txtUsername);

            // ===== Password Input =====
            lblPasswordLabel = new Label();
            lblPasswordLabel.Text = "Password";
            lblPasswordLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblPasswordLabel.AutoSize = true;
            lblPasswordLabel.Location = new Point(20, 170);
            pnlRightLogin.Controls.Add(lblPasswordLabel);

            txtPassword = new TextBox();
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10);
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Size = new Size(pnlRightLogin.Width - 40, 35);
            txtPassword.Location = new Point(20, 195);
            pnlRightLogin.Controls.Add(txtPassword);

            // ===== Login Button =====
            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.FromArgb(218, 165, 32); // Gold
            btnLogin.ForeColor = Color.White;
            btnLogin.Size = new Size(pnlRightLogin.Width - 40, 40);
            btnLogin.Location = new Point(20, 250);
            btnLogin.Cursor = Cursors.Hand;
            pnlRightLogin.Controls.Add(btnLogin);
        }
    }
}
