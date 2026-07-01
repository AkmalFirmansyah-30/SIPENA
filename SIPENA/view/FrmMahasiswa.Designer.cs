namespace SIPENA.view
{
    partial class FrmMahasiswa
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            this.cNim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamaMhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProdiMhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Semester_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mahasiswa_txt = new System.Windows.Forms.TextBox();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.nim_txt = new System.Windows.Forms.TextBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.ProgramStudi_cmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.naikSemester_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 86);
            this.panel2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manajemen data mahasiswa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(40, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mahasiswa";
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.AllowUserToAddRows = false;
            this.dgvMahasiswa.AllowUserToDeleteRows = false;
            this.dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMahasiswa.BackgroundColor = System.Drawing.Color.Navy;
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNim,
            this.cNamaMhs,
            this.cSemester,
            this.cProdiMhs});
            this.dgvMahasiswa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMahasiswa.Location = new System.Drawing.Point(0, 373);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.ReadOnly = true;
            this.dgvMahasiswa.Size = new System.Drawing.Size(700, 221);
            this.dgvMahasiswa.TabIndex = 33;
            this.dgvMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellContentClick);
            // 
            // cNim
            // 
            this.cNim.DataPropertyName = "NIM";
            this.cNim.FillWeight = 47.7707F;
            this.cNim.HeaderText = "NIM";
            this.cNim.Name = "cNim";
            this.cNim.ReadOnly = true;
            // 
            // cNamaMhs
            // 
            this.cNamaMhs.DataPropertyName = "Nama Mahasiswa";
            this.cNamaMhs.FillWeight = 159.0179F;
            this.cNamaMhs.HeaderText = "Nama Mahasiswa";
            this.cNamaMhs.Name = "cNamaMhs";
            this.cNamaMhs.ReadOnly = true;
            // 
            // cSemester
            // 
            this.cSemester.DataPropertyName = "semester";
            this.cSemester.HeaderText = "Semester";
            this.cSemester.Name = "cSemester";
            this.cSemester.ReadOnly = true;
            // 
            // cProdiMhs
            // 
            this.cProdiMhs.DataPropertyName = "Program Studi";
            this.cProdiMhs.FillWeight = 93.21141F;
            this.cProdiMhs.HeaderText = "Program Studi";
            this.cProdiMhs.Name = "cProdiMhs";
            this.cProdiMhs.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.naikSemester_btn);
            this.panel1.Controls.Add(this.Semester_cmb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mahasiswa_txt);
            this.panel1.Controls.Add(this.tutup_btn);
            this.panel1.Controls.Add(this.ubah_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.hapus_btn);
            this.panel1.Controls.Add(this.batal_btn);
            this.panel1.Controls.Add(this.nim_txt);
            this.panel1.Controls.Add(this.simpan_btn);
            this.panel1.Controls.Add(this.ProgramStudi_cmb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 285);
            this.panel1.TabIndex = 32;
            // 
            // Semester_cmb
            // 
            this.Semester_cmb.BackColor = System.Drawing.SystemColors.Control;
            this.Semester_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Semester_cmb.FormattingEnabled = true;
            this.Semester_cmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Semester_cmb.Location = new System.Drawing.Point(208, 161);
            this.Semester_cmb.Name = "Semester_cmb";
            this.Semester_cmb.Size = new System.Drawing.Size(338, 21);
            this.Semester_cmb.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Semester";
            // 
            // mahasiswa_txt
            // 
            this.mahasiswa_txt.BackColor = System.Drawing.SystemColors.Control;
            this.mahasiswa_txt.Location = new System.Drawing.Point(208, 83);
            this.mahasiswa_txt.Name = "mahasiswa_txt";
            this.mahasiswa_txt.Size = new System.Drawing.Size(338, 20);
            this.mahasiswa_txt.TabIndex = 33;
            // 
            // tutup_btn
            // 
            this.tutup_btn.Location = new System.Drawing.Point(484, 218);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(63, 28);
            this.tutup_btn.TabIndex = 39;
            this.tutup_btn.Text = "Tutup";
            this.tutup_btn.UseVisualStyleBackColor = true;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ubah_btn.Location = new System.Drawing.Point(277, 218);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(63, 28);
            this.ubah_btn.TabIndex = 36;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = false;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "NIM";
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hapus_btn.Location = new System.Drawing.Point(346, 218);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(63, 28);
            this.hapus_btn.TabIndex = 37;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(415, 218);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(63, 28);
            this.batal_btn.TabIndex = 38;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // nim_txt
            // 
            this.nim_txt.BackColor = System.Drawing.SystemColors.Control;
            this.nim_txt.Location = new System.Drawing.Point(208, 48);
            this.nim_txt.Name = "nim_txt";
            this.nim_txt.Size = new System.Drawing.Size(154, 20);
            this.nim_txt.TabIndex = 30;
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpan_btn.Location = new System.Drawing.Point(208, 218);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(63, 28);
            this.simpan_btn.TabIndex = 35;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // ProgramStudi_cmb
            // 
            this.ProgramStudi_cmb.BackColor = System.Drawing.SystemColors.Control;
            this.ProgramStudi_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProgramStudi_cmb.FormattingEnabled = true;
            this.ProgramStudi_cmb.Location = new System.Drawing.Point(208, 121);
            this.ProgramStudi_cmb.Name = "ProgramStudi_cmb";
            this.ProgramStudi_cmb.Size = new System.Drawing.Size(338, 21);
            this.ProgramStudi_cmb.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nama Mahasiswa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Program Studi";
            // 
            // naikSemester_btn
            // 
            this.naikSemester_btn.Location = new System.Drawing.Point(553, 218);
            this.naikSemester_btn.Name = "naikSemester_btn";
            this.naikSemester_btn.Size = new System.Drawing.Size(135, 28);
            this.naikSemester_btn.TabIndex = 42;
            this.naikSemester_btn.Text = "Naik Semester";
            this.naikSemester_btn.UseVisualStyleBackColor = true;
            this.naikSemester_btn.Click += new System.EventHandler(this.naikSemester_btn_Click);
            // 
            // FrmMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMahasiswa";
            this.Text = "FrmMahasiswa";
            this.Load += new System.EventHandler(this.FrmMahasiswa_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNim;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamaMhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProdiMhs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Semester_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mahasiswa_txt;
        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.TextBox nim_txt;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.ComboBox ProgramStudi_cmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button naikSemester_btn;
    }
}