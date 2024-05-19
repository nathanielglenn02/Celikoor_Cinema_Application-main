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
    public partial class FormTambahStudio : Form
    {
        public FormTambahStudio()
        {
            InitializeComponent();
        }

        private void FormTambahStudio_Load(object sender, EventArgs e)
        {
            List<JenisStudio> listJenisStudio = JenisStudio.BacaData();

            comboBoxJenis.DataSource = listJenisStudio;
            comboBoxJenis.DisplayMember = "Nama";

            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "Nama_cabang";
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Studio s = new Studio();
                s.Nama = textBoxNama.Text;
                s.Kapasitas = int.Parse(textBoxKapasitas.Text);
                s.JenisStudio = (JenisStudio)comboBoxJenis.SelectedItem;
                s.Cinema = (Cinema)comboBoxCinema.SelectedItem;
                s.HargaWeekday = int.Parse(textBoxHargaDay.Text);
                s.HargaWeekend = int.Parse(textBoxHargaEnd.Text);

                Studio.TambahData(s);
                MessageBox.Show("Tambah Data Berhasil");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
