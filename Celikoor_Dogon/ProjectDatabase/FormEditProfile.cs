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
    public partial class FormEditProfile : Form
    {
        FormUtamaKonsumen formUtamaKonsumen;

        public FormEditProfile()
        {
            InitializeComponent();

        }
        //FormKonsumen frmKonsumen;
        private void EditProfile_Load(object sender, EventArgs e)
        {
            formUtamaKonsumen = (FormUtamaKonsumen)this.Owner.Owner;
            textBoxNama.Text = formUtamaKonsumen.userLogin.Nama;
            textBoxEmail.Text = formUtamaKonsumen.userLogin.Email;
            textBoxNoHp.Text = formUtamaKonsumen.userLogin.No_hp;
            dateTimePicker1.Value = formUtamaKonsumen.userLogin.Tgl_lahir;
            if (formUtamaKonsumen.userLogin.Gender == "L")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }

        }

        private void pictureBoxSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                formUtamaKonsumen.userLogin.Nama = textBoxNama.Text;
                formUtamaKonsumen.userLogin.Email = textBoxEmail.Text;
                formUtamaKonsumen.userLogin.No_hp = textBoxNoHp.Text;
                formUtamaKonsumen.userLogin.Tgl_lahir = dateTimePicker1.Value;
                if (radioButtonMale.Checked)
                {
                    formUtamaKonsumen.userLogin.Gender = "L";
                }
                else
                {
                    formUtamaKonsumen.userLogin.Gender = "P";
                }
                Konsumen.UbahData(formUtamaKonsumen.userLogin);
                MessageBox.Show("Ubah data Berhasil");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormGantiPasswordKonsumen form = new FormGantiPasswordKonsumen();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
