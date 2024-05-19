﻿namespace ProjectDatabase
{
    partial class FormUpdateStudio
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
            this.comboBoxCinema = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxJenis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHargaEnd = new System.Windows.Forms.TextBox();
            this.textBoxKapasitas = new System.Windows.Forms.TextBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxTambah = new System.Windows.Forms.PictureBox();
            this.textBoxHargaDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panelDepan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).BeginInit();
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
            this.panelAtas.Size = new System.Drawing.Size(800, 61);
            this.panelAtas.TabIndex = 15;
            // 
            // labelAdmin
            // 
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelAdmin.Location = new System.Drawing.Point(339, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(186, 65);
            this.labelAdmin.TabIndex = 3;
            this.labelAdmin.Text = "DeAdmin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAdmin.Click += new System.EventHandler(this.labelAdmin_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(252, -10);
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
            this.panelBack.Size = new System.Drawing.Size(800, 475);
            this.panelBack.TabIndex = 16;
            // 
            // panelDepan
            // 
            this.panelDepan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panelDepan.Controls.Add(this.comboBoxCinema);
            this.panelDepan.Controls.Add(this.label7);
            this.panelDepan.Controls.Add(this.comboBoxJenis);
            this.panelDepan.Controls.Add(this.label6);
            this.panelDepan.Controls.Add(this.label5);
            this.panelDepan.Controls.Add(this.label3);
            this.panelDepan.Controls.Add(this.textBoxHargaEnd);
            this.panelDepan.Controls.Add(this.textBoxKapasitas);
            this.panelDepan.Controls.Add(this.pictureBoxBack);
            this.panelDepan.Controls.Add(this.pictureBoxTambah);
            this.panelDepan.Controls.Add(this.textBoxHargaDay);
            this.panelDepan.Controls.Add(this.label4);
            this.panelDepan.Controls.Add(this.label2);
            this.panelDepan.Controls.Add(this.textBoxNama);
            this.panelDepan.Controls.Add(this.label1);
            this.panelDepan.Location = new System.Drawing.Point(161, 38);
            this.panelDepan.Name = "panelDepan";
            this.panelDepan.Size = new System.Drawing.Size(479, 399);
            this.panelDepan.TabIndex = 6;
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBoxCinema.FormattingEnabled = true;
            this.comboBoxCinema.Location = new System.Drawing.Point(184, 148);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(231, 28);
            this.comboBoxCinema.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(83, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cinema:";
            // 
            // comboBoxJenis
            // 
            this.comboBoxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBoxJenis.FormattingEnabled = true;
            this.comboBoxJenis.Location = new System.Drawing.Point(184, 115);
            this.comboBoxJenis.Name = "comboBoxJenis";
            this.comboBoxJenis.Size = new System.Drawing.Size(231, 28);
            this.comboBoxJenis.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(40, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Jenis Studio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(77, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Weekend";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(77, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Weekday";
            // 
            // textBoxHargaEnd
            // 
            this.textBoxHargaEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHargaEnd.Location = new System.Drawing.Point(184, 238);
            this.textBoxHargaEnd.Name = "textBoxHargaEnd";
            this.textBoxHargaEnd.Size = new System.Drawing.Size(231, 27);
            this.textBoxHargaEnd.TabIndex = 27;
            // 
            // textBoxKapasitas
            // 
            this.textBoxKapasitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKapasitas.Location = new System.Drawing.Point(184, 83);
            this.textBoxKapasitas.Name = "textBoxKapasitas";
            this.textBoxKapasitas.Size = new System.Drawing.Size(231, 27);
            this.textBoxKapasitas.TabIndex = 26;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::ProjectDatabase.Properties.Resources.back_1689837_1280_removebg_preview;
            this.pictureBoxBack.Location = new System.Drawing.Point(366, 307);
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
            this.pictureBoxTambah.Location = new System.Drawing.Point(51, 307);
            this.pictureBoxTambah.Name = "pictureBoxTambah";
            this.pictureBoxTambah.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTambah.TabIndex = 11;
            this.pictureBoxTambah.TabStop = false;
            this.pictureBoxTambah.Click += new System.EventHandler(this.pictureBoxTambah_Click);
            // 
            // textBoxHargaDay
            // 
            this.textBoxHargaDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHargaDay.Location = new System.Drawing.Point(184, 205);
            this.textBoxHargaDay.Name = "textBoxHargaDay";
            this.textBoxHargaDay.Size = new System.Drawing.Size(231, 27);
            this.textBoxHargaDay.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(36, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Harga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(62, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kapasitas:";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(184, 51);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(231, 27);
            this.textBoxNama.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nama Studio:";
            // 
            // panelBlkng
            // 
            this.panelBlkng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panelBlkng.Location = new System.Drawing.Point(156, 32);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(489, 413);
            this.panelBlkng.TabIndex = 7;
            // 
            // FormUpdateStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panelAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateStudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateStudio";
            this.Load += new System.EventHandler(this.FormUpdateStudio_Load);
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelDepan.ResumeLayout(false);
            this.panelDepan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTambah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.ComboBox comboBoxCinema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxJenis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelDepan;
        private System.Windows.Forms.TextBox textBoxHargaEnd;
        private System.Windows.Forms.TextBox textBoxKapasitas;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxTambah;
        private System.Windows.Forms.TextBox textBoxHargaDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Label labelAdmin;
    }
}