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
    public partial class FormTambahAktor : Form
    {
        public FormTambahAktor()
        {
            InitializeComponent();
        }

        private void FormTambahAktor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Aktor a = new Aktor();
                a.Nama = textBoxNama.Text;
                a.Tgl_Lahir = dateTimePickerTglLahir.Value;
                if (radioButtonFemale.Checked )
                {
                    a.Gender = "P";
                }
                else
                {
                    a.Gender = "L";
                }
                a.NegaraAsal = textBoxKota.Text;
                Aktor.TambahData(a);
                MessageBox.Show("tambah data berhasil");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tambah data. Pesan kesalahan : " + ex.Message, "informasi");
            }
            
        }

        private void panelDepan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
