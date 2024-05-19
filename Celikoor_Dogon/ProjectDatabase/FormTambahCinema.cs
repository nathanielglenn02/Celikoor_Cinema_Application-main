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
    public partial class FormTambahCinema : Form
    {
        public FormTambahCinema()
        {
            InitializeComponent();
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Cinema c = new Cinema();
                c.Nama_cabang = textBoxNama.Text;
                c.Alamat = textBoxAlamat.Text;
                c.Tgl_dibuka = dateTimePicker1.Value;
                c.Kota = textBoxKota.Text;
                
                Cinema.TambahData(c);
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
