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
    public partial class FormOperator : Form
    {
        public FormOperator(Pegawai p)
        {
            InitializeComponent();
            user = p;
        }
        public Pegawai user;
        private void Operator_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            textBoxCekBarcode_TextChanged(sender, e);
        }

        private void textBoxCekBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCekBarcode.Text.Length == textBoxCekBarcode.MaxLength)
                {
                    string barcode = textBoxCekBarcode.Text;
                    Tiket t = new Tiket();
                    t.Invoices.Id = int.Parse(barcode.Substring(0, 3).TrimStart('0'));
                    t.Nomor_kursi = barcode.Substring(3, 3);

                    if (Tiket.AbsenCustomers(t, user) == true)
                    {
                        MessageBox.Show("update absen berhasil");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
