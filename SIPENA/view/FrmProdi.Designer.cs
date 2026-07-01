namespace SIPENA.view
{
    partial class FrmProdi
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
            this.formInput = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdProdi_txt = new System.Windows.Forms.TextBox();
            this.batal_btn = new System.Windows.Forms.Button();
            this.NamaProdi_txt = new System.Windows.Forms.TextBox();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.dgvProdi = new System.Windows.Forms.DataGridView();
            this.cIdProdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNamaProdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formInput.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formInput
            // 
            this.formInput.BackColor = System.Drawing.Color.White;
            this.formInput.Controls.Add(this.panel2);
            this.formInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formInput.Location = new System.Drawing.Point(0, 79);
            this.formInput.Name = "formInput";
            this.formInput.Size = new System.Drawing.Size(715, 240);
            this.formInput.TabIndex = 14;
            this.formInput.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tutup_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.IdProdi_txt);
            this.panel2.Controls.Add(this.batal_btn);
            this.panel2.Controls.Add(this.NamaProdi_txt);
            this.panel2.Controls.Add(this.hapus_btn);
            this.panel2.Controls.Add(this.simpan_btn);
            this.panel2.Controls.Add(this.ubah_btn);
            this.panel2.Location = new System.Drawing.Point(-134, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 209);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nama Prodi";
            // 
            // tutup_btn
            // 
            this.tutup_btn.Location = new System.Drawing.Point(630, 133);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(63, 28);
            this.tutup_btn.TabIndex = 24;
            this.tutup_btn.Text = "Tutup";
            this.tutup_btn.UseVisualStyleBackColor = true;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kode Prodi";
            // 
            // IdProdi_txt
            // 
            this.IdProdi_txt.BackColor = System.Drawing.SystemColors.Control;
            this.IdProdi_txt.Location = new System.Drawing.Point(354, 54);
            this.IdProdi_txt.Name = "IdProdi_txt";
            this.IdProdi_txt.Size = new System.Drawing.Size(115, 20);
            this.IdProdi_txt.TabIndex = 17;
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(561, 133);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(63, 28);
            this.batal_btn.TabIndex = 23;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // NamaProdi_txt
            // 
            this.NamaProdi_txt.BackColor = System.Drawing.SystemColors.Control;
            this.NamaProdi_txt.Location = new System.Drawing.Point(354, 95);
            this.NamaProdi_txt.Name = "NamaProdi_txt";
            this.NamaProdi_txt.Size = new System.Drawing.Size(276, 20);
            this.NamaProdi_txt.TabIndex = 18;
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hapus_btn.Location = new System.Drawing.Point(492, 133);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(63, 28);
            this.hapus_btn.TabIndex = 22;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpan_btn.Location = new System.Drawing.Point(354, 133);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(63, 28);
            this.simpan_btn.TabIndex = 20;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ubah_btn.Location = new System.Drawing.Point(423, 133);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(63, 28);
            this.ubah_btn.TabIndex = 21;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = false;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // dgvProdi
            // 
            this.dgvProdi.AllowUserToAddRows = false;
            this.dgvProdi.AllowUserToDeleteRows = false;
            this.dgvProdi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdi.BackgroundColor = System.Drawing.Color.Navy;
            this.dgvProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdProdi,
            this.cNamaProdi});
            this.dgvProdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProdi.Location = new System.Drawing.Point(0, 319);
            this.dgvProdi.Name = "dgvProdi";
            this.dgvProdi.ReadOnly = true;
            this.dgvProdi.Size = new System.Drawing.Size(715, 237);
            this.dgvProdi.TabIndex = 13;
            this.dgvProdi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdi_CellContentClick);
            // 
            // cIdProdi
            // 
            this.cIdProdi.DataPropertyName = "id_prodi";
            this.cIdProdi.HeaderText = "ID Prodi";
            this.cIdProdi.Name = "cIdProdi";
            this.cIdProdi.ReadOnly = true;
            // 
            // cNamaProdi
            // 
            this.cNamaProdi.DataPropertyName = "nama_prodi";
            this.cNamaProdi.HeaderText = "Nama Prodi";
            this.cNamaProdi.Name = "cNamaProdi";
            this.cNamaProdi.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 79);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Manajemen data program studi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Studi";
            // 
            // FrmProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 556);
            this.Controls.Add(this.formInput);
            this.Controls.Add(this.dgvProdi);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProdi";
            this.Text = "FrmProdi";
            this.Load += new System.EventHandler(this.FrmProdi_Load);
            this.formInput.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox formInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdProdi_txt;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.TextBox NamaProdi_txt;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.DataGridView dgvProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNamaProdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}