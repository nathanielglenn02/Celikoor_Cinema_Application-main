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
    public partial class FormTambahGenre : Form
    {
        public FormTambahGenre()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTambahGenre_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Genre g = new Genre();
                g.Nama = textBoxNama.Text;
                g.Deskripsi = textBoxDeskripsi.Text;
                Genre.TambahData(g);
                MessageBox.Show("tambah data berhasil");
                DialogResult = DialogResult.OK;
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
