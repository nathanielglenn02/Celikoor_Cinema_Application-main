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
    public partial class FormDaftarPegawai : Form
    {
        public FormDaftarPegawai()
        {
            InitializeComponent();
        }
        List<Pegawai> listPegawai;
        private void FormDaftarPegawai_Load(object sender, EventArgs e)
        {
            listPegawai = Pegawai.BacaData("", "");
            TampilDataGrid();
        }

        private void dataGridViewKonsumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridViewKonsumen.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = listPegawai[e.RowIndex].Id.ToString();

                DialogResult hasil = MessageBox.Show(this, "anda yakin menghapus " + kodeHapus + "?",
                    "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Pegawai.HapusData(listPegawai[e.RowIndex]);
                    if (hapus == true)
                    {
                        MessageBox.Show("penghapusan data berhasil");
                        FormDaftarPegawai_Load(dataGridViewKonsumen, e);
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
        private void TampilDataGrid()
        {
            dataGridViewKonsumen.Rows.Clear();
            foreach (Pegawai pegawai in listPegawai)
            {
                dataGridViewKonsumen.Rows.Add(pegawai.Id, pegawai.Nama, pegawai.Email, pegawai.Username, pegawai.Roles);
            }
        }
        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxId.SelectedIndex == 0)
            {
                listPegawai = Pegawai.BacaData("Id", textBoxNama.Text);
            }
            else if (comboBoxId.SelectedIndex == 1)
            {
                listPegawai = Pegawai.BacaData("Nama", textBoxNama.Text);
            }
            else if (comboBoxId.SelectedIndex == 2)
            {
                listPegawai = Pegawai.BacaData("Email", textBoxNama.Text);
            }
            else if (comboBoxId.SelectedIndex == 3)
            {
                listPegawai = Pegawai.BacaData("Username", textBoxNama.Text);
            }
            else if (comboBoxId.SelectedIndex == 4)
            {
                listPegawai = Pegawai.BacaData("Roles", textBoxNama.Text);
            }
            TampilDataGrid();
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai form = new FormTambahPegawai();
            if(form.ShowDialog() == DialogResult.OK)
            {
                FormDaftarPegawai_Load(pictureBoxBack, e);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
