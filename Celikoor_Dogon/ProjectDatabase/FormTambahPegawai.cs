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
    public partial class FormTambahPegawai : Form
    {
        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai p = new Pegawai();
                p.Nama = textBoxNama.Text;
                p.Email = textBoxEmail.Text;
                p.Username = textBoxUsername.Text;
                p.Password = textBoxPassword.Text;
                p.Roles = comboBoxRole.Text;

                Pegawai.TambahData(p);
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
