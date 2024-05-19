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
    public partial class FormDaftarJadwalFilm : Form
    {
        public FormDaftarJadwalFilm()
        {
            InitializeComponent();
        }
        List<Sesi_films> listSesiFilm;
        private void FormDaftarJadwalFilm_Load(object sender, EventArgs e)
        {
            listSesiFilm = Sesi_films.BacaData();

            TampilDataGrid();
        }
        private void TampilDataGrid()
        {
            dataGridViewJadwal.Rows.Clear();
            foreach (Sesi_films sf in listSesiFilm)
            {
                dataGridViewJadwal.Rows.Add(sf.Film_studios.Studios.Cinema.Nama_cabang, sf.Film_studios.Studios.Nama, sf.JadwalFilms.Tanggal.ToShortDateString(), sf.JadwalFilms.JamPemutaran, sf.Film_studios.Films.Judul);

            }
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            FormTambahJadwalFilm form = new FormTambahJadwalFilm();
            if(form.ShowDialog() == DialogResult.OK )
            {
                FormDaftarJadwalFilm_Load(pictureBoxTambah, e);
            }
        }

        private void dataGridViewJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewJadwal.Columns["ColumnBtnHapus"].Index)
            {
                Sesi_films selectedJadwalFilm = listSesiFilm[e.RowIndex];
                DialogResult hasil = MessageBox.Show("Delete data ini?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    if (Sesi_films.HapusData(selectedJadwalFilm)) 
                    {
                        MessageBox.Show("Hapus data berhasil");
                        FormDaftarJadwalFilm_Load(dataGridViewJadwal, e);
                    }
                    else
                    {
                        MessageBox.Show("Hapus data gagal : Terdapat tiket terjual pada sesi ini");
                    }
                    
                }
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
