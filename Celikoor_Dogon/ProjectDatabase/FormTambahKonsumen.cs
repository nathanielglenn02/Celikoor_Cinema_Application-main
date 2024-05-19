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
    public partial class FormTambahKonsumen : Form
    {
        public FormTambahKonsumen()
        {
            InitializeComponent();
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Konsumen k = new Konsumen();
                k.Nama = textBoxNama.Text;
                k.Email = textBoxEmail.Text;
                k.No_hp = textBoxNoHp.Text;
                if (radioButtonFemale.Checked )
                {
                    k.Gender = "P";
                }
                else
                {
                    k.Gender = "L";
                }
                k.Tgl_lahir = dateTimePicker1.Value;
                k.Username = textBoxUsername.Text;
                k.Password = textBoxPassword.Text;
                Konsumen.TambahData(k);
                MessageBox.Show("tambah data berhasil");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tambah data. Pesan kesalahan : " + ex.Message, "informasi");
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
