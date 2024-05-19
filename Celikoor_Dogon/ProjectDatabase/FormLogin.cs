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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public Konsumen k;
        public Pegawai p;
        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            try
            {
                k = Konsumen.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                if (k != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    p = Pegawai.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                    if(p != null)
                    {
                        this.DialogResult = DialogResult.No;
                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show(this, "Username tidak ditemukan atau password salah");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLoginKonsumen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                pictureBoxLogin_Click(sender, e);
            }
        }
    }
}
