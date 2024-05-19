using CelikoorMaster_LIB;
using ProjectDatabase.Properties;
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
    public partial class FormGantiPasswordKonsumen : Form
    {
        public FormGantiPasswordKonsumen()
        {
            InitializeComponent();
        }
        FormUtamaKonsumen formUtamaKonsumen;

        private void buttonViewPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordBaru.UseSystemPasswordChar == false)
            {
                textBoxPasswordLama.UseSystemPasswordChar = true;
                textBoxPasswordBaru.UseSystemPasswordChar = true;
                textBoxConfirmPasswordBaru.UseSystemPasswordChar = true;
                buttonViewPassword.BackgroundImage = Resources._1;
            }
            else
            {
                textBoxPasswordLama.UseSystemPasswordChar = false;
                textBoxPasswordBaru.UseSystemPasswordChar = false;
                textBoxConfirmPasswordBaru.UseSystemPasswordChar = false;
                buttonViewPassword.BackgroundImage = Resources._2;
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGantiPasswordKonsumen_Load(object sender, EventArgs e)
        {
            formUtamaKonsumen = (FormUtamaKonsumen)this.Owner.Owner.Owner;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxPasswordBaru.Text == textBoxConfirmPasswordBaru.Text)
                {
                    Konsumen.GantiPassword(formUtamaKonsumen.userLogin, textBoxPasswordLama.Text, textBoxPasswordBaru.Text);
                    MessageBox.Show("Ganti Password Berhasil");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cek kembali password anda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
