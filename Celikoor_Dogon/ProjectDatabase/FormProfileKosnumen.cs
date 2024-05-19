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
    public partial class FormProfileKosnumen : Form
    {
        public FormProfileKosnumen()
        {
            InitializeComponent();
        }


        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        FormUtamaKonsumen formUtamaKonsumen;

        private void ProfileKosnumen_Load(object sender, EventArgs e)
        {
            formUtamaKonsumen = (FormUtamaKonsumen)this.Owner;

            labelInputNama.Text = formUtamaKonsumen.userLogin.Nama;
            labelInputEmail.Text = formUtamaKonsumen.userLogin.Email;
            labelInputHp.Text = formUtamaKonsumen.userLogin.No_hp;
            labelInputGender.Text = formUtamaKonsumen.userLogin.Gender;
            labelInputTglLahir.Text = formUtamaKonsumen.userLogin.Tgl_lahir.ToShortDateString();
            labelInputSaldo.Text = formUtamaKonsumen.userLogin.Saldo.ToString();
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            FormEditProfile frmEditProfile = new FormEditProfile();
            frmEditProfile.Owner = this;
            if (frmEditProfile.ShowDialog() == DialogResult.OK)
            {
                ProfileKosnumen_Load(pictureBoxEdit, e);
            }
        }
    }
}
