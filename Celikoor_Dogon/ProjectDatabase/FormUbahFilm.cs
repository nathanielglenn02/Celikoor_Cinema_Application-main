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
    public partial class FormUbahFilm : Form
    {
        Film film;
        bool gantiImage = false;
        public FormUbahFilm(Film f)
        {
            InitializeComponent();
            film = f;
        }

        private void FormUbahFilm_Load(object sender, EventArgs e)
        {
            textBoxJudul.Text = film.Judul;
            textBoxDurasi.Text = film.Durasi.ToString();
            textBoxTahun.Text = film.Tahun.ToString();
            textBoxDiskonNominal.Text = film.DiskonNominal.ToString();

            comboBoxKelompok.DataSource = Kelompok.BacaData();
            comboBoxKelompok.DisplayMember = "Nama";
            comboBoxKelompok.SelectedItem = film.Kelompok;

            comboBoxBhs.SelectedItem = film.Bahasa;
            if(film.IsSubIndo == true)
            {
                radioButtonYes.Checked = true;
                radioButtonNo.Checked = false;
            }
            else
            {
                radioButtonYes.Checked = false;
                radioButtonNo.Checked = true;
            }

            textBoxSinopsis.Text = film.Sinopsis;
            pictureBoxPoster.Image = Film.BacaGambar(film.CoverImage);

            TampilDataGridAktor();
            TampilDataGridGenre();

            comboBoxAktor.DataSource = Aktor.BacaData();
            comboBoxAktor.DisplayMember = "Nama";

            comboBoxGenre.DataSource = Genre.BacaData();
            comboBoxGenre.DisplayMember = "Nama";
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialogPoster.ShowDialog(this);
        }

        private void openFileDialogPoster_FileOk(object sender, CancelEventArgs e)
        {
            pictureBoxPoster.ImageLocation = openFileDialogPoster.FileName;
            gantiImage = true;
        }
        private void TampilDataGridAktor()
        {
            dataGridViewAktor.Rows.Clear();
            foreach(Aktor_film af in film.AktorList)
            {
                dataGridViewAktor.Rows.Add(af.Aktors.Nama, af.Peran);
            }
        }
        private void TampilDataGridGenre()
        {
            dataGridViewGenre.Rows.Clear();
            foreach (Genre_film gf in film.GenreList)
            {
                dataGridViewGenre.Rows.Add(gf.Genres.Nama);
            }
        }

        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewAktor.Columns["btnHapusAktor"].Index && e.RowIndex >= 0)
            {
                film.AktorList.RemoveAt(e.RowIndex);
                dataGridViewAktor.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridViewGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewGenre.Columns["btnHapusGenre"].Index && e.RowIndex >= 0)
            {
                film.GenreList.RemoveAt(e.RowIndex);
                dataGridViewGenre.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void buttonTambahAktor_Click(object sender, EventArgs e)
        {
            Aktor selectedAktor = (Aktor)comboBoxAktor.SelectedItem;
            dataGridViewAktor.Rows.Add(selectedAktor.Nama, comboBoxPeran.Text);
            Aktor_film af = new Aktor_film();
            af.Films = film;
            af.Aktors = selectedAktor;
            af.Peran = comboBoxPeran.Text;
            film.AktorList.Add(af);
        }

        private void buttonTambahGenre_Click(object sender, EventArgs e)
        {
            Genre selectedGenre = (Genre)comboBoxGenre.SelectedItem;
            dataGridViewGenre.Rows.Add(selectedGenre.Nama);
            Genre_film gf = new Genre_film();
            gf.Films = film;
            gf.Genres = selectedGenre;
            film.GenreList.Add(gf);
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                film.Judul = textBoxJudul.Text;
                film.Tahun = int.Parse(textBoxTahun.Text);
                film.Durasi = int.Parse(textBoxDurasi.Text);
                film.Kelompok = (Kelompok)comboBoxKelompok.SelectedItem;
                film.Bahasa = comboBoxBhs.Text;
                film.DiskonNominal = double.Parse(textBoxDiskonNominal.Text);
                if(radioButtonYes.Checked )
                {
                    film.IsSubIndo = true;
                }
                else
                {
                    film.IsSubIndo = false;
                }
                film.Sinopsis = textBoxSinopsis.Text;
                if (gantiImage)
                {
                    Film.UpdateData(film, pictureBoxPoster.Image);
                }
                else
                {
                    Film.UpdateData(film);
                }
                MessageBox.Show("data berhasil diubah");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
