namespace ProjectDatabase
{
    partial class FormUtamaKonsumen
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxKeluar = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxInvoice = new System.Windows.Forms.PictureBox();
            this.pictureBoxPesanTiket = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelSelamatDatang = new System.Windows.Forms.Panel();
            this.labelSelamatDatang = new System.Windows.Forms.Label();
            this.timerSelamatDatang = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeluar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesanTiket)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panelSelamatDatang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.pictureBoxKeluar);
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Controls.Add(this.pictureBoxInvoice);
            this.panel1.Controls.Add(this.pictureBoxPesanTiket);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1033);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxKeluar
            // 
            this.pictureBoxKeluar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxKeluar.Image = global::ProjectDatabase.Properties.Resources.home_icon1;
            this.pictureBoxKeluar.Location = new System.Drawing.Point(0, 289);
            this.pictureBoxKeluar.Name = "pictureBoxKeluar";
            this.pictureBoxKeluar.Size = new System.Drawing.Size(200, 71);
            this.pictureBoxKeluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKeluar.TabIndex = 5;
            this.pictureBoxKeluar.TabStop = false;
            this.pictureBoxKeluar.Click += new System.EventHandler(this.pictureBoxKeluar_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxProfile.Image = global::ProjectDatabase.Properties.Resources.profile_user_icon1;
            this.pictureBoxProfile.Location = new System.Drawing.Point(0, 218);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(200, 71);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // pictureBoxInvoice
            // 
            this.pictureBoxInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxInvoice.Image = global::ProjectDatabase.Properties.Resources.invoice_icon1;
            this.pictureBoxInvoice.Location = new System.Drawing.Point(0, 147);
            this.pictureBoxInvoice.Name = "pictureBoxInvoice";
            this.pictureBoxInvoice.Size = new System.Drawing.Size(200, 71);
            this.pictureBoxInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInvoice.TabIndex = 3;
            this.pictureBoxInvoice.TabStop = false;
            this.pictureBoxInvoice.Click += new System.EventHandler(this.pictureBoxInvoice_Click);
            // 
            // pictureBoxPesanTiket
            // 
            this.pictureBoxPesanTiket.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxPesanTiket.Image = global::ProjectDatabase.Properties.Resources.tickets_icon1;
            this.pictureBoxPesanTiket.Location = new System.Drawing.Point(0, 76);
            this.pictureBoxPesanTiket.Name = "pictureBoxPesanTiket";
            this.pictureBoxPesanTiket.Size = new System.Drawing.Size(200, 71);
            this.pictureBoxPesanTiket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPesanTiket.TabIndex = 2;
            this.pictureBoxPesanTiket.TabStop = false;
            this.pictureBoxPesanTiket.Click += new System.EventHandler(this.pictureBoxPesanTiket_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 76);
            this.panelLogo.TabIndex = 1;
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
            this.panelForm.BackgroundImage = global::ProjectDatabase.Properties.Resources.pngtree_contrast_color_rotation_effect_retro_background_picture_image_1340025;
            this.panelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelForm.Controls.Add(this.panelSelamatDatang);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1702, 1033);
            this.panelForm.TabIndex = 3;
            // 
            // panelSelamatDatang
            // 
            this.panelSelamatDatang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panelSelamatDatang.Controls.Add(this.labelSelamatDatang);
            this.panelSelamatDatang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelamatDatang.Location = new System.Drawing.Point(0, 0);
            this.panelSelamatDatang.Name = "panelSelamatDatang";
            this.panelSelamatDatang.Size = new System.Drawing.Size(1702, 76);
            this.panelSelamatDatang.TabIndex = 0;
            // 
            // labelSelamatDatang
            // 
            this.labelSelamatDatang.AutoSize = true;
            this.labelSelamatDatang.Font = new System.Drawing.Font("Magneto", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelamatDatang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.labelSelamatDatang.Location = new System.Drawing.Point(6, 5);
            this.labelSelamatDatang.Name = "labelSelamatDatang";
            this.labelSelamatDatang.Size = new System.Drawing.Size(1123, 72);
            this.labelSelamatDatang.TabIndex = 4;
            this.labelSelamatDatang.Text = "Selamat Datang di Celikoor Dogon";
            // 
            // timerSelamatDatang
            // 
            this.timerSelamatDatang.Tick += new System.EventHandler(this.timerSelamatDatang_Tick);
            // 
            // FormUtamaKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel1);
            this.Name = "FormUtamaKonsumen";
            this.Text = "FormUtamaKonsumen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUtamaKonsumen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeluar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesanTiket)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelSelamatDatang.ResumeLayout(false);
            this.panelSelamatDatang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxKeluar;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxInvoice;
        private System.Windows.Forms.PictureBox pictureBoxPesanTiket;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelSelamatDatang;
        private System.Windows.Forms.Label labelSelamatDatang;
        private System.Windows.Forms.Timer timerSelamatDatang;
    }
}