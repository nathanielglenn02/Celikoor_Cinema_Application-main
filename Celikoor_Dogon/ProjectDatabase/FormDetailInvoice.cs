
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
    public partial class FormDetailInvoice : Form
    {
        Invoice invoice;
        public FormDetailInvoice(Invoice i)
        {
            InitializeComponent();
            invoice = i;
        }

        private void FormDetailInvoice_Load(object sender, EventArgs e)
        {
            labelId.Text = invoice.Id.ToString();
            labelTanggal.Text = invoice.Tanggal.ToString();
            labelGrandTotal.Text = invoice.GrandTotal.ToString();
            labelDiskonNominal.Text = invoice.DiskonNominal.ToString();
            labelKonsumen.Text = invoice.Konsumen.Nama.ToString();
            labelKasir.Text = invoice.Kasir.Nama.ToString();
            labelStatus.Text = invoice.Status.ToString();

            foreach(Tiket t in invoice.Tiket)
            {
                dataGridView1.Rows.Add(t.Nomor_kursi, t.Status_hadir, t.Operators.Nama, t.Harga, t.Sesi_film.JadwalFilms.Tanggal.ToShortDateString(), t.Sesi_film.JadwalFilms.JamPemutaran,t.Sesi_film.Film_studios.Studios.Cinema.Nama_cabang, t.Sesi_film.Film_studios.Studios.Nama, t.Sesi_film.Film_studios.Films.Judul);
            }
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
