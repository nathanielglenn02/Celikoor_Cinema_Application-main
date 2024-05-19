using CelikoorMaster_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class FormTambahFilm : Form
    {
        public FormTambahFilm()
        {
            InitializeComponent();
        }
        List<Aktor_film> listAktor = new List<Aktor_film>();
        List<Genre_film> listGenre = new List<Genre_film>();
        



        private void FormTambahFilm_Load(object sender, EventArgs e)
        {

            comboBoxKelompok.DataSource = Kelompok.BacaData();
            comboBoxKelompok.DisplayMember = "Nama";

            comboBoxAktor.DataSource = Aktor.BacaData();
            comboBoxAktor.DisplayMember = "Nama";

            comboBoxGenre.DataSource = Genre.BacaData();
            comboBoxGenre.DisplayMember = "Nama";

        }

        private void buttonTambahAktor_Click(object sender, EventArgs e)
        {
            Aktor_film af = new Aktor_film();
            af.Aktors = (Aktor)comboBoxAktor.SelectedItem;
            af.Peran = comboBoxPeran.Text;
            bool duplikatAktor = false;
            foreach(Aktor_film a in listAktor)
            {
                if(a.Aktors.Nama == af.Aktors.Nama)
                {
                    duplikatAktor = true;
                }
            }
            if(duplikatAktor == false)
            {
                listAktor.Add(af);
                dataGridViewAktor.Rows.Add(af.Aktors.Nama, af.Peran);
            }
            else
            {
                MessageBox.Show("Aktor sudah ditambahkan");
            }

        }

        private void buttonTambahGenre_Click(object sender, EventArgs e)
        {
            Genre_film gf = new Genre_film();
            gf.Genres = (Genre)comboBoxGenre.SelectedItem;

            bool duplikatGenre = false;
            foreach (Genre_film a in listGenre)
            {
                if (a.Genres.Nama == gf.Genres.Nama)
                {
                    duplikatGenre = true;
                }
            }
            if (duplikatGenre == false)
            {
                listGenre.Add(gf);
                dataGridViewGenre.Rows.Add(gf.Genres.Nama);
            }
            else
            {
                MessageBox.Show("Aktor sudah ditambahkan");
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Film f = new Film();
                f.Judul = textBoxJudul.Text;
                f.Sinopsis = textBox1.Text;
                f.Tahun = int.Parse(textBoxTahun.Text);
                f.Durasi = int.Parse(textBoxDurasi.Text);
                f.Kelompok = (Kelompok)comboBoxKelompok.SelectedItem;
                f.Bahasa = comboBoxBhs.Text;
                f.DiskonNominal = int.Parse(textBoxDiskonNominal.Text);
                if (radioButtonYes.Checked)
                {
                    f.IsSubIndo = true;
                }
                else
                {
                    f.IsSubIndo = false;
                };
                foreach(Aktor_film af in listAktor)
                {
                    f.TambahAktor(af.Aktors,af.Peran);
                }
                foreach (Genre_film gf in listGenre)
                {
                    f.TambahGenre(gf.Genres);
                }
               
                Film.TambahData(f,pictureBoxPoster.Image);

                MessageBox.Show("Tambah Data berhasil!");

                this.DialogResult = DialogResult.OK;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewAktor.Columns["btnHapusAktor"].Index && e.RowIndex >= 0)
            {
                listAktor.RemoveAt(e.RowIndex);
                dataGridViewAktor.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridViewGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewAktor.Columns["btnHapusGenre"].Index && e.RowIndex >= 0)
            {
                listGenre.RemoveAt(e.RowIndex);
                dataGridViewGenre.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void openFileDialogPoster_FileOk(object sender, CancelEventArgs e)
        {
            pictureBoxPoster.ImageLocation = openFileDialogPoster.FileName;
        }


        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialogPoster.ShowDialog(this);
        }
    }
}
