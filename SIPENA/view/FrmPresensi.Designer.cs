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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtNim = new System.Windows.Forms.MaskedTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKodeMk = new System.Windows.Forms.MaskedTextBox();
            this.dgvPresensi = new System.Windows.Forms.DataGridView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.colTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresensi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA PRESENSI MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(272, 90);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(296, 26);
            this.dtpTanggal.TabIndex = 5;
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(274, 142);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(296, 26);
            this.txtNim.TabIndex = 6;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Hadir",
            "Izin",
            "Sakit",
            "Alpa"});
            this.cmbStatus.Location = new System.Drawing.Point(272, 250);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(296, 28);
            this.cmbStatus.TabIndex = 8;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(137, 313);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 33);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(244, 313);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 33);
            this.btnUbah.TabIndex = 10;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(367, 313);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 33);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(493, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kode MK";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtKodeMk
            // 
            this.txtKodeMk.Location = new System.Drawing.Point(272, 194);
            this.txtKodeMk.Name = "txtKodeMk";
            this.txtKodeMk.Size = new System.Drawing.Size(296, 26);
            this.txtKodeMk.TabIndex = 15;
            this.txtKodeMk.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // dgvPresensi
            // 
            this.dgvPresensi.AllowUserToAddRows = false;
            this.dgvPresensi.AllowUserToDeleteRows = false;
            this.dgvPresensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresensi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTanggal,
            this.colNim,
            this.colNama,
            this.colMk,
            this.colStatus});
            this.dgvPresensi.Location = new System.Drawing.Point(2, 378);
            this.dgvPresensi.Name = "dgvPresensi";
            this.dgvPresensi.ReadOnly = true;
            this.dgvPresensi.RowHeadersWidth = 62;
            this.dgvPresensi.RowTemplate.Height = 28;
            this.dgvPresensi.Size = new System.Drawing.Size(798, 333);
            this.dgvPresensi.TabIndex = 16;
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(620, 313);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 33);
            this.btnTutup.TabIndex = 17;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // colTanggal
            // 
            this.colTanggal.DataPropertyName = "tanggal";
            this.colTanggal.HeaderText = "Tanggal";
            this.colTanggal.MinimumWidth = 8;
            this.colTanggal.Name = "colTanggal";
            this.colTanggal.ReadOnly = true;
            this.colTanggal.Width = 150;
            // 
            // colNim
            // 
            this.colNim.DataPropertyName = "nim";
            this.colNim.HeaderText = "NIM";
            this.colNim.MinimumWidth = 8;
            this.colNim.Name = "colNim";
            this.colNim.ReadOnly = true;
            this.colNim.Width = 150;
            // 
            // colNama
            // 
            this.colNama.DataPropertyName = "nama_mahasiswa";
            this.colNama.HeaderText = "Nama Mhs";
            this.colNama.MinimumWidth = 8;
            this.colNama.Name = "colNama";
            this.colNama.ReadOnly = true;
            this.colNama.Width = 150;
            // 
            // colMk
            // 
            this.colMk.DataPropertyName = "nama_mk";
            this.colMk.HeaderText = "Mata Kuliah";
            this.colMk.MinimumWidth = 8;
            this.colMk.Name = "colMk";
            this.colMk.ReadOnly = true;
            this.colMk.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "status_hadir";
            this.colStatus.HeaderText = "Status Hadir";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 150;
            // 
            // FrmPresensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.dgvPresensi);
            this.Controls.Add(this.txtKodeMk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPresensi";
            this.Text = "FrmPresensi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresensi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.MaskedTextBox txtNim;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtKodeMk;
        private System.Windows.Forms.DataGridView dgvPresensi;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}