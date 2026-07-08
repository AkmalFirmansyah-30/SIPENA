namespace SIPENA.view
{
    partial class FrmPresensi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtNim = new System.Windows.Forms.MaskedTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPresensi = new System.Windows.Forms.DataGridView();
            this.colTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPertemuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTutup = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pertemuan = new System.Windows.Forms.Label();
            this.txtKodeMk = new System.Windows.Forms.MaskedTextBox();
            this.rbHadir = new System.Windows.Forms.RadioButton();
            this.rbIzin = new System.Windows.Forms.RadioButton();
            this.rbSakit = new System.Windows.Forms.RadioButton();
            this.rbAlpha = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.MaskedTextBox();
            this.txtPertemuan = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresensi)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status Kehadiran";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(47, 141);
            this.dtpTanggal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(333, 27);
            this.dtpTanggal.TabIndex = 5;
            // 
            // txtNim
            // 
            this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNim.Location = new System.Drawing.Point(49, 243);
            this.txtNim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(333, 27);
            this.txtNim.TabIndex = 6;
            this.txtNim.Leave += new System.EventHandler(this.txtNim_Leave);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(47, 536);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(115, 40);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "💾 Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(211, 536);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(107, 40);
            this.btnUbah.TabIndex = 10;
            this.btnUbah.Text = "✏️ Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(368, 536);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 40);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "🗑️ Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(533, 536);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "✖ Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kode MK";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvPresensi
            // 
            this.dgvPresensi.AllowUserToAddRows = false;
            this.dgvPresensi.AllowUserToDeleteRows = false;
            this.dgvPresensi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresensi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.dgvPresensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresensi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTanggal,
            this.colPertemuan,
            this.colNim,
            this.colNama,
            this.colMk,
            this.Semester,
            this.colStatus});
            this.dgvPresensi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.dgvPresensi.Location = new System.Drawing.Point(2, 643);
            this.dgvPresensi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPresensi.Name = "dgvPresensi";
            this.dgvPresensi.ReadOnly = true;
            this.dgvPresensi.RowHeadersWidth = 62;
            this.dgvPresensi.RowTemplate.Height = 28;
            this.dgvPresensi.Size = new System.Drawing.Size(887, 313);
            this.dgvPresensi.TabIndex = 16;
            // 
            // colTanggal
            // 
            this.colTanggal.DataPropertyName = "tanggal";
            this.colTanggal.HeaderText = "Tanggal";
            this.colTanggal.MinimumWidth = 8;
            this.colTanggal.Name = "colTanggal";
            this.colTanggal.ReadOnly = true;
            // 
            // colPertemuan
            // 
            this.colPertemuan.DataPropertyName = "pertemuan";
            this.colPertemuan.HeaderText = "Pertemuan";
            this.colPertemuan.MinimumWidth = 8;
            this.colPertemuan.Name = "colPertemuan";
            this.colPertemuan.ReadOnly = true;
            // 
            // colNim
            // 
            this.colNim.DataPropertyName = "nim";
            this.colNim.HeaderText = "NIM";
            this.colNim.MinimumWidth = 8;
            this.colNim.Name = "colNim";
            this.colNim.ReadOnly = true;
            // 
            // colNama
            // 
            this.colNama.DataPropertyName = "nama_mahasiswa";
            this.colNama.HeaderText = "Nama Mhs";
            this.colNama.MinimumWidth = 8;
            this.colNama.Name = "colNama";
            this.colNama.ReadOnly = true;
            // 
            // colMk
            // 
            this.colMk.DataPropertyName = "nama_mk";
            this.colMk.HeaderText = "Mata Kuliah";
            this.colMk.MinimumWidth = 8;
            this.colMk.Name = "colMk";
            this.colMk.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "semester";
            this.Semester.HeaderText = "Semester";
            this.Semester.MinimumWidth = 8;
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "status_hadir";
            this.colStatus.HeaderText = "Status Hadir";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.ForeColor = System.Drawing.Color.White;
            this.btnTutup.Location = new System.Drawing.Point(709, 536);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(116, 40);
            this.btnTutup.TabIndex = 17;
            this.btnTutup.Text = "✕ Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(889, 67);
            this.pnlHeader.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "👥 Form Input Presensi";
            // 
            // pertemuan
            // 
            this.pertemuan.AutoSize = true;
            this.pertemuan.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertemuan.Location = new System.Drawing.Point(493, 305);
            this.pertemuan.Name = "pertemuan";
            this.pertemuan.Size = new System.Drawing.Size(82, 19);
            this.pertemuan.TabIndex = 19;
            this.pertemuan.Text = "Pertemuan";
            // 
            // txtKodeMk
            // 
            this.txtKodeMk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeMk.Location = new System.Drawing.Point(494, 243);
            this.txtKodeMk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKodeMk.Name = "txtKodeMk";
            this.txtKodeMk.Size = new System.Drawing.Size(333, 27);
            this.txtKodeMk.TabIndex = 15;
            this.txtKodeMk.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // rbHadir
            // 
            this.rbHadir.AutoSize = true;
            this.rbHadir.BackColor = System.Drawing.SystemColors.Window;
            this.rbHadir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHadir.ForeColor = System.Drawing.Color.SeaGreen;
            this.rbHadir.Location = new System.Drawing.Point(47, 450);
            this.rbHadir.Name = "rbHadir";
            this.rbHadir.Size = new System.Drawing.Size(98, 24);
            this.rbHadir.TabIndex = 21;
            this.rbHadir.TabStop = true;
            this.rbHadir.Text = "✔  Hadir";
            this.rbHadir.UseVisualStyleBackColor = false;
            this.rbHadir.CheckedChanged += new System.EventHandler(this.rbHadir_CheckedChanged);
            // 
            // rbIzin
            // 
            this.rbIzin.AutoSize = true;
            this.rbIzin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIzin.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbIzin.Location = new System.Drawing.Point(198, 450);
            this.rbIzin.Name = "rbIzin";
            this.rbIzin.Size = new System.Drawing.Size(85, 24);
            this.rbIzin.TabIndex = 22;
            this.rbIzin.TabStop = true;
            this.rbIzin.Text = "📄  Izin";
            this.rbIzin.UseVisualStyleBackColor = true;
            this.rbIzin.CheckedChanged += new System.EventHandler(this.rbIzin_CheckedChanged);
            // 
            // rbSakit
            // 
            this.rbSakit.AutoSize = true;
            this.rbSakit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSakit.ForeColor = System.Drawing.Color.Red;
            this.rbSakit.Location = new System.Drawing.Point(345, 450);
            this.rbSakit.Name = "rbSakit";
            this.rbSakit.Size = new System.Drawing.Size(94, 24);
            this.rbSakit.TabIndex = 23;
            this.rbSakit.TabStop = true;
            this.rbSakit.Text = "➕  Sakit";
            this.rbSakit.UseVisualStyleBackColor = true;
            this.rbSakit.CheckedChanged += new System.EventHandler(this.rbSakit_CheckedChanged);
            // 
            // rbAlpha
            // 
            this.rbAlpha.AutoSize = true;
            this.rbAlpha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlpha.ForeColor = System.Drawing.Color.DimGray;
            this.rbAlpha.Location = new System.Drawing.Point(495, 450);
            this.rbAlpha.Name = "rbAlpha";
            this.rbAlpha.Size = new System.Drawing.Size(101, 24);
            this.rbAlpha.TabIndex = 24;
            this.rbAlpha.TabStop = true;
            this.rbAlpha.Text = "✖  Alpha";
            this.rbAlpha.UseVisualStyleBackColor = true;
            this.rbAlpha.CheckedChanged += new System.EventHandler(this.rbAlpha_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Semester";
            // 
            // txtSemester
            // 
            this.txtSemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSemester.Location = new System.Drawing.Point(47, 345);
            this.txtSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(333, 27);
            this.txtSemester.TabIndex = 27;
            // 
            // txtPertemuan
            // 
            this.txtPertemuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPertemuan.Location = new System.Drawing.Point(494, 345);
            this.txtPertemuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPertemuan.Name = "txtPertemuan";
            this.txtPertemuan.Size = new System.Drawing.Size(333, 27);
            this.txtPertemuan.TabIndex = 28;
            // 
            // FrmPresensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 853);
            this.Controls.Add(this.dgvPresensi);
            this.Controls.Add(this.txtPertemuan);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbAlpha);
            this.Controls.Add(this.rbSakit);
            this.Controls.Add(this.rbIzin);
            this.Controls.Add(this.rbHadir);
            this.Controls.Add(this.pertemuan);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.txtKodeMk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPresensi";
            this.Text = "FrmPresensi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresensi)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.MaskedTextBox txtNim;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPresensi;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pertemuan;
        private System.Windows.Forms.MaskedTextBox txtKodeMk;
        private System.Windows.Forms.RadioButton rbHadir;
        private System.Windows.Forms.RadioButton rbIzin;
        private System.Windows.Forms.RadioButton rbSakit;
        private System.Windows.Forms.RadioButton rbAlpha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtSemester;
        private System.Windows.Forms.MaskedTextBox txtPertemuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPertemuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}