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
    public partial class FormPesanFilm : Form
    {
        List<Sesi_films> sesiFilmList;
        List<Sesi_films> sesiFilmAvailableList;
        public List<string> listKursi;
        Sesi_films selectedSesi;
        FormUtamaKonsumen formUtamaKonsumen;
        public FormPesanFilm()
        {
            InitializeComponent();
        }

        private void pictureBoxPilih_Click(object sender, EventArgs e)
        {
            if(comboBoxJam.SelectedIndex != -1)
            {
                FormPilihSeat pilihSeat = new FormPilihSeat(selectedSesi);
                pilihSeat.Owner = this;
                pilihSeat.ShowDialog();

                labelListKursi.Text = String.Join(", ", listKursi);

                int total;
                if(listKursi.Count != 0)
                {
                    if(dateTimePicker1.Value.ToString("dddd") == "Saturday" ||  dateTimePicker1.Value.ToString("dddd") == "Sunday")
                    {
                        total = listKursi.Count * selectedSesi.Film_studios.Studios.HargaWeekend;
                        labelHargaTotal.Text = total.ToString(); 
                    }
                    else
                    {
                        total = listKursi.Count * selectedSesi.Film_studios.Studios.HargaWeekday;
                        labelHargaTotal.Text = total.ToString();
                    }
                    labelHargaAkhir.Text = (total - (int)selectedSesi.Film_studios.Films.DiskonNominal).ToString();
                }
                else
                {
                    MessageBox.Show("Pilih Jam terlebih dahulu");
                    labelHarga.Text = "0";
                }                
            }
        }

        private void comboBoxJudul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxJudul.SelectedIndex != -1)
            {
                BacaDataCinema();

                Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
                labelSinopsis.Text = selectedFilm.Sinopsis;
                labelDurasi.Text = selectedFilm.Durasi.ToString() + " menit";
                
                if(selectedFilm.AktorList.Count > 2)
                {
                    labelAktor.Text = selectedFilm.AktorList[0].Aktors.Nama + ", " + selectedFilm.AktorList[1].Aktors.Nama + ", ...";
                }
                else if (selectedFilm.AktorList.Count == 2)
                {
                    labelAktor.Text = selectedFilm.AktorList[0].Aktors.Nama + ", " + selectedFilm.AktorList[1].Aktors.Nama;
                }
                else if(selectedFilm.AktorList.Count == 1)
                {
                    labelAktor.Text = selectedFilm.AktorList[0].Aktors.Nama;
                }
                
                pictureBox12.Image = Film.BacaGambar(selectedFilm.CoverImage);
                List<string> listGenre = new List<string>();
                foreach (Genre_film gf in selectedFilm.GenreList)
                {
                    listGenre.Add(gf.Genres.Nama);
                }
                labelGenre.Text = string.Join(",", listGenre);

                labelKelompok.Text = selectedFilm.Kelompok.Nama;

                labelDiskonHarga.Text = selectedFilm.DiskonNominal.ToString();
            }
        }

        private void FormPesanFilm_Load(object sender, EventArgs e)
        {
            formUtamaKonsumen = (FormUtamaKonsumen)this.Owner;

            listKursi = new List<string>();
            comboBoxJudul.DataSource = Film.BacaData();
            comboBoxJudul.DisplayMember = "Judul";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;

            
            labelTotalSaldo.Text = formUtamaKonsumen.userLogin.Saldo.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BacaDataCinema();
        }

        void BacaDataCinema()
        {
            Film selectedFilm = (Film)comboBoxJudul.SelectedItem;
            sesiFilmList = Sesi_films.BacaData("sesi_films.films_id", selectedFilm.Id.ToString(), "jadwal_films.tanggal", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            if (sesiFilmList.Count != 0)
            {
                List<Cinema> cinemaList = new List<Cinema>();
                foreach (Sesi_films sf in sesiFilmList)
                {
                    if (!cinemaList.Contains(sf.Film_studios.Studios.Cinema))
                    {
                        cinemaList.Add(sf.Film_studios.Studios.Cinema);
                    }
                }
                comboBoxCinema.DataSource = cinemaList;
                comboBoxCinema.DisplayMember = "Nama_cabang";
            }
            else
            {
                comboBoxCinema.DataSource = null;
            }
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxJam.Items.Clear();
            Cinema selectedCinema = (Cinema)comboBoxCinema.SelectedItem;
            if(sesiFilmList.Count != 0)
            {
                sesiFilmAvailableList = new List<Sesi_films>();
                foreach(Sesi_films s in sesiFilmList)
                {
                    if(s.Film_studios.Studios.Cinema.Id == selectedCinema.Id)
                    {
                        sesiFilmAvailableList.Add(s);
                        string jam = "";
                        switch (s.JadwalFilms.JamPemutaran) 
                        {
                            case "I":
                                jam = "12.00";
                                break;
                            case "II":
                                jam = "15.30";
                                break;
                            case "III":
                                jam = "19.00";
                                break;
                            case "IV":
                                jam = "22.30";
                                break;
                        }

                        
                        comboBoxJam.Items.Add(jam + " " + s.Film_studios.Studios.Nama + " " + s.Film_studios.Studios.JenisStudio.Nama);
                    }
                }
                comboBoxJam.SelectedIndex = -1;
            }
        }

        private void comboBoxJam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxJam.SelectedIndex != -1)
            {
                selectedSesi = sesiFilmAvailableList[comboBoxJam.SelectedIndex];
                labelJenisStudio.Text = selectedSesi.Film_studios.Studios.JenisStudio.Nama;
                labelJumlahKursi.Text = selectedSesi.Film_studios.Studios.Kapasitas.ToString() + " Kursi";
                if(dateTimePicker1.Value.ToString("dddd") == "Sunday" || dateTimePicker1.Value.ToString("dddd") == "Saturday")
                {
                    labelHargaTiket.Text = selectedSesi.Film_studios.Studios.HargaWeekend.ToString();
                }
                else
                {
                    labelHargaTiket.Text = selectedSesi.Film_studios.Studios.HargaWeekday.ToString();
                }
                labelSisa.Text = "(Sisa " + Sesi_films.BacaDataKursiKosong(selectedSesi) + " kursi)";
            }
            else
            {
                labelJenisStudio.Text = "";
                labelJumlahKursi.Text = "";
                labelHargaTiket.Text = "";
            }
        }

        private void labelTotalSaldo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBayar_Click(object sender, EventArgs e)
        {
            try
            {
                if(listKursi.Count != 0)
                {
                    Invoice i = new Invoice();

                    i.GrandTotal = int.Parse(labelHargaAkhir.Text);
                    i.DiskonNominal = selectedSesi.Film_studios.Films.DiskonNominal;
                    i.Konsumen = formUtamaKonsumen.userLogin;

                    foreach(string s in listKursi)
                    {
                        Tiket t = new Tiket();
                        t.Nomor_kursi = s;
                        t.Harga = int.Parse(labelHargaTiket.Text);
                        t.Sesi_film = selectedSesi;
                        i.Tiket.Add(t);
                    }
                    Invoice.TambahData(i,formUtamaKonsumen.userLogin);
                    MessageBox.Show("Pesan Tiket Berhasil");
                    formUtamaKonsumen.userLogin = Konsumen.BacaData("id", formUtamaKonsumen.userLogin.Id.ToString())[0];
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pilih Kursi terlebih dahulu");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
