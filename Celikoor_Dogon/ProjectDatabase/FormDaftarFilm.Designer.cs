namespace ProjectDatabase
{
    partial class FormDaftarFilm
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
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJudul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSinopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKelompok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBahasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkboxSubtitleIndonesia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiskonNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDepan = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxTambah = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNilaiKriteria = new System.Windows.Forms.TextBox();
            this.comboBoxFilm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNoInvoice = new System.Windows.Forms.Label();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.panelBack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDepan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBlkng.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelAdmin.Location = new System.Drawing.Point(789, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(186, 65);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "DeAdmin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnJudul,
            this.ColumnSinopsis,
            this.ColumnTahun,
            this.ColumnDurasi,
            this.ColumnKelompok,
            this.ColumnBahasa,
            this.checkboxSubtitleIndonesia,
            this.ColumnDiskonNominal,
            this.btnDetail,
            this.btnUbah,
            this.btnHapus});
            this.dataGridViewFilm.Location = new System.Drawing.Point(23, 136);
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.RowHeadersWidth = 51;
            this.dataGridViewFilm.RowTemplate.Height = 24;
            this.dataGridViewFilm.Size = new System.Drawing.Size(1570, 554);
            this.dataGridViewFilm.TabIndex = 13;
            this.dataGridViewFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilm_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 125;
            // 
            // ColumnJudul
            // 
            this.ColumnJudul.HeaderText = "Judul";
            this.ColumnJudul.MinimumWidth = 6;
            this.ColumnJudul.Name = "ColumnJudul";
            this.ColumnJudul.ReadOnly = true;
            this.ColumnJudul.Width = 125;
            // 
            // ColumnSinopsis
            // 
            this.ColumnSinopsis.HeaderText = "Sinopsis";
            this.ColumnSinopsis.MinimumWidth = 6;
            this.ColumnSinopsis.Name = "ColumnSinopsis";
            this.ColumnSinopsis.ReadOnly = true;
            this.ColumnSinopsis.Width = 125;
            // 
            // ColumnTahun
            // 
            this.ColumnTahun.HeaderText = "Tahun";
            this.ColumnTahun.MinimumWidth = 6;
            this.ColumnTahun.Name = "ColumnTahun";
            this.ColumnTahun.ReadOnly = true;
            this.ColumnTahun.Width = 125;
            // 
            // ColumnDurasi
            // 
            this.ColumnDurasi.HeaderText = "Durasi";
            this.ColumnDurasi.MinimumWidth = 6;
            this.ColumnDurasi.Name = "ColumnDurasi";
            this.ColumnDurasi.ReadOnly = true;
            this.ColumnDurasi.Width = 125;
            // 
            // ColumnKelompok
            // 
            this.ColumnKelompok.HeaderText = "Kelompok";
            this.ColumnKelompok.MinimumWidth = 6;
            this.ColumnKelompok.Name = "ColumnKelompok";
            this.ColumnKelompok.ReadOnly = true;
            this.ColumnKelompok.Width = 125;
            // 
            // ColumnBahasa
            // 
            this.ColumnBahasa.HeaderText = "Bahasa";
            this.ColumnBahasa.MinimumWidth = 6;
            this.ColumnBahasa.Name = "ColumnBahasa";
            this.ColumnBahasa.ReadOnly = true;
            this.ColumnBahasa.Width = 125;
            // 
            // checkboxSubtitleIndonesia
            // 
            this.checkboxSubtitleIndonesia.HeaderText = "Subtitle Indonesia";
            this.checkboxSubtitleIndonesia.MinimumWidth = 6;
            this.checkboxSubtitleIndonesia.Name = "checkboxSubtitleIndonesia";
            this.checkboxSubtitleIndonesia.ReadOnly = true;
            this.checkboxSubtitleIndonesia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkboxSubtitleIndonesia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.checkboxSubtitleIndonesia.Width = 125;
            // 
            // ColumnDiskonNominal
            // 
            this.ColumnDiskonNominal.HeaderText = "DiskonNominal";
            this.ColumnDiskonNominal.MinimumWidth = 6;
            this.ColumnDiskonNominal.Name = "ColumnDiskonNominal";
            this.ColumnDiskonNominal.ReadOnly = true;
            this.ColumnDiskonNominal.Width = 125;
            // 
            // btnDetail
            // 
            this.btnDetail.HeaderText = "Aksi";
            this.btnDetail.MinimumWidth = 6;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ReadOnly = true;
            this.btnDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseColumnTextForButtonValue = true;
            this.btnDetail.Width = 125;
            // 
            // btnUbah
            // 
            this.btnUbah.HeaderText = "Aksi";
            this.btnUbah.MinimumWidth = 6;
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.ReadOnly = true;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseColumnTextForButtonValue = true;
            this.btnUbah.Width = 125;
            // 
            // btnHapus
            // 
            this.btnHapus.HeaderText = "Aksi";
            this.btnHapus.MinimumWidth = 6;
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.ReadOnly = true;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseColumnTextForButtonValue = true;
            this.btnHapus.Width = 125;
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panelAtas.Controls.Add(this.labelAdmin);
            this.panelAtas.Controls.Add(this.pictureBoxLogo);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1702, 61);
            this.panelAtas.TabIndex = 14;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(702, -10);
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
            this.panelDepan.Controls.Add(this.dataGridViewFilm);
            this.panelDepan.Controls.Add(this.pictureBoxBack);
            this.panelDepan.Controls.Add(this.pictureBoxTambah);
            this.panelDepan.Controls.Add(this.panel1);
            this.panelDepan.Controls.Add(this.labelNoInvoice);
            this.panelDepan.Location = new System.Drawing.Point(15, 10);
            this.panelDepan.Name = "panelDepan";
            this.panelDepan.Size = new System.Drawing.Size(1629, 769);
            this.panelDepan.TabIndex = 15;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::ProjectDatabase.Properties.Resources.back_1689837_1280_removebg_preview;
            this.pictureBoxBack.Location = new System.Drawing.Point(1556, 705);
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
            this.pictureBoxTambah.Location = new System.Drawing.Point(10, 705);
            this.pictureBoxTambah.Name = "pictureBoxTambah";
            this.pictureBoxTambah.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTambah.TabIndex = 0;
            this.pictureBoxTambah.TabStop = false;
            this.pictureBoxTambah.Click += new System.EventHandler(this.pictureBoxTambah_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.textBoxNilaiKriteria);
            this.panel1.Controls.Add(this.comboBoxFilm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 33);
            this.panel1.TabIndex = 19;
            // 
            // textBoxNilaiKriteria
            // 
            this.textBoxNilaiKriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNilaiKriteria.Location = new System.Drawing.Point(326, 5);
            this.textBoxNilaiKriteria.Name = "textBoxNilaiKriteria";
            this.textBoxNilaiKriteria.Size = new System.Drawing.Size(465, 22);
            this.textBoxNilaiKriteria.TabIndex = 21;
            this.textBoxNilaiKriteria.TextChanged += new System.EventHandler(this.textBoxNilaiKriteria_TextChanged);
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilm.FormattingEnabled = true;
            this.comboBoxFilm.Items.AddRange(new object[] {
            "Judul",
            "Tahun",
            "Kelompok",
            "Genre",
            "Bahasa",
            "Aktor"});
            this.comboBoxFilm.Location = new System.Drawing.Point(183, 4);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(135, 24);
            this.comboBoxFilm.TabIndex = 20;
            this.comboBoxFilm.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(51, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Film";
            // 
            // labelNoInvoice
            // 
            this.labelNoInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNoInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNoInvoice.Location = new System.Drawing.Point(2, 18);
            this.labelNoInvoice.Name = "labelNoInvoice";
            this.labelNoInvoice.Size = new System.Drawing.Size(1603, 54);
            this.labelNoInvoice.TabIndex = 18;
            this.labelNoInvoice.Text = "Film List";
            this.labelNoInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNoInvoice.Click += new System.EventHandler(this.labelNoInvoice_Click);
            // 
            // panelBlkng
            // 
            this.panelBlkng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBlkng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panelBlkng.Controls.Add(this.panelDepan);
            this.panelBlkng.Location = new System.Drawing.Point(12, 77);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(1658, 791);
            this.panelBlkng.TabIndex = 16;
            // 
            // panelBack
            // 
            this.panelBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBack.BackgroundImage = global::ProjectDatabase.Properties.Resources.pngtree_contrast_color_rotation_effect_retro_background_picture_image_1340025;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1702, 1033);
            this.panelBack.TabIndex = 17;
            // 
            // FormDaftarFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelBlkng);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarFilm";
            this.Text = "FormFilm";
            this.Load += new System.EventHandler(this.FormFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDepan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBlkng.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelDepan;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxTambah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNoInvoice;
        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.TextBox textBoxNilaiKriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJudul;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSinopsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDurasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKelompok;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBahasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkboxSubtitleIndonesia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiskonNominal;
        private System.Windows.Forms.DataGridViewButtonColumn btnDetail;
        private System.Windows.Forms.DataGridViewButtonColumn btnUbah;
        private System.Windows.Forms.DataGridViewButtonColumn btnHapus;
    }
}