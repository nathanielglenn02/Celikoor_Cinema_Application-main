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
    public partial class FormUpdateKonsumen : Form
    {
        Konsumen konsumen;
        public FormUpdateKonsumen(Konsumen k )
        {
            InitializeComponent();
            konsumen = k;
        }

        private void FormUpdateKonsumen_Load(object sender, EventArgs e)
        {
            textBoxNama.Text = konsumen.Nama;
            textBoxEmail.Text = konsumen.Email;
            textBoxNoHp.Text = konsumen.No_hp;
            if (konsumen.Gender == "L")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
            dateTimePicker1.Value = konsumen.Tgl_lahir;
            textBoxUsername.Text = konsumen.Username; 
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                konsumen.Nama = textBoxNama.Text;
                konsumen.Email = textBoxEmail.Text;
                konsumen.No_hp = textBoxNoHp.Text;
                if (radioButtonMale.Checked)
                {
                    konsumen.Gender = "L";
                }
                else
                {
                    konsumen.Gender = "P";
                }
                konsumen.Tgl_lahir = dateTimePicker1.Value;
                konsumen.Username = textBoxUsername.Text;
                
                Konsumen.UbahData(konsumen);
                MessageBox.Show("Ubah data konsumen berhasil");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
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
