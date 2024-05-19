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
    public partial class FormTambahJadwalFilm : Form
    {
        public FormTambahJadwalFilm()
        {
            InitializeComponent();
        }
        List<Sesi_films> sesiFilmList = new List<Sesi_films>();
        private void FormTambahJadwalFilm_Load(object sender, EventArgs e)
        {
            comboBoxStudio.Enabled = false;
            comboBoxCinema.DataSource = Cinema.BacaData();
            comboBoxCinema.DisplayMember = "Nama_cabang";
            
            comboBoxJudul.DataSource = Film.BacaData();
            comboBoxJudul.DisplayMember = "Judul";

            dateTimePicker1.MinDate = DateTime.Now;

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxJudul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxJudul.SelectedIndex != -1)
            {
                Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                labelSinopsis.Text = selectedFilm.Sinopsis;
                labelDurasi.Text = selectedFilm.Durasi.ToString() + " menit";

                if (selectedFilm.AktorList.Count > 2)
                {
                    labelAktor.Text = selectedFilm.AktorList[0].Aktors.Nama + ", " + selectedFilm.AktorList[1].Aktors.Nama + ", ...";
                }
                else if (selectedFilm.AktorList.Count == 2)
                {
                    labelAktor.Text = selectedFilm.AktorList[0].Aktors.Nama + ", " + selectedFilm.AktorList[1].Aktors.Nama;
                }
                else if (selectedFilm.AktorList.Count == 1)
                {
                    labelAktor.Text = selectedFilm.AktorList[0].Aktors.Nama;
                }

                pictureBoxPoster.Image = Film.BacaGambar(selectedFilm.CoverImage);
                List<string>listGenre = new List<string>();
                foreach(Genre_film gf in selectedFilm.GenreList)
                {
                    listGenre.Add(gf.Genres.Nama);
                }
                labelGenre.Text = string.Join(",",listGenre);

                labelKelompok.Text = selectedFilm.Kelompok.Nama;


            }
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCinema.SelectedIndex != -1)
            {
                comboBoxStudio.DataSource = Studio.BacaData("s.cinemas_id", ((Cinema)comboBoxCinema.SelectedItem).Id.ToString());
                comboBoxStudio.DisplayMember = "Nama";
                comboBoxStudio.Enabled = true;
            }
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxStudio.SelectedIndex != -1)
            {
                Studio selectedStudio = (Studio)comboBoxStudio.SelectedItem;
                labelJenisStudio.Text = selectedStudio.JenisStudio.Nama;
                labelKapasitas.Text = selectedStudio.Kapasitas.ToString() + " kursi";
                labelHargaWeekday.Text = "Rp" + selectedStudio.HargaWeekday.ToString() + ",-";
                labelHargaWeekend.Text = "Rp" + selectedStudio.HargaWeekend.ToString() + ",-";
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            Studio s = (Studio)comboBoxStudio.SelectedItem;
            Film f = (Film)comboBoxJudul.SelectedItem;
            DateTime tanggal = dateTimePicker1.Value;
            string sesi;
            if (checkBoxI.Checked)
            {
                sesi = "I";
                Film_studio fs = new Film_studio(f, s);
                JadwalFilm jf = new JadwalFilm(tanggal, sesi);
                sesiFilmList.Add(new Sesi_films(fs, jf));
                dataGridView1.Rows.Add(f.Judul, s.Cinema.Nama_cabang, s.Nama, tanggal.ToShortDateString(), sesi);
            }
            if (checkBoxII.Checked)
            {
                sesi = "II";
                Film_studio fs = new Film_studio(f, s);
                JadwalFilm jf = new JadwalFilm(tanggal, sesi);
                sesiFilmList.Add(new Sesi_films(fs, jf));
                dataGridView1.Rows.Add(f.Judul, s.Cinema.Nama_cabang, s.Nama, tanggal.ToShortDateString(), sesi);
            }
            if (checkBoxIII.Checked)
            {
                sesi = "III";
                Film_studio fs = new Film_studio(f, s);
                JadwalFilm jf = new JadwalFilm(tanggal, sesi);
                sesiFilmList.Add(new Sesi_films(fs, jf));
                dataGridView1.Rows.Add(f.Judul, s.Cinema.Nama_cabang, s.Nama, tanggal.ToShortDateString(), sesi);
            }
            if (checkBoxIV.Checked)
            {
                sesi = "IV";
                Film_studio fs = new Film_studio(f, s);
                JadwalFilm jf = new JadwalFilm(tanggal, sesi);
                sesiFilmList.Add(new Sesi_films(fs, jf));
                dataGridView1.Rows.Add(f.Judul, s.Cinema.Nama_cabang, s.Nama, tanggal.ToShortDateString(), sesi);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                sesiFilmList.RemoveAt(e.RowIndex);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void pictureBoxSimpan_Click(object sender, EventArgs e)
        {
            foreach(Sesi_films sf in sesiFilmList)
            {
                Sesi_films.TambahData(sf);
            }
            MessageBox.Show("Tambah Data berhasil");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
