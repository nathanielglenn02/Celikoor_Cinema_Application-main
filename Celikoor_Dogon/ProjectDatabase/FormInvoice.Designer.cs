namespace ProjectDatabase
{
    partial class FormInvoice
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
            this.panelDepan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiskonNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKonsumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKasir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUbahStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
            this.textBoxNilaiKriteria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNoInvoice = new System.Windows.Forms.Label();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDepan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelAdmin.Location = new System.Drawing.Point(585, -4);
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
            this.panelAtas.Size = new System.Drawing.Size(1269, 61);
            this.panelAtas.TabIndex = 19;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.Image = global::ProjectDatabase.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(498, -14);
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
            this.panelDepan.Controls.Add(this.dataGridViewInvoice);
            this.panelDepan.Controls.Add(this.pictureBoxBack);
            this.panelDepan.Controls.Add(this.panel1);
            this.panelDepan.Controls.Add(this.labelNoInvoice);
            this.panelDepan.Location = new System.Drawing.Point(19, 83);
            this.panelDepan.Name = "panelDepan";
            this.panelDepan.Size = new System.Drawing.Size(1211, 509);
            this.panelDepan.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(836, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Status Transaksi";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Validasi",
            "Terbayar"});
            this.comboBoxStatus.Location = new System.Drawing.Point(1024, 5);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(163, 24);
            this.comboBoxStatus.TabIndex = 21;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTanggal,
            this.ColumnGrandTotal,
            this.ColumnDiskonNominal,
            this.ColumnKonsumen,
            this.ColumnKasir,
            this.ColumnStatus,
            this.btnUbahStatus,
            this.btnDetail});
            this.dataGridViewInvoice.Location = new System.Drawing.Point(10, 136);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowHeadersWidth = 51;
            this.dataGridViewInvoice.RowTemplate.Height = 24;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(1177, 294);
            this.dataGridViewInvoice.TabIndex = 21;
            this.dataGridViewInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoice_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 125;
            // 
            // ColumnTanggal
            // 
            this.ColumnTanggal.HeaderText = "Tanggal";
            this.ColumnTanggal.MinimumWidth = 6;
            this.ColumnTanggal.Name = "ColumnTanggal";
            this.ColumnTanggal.ReadOnly = true;
            this.ColumnTanggal.Width = 125;
            // 
            // ColumnGrandTotal
            // 
            this.ColumnGrandTotal.HeaderText = "Grand Total";
            this.ColumnGrandTotal.MinimumWidth = 6;
            this.ColumnGrandTotal.Name = "ColumnGrandTotal";
            this.ColumnGrandTotal.ReadOnly = true;
            this.ColumnGrandTotal.Width = 125;
            // 
            // ColumnDiskonNominal
            // 
            this.ColumnDiskonNominal.HeaderText = "Diskon Nominal";
            this.ColumnDiskonNominal.MinimumWidth = 6;
            this.ColumnDiskonNominal.Name = "ColumnDiskonNominal";
            this.ColumnDiskonNominal.ReadOnly = true;
            this.ColumnDiskonNominal.Width = 125;
            // 
            // ColumnKonsumen
            // 
            this.ColumnKonsumen.HeaderText = "Konsumen";
            this.ColumnKonsumen.MinimumWidth = 6;
            this.ColumnKonsumen.Name = "ColumnKonsumen";
            this.ColumnKonsumen.ReadOnly = true;
            this.ColumnKonsumen.Width = 125;
            // 
            // ColumnKasir
            // 
            this.ColumnKasir.HeaderText = "Kasir";
            this.ColumnKasir.MinimumWidth = 6;
            this.ColumnKasir.Name = "ColumnKasir";
            this.ColumnKasir.ReadOnly = true;
            this.ColumnKasir.Width = 125;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 6;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 125;
            // 
            // btnUbahStatus
            // 
            this.btnUbahStatus.HeaderText = "Ubah Status";
            this.btnUbahStatus.MinimumWidth = 6;
            this.btnUbahStatus.Name = "btnUbahStatus";
            this.btnUbahStatus.ReadOnly = true;
            this.btnUbahStatus.Text = "Ubah";
            this.btnUbahStatus.UseColumnTextForButtonValue = true;
            this.btnUbahStatus.Width = 125;
            // 
            // btnDetail
            // 
            this.btnDetail.HeaderText = "Detail";
            this.btnDetail.MinimumWidth = 6;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ReadOnly = true;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseColumnTextForButtonValue = true;
            this.btnDetail.Width = 125;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::ProjectDatabase.Properties.Resources.back_1689837_1280_removebg_preview;
            this.pictureBoxBack.Location = new System.Drawing.Point(1127, 445);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(60, 54);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 20;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxKriteria);
            this.panel1.Controls.Add(this.textBoxNilaiKriteria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 33);
            this.panel1.TabIndex = 19;
            // 
            // comboBoxKriteria
            // 
            this.comboBoxKriteria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxKriteria.FormattingEnabled = true;
            this.comboBoxKriteria.Items.AddRange(new object[] {
            "Id",
            "Tanggal",
            "Grand Total",
            "Konsumen",
            "Kasir"});
            this.comboBoxKriteria.Location = new System.Drawing.Point(183, 5);
            this.comboBoxKriteria.Name = "comboBoxKriteria";
            this.comboBoxKriteria.Size = new System.Drawing.Size(118, 24);
            this.comboBoxKriteria.TabIndex = 20;
            // 
            // textBoxNilaiKriteria
            // 
            this.textBoxNilaiKriteria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNilaiKriteria.Location = new System.Drawing.Point(307, 6);
            this.textBoxNilaiKriteria.Name = "textBoxNilaiKriteria";
            this.textBoxNilaiKriteria.Size = new System.Drawing.Size(308, 22);
            this.textBoxNilaiKriteria.TabIndex = 19;
            this.textBoxNilaiKriteria.TextChanged += new System.EventHandler(this.textBoxNilaiKriteria_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Invoices";
            // 
            // labelNoInvoice
            // 
            this.labelNoInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNoInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNoInvoice.Location = new System.Drawing.Point(0, 0);
            this.labelNoInvoice.Name = "labelNoInvoice";
            this.labelNoInvoice.Size = new System.Drawing.Size(1211, 54);
            this.labelNoInvoice.TabIndex = 18;
            this.labelNoInvoice.Text = "Invoices";
            this.labelNoInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBlkng
            // 
            this.panelBlkng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBlkng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panelBlkng.Location = new System.Drawing.Point(12, 77);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(1224, 522);
            this.panelBlkng.TabIndex = 21;
            // 
            // panelBack
            // 
            this.panelBack.BackgroundImage = global::ProjectDatabase.Properties.Resources.pngtree_contrast_color_rotation_effect_retro_background_picture_image_1340025;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1269, 610);
            this.panelBack.TabIndex = 22;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 610);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelDepan);
            this.Controls.Add(this.panelBlkng);
            this.Controls.Add(this.panelBack);
            this.Name = "FormInvoice";
            this.Text = "FormInvoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDepan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelDepan;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxKriteria;
        private System.Windows.Forms.TextBox textBoxNilaiKriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNoInvoice;
        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiskonNominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKonsumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKasir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewButtonColumn btnUbahStatus;
        private System.Windows.Forms.DataGridViewButtonColumn btnDetail;
    }
}