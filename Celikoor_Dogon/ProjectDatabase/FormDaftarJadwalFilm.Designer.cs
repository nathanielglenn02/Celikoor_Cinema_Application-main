namespace ProjectDatabase
{
    partial class FormDaftarJadwalFilm
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
            this.labelAdmin = new System.Windows.Forms.Label();
            this.dataGridViewJadwal = new System.Windows.Forms.DataGridView();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDepan = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxTambah = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerJadwal = new System.Windows.Forms.DateTimePicker();
            this.comboBoxJam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNoInvoice = new System.Windows.Forms.Label();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.panelBack = new System.Windows.Forms.Panel();
            this.ColumnCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJamPemutaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBtnHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJadwal)).BeginInit();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDepan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelAdmin.Location = new System.Drawing.Point(410, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(186, 65);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "DeAdmin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewJadwal
            // 
            this.dataGridViewJadwal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCinema,
            this.ColumnStudion,
            this.ColumnTanggal,
            this.ColumnJamPemutaran,
            this.ColumnFilm,
            this.ColumnBtnHapus});
            this.dataGridViewJadwal.Location = new System.Drawing.Point(26, 93);
            this.dataGridViewJadwal.Name = "dataGridViewJadwal";
            this.dataGridViewJadwal.RowHeadersWidth = 51;
            this.dataGridViewJadwal.RowTemplate.Height = 24;
            this.dataGridViewJadwal.Size = new System.Drawing.Size(726, 346);
            this.dataGridViewJadwal.TabIndex = 18;
            this.dataGridViewJadwal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJadwal_CellContentClick);
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panelAtas.Controls.Add(this.labelAdmin);
            this.panelAtas.Controls.Add(this.pictureBoxLogo);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(852, 61);
            this.panelAtas.TabIndex = 19;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(315, -10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(89, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelDepan
            // 
            this.panelDepan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDepan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panelDepan.Controls.Add(this.dataGridViewJadwal);
            this.panelDepan.Controls.Add(this.pictureBoxBack);
            this.panelDepan.Controls.Add(this.pictureBoxTambah);
            this.panelDepan.Controls.Add(this.panel1);
            this.panelDepan.Controls.Add(this.labelNoInvoice);
            this.panelDepan.Location = new System.Drawing.Point(46, 77);
            this.panelDepan.Name = "panelDepan";
            this.panelDepan.Size = new System.Drawing.Size(763, 509);
            this.panelDepan.TabIndex = 20;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::ProjectDatabase.Properties.Resources.back_1689837_1280_removebg_preview;
            this.pictureBoxBack.Location = new System.Drawing.Point(692, 445);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 20;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBoxTambah
            // 
            this.pictureBoxTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxTambah.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTambah.Image = global::ProjectDatabase.Properties.Resources.buttonTambah;
            this.pictureBoxTambah.Location = new System.Drawing.Point(10, 445);
            this.pictureBoxTambah.Name = "pictureBoxTambah";
            this.pictureBoxTambah.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTambah.TabIndex = 0;
            this.pictureBoxTambah.TabStop = false;
            this.pictureBoxTambah.Click += new System.EventHandler(this.pictureBoxTambah_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.dateTimePickerJadwal);
            this.panel1.Controls.Add(this.comboBoxJam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 33);
            this.panel1.TabIndex = 19;
            // 
            // dateTimePickerJadwal
            // 
            this.dateTimePickerJadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJadwal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerJadwal.Location = new System.Drawing.Point(413, 4);
            this.dateTimePickerJadwal.Name = "dateTimePickerJadwal";
            this.dateTimePickerJadwal.Size = new System.Drawing.Size(223, 24);
            this.dateTimePickerJadwal.TabIndex = 22;
            // 
            // comboBoxJam
            // 
            this.comboBoxJam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJam.FormattingEnabled = true;
            this.comboBoxJam.Location = new System.Drawing.Point(183, 4);
            this.comboBoxJam.Name = "comboBoxJam";
            this.comboBoxJam.Size = new System.Drawing.Size(224, 24);
            this.comboBoxJam.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Jadwal";
            // 
            // labelNoInvoice
            // 
            this.labelNoInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNoInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNoInvoice.Location = new System.Drawing.Point(0, 0);
            this.labelNoInvoice.Name = "labelNoInvoice";
            this.labelNoInvoice.Size = new System.Drawing.Size(763, 54);
            this.labelNoInvoice.TabIndex = 18;
            this.labelNoInvoice.Text = "Jadwal Film";
            this.labelNoInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBlkng
            // 
            this.panelBlkng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBlkng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panelBlkng.Location = new System.Drawing.Point(39, 71);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(776, 522);
            this.panelBlkng.TabIndex = 21;
            // 
            // panelBack
            // 
            this.panelBack.BackgroundImage = global::ProjectDatabase.Properties.Resources.pngtree_contrast_color_rotation_effect_retro_background_picture_image_1340025;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Controls.Add(this.panelDepan);
            this.panelBack.Controls.Add(this.panelBlkng);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(852, 608);
            this.panelBack.TabIndex = 22;
            // 
            // ColumnCinema
            // 
            this.ColumnCinema.HeaderText = "Cinema";
            this.ColumnCinema.MinimumWidth = 6;
            this.ColumnCinema.Name = "ColumnCinema";
            this.ColumnCinema.ReadOnly = true;
            this.ColumnCinema.Width = 125;
            // 
            // ColumnStudion
            // 
            this.ColumnStudion.HeaderText = "Studio";
            this.ColumnStudion.MinimumWidth = 6;
            this.ColumnStudion.Name = "ColumnStudion";
            this.ColumnStudion.ReadOnly = true;
            this.ColumnStudion.Width = 125;
            // 
            // ColumnTanggal
            // 
            this.ColumnTanggal.HeaderText = "Tanggal";
            this.ColumnTanggal.MinimumWidth = 6;
            this.ColumnTanggal.Name = "ColumnTanggal";
            this.ColumnTanggal.ReadOnly = true;
            this.ColumnTanggal.Width = 125;
            // 
            // ColumnJamPemutaran
            // 
            this.ColumnJamPemutaran.HeaderText = "JamPemutaran";
            this.ColumnJamPemutaran.MinimumWidth = 6;
            this.ColumnJamPemutaran.Name = "ColumnJamPemutaran";
            this.ColumnJamPemutaran.ReadOnly = true;
            this.ColumnJamPemutaran.Width = 125;
            // 
            // ColumnFilm
            // 
            this.ColumnFilm.HeaderText = "Film";
            this.ColumnFilm.MinimumWidth = 6;
            this.ColumnFilm.Name = "ColumnFilm";
            this.ColumnFilm.ReadOnly = true;
            this.ColumnFilm.Width = 125;
            // 
            // ColumnBtnHapus
            // 
            this.ColumnBtnHapus.HeaderText = "Aksi";
            this.ColumnBtnHapus.MinimumWidth = 6;
            this.ColumnBtnHapus.Name = "ColumnBtnHapus";
            this.ColumnBtnHapus.ReadOnly = true;
            this.ColumnBtnHapus.Text = "Hapus";
            this.ColumnBtnHapus.UseColumnTextForButtonValue = true;
            this.ColumnBtnHapus.Width = 125;
            // 
            // FormDaftarJadwalFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 608);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelBack);
            this.Name = "FormDaftarJadwalFilm";
            this.Text = "FormDaftarJadwalFilm";
            this.Load += new System.EventHandler(this.FormDaftarJadwalFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJadwal)).EndInit();
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDepan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.DataGridView dataGridViewJadwal;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelDepan;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxTambah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerJadwal;
        private System.Windows.Forms.ComboBox comboBoxJam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNoInvoice;
        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJamPemutaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilm;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBtnHapus;
    }
}