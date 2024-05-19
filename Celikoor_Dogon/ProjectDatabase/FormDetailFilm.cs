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
    public partial class FormDetailFilm : Form
    {
        Film film;
        public FormDetailFilm(Film f)
        {
            InitializeComponent();
            film = f;
        }

        private void FormDetailFilm_Load(object sender, EventArgs e)
        {
            textBoxJudul.Text = film.Judul;
            textBoxTahun.Text = film.Tahun.ToString();
            textBoxDurasi.Text = film.Durasi.ToString();
            textBoxKelompok.Text = film.Kelompok.Nama;
            textBoxBahasa.Text = film.Bahasa;
            textBoxDiskonNominal.Text = film.DiskonNominal.ToString();
            if (film.IsSubIndo)
            {
                radioButtonYes.Checked = true;
            }
            else
            {
                radioButtonNo.Checked = true;
            }
            textBoxSinopsis.Text = film.Sinopsis;

            foreach(Aktor_film af in film.AktorList)
            {
                dataGridViewAktor.Rows.Add(af.Aktors.Nama,af.Peran);
            }
            foreach(Genre_film gf in film.GenreList)
            {
                dataGridViewGenre.Rows.Add(gf.Genres.Nama);
            }
            pictureBoxPoster.Image = Film.BacaGambar(film.CoverImage);
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
