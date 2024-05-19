namespace ProjectDatabase
{
    partial class FormUtamaPegawai
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonPegawai = new System.Windows.Forms.Button();
            this.buttonLaporan = new System.Windows.Forms.Button();
            this.buttonJadwal = new System.Windows.Forms.Button();
            this.buttonStudio = new System.Windows.Forms.Button();
            this.buttonJenisStudio = new System.Windows.Forms.Button();
            this.buttonCinema = new System.Windows.Forms.Button();
            this.buttonAktor = new System.Windows.Forms.Button();
            this.buttonGenre = new System.Windows.Forms.Button();
            this.buttonFilm = new System.Windows.Forms.Button();
            this.buttonKelompok = new System.Windows.Forms.Button();
            this.buttonKonsumen = new System.Windows.Forms.Button();
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.buttonScanTicket = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(179, 76);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(55, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(89, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.AutoScroll = true;
            this.panelForm.BackColor = System.Drawing.Color.DimGray;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(10);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(582, 553);
            this.panelForm.TabIndex = 3;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panelMenu.Controls.Add(this.buttonPegawai);
            this.panelMenu.Controls.Add(this.buttonLaporan);
            this.panelMenu.Controls.Add(this.buttonJadwal);
            this.panelMenu.Controls.Add(this.buttonStudio);
            this.panelMenu.Controls.Add(this.buttonJenisStudio);
            this.panelMenu.Controls.Add(this.buttonCinema);
            this.panelMenu.Controls.Add(this.buttonAktor);
            this.panelMenu.Controls.Add(this.buttonGenre);
            this.panelMenu.Controls.Add(this.buttonFilm);
            this.panelMenu.Controls.Add(this.buttonKelompok);
            this.panelMenu.Controls.Add(this.buttonKonsumen);
            this.panelMenu.Controls.Add(this.buttonInvoice);
            this.panelMenu.Controls.Add(this.buttonScanTicket);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 553);
            this.panelMenu.TabIndex = 2;
            // 
            // buttonPegawai
            // 
            this.buttonPegawai.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPegawai.FlatAppearance.BorderSize = 0;
            this.buttonPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonPegawai.ForeColor = System.Drawing.Color.White;
            this.buttonPegawai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPegawai.Location = new System.Drawing.Point(0, 796);
            this.buttonPegawai.Name = "buttonPegawai";
            this.buttonPegawai.Size = new System.Drawing.Size(179, 60);
            this.buttonPegawai.TabIndex = 16;
            this.buttonPegawai.Text = "Pegawai";
            this.buttonPegawai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPegawai.UseVisualStyleBackColor = true;
            this.buttonPegawai.Click += new System.EventHandler(this.buttonPegawai_Click);
            // 
            // buttonLaporan
            // 
            this.buttonLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLaporan.FlatAppearance.BorderSize = 0;
            this.buttonLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonLaporan.ForeColor = System.Drawing.Color.White;
            this.buttonLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLaporan.Location = new System.Drawing.Point(0, 736);
            this.buttonLaporan.Name = "buttonLaporan";
            this.buttonLaporan.Size = new System.Drawing.Size(179, 60);
            this.buttonLaporan.TabIndex = 15;
            this.buttonLaporan.Text = "Laporan";
            this.buttonLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLaporan.UseVisualStyleBackColor = true;
            this.buttonLaporan.Click += new System.EventHandler(this.buttonLaporan_Click);
            // 
            // buttonJadwal
            // 
            this.buttonJadwal.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJadwal.FlatAppearance.BorderSize = 0;
            this.buttonJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonJadwal.ForeColor = System.Drawing.Color.White;
            this.buttonJadwal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJadwal.Location = new System.Drawing.Point(0, 676);
            this.buttonJadwal.Name = "buttonJadwal";
            this.buttonJadwal.Size = new System.Drawing.Size(179, 60);
            this.buttonJadwal.TabIndex = 14;
            this.buttonJadwal.Text = "Jadwal";
            this.buttonJadwal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonJadwal.UseVisualStyleBackColor = true;
            this.buttonJadwal.Click += new System.EventHandler(this.buttonJadwal_Click_1);
            // 
            // buttonStudio
            // 
            this.buttonStudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudio.FlatAppearance.BorderSize = 0;
            this.buttonStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonStudio.ForeColor = System.Drawing.Color.White;
            this.buttonStudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudio.Location = new System.Drawing.Point(0, 616);
            this.buttonStudio.Name = "buttonStudio";
            this.buttonStudio.Size = new System.Drawing.Size(179, 60);
            this.buttonStudio.TabIndex = 13;
            this.buttonStudio.Text = "Studio";
            this.buttonStudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudio.UseVisualStyleBackColor = true;
            this.buttonStudio.Click += new System.EventHandler(this.buttonStudio_Click);
            // 
            // buttonJenisStudio
            // 
            this.buttonJenisStudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJenisStudio.FlatAppearance.BorderSize = 0;
            this.buttonJenisStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJenisStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonJenisStudio.ForeColor = System.Drawing.Color.White;
            this.buttonJenisStudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJenisStudio.Location = new System.Drawing.Point(0, 556);
            this.buttonJenisStudio.Name = "buttonJenisStudio";
            this.buttonJenisStudio.Size = new System.Drawing.Size(179, 60);
            this.buttonJenisStudio.TabIndex = 12;
            this.buttonJenisStudio.Text = "Jenis Studio";
            this.buttonJenisStudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonJenisStudio.UseVisualStyleBackColor = true;
            this.buttonJenisStudio.Click += new System.EventHandler(this.buttonJenisStudio_Click);
            // 
            // buttonCinema
            // 
            this.buttonCinema.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCinema.FlatAppearance.BorderSize = 0;
            this.buttonCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonCinema.ForeColor = System.Drawing.Color.White;
            this.buttonCinema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCinema.Location = new System.Drawing.Point(0, 496);
            this.buttonCinema.Name = "buttonCinema";
            this.buttonCinema.Size = new System.Drawing.Size(179, 60);
            this.buttonCinema.TabIndex = 11;
            this.buttonCinema.Text = "Cinema";
            this.buttonCinema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCinema.UseVisualStyleBackColor = true;
            this.buttonCinema.Click += new System.EventHandler(this.buttonCinema_Click);
            // 
            // buttonAktor
            // 
            this.buttonAktor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAktor.FlatAppearance.BorderSize = 0;
            this.buttonAktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonAktor.ForeColor = System.Drawing.Color.White;
            this.buttonAktor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAktor.Location = new System.Drawing.Point(0, 436);
            this.buttonAktor.Name = "buttonAktor";
            this.buttonAktor.Size = new System.Drawing.Size(179, 60);
            this.buttonAktor.TabIndex = 10;
            this.buttonAktor.Text = "Aktor";
            this.buttonAktor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAktor.UseVisualStyleBackColor = true;
            this.buttonAktor.Click += new System.EventHandler(this.buttonAktor_Click);
            // 
            // buttonGenre
            // 
            this.buttonGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGenre.FlatAppearance.BorderSize = 0;
            this.buttonGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonGenre.ForeColor = System.Drawing.Color.White;
            this.buttonGenre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenre.Location = new System.Drawing.Point(0, 376);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Size = new System.Drawing.Size(179, 60);
            this.buttonGenre.TabIndex = 9;
            this.buttonGenre.Text = "Genre";
            this.buttonGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGenre.UseVisualStyleBackColor = true;
            this.buttonGenre.Click += new System.EventHandler(this.buttonGenre_Click);
            // 
            // buttonFilm
            // 
            this.buttonFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFilm.FlatAppearance.BorderSize = 0;
            this.buttonFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonFilm.ForeColor = System.Drawing.Color.White;
            this.buttonFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilm.Location = new System.Drawing.Point(0, 316);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(179, 60);
            this.buttonFilm.TabIndex = 8;
            this.buttonFilm.Text = "Film";
            this.buttonFilm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFilm.UseVisualStyleBackColor = true;
            this.buttonFilm.Click += new System.EventHandler(this.buttonFilm_Click);
            // 
            // buttonKelompok
            // 
            this.buttonKelompok.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKelompok.FlatAppearance.BorderSize = 0;
            this.buttonKelompok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKelompok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonKelompok.ForeColor = System.Drawing.Color.White;
            this.buttonKelompok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKelompok.Location = new System.Drawing.Point(0, 256);
            this.buttonKelompok.Name = "buttonKelompok";
            this.buttonKelompok.Size = new System.Drawing.Size(179, 60);
            this.buttonKelompok.TabIndex = 7;
            this.buttonKelompok.Text = "Kelompok";
            this.buttonKelompok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKelompok.UseVisualStyleBackColor = true;
            this.buttonKelompok.Click += new System.EventHandler(this.buttonKelompok_Click);
            // 
            // buttonKonsumen
            // 
            this.buttonKonsumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKonsumen.FlatAppearance.BorderSize = 0;
            this.buttonKonsumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonsumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonKonsumen.ForeColor = System.Drawing.Color.White;
            this.buttonKonsumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKonsumen.Location = new System.Drawing.Point(0, 196);
            this.buttonKonsumen.Name = "buttonKonsumen";
            this.buttonKonsumen.Size = new System.Drawing.Size(179, 60);
            this.buttonKonsumen.TabIndex = 6;
            this.buttonKonsumen.Text = "Konsumen";
            this.buttonKonsumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKonsumen.UseVisualStyleBackColor = true;
            this.buttonKonsumen.Click += new System.EventHandler(this.buttonKonsumen_Click);
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInvoice.FlatAppearance.BorderSize = 0;
            this.buttonInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonInvoice.ForeColor = System.Drawing.Color.White;
            this.buttonInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInvoice.Location = new System.Drawing.Point(0, 136);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(179, 60);
            this.buttonInvoice.TabIndex = 2;
            this.buttonInvoice.Text = "Invoice";
            this.buttonInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInvoice.UseVisualStyleBackColor = true;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // buttonScanTicket
            // 
            this.buttonScanTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonScanTicket.FlatAppearance.BorderSize = 0;
            this.buttonScanTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScanTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonScanTicket.ForeColor = System.Drawing.Color.White;
            this.buttonScanTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonScanTicket.Location = new System.Drawing.Point(0, 76);
            this.buttonScanTicket.Name = "buttonScanTicket";
            this.buttonScanTicket.Size = new System.Drawing.Size(179, 60);
            this.buttonScanTicket.TabIndex = 1;
            this.buttonScanTicket.Text = "Scan Ticket";
            this.buttonScanTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonScanTicket.UseVisualStyleBackColor = true;
            this.buttonScanTicket.Click += new System.EventHandler(this.buttonScanTicket_Click);
            // 
            // FormUtamaPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUtamaPegawai";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUtamaPegawai_Load);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonInvoice;
        private System.Windows.Forms.Button buttonScanTicket;
        private System.Windows.Forms.Button buttonKonsumen;
        private System.Windows.Forms.Button buttonKelompok;
        private System.Windows.Forms.Button buttonFilm;
        private System.Windows.Forms.Button buttonGenre;
        private System.Windows.Forms.Button buttonAktor;
        private System.Windows.Forms.Button buttonCinema;
        private System.Windows.Forms.Button buttonJenisStudio;
        private System.Windows.Forms.Button buttonLaporan;
        private System.Windows.Forms.Button buttonJadwal;
        private System.Windows.Forms.Button buttonStudio;
        private System.Windows.Forms.Button buttonPegawai;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}