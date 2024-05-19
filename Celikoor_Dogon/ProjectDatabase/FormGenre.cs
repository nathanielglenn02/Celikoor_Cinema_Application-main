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
    public partial class FormGenre : Form
    {
        public FormGenre()
        {
            InitializeComponent();
        }
        List<Genre> listGenre;
        public Genre selectedGenre;
        private void FormGenre_Load(object sender, EventArgs e)
        {
            listGenre = Genre.BacaData();
            if (listGenre.Count > 0)
            {
                dataGridViewGenre.DataSource = listGenre;

                if (dataGridViewGenre.ColumnCount == 3)
                { 

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "DELETE";
                    bcol2.Name = "btnDeleteGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewGenre.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewGenre.DataSource = null;
            }
        }

        private void dataGridViewGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewGenre.Columns["btnDeleteGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = dataGridViewGenre.CurrentRow.Cells["id"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "anda yakin menghapus " + kodeHapus + "?",
                    "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Genre.HapusData(listGenre[e.RowIndex]);
                    if (hapus == true)
                    {
                        MessageBox.Show("penghapusan data berhasil");
                        FormGenre_Load(pictureBoxBack, e);
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
            FormTambahGenre Form = new FormTambahGenre();
            if(Form.ShowDialog() == DialogResult.OK)
            {
                FormGenre_Load(pictureBoxTambah, e);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
