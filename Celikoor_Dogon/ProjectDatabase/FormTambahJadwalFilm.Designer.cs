namespace ProjectDatabase
{
    partial class FormTambahJadwalFilm
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
            this.comboBoxCinema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStudio = new System.Windows.Forms.ComboBox();
            this.labelJenisStudio = new System.Windows.Forms.Label();
            this.labelKapasitas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHargaWeekday = new System.Windows.Forms.Label();
            this.labelHargaWeekend = new System.Windows.Forms.Label();
            this.comboBoxJudul = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxI = new System.Windows.Forms.CheckBox();
            this.checkBoxII = new System.Windows.Forms.CheckBox();
            this.checkBoxIII = new System.Windows.Forms.CheckBox();
            this.checkBoxIV = new System.Windows.Forms.CheckBox();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKelompok = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAktor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDurasi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSinopsis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnJudulFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudiio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.pictureBoxSimpan = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxTambah = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBlkng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinema";
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Location = new System.Drawing.Point(105, 13);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCinema.TabIndex = 1;
            this.comboBoxCinema.SelectedIndexChanged += new System.EventHandler(this.comboBoxCinema_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Studio";
            // 
            // comboBoxStudio
            // 
            this.comboBoxStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudio.FormattingEnabled = true;
            this.comboBoxStudio.Location = new System.Drawing.Point(105, 52);
            this.comboBoxStudio.Name = "comboBoxStudio";
            this.comboBoxStudio.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStudio.TabIndex = 3;
            this.comboBoxStudio.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudio_SelectedIndexChanged);
            // 
            // labelJenisStudio
            // 
            this.labelJenisStudio.AutoSize = true;
            this.labelJenisStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJenisStudio.ForeColor = System.Drawing.SystemColors.Control;
            this.labelJenisStudio.Location = new System.Drawing.Point(62, 98);
            this.labelJenisStudio.Name = "labelJenisStudio";
            this.labelJenisStudio.Size = new System.Drawing.Size(101, 18);
            this.labelJenisStudio.TabIndex = 4;
            this.labelJenisStudio.Text = "Jenis Studio";
            this.labelJenisStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKapasitas
            // 
            this.labelKapasitas.AutoSize = true;
            this.labelKapasitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKapasitas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelKapasitas.Location = new System.Drawing.Point(172, 98);
            this.labelKapasitas.Name = "labelKapasitas";
            this.labelKapasitas.Size = new System.Drawing.Size(73, 18);
            this.labelKapasitas.TabIndex = 5;
            this.labelKapasitas.Text = "Kapasitas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(62, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weekday:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(62, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Weekend:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHargaWeekday
            // 
            this.labelHargaWeekday.AutoSize = true;
            this.labelHargaWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaWeekday.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHargaWeekday.Location = new System.Drawing.Point(172, 128);
            this.labelHargaWeekday.Name = "labelHargaWeekday";
            this.labelHargaWeekday.Size = new System.Drawing.Size(114, 18);
            this.labelHargaWeekday.TabIndex = 8;
            this.labelHargaWeekday.Text = "Harga Weekday";
            // 
            // labelHargaWeekend
            // 
            this.labelHargaWeekend.AutoSize = true;
            this.labelHargaWeekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaWeekend.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHargaWeekend.Location = new System.Drawing.Point(172, 159);
            this.labelHargaWeekend.Name = "labelHargaWeekend";
            this.labelHargaWeekend.Size = new System.Drawing.Size(115, 18);
            this.labelHargaWeekend.TabIndex = 9;
            this.labelHargaWeekend.Text = "Harga Weekend";
            // 
            // comboBoxJudul
            // 
            this.comboBoxJudul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJudul.FormattingEnabled = true;
            this.comboBoxJudul.Location = new System.Drawing.Point(105, 206);
            this.comboBoxJudul.Name = "comboBoxJudul";
            this.comboBoxJudul.Size = new System.Drawing.Size(121, 24);
            this.comboBoxJudul.TabIndex = 11;
            this.comboBoxJudul.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudul_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(18, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Judul";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(18, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tanggal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(18, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Jam";
            // 
            // checkBoxI
            // 
            this.checkBoxI.AutoSize = true;
            this.checkBoxI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxI.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxI.Location = new System.Drawing.Point(105, 294);
            this.checkBoxI.Name = "checkBoxI";
            this.checkBoxI.Size = new System.Drawing.Size(33, 20);
            this.checkBoxI.TabIndex = 15;
            this.checkBoxI.Text = "I";
            this.checkBoxI.UseVisualStyleBackColor = true;
            // 
            // checkBoxII
            // 
            this.checkBoxII.AutoSize = true;
            this.checkBoxII.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxII.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxII.Location = new System.Drawing.Point(145, 294);
            this.checkBoxII.Name = "checkBoxII";
            this.checkBoxII.Size = new System.Drawing.Size(37, 20);
            this.checkBoxII.TabIndex = 16;
            this.checkBoxII.Text = "II";
            this.checkBoxII.UseVisualStyleBackColor = true;
            // 
            // checkBoxIII
            // 
            this.checkBoxIII.AutoSize = true;
            this.checkBoxIII.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIII.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxIII.Location = new System.Drawing.Point(188, 294);
            this.checkBoxIII.Name = "checkBoxIII";
            this.checkBoxIII.Size = new System.Drawing.Size(41, 20);
            this.checkBoxIII.TabIndex = 17;
            this.checkBoxIII.Text = "III";
            this.checkBoxIII.UseVisualStyleBackColor = true;
            // 
            // checkBoxIV
            // 
            this.checkBoxIV.AutoSize = true;
            this.checkBoxIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIV.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxIV.Location = new System.Drawing.Point(235, 294);
            this.checkBoxIV.Name = "checkBoxIV";
            this.checkBoxIV.Size = new System.Drawing.Size(43, 20);
            this.checkBoxIV.TabIndex = 18;
            this.checkBoxIV.Text = "IV";
            this.checkBoxIV.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.pictureBoxPoster.Location = new System.Drawing.Point(438, 84);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(230, 381);
            this.pictureBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPoster.TabIndex = 37;
            this.pictureBoxPoster.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.labelKelompok);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.labelGenre);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.labelAktor);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labelDurasi);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.labelSinopsis);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(700, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 383);
            this.panel1.TabIndex = 38;
            // 
            // labelKelompok
            // 
            this.labelKelompok.AutoSize = true;
            this.labelKelompok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelompok.ForeColor = System.Drawing.SystemColors.Control;
            this.labelKelompok.Location = new System.Drawing.Point(141, 302);
            this.labelKelompok.Name = "labelKelompok";
            this.labelKelompok.Size = new System.Drawing.Size(76, 18);
            this.labelKelompok.TabIndex = 48;
            this.labelKelompok.Text = "Kelompok";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(17, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 18);
            this.label14.TabIndex = 47;
            this.label14.Text = "Kelompok";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGenre.Location = new System.Drawing.Point(141, 265);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(45, 18);
            this.labelGenre.TabIndex = 46;
            this.labelGenre.Text = "genre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(17, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 45;
            this.label11.Text = "Genre";
            // 
            // labelAktor
            // 
            this.labelAktor.AutoSize = true;
            this.labelAktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAktor.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAktor.Location = new System.Drawing.Point(141, 226);
            this.labelAktor.Name = "labelAktor";
            this.labelAktor.Size = new System.Drawing.Size(43, 18);
            this.labelAktor.TabIndex = 44;
            this.labelAktor.Text = "Aktor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(17, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Aktor Utama";
            // 
            // labelDurasi
            // 
            this.labelDurasi.AutoSize = true;
            this.labelDurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurasi.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDurasi.Location = new System.Drawing.Point(141, 188);
            this.labelDurasi.Name = "labelDurasi";
            this.labelDurasi.Size = new System.Drawing.Size(44, 18);
            this.labelDurasi.TabIndex = 42;
            this.labelDurasi.Text = "menit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(17, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Durasi";
            // 
            // labelSinopsis
            // 
            this.labelSinopsis.AutoSize = true;
            this.labelSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinopsis.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSinopsis.Location = new System.Drawing.Point(17, 51);
            this.labelSinopsis.Name = "labelSinopsis";
            this.labelSinopsis.Size = new System.Drawing.Size(58, 18);
            this.labelSinopsis.TabIndex = 40;
            this.labelSinopsis.Text = "sjafkjsd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(17, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Sinopsis";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnJudulFilm,
            this.ColumnTanggal,
            this.ColumnJam,
            this.ColumnCinema,
            this.ColumnStudiio,
            this.btnHapus});
            this.dataGridView1.Location = new System.Drawing.Point(31, 487);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 218);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnJudulFilm
            // 
            this.ColumnJudulFilm.HeaderText = "Judul Film";
            this.ColumnJudulFilm.MinimumWidth = 6;
            this.ColumnJudulFilm.Name = "ColumnJudulFilm";
            this.ColumnJudulFilm.ReadOnly = true;
            this.ColumnJudulFilm.Width = 125;
            // 
            // ColumnTanggal
            // 
            this.ColumnTanggal.HeaderText = "Tanggal";
            this.ColumnTanggal.MinimumWidth = 6;
            this.ColumnTanggal.Name = "ColumnTanggal";
            this.ColumnTanggal.ReadOnly = true;
            this.ColumnTanggal.Width = 125;
            // 
            // ColumnJam
            // 
            this.ColumnJam.HeaderText = "Jam";
            this.ColumnJam.MinimumWidth = 6;
            this.ColumnJam.Name = "ColumnJam";
            this.ColumnJam.ReadOnly = true;
            this.ColumnJam.Width = 125;
            // 
            // ColumnCinema
            // 
            this.ColumnCinema.HeaderText = "Cinema";
            this.ColumnCinema.MinimumWidth = 6;
            this.ColumnCinema.Name = "ColumnCinema";
            this.ColumnCinema.ReadOnly = true;
            this.ColumnCinema.Width = 125;
            // 
            // ColumnStudiio
            // 
            this.ColumnStudiio.HeaderText = "Studio";
            this.ColumnStudiio.MinimumWidth = 6;
            this.ColumnStudiio.Name = "ColumnStudiio";
            this.ColumnStudiio.ReadOnly = true;
            this.ColumnStudiio.Width = 125;
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
            this.panelAtas.Size = new System.Drawing.Size(1151, 61);
            this.panelAtas.TabIndex = 42;
            // 
            // labelAdmin
            // 
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelAdmin.Location = new System.Drawing.Point(512, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(186, 65);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "DeAdmin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(425, -10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(89, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelBlkng
            // 
            this.panelBlkng.BackColor = System.Drawing.Color.Black;
            this.panelBlkng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBlkng.Controls.Add(this.pictureBoxSimpan);
            this.panelBlkng.Controls.Add(this.pictureBoxBack);
            this.panelBlkng.Controls.Add(this.pictureBoxPoster);
            this.panelBlkng.Controls.Add(this.dataGridView1);
            this.panelBlkng.Controls.Add(this.panel1);
            this.panelBlkng.Controls.Add(this.panel2);
            this.panelBlkng.Controls.Add(this.panel4);
            this.panelBlkng.Controls.Add(this.panel5);
            this.panelBlkng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBlkng.Location = new System.Drawing.Point(0, 0);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(1151, 803);
            this.panelBlkng.TabIndex = 43;
            // 
            // pictureBoxSimpan
            // 
            this.pictureBoxSimpan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSimpan.Image = global::ProjectDatabase.Properties.Resources._52518161;
            this.pictureBoxSimpan.Location = new System.Drawing.Point(934, 727);
            this.pictureBoxSimpan.Name = "pictureBoxSimpan";
            this.pictureBoxSimpan.Size = new System.Drawing.Size(58, 54);
            this.pictureBoxSimpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSimpan.TabIndex = 51;
            this.pictureBoxSimpan.TabStop = false;
            this.pictureBoxSimpan.Click += new System.EventHandler(this.pictureBoxSimpan_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::ProjectDatabase.Properties.Resources.back_1689837_1280_removebg_preview;
            this.pictureBoxBack.Location = new System.Drawing.Point(1064, 727);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 50;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(31, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 390);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panel3.Controls.Add(this.pictureBoxTambah);
            this.panel3.Controls.Add(this.comboBoxJudul);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.checkBoxIV);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelKapasitas);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.checkBoxIII);
            this.panel3.Controls.Add(this.comboBoxCinema);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.labelJenisStudio);
            this.panel3.Controls.Add(this.labelHargaWeekend);
            this.panel3.Controls.Add(this.checkBoxII);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBoxStudio);
            this.panel3.Controls.Add(this.checkBoxI);
            this.panel3.Controls.Add(this.labelHargaWeekday);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 377);
            this.panel3.TabIndex = 43;
            // 
            // pictureBoxTambah
            // 
            this.pictureBoxTambah.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTambah.Image = global::ProjectDatabase.Properties.Resources.buttonTambah;
            this.pictureBoxTambah.Location = new System.Drawing.Point(321, 332);
            this.pictureBoxTambah.Name = "pictureBoxTambah";
            this.pictureBoxTambah.Size = new System.Drawing.Size(38, 36);
            this.pictureBoxTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTambah.TabIndex = 43;
            this.pictureBoxTambah.TabStop = false;
            this.pictureBoxTambah.Click += new System.EventHandler(this.pictureBoxTambah_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panel4.Location = new System.Drawing.Point(433, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 391);
            this.panel4.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panel5.Location = new System.Drawing.Point(696, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(428, 391);
            this.panel5.TabIndex = 49;
            // 
            // FormTambahJadwalFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 803);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelBlkng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahJadwalFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahJadwalFilm";
            this.Load += new System.EventHandler(this.FormTambahJadwalFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBlkng.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCinema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStudio;
        private System.Windows.Forms.Label labelJenisStudio;
        private System.Windows.Forms.Label labelKapasitas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHargaWeekday;
        private System.Windows.Forms.Label labelHargaWeekend;
        private System.Windows.Forms.ComboBox comboBoxJudul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxI;
        private System.Windows.Forms.CheckBox checkBoxII;
        private System.Windows.Forms.CheckBox checkBoxIII;
        private System.Windows.Forms.CheckBox checkBoxIV;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDurasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSinopsis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAktor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelKelompok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxTambah;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxSimpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJudulFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudiio;
        private System.Windows.Forms.DataGridViewButtonColumn btnHapus;
    }
}