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
using System.Xml.Serialization;

namespace ProjectDatabase
{
    public partial class FormDaftarFilm : Form
    {
        public FormDaftarFilm()
        {
            InitializeComponent();
        }
        List<Film> listFilm;
        public Film selectedFilm;
        private void FormFilm_Load(object sender, EventArgs e)
        {
            listFilm = Film.BacaData("", "");

            TampilDataGrid();
        }

        private void dataGridViewFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFilm.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = dataGridViewFilm.CurrentRow.Cells["ColumnId"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "anda yakin menghapus Film id- " + kodeHapus + "?",
                    "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Film f = new Film();
                    Boolean hapus = Film.HapusData(f.Id);
                    if (hapus == true)
                    {
                        MessageBox.Show("penghapusan data berhasil");
                        FormFilm_Load(pictureBoxBack, e);
                    }
                    else
                    {
                        MessageBox.Show("penghapusan data gagal");
                    }
                }

            }
            else if (e.ColumnIndex == dataGridViewFilm.Columns["btnDetail"].Index && e.RowIndex >= 0)
            {
                FormDetailFilm formDetailFilm = new FormDetailFilm(listFilm[e.RowIndex]);
                formDetailFilm.Owner = this;
                formDetailFilm.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridViewFilm.Columns["btnUbah"].Index && e.RowIndex >= 0)
            {
                FormUbahFilm formUbahFilm = new FormUbahFilm(listFilm[e.RowIndex]);
                formUbahFilm.Owner = this;
                if(formUbahFilm.ShowDialog() == DialogResult.OK)
                {
                    FormFilm_Load(dataGridViewFilm, e);
                }
            }
        }

        private void textBoxNilaiKriteria_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFilm.Text == "Judul")
            {
                listFilm = Film.BacaDataFilter("Judul", textBoxNilaiKriteria.Text);

            }
            else if (comboBoxFilm.Text == "Tahun")
            {
                listFilm = Film.BacaDataFilter("Tahun", textBoxNilaiKriteria.Text);
            }
            else if (comboBoxFilm.Text == "Kelompok")
            {
                listFilm = Film.BacaDataFilter("Kelompok", textBoxNilaiKriteria.Text);
            }
            else if (comboBoxFilm.Text == "Genre")
            {
                listFilm = Film.BacaDataFilter("Genre", textBoxNilaiKriteria.Text);
            }
            else if (comboBoxFilm.Text == "Bahasa")
            {
                listFilm = Film.BacaDataFilter("Bahasa", textBoxNilaiKriteria.Text);
            }
            else
            {
                listFilm = Film.BacaDataFilter("Aktor", textBoxNilaiKriteria.Text);
            }
            TampilDataGrid();
        }

        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            FormTambahFilm form = new FormTambahFilm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                FormFilm_Load(pictureBoxTambah, e);
            }
        }
        private void TampilDataGrid()
        {
            dataGridViewFilm.Rows.Clear();
            foreach (Film film in listFilm)
            {
                dataGridViewFilm.Rows.Add(film.Id, film.Judul, film.Sinopsis, film.Tahun, film.Durasi, film.Kelompok.Nama, film.Bahasa, (film.IsSubIndo)?"Ya":"Tidak", film.DiskonNominal) ;
            }
        }

        private void labelNoInvoice_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
