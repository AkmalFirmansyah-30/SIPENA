namespace SIPENA.view
{
    partial class FrmNilai
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtKodeMk = new System.Windows.Forms.TextBox();
            this.txtTugas = new System.Windows.Forms.TextBox();
            this.txtUts = new System.Windows.Forms.TextBox();
            this.txtUas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.dgvNilai = new System.Windows.Forms.DataGridView();
            this.colIdNilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNilaiUTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNilaiUAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNilaiTugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAkhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilai)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengelolaan Nilai Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(59, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "🪪 NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(450, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "📚 Kode MK";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(59, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "📋 Nilai Tugas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "📝 Nilai UTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(450, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "📝 Nilai UAS";
            // 
            // txtNim
            // 
            this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNim.Location = new System.Drawing.Point(63, 145);
            this.txtNim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(322, 27);
            this.txtNim.TabIndex = 6;
            // 
            // txtKodeMk
            // 
            this.txtKodeMk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKodeMk.Location = new System.Drawing.Point(450, 145);
            this.txtKodeMk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKodeMk.Name = "txtKodeMk";
            this.txtKodeMk.Size = new System.Drawing.Size(322, 27);
            this.txtKodeMk.TabIndex = 7;
            this.txtKodeMk.TextChanged += new System.EventHandler(this.txtKodeMk_TextChanged);
            // 
            // txtTugas
            // 
            this.txtTugas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTugas.Location = new System.Drawing.Point(63, 361);
            this.txtTugas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTugas.Name = "txtTugas";
            this.txtTugas.Size = new System.Drawing.Size(322, 27);
            this.txtTugas.TabIndex = 8;
            // 
            // txtUts
            // 
            this.txtUts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUts.Location = new System.Drawing.Point(63, 257);
            this.txtUts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUts.Name = "txtUts";
            this.txtUts.Size = new System.Drawing.Size(322, 27);
            this.txtUts.TabIndex = 9;
            // 
            // txtUas
            // 
            this.txtUas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUas.Location = new System.Drawing.Point(450, 257);
            this.txtUas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUas.Name = "txtUas";
            this.txtUas.Size = new System.Drawing.Size(322, 27);
            this.txtUas.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(165, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "30%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "30%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(555, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "40%";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(63, 448);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(118, 35);
            this.btnSimpan.TabIndex = 14;
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
            this.btnUbah.Location = new System.Drawing.Point(223, 448);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(96, 35);
            this.btnUbah.TabIndex = 15;
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
            this.btnHapus.Location = new System.Drawing.Point(362, 448);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(113, 35);
            this.btnHapus.TabIndex = 16;
            this.btnHapus.Text = "🗑️ Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(523, 448);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 35);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "✖ Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.ForeColor = System.Drawing.Color.White;
            this.btnTutup.Location = new System.Drawing.Point(674, 448);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(98, 35);
            this.btnTutup.TabIndex = 18;
            this.btnTutup.Text = "🚪 Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // dgvNilai
            // 
            this.dgvNilai.AllowUserToAddRows = false;
            this.dgvNilai.AllowUserToDeleteRows = false;
            this.dgvNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNilai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNilai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdNilai,
            this.colNim,
            this.colNama,
            this.colMk,
            this.Semester,
            this.colNilaiUTS,
            this.colNilaiUAS,
            this.colNilaiTugas,
            this.colAkhir,
            this.colGrade});
            this.dgvNilai.Location = new System.Drawing.Point(1, 567);
            this.dgvNilai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNilai.Name = "dgvNilai";
            this.dgvNilai.ReadOnly = true;
            this.dgvNilai.RowHeadersWidth = 62;
            this.dgvNilai.RowTemplate.Height = 28;
            this.dgvNilai.Size = new System.Drawing.Size(836, 180);
            this.dgvNilai.TabIndex = 19;
            this.dgvNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNilai_CellClick);
            // 
            // colIdNilai
            // 
            this.colIdNilai.DataPropertyName = "id_nilai";
            this.colIdNilai.HeaderText = "ID Nilai";
            this.colIdNilai.MinimumWidth = 8;
            this.colIdNilai.Name = "colIdNilai";
            this.colIdNilai.ReadOnly = true;
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
            // colNilaiUTS
            // 
            this.colNilaiUTS.DataPropertyName = "nilai_uts";
            this.colNilaiUTS.HeaderText = "Nilai UTS";
            this.colNilaiUTS.MinimumWidth = 8;
            this.colNilaiUTS.Name = "colNilaiUTS";
            this.colNilaiUTS.ReadOnly = true;
            // 
            // colNilaiUAS
            // 
            this.colNilaiUAS.DataPropertyName = "nilai_uas";
            this.colNilaiUAS.HeaderText = "Nilai UAS";
            this.colNilaiUAS.MinimumWidth = 8;
            this.colNilaiUAS.Name = "colNilaiUAS";
            this.colNilaiUAS.ReadOnly = true;
            // 
            // colNilaiTugas
            // 
            this.colNilaiTugas.DataPropertyName = "nilai_tugas";
            this.colNilaiTugas.HeaderText = "Nilai Tugas";
            this.colNilaiTugas.MinimumWidth = 8;
            this.colNilaiTugas.Name = "colNilaiTugas";
            this.colNilaiTugas.ReadOnly = true;
            // 
            // colAkhir
            // 
            this.colAkhir.DataPropertyName = "nilai_akhir";
            this.colAkhir.HeaderText = "Nilai Akhir";
            this.colAkhir.MinimumWidth = 8;
            this.colAkhir.Name = "colAkhir";
            this.colAkhir.ReadOnly = true;
            // 
            // colGrade
            // 
            this.colGrade.DataPropertyName = "grade";
            this.colGrade.HeaderText = "Grade";
            this.colGrade.MinimumWidth = 8;
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 0);
            this.panel1.TabIndex = 20;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnlHeader.Controls.Add(this.label10);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(837, 71);
            this.pnlHeader.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "🎓 Form Input Nilai";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(450, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "🎓 Semester";
            // 
            // txtSemester
            // 
            this.txtSemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSemester.Location = new System.Drawing.Point(450, 361);
            this.txtSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(322, 27);
            this.txtSemester.TabIndex = 23;
            // 
            // FrmNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 744);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNilai);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUas);
            this.Controls.Add(this.txtUts);
            this.Controls.Add(this.txtTugas);
            this.Controls.Add(this.txtKodeMk);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNilai";
            this.Text = "FrmNilai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtKodeMk;
        private System.Windows.Forms.TextBox txtTugas;
        private System.Windows.Forms.TextBox txtUts;
        private System.Windows.Forms.TextBox txtUas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.DataGridView dgvNilai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdNilai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNilaiUTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNilaiUAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNilaiTugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAkhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
    }
}