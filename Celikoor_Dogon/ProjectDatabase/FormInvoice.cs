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
    public partial class FormInvoice : Form
    {
        public FormInvoice(Pegawai p)
        {
            InitializeComponent();
            userLogin = p;
        }
        List<Invoice> listInvoice;
        Pegawai userLogin;
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            comboBoxKriteria.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
            TampilDataGrid();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewInvoice.Columns["btnUbahStatus"].Index && e.RowIndex >= 0)
            {
                Invoice selectedInvoice = listInvoice[e.RowIndex];
                if (selectedInvoice.Status == "PENDING")
                {
                    DialogResult hasil = MessageBox.Show(this, "anda yakin ingin memvalidasi transaksi id = " + selectedInvoice.Id + "?",
                    "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hasil == DialogResult.Yes)
                    {
                        selectedInvoice.Kasir = userLogin;
                        Boolean updateValidasi = Invoice.UpdateDataValidasi(selectedInvoice);
                        if (updateValidasi == true)
                        {
                            MessageBox.Show("update data berhasil");
                            textBoxNilaiKriteria_TextChanged(dataGridViewInvoice, e);
                        }
                        else
                        {
                            MessageBox.Show("penghapusan data gagal");
                        }
                    }
                }
                else if (selectedInvoice.Status == "VALIDASI")
                {
                    DialogResult hasil = MessageBox.Show(this, "anda yakin ingin mengubah status TERBAYAR transaksi id = " + selectedInvoice.Id + "?",
                    "Terbayar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hasil == DialogResult.Yes)
                    {
                        Boolean updateTerbayar = Invoice.UpdateDataTerbayar(selectedInvoice);
                        if (updateTerbayar == true)
                        {
                            MessageBox.Show("update data berhasil");
                            textBoxNilaiKriteria_TextChanged(dataGridViewInvoice, e);
                        }
                        else
                        {
                            MessageBox.Show("penghapusan data gagal");
                        }
                    }
                }
            }
            if (e.ColumnIndex == dataGridViewInvoice.Columns["btnDetail"].Index && e.RowIndex >= 0)
            {
                Invoice.BacaDataTiket(listInvoice[e.RowIndex]);
                FormDetailInvoice form = new FormDetailInvoice(listInvoice[e.RowIndex]);
                form.ShowDialog();
            }
        }

        private void TampilDataGrid()
        {
            dataGridViewInvoice.Rows.Clear();

            string kriteria = "";
            string nilaiKriteria = "";

            string status = "";
            string nilaiStatus = "";

            if (comboBoxKriteria.SelectedIndex == 0)
            {
                kriteria = "i.id";
                nilaiKriteria = textBoxNilaiKriteria.Text;
            }
            else if (comboBoxKriteria.SelectedIndex == 1)
            {
                kriteria = "i.tanggal";
                nilaiKriteria = textBoxNilaiKriteria.Text;
            }
            else if (comboBoxKriteria.SelectedIndex == 2)
            {
                kriteria = "i.grand_total";
                nilaiKriteria = textBoxNilaiKriteria.Text;
            }
            else if (comboBoxKriteria.SelectedIndex == 3)
            {
                kriteria = "k.nama";
                nilaiKriteria = textBoxNilaiKriteria.Text;
            }
            else
            {
                kriteria = "p.nama";
                nilaiKriteria = textBoxNilaiKriteria.Text;
            }

            if(comboBoxStatus.SelectedIndex == 0)
            {
                status = "i.status";
                nilaiStatus = "";
            }
            else if (comboBoxStatus.SelectedIndex == 1)
            {
                status = "i.status";
                nilaiStatus = "PENDING";
            }
            else if (comboBoxStatus.SelectedIndex == 2)
            {
                status = "i.status";
                nilaiStatus = "VALIDASI";

            }
            else if (comboBoxStatus.SelectedIndex == 3)
            {
                status = "i.status";
                nilaiStatus = "TERBAYAR";
            }

            listInvoice = Invoice.BacaData(status, nilaiStatus, kriteria, nilaiKriteria);
            foreach (Invoice i in listInvoice)
            {
                dataGridViewInvoice.Rows.Add(i.Id, i.Tanggal.ToShortDateString(), i.GrandTotal, i.DiskonNominal, i.Konsumen.Nama, i.Kasir.Nama, i.Status);
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilDataGrid();

        }

        private void textBoxNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            TampilDataGrid();
        }
    }
}
