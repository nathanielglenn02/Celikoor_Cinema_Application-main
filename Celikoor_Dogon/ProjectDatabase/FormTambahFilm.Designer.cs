namespace ProjectDatabase
{
    partial class FormTambahFilm
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
            this.panelAtas = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelDepan = new System.Windows.Forms.Panel();
            this.textBoxDiskonNominal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonTambahGenre = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.dataGridViewGenre = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHapusGenre = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonTambahAktor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxPeran = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxAktor = new System.Windows.Forms.ComboBox();
            this.dataGridViewAktor = new System.Windows.Forms.DataGridView();
            this.colomAktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colomPeran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHapusAktor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBhs = new System.Windows.Forms.ComboBox();
            this.comboBoxKelompok = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDurasi = new System.Windows.Forms.TextBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxTambah = new System.Windows.Forms.PictureBox();
            this.textBoxTahun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.openFileDialogPoster = new System.Windows.Forms.OpenFileDialog();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panelDepan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelAdmin.Location = new System.Drawing.Point(428, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(186, 65);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "DeAdmin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panelAtas.Controls.Add(this.labelAdmin);
            this.panelAtas.Controls.Add(this.pictureBoxLogo);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(923, 61);
            this.panelAtas.TabIndex = 13;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(341, -10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(89, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.Black;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Controls.Add(this.panelDepan);
            this.panelBack.Controls.Add(this.panelBlkng);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 61);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(923, 876);
            this.panelBack.TabIndex = 14;
            // 
            // panelDepan
            // 
            this.panelDepan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panelDepan.Controls.Add(this.textBoxDiskonNominal);
            this.panelDepan.Controls.Add(this.label23);
            this.panelDepan.Controls.Add(this.buttonUploadImage);
            this.panelDepan.Controls.Add(this.radioButtonNo);
            this.panelDepan.Controls.Add(this.radioButtonYes);
            this.panelDepan.Controls.Add(this.label11);
            this.panelDepan.Controls.Add(this.buttonTambahGenre);
            this.panelDepan.Controls.Add(this.label12);
            this.panelDepan.Controls.Add(this.comboBoxGenre);
            this.panelDepan.Controls.Add(this.dataGridViewGenre);
            this.panelDepan.Controls.Add(this.buttonTambahAktor);
            this.panelDepan.Controls.Add(this.label10);
            this.panelDepan.Controls.Add(this.comboBoxPeran);
            this.panelDepan.Controls.Add(this.label9);
            this.panelDepan.Controls.Add(this.comboBoxAktor);
            this.panelDepan.Controls.Add(this.dataGridViewAktor);
            this.panelDepan.Controls.Add(this.pictureBoxPoster);
            this.panelDepan.Controls.Add(this.textBox1);
            this.panelDepan.Controls.Add(this.label8);
            this.panelDepan.Controls.Add(this.comboBoxBhs);
            this.panelDepan.Controls.Add(this.comboBoxKelompok);
            this.panelDepan.Controls.Add(this.label7);
            this.panelDepan.Controls.Add(this.label6);
            this.panelDepan.Controls.Add(this.label5);
            this.panelDepan.Controls.Add(this.textBoxDurasi);
            this.panelDepan.Controls.Add(this.pictureBoxBack);
            this.panelDepan.Controls.Add(this.pictureBoxTambah);
            this.panelDepan.Controls.Add(this.textBoxTahun);
            this.panelDepan.Controls.Add(this.label3);
            this.panelDepan.Controls.Add(this.label2);
            this.panelDepan.Controls.Add(this.textBoxJudul);
            this.panelDepan.Controls.Add(this.label1);
            this.panelDepan.Location = new System.Drawing.Point(30, 27);
            this.panelDepan.Name = "panelDepan";
            this.panelDepan.Size = new System.Drawing.Size(862, 768);
            this.panelDepan.TabIndex = 6;
            // 
            // textBoxDiskonNominal
            // 
            this.textBoxDiskonNominal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiskonNominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiskonNominal.Location = new System.Drawing.Point(244, 225);
            this.textBoxDiskonNominal.Name = "textBoxDiskonNominal";
            this.textBoxDiskonNominal.Size = new System.Drawing.Size(181, 27);
            this.textBoxDiskonNominal.TabIndex = 55;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.Location = new System.Drawing.Point(54, 226);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(161, 22);
            this.label23.TabIndex = 54;
            this.label23.Text = "Diskon Nominal :";
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.Color.Transparent;
            this.buttonUploadImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonUploadImage.FlatAppearance.BorderSize = 3;
            this.buttonUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadImage.ForeColor = System.Drawing.Color.White;
            this.buttonUploadImage.Location = new System.Drawing.Point(615, 370);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(125, 36);
            this.buttonUploadImage.TabIndex = 51;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.radioButtonNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.radioButtonNo.Location = new System.Drawing.Point(316, 195);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(56, 26);
            this.radioButtonNo.TabIndex = 49;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.radioButtonYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.radioButtonYes.Location = new System.Drawing.Point(244, 195);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(65, 26);
            this.radioButtonYes.TabIndex = 48;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(33, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 22);
            this.label11.TabIndex = 47;
            this.label11.Text = "Subtitle Indonesia :";
            // 
            // buttonTambahGenre
            // 
            this.buttonTambahGenre.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambahGenre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonTambahGenre.FlatAppearance.BorderSize = 3;
            this.buttonTambahGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahGenre.ForeColor = System.Drawing.Color.White;
            this.buttonTambahGenre.Location = new System.Drawing.Point(598, 679);
            this.buttonTambahGenre.Name = "buttonTambahGenre";
            this.buttonTambahGenre.Size = new System.Drawing.Size(165, 42);
            this.buttonTambahGenre.TabIndex = 46;
            this.buttonTambahGenre.Text = "Tambah Genre";
            this.buttonTambahGenre.UseVisualStyleBackColor = false;
            this.buttonTambahGenre.Click += new System.EventHandler(this.buttonTambahGenre_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(515, 643);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 22);
            this.label12.TabIndex = 45;
            this.label12.Text = "Genre :";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(598, 645);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(165, 24);
            this.comboBoxGenre.TabIndex = 44;
            // 
            // dataGridViewGenre
            // 
            this.dataGridViewGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.btnHapusGenre});
            this.dataGridViewGenre.Location = new System.Drawing.Point(522, 411);
            this.dataGridViewGenre.Name = "dataGridViewGenre";
            this.dataGridViewGenre.RowHeadersWidth = 51;
            this.dataGridViewGenre.RowTemplate.Height = 24;
            this.dataGridViewGenre.Size = new System.Drawing.Size(304, 211);
            this.dataGridViewGenre.TabIndex = 43;
            this.dataGridViewGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGenre_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // btnHapusGenre
            // 
            this.btnHapusGenre.HeaderText = "Aksi";
            this.btnHapusGenre.MinimumWidth = 6;
            this.btnHapusGenre.Name = "btnHapusGenre";
            this.btnHapusGenre.Text = "Hapus";
            this.btnHapusGenre.UseColumnTextForButtonValue = true;
            this.btnHapusGenre.Width = 125;
            // 
            // buttonTambahAktor
            // 
            this.buttonTambahAktor.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambahAktor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonTambahAktor.FlatAppearance.BorderSize = 4;
            this.buttonTambahAktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahAktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahAktor.ForeColor = System.Drawing.Color.Transparent;
            this.buttonTambahAktor.Location = new System.Drawing.Point(382, 641);
            this.buttonTambahAktor.Name = "buttonTambahAktor";
            this.buttonTambahAktor.Size = new System.Drawing.Size(99, 64);
            this.buttonTambahAktor.TabIndex = 42;
            this.buttonTambahAktor.Text = "Tambah Aktor";
            this.buttonTambahAktor.UseVisualStyleBackColor = false;
            this.buttonTambahAktor.Click += new System.EventHandler(this.buttonTambahAktor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(128, 683);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 41;
            this.label10.Text = "Peran:";
            // 
            // comboBoxPeran
            // 
            this.comboBoxPeran.FormattingEnabled = true;
            this.comboBoxPeran.Items.AddRange(new object[] {
            "UTAMA",
            "PEMBANTU",
            "FIGURAN"});
            this.comboBoxPeran.Location = new System.Drawing.Point(197, 681);
            this.comboBoxPeran.Name = "comboBoxPeran";
            this.comboBoxPeran.Size = new System.Drawing.Size(165, 24);
            this.comboBoxPeran.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(128, 643);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 39;
            this.label9.Text = "Aktor:";
            // 
            // comboBoxAktor
            // 
            this.comboBoxAktor.FormattingEnabled = true;
            this.comboBoxAktor.Location = new System.Drawing.Point(197, 641);
            this.comboBoxAktor.Name = "comboBoxAktor";
            this.comboBoxAktor.Size = new System.Drawing.Size(165, 24);
            this.comboBoxAktor.TabIndex = 38;
            // 
            // dataGridViewAktor
            // 
            this.dataGridViewAktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAktor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colomAktor,
            this.colomPeran,
            this.btnHapusAktor});
            this.dataGridViewAktor.Location = new System.Drawing.Point(51, 411);
            this.dataGridViewAktor.Name = "dataGridViewAktor";
            this.dataGridViewAktor.RowHeadersWidth = 51;
            this.dataGridViewAktor.RowTemplate.Height = 24;
            this.dataGridViewAktor.Size = new System.Drawing.Size(430, 211);
            this.dataGridViewAktor.TabIndex = 37;
            this.dataGridViewAktor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAktor_CellContentClick);
            // 
            // colomAktor
            // 
            this.colomAktor.HeaderText = "Aktor";
            this.colomAktor.MinimumWidth = 6;
            this.colomAktor.Name = "colomAktor";
            this.colomAktor.Width = 125;
            // 
            // colomPeran
            // 
            this.colomPeran.HeaderText = "Peran";
            this.colomPeran.MinimumWidth = 6;
            this.colomPeran.Name = "colomPeran";
            this.colomPeran.Width = 125;
            // 
            // btnHapusAktor
            // 
            this.btnHapusAktor.HeaderText = "Aksi";
            this.btnHapusAktor.MinimumWidth = 6;
            this.btnHapusAktor.Name = "btnHapusAktor";
            this.btnHapusAktor.Text = "Hapus";
            this.btnHapusAktor.UseColumnTextForButtonValue = true;
            this.btnHapusAktor.Width = 125;
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(559, 26);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(230, 337);
            this.pictureBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPoster.TabIndex = 36;
            this.pictureBoxPoster.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(244, 260);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(231, 117);
            this.textBox1.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(123, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Sinopsis:";
            // 
            // comboBoxBhs
            // 
            this.comboBoxBhs.FormattingEnabled = true;
            this.comboBoxBhs.Items.AddRange(new object[] {
            "EN",
            "ID",
            "CHN",
            "KOR",
            "JPN",
            "OTH"});
            this.comboBoxBhs.Location = new System.Drawing.Point(244, 168);
            this.comboBoxBhs.Name = "comboBoxBhs";
            this.comboBoxBhs.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBhs.TabIndex = 33;
            // 
            // comboBoxKelompok
            // 
            this.comboBoxKelompok.FormattingEnabled = true;
            this.comboBoxKelompok.Location = new System.Drawing.Point(244, 134);
            this.comboBoxKelompok.Name = "comboBoxKelompok";
            this.comboBoxKelompok.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKelompok.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(132, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Bahasa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(112, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Kelompok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(312, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Menit";
            // 
            // textBoxDurasi
            // 
            this.textBoxDurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurasi.Location = new System.Drawing.Point(244, 97);
            this.textBoxDurasi.Name = "textBoxDurasi";
            this.textBoxDurasi.Size = new System.Drawing.Size(62, 27);
            this.textBoxDurasi.TabIndex = 26;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::ProjectDatabase.Properties.Resources.back_1689837_1280_removebg_preview;
            this.pictureBoxBack.Location = new System.Drawing.Point(787, 704);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 25;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBoxTambah
            // 
            this.pictureBoxTambah.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTambah.Image = global::ProjectDatabase.Properties.Resources.buttonTambah;
            this.pictureBoxTambah.Location = new System.Drawing.Point(32, 704);
            this.pictureBoxTambah.Name = "pictureBoxTambah";
            this.pictureBoxTambah.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTambah.TabIndex = 11;
            this.pictureBoxTambah.TabStop = false;
            this.pictureBoxTambah.Click += new System.EventHandler(this.pictureBoxTambah_Click);
            // 
            // textBoxTahun
            // 
            this.textBoxTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTahun.Location = new System.Drawing.Point(244, 61);
            this.textBoxTahun.Name = "textBoxTahun";
            this.textBoxTahun.Size = new System.Drawing.Size(111, 27);
            this.textBoxTahun.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(142, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tahun:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(141, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Durasi:";
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJudul.Location = new System.Drawing.Point(244, 25);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(231, 27);
            this.textBoxJudul.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(151, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Judul:";
            // 
            // panelBlkng
            // 
            this.panelBlkng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panelBlkng.Location = new System.Drawing.Point(25, 23);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(871, 779);
            this.panelBlkng.TabIndex = 7;
            // 
            // openFileDialogPoster
            // 
            this.openFileDialogPoster.FileName = "openFileDialogPoster";
            this.openFileDialogPoster.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogPoster_FileOk);
            // 
            // FormTambahFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 937);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panelAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahFilm";
            this.Load += new System.EventHandler(this.FormTambahFilm_Load);
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelDepan.ResumeLayout(false);
            this.panelDepan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.OpenFileDialog openFileDialogPoster;
        private System.Windows.Forms.Panel panelDepan;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonTambahGenre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.DataGridView dataGridViewGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn btnHapusGenre;
        private System.Windows.Forms.Button buttonTambahAktor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxPeran;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxAktor;
        private System.Windows.Forms.DataGridView dataGridViewAktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colomAktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colomPeran;
        private System.Windows.Forms.DataGridViewButtonColumn btnHapusAktor;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBhs;
        private System.Windows.Forms.ComboBox comboBoxKelompok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDurasi;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxTambah;
        private System.Windows.Forms.TextBox textBoxTahun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.TextBox textBoxDiskonNominal;
        private System.Windows.Forms.Label label23;
    }
}