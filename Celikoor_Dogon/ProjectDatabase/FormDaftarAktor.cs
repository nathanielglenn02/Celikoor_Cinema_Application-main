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
    public partial class FormDaftarAktor : Form
    {
        public FormDaftarAktor()
        {
            InitializeComponent();
        }
        List<Aktor> listAktor;
        
        private void FormAktor_Load(object sender, EventArgs e)
        {
            listAktor = Aktor.BacaData("", "");
            if (listAktor.Count > 0)
            {
                dataGridViewAktor.DataSource = listAktor;

                if (dataGridViewAktor.ColumnCount == 5)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "UBAH";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewAktor.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "DELETE";
                    bcol2.Name = "btnDeleteGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewAktor.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewAktor.DataSource = null;
            }
        }

        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewAktor.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                FormUpdateAktor form = new FormUpdateAktor(listAktor[e.RowIndex]);
                form.Owner = this;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FormAktor_Load(dataGridViewAktor, e);
                }
            }
            
            else if (e.ColumnIndex == dataGridViewAktor.Columns["btnDeleteGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = listAktor[e.RowIndex].Id.ToString();

                DialogResult hasil = MessageBox.Show(this, "anda yakin menghapus " + kodeHapus + "?",
                    "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Aktor.HapusData(listAktor[e.RowIndex]);
                    if (hapus == true)
                    {
                        MessageBox.Show("penghapusan data berhasil");
                        FormAktor_Load(dataGridViewAktor, e);
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

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            FormTambahAktor form = new FormTambahAktor();
            if(form.ShowDialog() == DialogResult.OK)
            {
                FormAktor_Load(pictureBoxTambah, e);
            }
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFilm.SelectedIndex == 0)
            {
                listAktor = Aktor.BacaData("nama", textBoxNama.Text);
            }
            else
            {
                listAktor = Aktor.BacaData("negara_asal", textBoxNama.Text);
            }
            if (listAktor.Count > 0)
            {
                dataGridViewAktor.DataSource = listAktor;

                if (dataGridViewAktor.ColumnCount == 5)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "UBAH";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewAktor.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "DELETE";
                    bcol2.Name = "btnDeleteGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewAktor.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewAktor.DataSource = null;
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
