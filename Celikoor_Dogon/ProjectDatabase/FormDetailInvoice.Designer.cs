namespace ProjectDatabase
{
    partial class FormDetailInvoice
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
            this.panelBack = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDepan = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKasir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKonsumen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDiskonNominal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.ColumnNoKursi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusHadir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDepan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackgroundImage = global::ProjectDatabase.Properties.Resources.pngtree_contrast_color_rotation_effect_retro_background_picture_image_1340025;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Controls.Add(this.dataGridView1);
            this.panelBack.Controls.Add(this.panelAtas);
            this.panelBack.Controls.Add(this.panelDepan);
            this.panelBack.Controls.Add(this.panelBlkng);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1132, 624);
            this.panelBack.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNoKursi,
            this.ColumnStatusHadir,
            this.ColumnOperator,
            this.ColumnHarga,
            this.ColumnTanggal,
            this.ColumnSesi,
            this.ColumnCinema,
            this.ColumnStudio,
            this.ColumnFilm});
            this.dataGridView1.Location = new System.Drawing.Point(39, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 190);
            this.dataGridView1.TabIndex = 8;
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panelAtas.Controls.Add(this.pictureBox1);
            this.panelAtas.Controls.Add(this.labelAdmin);
            this.panelAtas.Controls.Add(this.pictureBoxLogo);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1132, 61);
            this.panelAtas.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(439, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelAdmin
            // 
            this.labelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelAdmin.Location = new System.Drawing.Point(534, -4);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(200, 65);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "DeAdmin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(498, -14);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(29, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelDepan
            // 
            this.panelDepan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panelDepan.Controls.Add(this.labelStatus);
            this.panelDepan.Controls.Add(this.pictureBoxBack);
            this.panelDepan.Controls.Add(this.label3);
            this.panelDepan.Controls.Add(this.labelKasir);
            this.panelDepan.Controls.Add(this.label2);
            this.panelDepan.Controls.Add(this.labelKonsumen);
            this.panelDepan.Controls.Add(this.label1);
            this.panelDepan.Controls.Add(this.labelDiskonNominal);
            this.panelDepan.Controls.Add(this.label4);
            this.panelDepan.Controls.Add(this.labelGrandTotal);
            this.panelDepan.Controls.Add(this.label6);
            this.panelDepan.Controls.Add(this.labelTanggal);
            this.panelDepan.Controls.Add(this.label7);
            this.panelDepan.Controls.Add(this.labelId);
            this.panelDepan.Controls.Add(this.label8);
            this.panelDepan.Location = new System.Drawing.Point(25, 79);
            this.panelDepan.Name = "panelDepan";
            this.panelDepan.Size = new System.Drawing.Size(1081, 523);
            this.panelDepan.TabIndex = 24;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(200, 212);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(110, 22);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "labelStatus";
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::ProjectDatabase.Properties.Resources.back_1689837_1280_removebg_preview;
            this.pictureBoxBack.Location = new System.Drawing.Point(1007, 455);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 21;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grand Total :";
            // 
            // labelKasir
            // 
            this.labelKasir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKasir.AutoSize = true;
            this.labelKasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelKasir.ForeColor = System.Drawing.Color.White;
            this.labelKasir.Location = new System.Drawing.Point(200, 180);
            this.labelKasir.Name = "labelKasir";
            this.labelKasir.Size = new System.Drawing.Size(99, 22);
            this.labelKasir.TabIndex = 16;
            this.labelKasir.Text = "labelKasir";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal :";
            // 
            // labelKonsumen
            // 
            this.labelKonsumen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKonsumen.AutoSize = true;
            this.labelKonsumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelKonsumen.ForeColor = System.Drawing.Color.White;
            this.labelKonsumen.Location = new System.Drawing.Point(200, 148);
            this.labelKonsumen.Name = "labelKonsumen";
            this.labelKonsumen.Size = new System.Drawing.Size(124, 22);
            this.labelKonsumen.TabIndex = 15;
            this.labelKonsumen.Text = "labelKonsum";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // labelDiskonNominal
            // 
            this.labelDiskonNominal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDiskonNominal.AutoSize = true;
            this.labelDiskonNominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelDiskonNominal.ForeColor = System.Drawing.Color.White;
            this.labelDiskonNominal.Location = new System.Drawing.Point(200, 116);
            this.labelDiskonNominal.Name = "labelDiskonNominal";
            this.labelDiskonNominal.Size = new System.Drawing.Size(132, 22);
            this.labelDiskonNominal.TabIndex = 13;
            this.labelDiskonNominal.Text = "labelDiscNom";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diskon nominal :";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelGrandTotal.ForeColor = System.Drawing.Color.White;
            this.labelGrandTotal.Location = new System.Drawing.Point(200, 84);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(81, 22);
            this.labelGrandTotal.TabIndex = 12;
            this.labelGrandTotal.Text = "labelGT";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(62, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Konsumen :";
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelTanggal.ForeColor = System.Drawing.Color.White;
            this.labelTanggal.Location = new System.Drawing.Point(200, 52);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(82, 22);
            this.labelTanggal.TabIndex = 11;
            this.labelTanggal.Text = "labelTgl";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(109, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kasir :";
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Location = new System.Drawing.Point(200, 20);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(69, 22);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "labelId";
            this.labelId.Click += new System.EventHandler(this.labelId_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(98, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status :";
            // 
            // panelBlkng
            // 
            this.panelBlkng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panelBlkng.Location = new System.Drawing.Point(18, 73);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(1095, 536);
            this.panelBlkng.TabIndex = 25;
            // 
            // ColumnNoKursi
            // 
            this.ColumnNoKursi.HeaderText = "No Kursi";
            this.ColumnNoKursi.MinimumWidth = 6;
            this.ColumnNoKursi.Name = "ColumnNoKursi";
            this.ColumnNoKursi.ReadOnly = true;
            this.ColumnNoKursi.Width = 125;
            // 
            // ColumnStatusHadir
            // 
            this.ColumnStatusHadir.HeaderText = "Status Hadir";
            this.ColumnStatusHadir.MinimumWidth = 6;
            this.ColumnStatusHadir.Name = "ColumnStatusHadir";
            this.ColumnStatusHadir.ReadOnly = true;
            this.ColumnStatusHadir.Width = 125;
            // 
            // ColumnOperator
            // 
            this.ColumnOperator.HeaderText = "Operator";
            this.ColumnOperator.MinimumWidth = 6;
            this.ColumnOperator.Name = "ColumnOperator";
            this.ColumnOperator.ReadOnly = true;
            this.ColumnOperator.Width = 125;
            // 
            // ColumnHarga
            // 
            this.ColumnHarga.HeaderText = "Harga";
            this.ColumnHarga.MinimumWidth = 6;
            this.ColumnHarga.Name = "ColumnHarga";
            this.ColumnHarga.ReadOnly = true;
            this.ColumnHarga.Width = 125;
            // 
            // ColumnTanggal
            // 
            this.ColumnTanggal.HeaderText = "Tanggal";
            this.ColumnTanggal.MinimumWidth = 6;
            this.ColumnTanggal.Name = "ColumnTanggal";
            this.ColumnTanggal.ReadOnly = true;
            this.ColumnTanggal.Width = 125;
            // 
            // ColumnSesi
            // 
            this.ColumnSesi.HeaderText = "Sesi";
            this.ColumnSesi.MinimumWidth = 6;
            this.ColumnSesi.Name = "ColumnSesi";
            this.ColumnSesi.ReadOnly = true;
            this.ColumnSesi.Width = 125;
            // 
            // ColumnCinema
            // 
            this.ColumnCinema.HeaderText = "Cinema";
            this.ColumnCinema.MinimumWidth = 6;
            this.ColumnCinema.Name = "ColumnCinema";
            this.ColumnCinema.ReadOnly = true;
            this.ColumnCinema.Width = 125;
            // 
            // ColumnStudio
            // 
            this.ColumnStudio.HeaderText = "Studio";
            this.ColumnStudio.MinimumWidth = 6;
            this.ColumnStudio.Name = "ColumnStudio";
            this.ColumnStudio.ReadOnly = true;
            this.ColumnStudio.Width = 125;
            // 
            // ColumnFilm
            // 
            this.ColumnFilm.HeaderText = "Film";
            this.ColumnFilm.MinimumWidth = 6;
            this.ColumnFilm.Name = "ColumnFilm";
            this.ColumnFilm.ReadOnly = true;
            this.ColumnFilm.Width = 125;
            // 
            // FormDetailInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 624);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailInvoice";
            this.Load += new System.EventHandler(this.FormDetailInvoice_Load);
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDepan.ResumeLayout(false);
            this.panelDepan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelKasir;
        private System.Windows.Forms.Label labelKonsumen;
        private System.Windows.Forms.Label labelDiskonNominal;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDepan;
        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNoKursi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusHadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilm;
    }
}