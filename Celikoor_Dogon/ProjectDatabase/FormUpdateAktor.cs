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
    public partial class FormUpdateAktor : Form
    {
        public FormUpdateAktor()
        {
            InitializeComponent();
        }
        Aktor aktor;
        public FormUpdateAktor(Aktor a)
        {
            InitializeComponent();
            aktor = a;
        }

        private void FormUpdateAktor_Load(object sender, EventArgs e)
        {
            textBoxNama.Text = aktor.Nama;
            if (aktor.Gender == "L")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = false;
            }
            textBoxKota.Text = aktor.NegaraAsal;
            dateTimePickerTglLahir.Value = aktor.Tgl_Lahir;
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                aktor.Nama = textBoxNama.Text;
                if (radioButtonMale.Checked)
                {
                    aktor.Gender = "L";
                }
                else
                {
                    aktor.Gender = "P";
                }
                aktor.NegaraAsal = textBoxKota.Text;
                aktor.Tgl_Lahir = dateTimePickerTglLahir.Value;
                Aktor.UbahData(aktor);
                MessageBox.Show("Ubah data aktor berhasil");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
