using CelikoorMaster_LIB;
using ProjectDatabase.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        private void pictureBoxRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text == textBoxConfirmPass.Text)
                {
                    Konsumen k = new Konsumen();
                    k.Nama = textBoxNama.Text;
                    k.Email = textBoxEmail.Text;
                    k.No_hp = textBoxNoHp.Text;
                    if(radioButtonMale.Checked )
                    {
                        k.Gender = "L";
                    }
                    else
                    {
                        k.Gender = "P";
                    }
                    k.Tgl_lahir = dateTimePicker1.Value;
                    k.Username = textBoxUsername.Text;
                    k.Password = textBoxPassword.Text;
                    if(k.Password == textBoxConfirmPass.Text )
                    {
                        Konsumen.TambahData(k);
                        MessageBox.Show("Register berhasil");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Register gagal");
                    }
                }
                else
                {
                    MessageBox.Show("Cek kembali password anda");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void buttonViewPassword_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.UseSystemPasswordChar == false)
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxConfirmPass.UseSystemPasswordChar = true;
                buttonViewPassword.BackgroundImage = Resources._1;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar= false;
                textBoxConfirmPass.UseSystemPasswordChar = false;
                buttonViewPassword.BackgroundImage = Resources._2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBoxRegister_Click(sender, e);
            }
        }
    }
}
