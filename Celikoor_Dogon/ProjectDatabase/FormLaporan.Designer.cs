namespace ProjectDatabase
{
    partial class FormLaporan
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
            this.panelAtas = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelDepan = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerTahun = new System.Windows.Forms.DateTimePicker();
            this.labelTahun = new System.Windows.Forms.Label();
            this.comboBoxPilih = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.labelCekBarcode = new System.Windows.Forms.Label();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panelDepan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panelAtas.Controls.Add(this.labelAdmin);
            this.panelAtas.Controls.Add(this.pictureBoxLogo);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1012, 61);
            this.panelAtas.TabIndex = 22;
            // 
            // labelAdmin
            // 
            this.labelAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelAdmin.Location = new System.Drawing.Point(418, -4);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(186, 65);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "DeAdmin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(344, -7);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(89, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.BackgroundImage = global::ProjectDatabase.Properties.Resources.pngtree_contrast_color_rotation_effect_retro_background_picture_image_1340025;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Controls.Add(this.panelDepan);
            this.panelBack.Controls.Add(this.panelBlkng);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 61);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1012, 591);
            this.panelBack.TabIndex = 25;
            // 
            // panelDepan
            // 
            this.panelDepan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDepan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panelDepan.Controls.Add(this.pictureBox1);
            this.panelDepan.Controls.Add(this.dateTimePickerTahun);
            this.panelDepan.Controls.Add(this.labelTahun);
            this.panelDepan.Controls.Add(this.comboBoxPilih);
            this.panelDepan.Controls.Add(this.dataGridView1);
            this.panelDepan.Controls.Add(this.pictureBoxBack);
            this.panelDepan.Controls.Add(this.labelCekBarcode);
            this.panelDepan.Location = new System.Drawing.Point(33, 19);
            this.panelDepan.Name = "panelDepan";
            this.panelDepan.Size = new System.Drawing.Size(933, 535);
            this.panelDepan.TabIndex = 23;
            this.panelDepan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDepan_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::ProjectDatabase.Properties.Resources.buttonPrint;
            this.pictureBox1.Location = new System.Drawing.Point(36, 471);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // dateTimePickerTahun
            // 
            this.dateTimePickerTahun.CustomFormat = "yyyy";
            this.dateTimePickerTahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTahun.Location = new System.Drawing.Point(605, 98);
            this.dateTimePickerTahun.Name = "dateTimePickerTahun";
            this.dateTimePickerTahun.ShowUpDown = true;
            this.dateTimePickerTahun.Size = new System.Drawing.Size(107, 22);
            this.dateTimePickerTahun.TabIndex = 90;
            this.dateTimePickerTahun.ValueChanged += new System.EventHandler(this.dateTimePickerTahun_ValueChanged);
            // 
            // labelTahun
            // 
            this.labelTahun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTahun.AutoSize = true;
            this.labelTahun.BackColor = System.Drawing.Color.Transparent;
            this.labelTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTahun.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTahun.Location = new System.Drawing.Point(507, 95);
            this.labelTahun.Name = "labelTahun";
            this.labelTahun.Size = new System.Drawing.Size(79, 22);
            this.labelTahun.TabIndex = 89;
            this.labelTahun.Text = "Tahun :";
            // 
            // comboBoxPilih
            // 
            this.comboBoxPilih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPilih.FormattingEnabled = true;
            this.comboBoxPilih.Items.AddRange(new object[] {
            "Data Jumlah Film Terlaris Pada Setiap Bulan",
            "Data 3 Cabang Dengan Pemasukan Terbanyak",
            "Data 3 Film Teratas",
            "Data 3 Studio dan Cinema Dengan Tingkat Utilitas Terendah",
            "Data 10 Konsumen Paling Sering Menonton Genre Comedy"});
            this.comboBoxPilih.Location = new System.Drawing.Point(34, 97);
            this.comboBoxPilih.Name = "comboBoxPilih";
            this.comboBoxPilih.Size = new System.Drawing.Size(402, 24);
            this.comboBoxPilih.TabIndex = 88;
            this.comboBoxPilih.SelectedIndexChanged += new System.EventHandler(this.comboBoxPilih_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 315);
            this.dataGridView1.TabIndex = 26;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::ProjectDatabase.Properties.Resources.back_1689837_1280_removebg_preview;
            this.pictureBoxBack.Location = new System.Drawing.Point(856, 471);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 20;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // labelCekBarcode
            // 
            this.labelCekBarcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCekBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCekBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelCekBarcode.Location = new System.Drawing.Point(0, 0);
            this.labelCekBarcode.Name = "labelCekBarcode";
            this.labelCekBarcode.Size = new System.Drawing.Size(933, 65);
            this.labelCekBarcode.TabIndex = 1;
            this.labelCekBarcode.Text = "Laporan";
            this.labelCekBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBlkng
            // 
            this.panelBlkng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBlkng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panelBlkng.Location = new System.Drawing.Point(26, 13);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(949, 550);
            this.panelBlkng.TabIndex = 24;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 652);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panelAtas);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelDepan.ResumeLayout(false);
            this.panelDepan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCekBarcode;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelDepan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.ComboBox comboBoxPilih;
        private System.Windows.Forms.Label labelTahun;
        private System.Windows.Forms.DateTimePicker dateTimePickerTahun;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}