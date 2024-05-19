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
    public partial class FormLoginRegister : Form
    {
        public FormLoginRegister()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxLogo.Location = new Point(740, -10);
            panelBlkng.Location = new Point(665, 250);
            panelDepan.Location = new Point(669, 256);
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Owner = this;
            DialogResult result = frmLogin.ShowDialog();

            if (result == DialogResult.OK)
            {
                FormUtamaKonsumen formUtamaKonsumen = new FormUtamaKonsumen(frmLogin.k);
                formUtamaKonsumen.Show();
            }

            else if(result == DialogResult.No)
            {
                FormUtamaPegawai formUtamaPegawai = new FormUtamaPegawai(frmLogin.p);
                formUtamaPegawai.Show();
            }
        }
        private void pictureBoxRegister_Click(object sender, EventArgs e)
        {
            FormRegister frmRegister = new FormRegister();
            frmRegister.ShowDialog();
        }
    }
}
