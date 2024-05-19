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
    public partial class FormInvoiceKonsumen : Form
    {
        Konsumen userLogin;
        public FormInvoiceKonsumen(Konsumen k)
        {
            InitializeComponent();
            userLogin = k;
        }
        List<Invoice> listInvoice;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormInvoiceKonsumen_Load(object sender, EventArgs e)
        {
            listInvoice = Invoice.BacaData(userLogin.Id.ToString());
            TampilDataGrid();
        }
        private void TampilDataGrid()
        {
            dataGridViewInvoice.Rows.Clear();
            foreach (Invoice i in listInvoice)
            {
                dataGridViewInvoice.Rows.Add(i.Id,i.Tanggal,i.GrandTotal,i.DiskonNominal,i.Kasir.Nama,i.Status);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewInvoice.Columns["btnDetail"].Index && e.RowIndex >= 0)
            {
                Invoice.BacaDataTiket(listInvoice[e.RowIndex]);
                FormDetailInvKons form = new FormDetailInvKons(listInvoice[e.RowIndex]);
                form.ShowDialog();
            }
        }
    }
}
