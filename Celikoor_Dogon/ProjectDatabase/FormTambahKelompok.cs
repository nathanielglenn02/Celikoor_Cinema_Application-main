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
    public partial class FormTambahKelompok : Form
    {
        public FormTambahKelompok()
        {
            InitializeComponent();
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Kelompok k = new Kelompok();
                k.Nama = textBoxNama.Text;
                Kelompok.TambahData(k);
                MessageBox.Show("tambah data berhasil");
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

        private void FormTambahKelompok_Load(object sender, EventArgs e)
        {

        }
    }
}
