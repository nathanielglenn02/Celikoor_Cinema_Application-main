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
    public partial class FormTambahJenisStudio : Form
    {
        public FormTambahJenisStudio()
        {
            InitializeComponent();
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                JenisStudio js = new JenisStudio();
                js.Nama = textBoxNamaJenisStudio.Text;
                js.Deskripsi = textBoxDeskripsi.Text;
                JenisStudio.TambahData(js);
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

        private void FormTambahJenisStudio_Load(object sender, EventArgs e)
        {

        }
    }
}
