using CelikoorMaster_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class FormUpdateStudio : Form
    {
        Studio studio;
        public FormUpdateStudio(Studio s)
        {
            InitializeComponent();
            studio = s;
        }
        
        
        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                studio.Nama = textBoxNama.Text;
                studio.Kapasitas = int.Parse(textBoxKapasitas.Text);
                studio.JenisStudio = (JenisStudio)comboBoxJenis.SelectedItem;
                studio.Cinema = (Cinema)comboBoxCinema.SelectedItem;
                studio.HargaWeekday = int.Parse(textBoxHargaDay.Text);
                studio.HargaWeekend = int.Parse(textBoxHargaEnd.Text);
                Studio.UpdateData(studio);
                MessageBox.Show("Update Berhasil");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormUpdateStudio_Load(object sender, EventArgs e)
        {
            
            textBoxNama.Text = studio.Nama;
            textBoxKapasitas.Text = studio.Kapasitas.ToString();
            List<JenisStudio> listJenis = JenisStudio.BacaData();
            comboBoxJenis.DataSource = listJenis;
            comboBoxJenis.DisplayMember = "Nama";
            comboBoxJenis.SelectedItem = studio.JenisStudio;
            foreach(JenisStudio j in listJenis)
            {
                if(j.Id == studio.JenisStudio.Id)
                {
                    comboBoxJenis.SelectedItem = j;
                }
            }
            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "Nama_cabang";
            foreach(Cinema c in listCinema)
            {
                if(c.Id == studio.Cinema.Id)
                {
                    comboBoxCinema.SelectedItem = c;
                }
            }
            textBoxHargaDay.Text = studio.HargaWeekday.ToString();
            textBoxHargaEnd.Text = studio.HargaWeekend.ToString();
        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
