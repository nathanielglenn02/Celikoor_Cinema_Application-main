using CelikoorMaster_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class FormUtamaKonsumen : Form
    {
        Form activeForm;
        public Konsumen userLogin;
        public FormUtamaKonsumen()
        {
            InitializeComponent();

        }
        public FormUtamaKonsumen(Konsumen user)
        {
            InitializeComponent();
            userLogin = user;

        }

        private void FormUtamaKonsumen_Load(object sender, EventArgs e)
        {
            x = panelSelamatDatang.Location.X + panelSelamatDatang.Size.Width;
            timerSelamatDatang.Interval = 1;
            timerSelamatDatang.Start();
        }
        private void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Form form1 = Application.OpenForms[form.DataBindings.ToString()];
            if (form1 == null)
            {
                panelSelamatDatang.Visible = false;
                activeForm = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                this.panelForm.Controls.Add(form);
                this.panelForm.Tag = form;
                form.Show();
                form.BringToFront();

            }
            else
            {
                activeForm = form;
                form.Show();
                form.BringToFront();
            }

        }

        private void pictureBoxPesanTiket_Click(object sender, EventArgs e)
        {
            FormPesanFilm form = new FormPesanFilm();
            form.Owner = this;
            OpenForm(form);
        }

        private void pictureBoxInvoice_Click(object sender, EventArgs e)
        {
            FormInvoiceKonsumen form = new FormInvoiceKonsumen(userLogin);
            form.Owner = this;
            OpenForm(form);

        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            FormProfileKosnumen form = new FormProfileKosnumen();
            form.Owner = this;
            OpenForm(form);
        }

        private void pictureBoxKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int x;
        private void timerSelamatDatang_Tick(object sender, EventArgs e)
        {
            Point panelLocation = panelSelamatDatang.Location;
            Size panelSize = panelSelamatDatang.Size;
            
            labelSelamatDatang.SetBounds(x, panelLocation.Y + (int)0.5 * panelSize.Height, 20, 20);
            x--;
            if (x < panelLocation.X - labelSelamatDatang.Width)
            {
                x = panelLocation.X + Size.Width;
            }
        }
    }
}
