namespace ProjectDatabase
{
    partial class FormOperator
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
            this.labelCekBarcode = new System.Windows.Forms.Label();
            this.panelDepan = new System.Windows.Forms.Panel();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.textBoxCekBarcode = new System.Windows.Forms.TextBox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.labelOperator = new System.Windows.Forms.Label();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.panelDepan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.panelAtas.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCekBarcode
            // 
            this.labelCekBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCekBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelCekBarcode.Location = new System.Drawing.Point(64, 13);
            this.labelCekBarcode.Name = "labelCekBarcode";
            this.labelCekBarcode.Size = new System.Drawing.Size(294, 65);
            this.labelCekBarcode.TabIndex = 0;
            this.labelCekBarcode.Text = "Cek Barcode";
            this.labelCekBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDepan
            // 
            this.panelDepan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDepan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panelDepan.Controls.Add(this.pictureBoxLogin);
            this.panelDepan.Controls.Add(this.textBoxCekBarcode);
            this.panelDepan.Controls.Add(this.labelBarcode);
            this.panelDepan.Controls.Add(this.labelCekBarcode);
            this.panelDepan.Location = new System.Drawing.Point(173, 91);
            this.panelDepan.Name = "panelDepan";
            this.panelDepan.Size = new System.Drawing.Size(430, 339);
            this.panelDepan.TabIndex = 7;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogin.Image = global::ProjectDatabase.Properties.Resources.buttonCekBar_1_;
            this.pictureBoxLogin.Location = new System.Drawing.Point(144, 173);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(146, 59);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 6;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBoxLogin_Click);
            // 
            // textBoxCekBarcode
            // 
            this.textBoxCekBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCekBarcode.Location = new System.Drawing.Point(167, 140);
            this.textBoxCekBarcode.MaxLength = 6;
            this.textBoxCekBarcode.Name = "textBoxCekBarcode";
            this.textBoxCekBarcode.Size = new System.Drawing.Size(231, 27);
            this.textBoxCekBarcode.TabIndex = 18;
            this.textBoxCekBarcode.TextChanged += new System.EventHandler(this.textBoxCekBarcode_TextChanged);
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBarcode.Location = new System.Drawing.Point(44, 142);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(96, 22);
            this.labelBarcode.TabIndex = 17;
            this.labelBarcode.Text = "Barcode :";
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panelAtas.Controls.Add(this.labelOperator);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(800, 61);
            this.panelAtas.TabIndex = 6;
            // 
            // labelOperator
            // 
            this.labelOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelOperator.Location = new System.Drawing.Point(237, -4);
            this.labelOperator.Name = "labelOperator";
            this.labelOperator.Size = new System.Drawing.Size(294, 65);
            this.labelOperator.TabIndex = 21;
            this.labelOperator.Text = "DeOperator";
            this.labelOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBlkng
            // 
            this.panelBlkng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBlkng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panelBlkng.Location = new System.Drawing.Point(168, 85);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(440, 353);
            this.panelBlkng.TabIndex = 8;
            // 
            // FormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectDatabase.Properties.Resources.pngtree_contrast_color_rotation_effect_retro_background_picture_image_1340025;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDepan);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelBlkng);
            this.Name = "FormOperator";
            this.Text = "Operator";
            this.Load += new System.EventHandler(this.Operator_Load);
            this.panelDepan.ResumeLayout(false);
            this.panelDepan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.panelAtas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCekBarcode;
        private System.Windows.Forms.Panel panelDepan;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.TextBox textBoxCekBarcode;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.Label labelOperator;
    }
}