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
    public partial class FormDaftarKonsumen : Form
    {
        public FormDaftarKonsumen()
        {
            InitializeComponent();
        }
        List<Konsumen> listKonsumen;
        private void FormDaftarKonsumen_Load(object sender, EventArgs e)
        {
            listKonsumen = Konsumen.BacaData("", "");
            TampilDataGrid();
        }
        private void TampilDataGrid()
        {
            dataGridViewKonsumen.Rows.Clear();
            foreach (Konsumen k in listKonsumen)
            {
                dataGridViewKonsumen.Rows.Add(k.Id, k.Nama, k.Email, k. No_hp, k.Gender, k.Tgl_lahir.ToShortDateString(), k.Saldo.ToString(), 
                    k.Username);

            }
        }

        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewKonsumen.Columns["btnUbah"].Index && e.RowIndex >= 0)
            {
                FormUpdateKonsumen form = new FormUpdateKonsumen(listKonsumen[e.RowIndex]);
                form.Owner = this;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FormDaftarKonsumen_Load(dataGridViewKonsumen, e);
                }
            }

            else if (e.ColumnIndex == dataGridViewKonsumen.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = listKonsumen[e.RowIndex].Id.ToString();

                DialogResult hasil = MessageBox.Show(this, "anda yakin ingin menghapus konsumen id - " + kodeHapus + "?",
                    "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Konsumen.HapusData(listKonsumen[e.RowIndex]);
                    if (hapus == true)
                    {
                        MessageBox.Show("penghapusan data berhasil");
                        FormDaftarKonsumen_Load(dataGridViewKonsumen, e);
                    }
                    else
                    {
                        MessageBox.Show("penghapusan data gagal");
                    }
                }
            }

            else
            {
                MessageBox.Show("Data tidak ditemukan");
            }
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxId.SelectedIndex == 0)
            {
                listKonsumen = Konsumen.BacaDataFilter("nama", textBoxNama.Text);
            }
            else if (comboBoxId.SelectedIndex == 1)
            {
                listKonsumen = Konsumen.BacaDataFilter("id", textBoxNama.Text);
            }
            else if (comboBoxId.SelectedIndex == 2)
            {
                listKonsumen = Konsumen.BacaDataFilter("gender", textBoxNama.Text);
            }
            else if (comboBoxId.SelectedIndex == 3)
            {
                listKonsumen = Konsumen.BacaDataFilter("email", textBoxNama.Text);
            }
            else if (comboBoxId.SelectedIndex == 4)
            {
                listKonsumen = Konsumen.BacaDataFilter("username", textBoxNama.Text);
            }
            TampilDataGrid();
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            FormTambahKonsumen form = new FormTambahKonsumen();
            if (form.ShowDialog() == DialogResult.OK)
            {
                FormDaftarKonsumen_Load(pictureBoxTambah, e);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
