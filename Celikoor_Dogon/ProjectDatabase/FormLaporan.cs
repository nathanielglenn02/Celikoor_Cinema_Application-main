using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelikoorMaster_LIB;
using Microsoft.Office.Interop.Excel;

namespace ProjectDatabase
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }
       
        private void FormLaporan_Load(object sender, EventArgs e)
        {
            labelTahun.Visible = false;
            dateTimePickerTahun.Visible=false;

        }

        //Menampilkan laporan 1(film terlaris) ke datagrid
        private void TampilLaporan1()
        {
            dataGridView1.Columns.Clear();
            labelTahun.Visible = true;
            dateTimePickerTahun.Visible = true;
            dataGridView1.Columns.Add("Tahun", "Tahun");
            dataGridView1.Columns.Add("Bulan", "Bulan");
            dataGridView1.Columns.Add("JudulFilm", "Judul Film");
            dataGridView1.Columns.Add("JumlahDitonton", "Jumlah Ditonton ");
            dataGridView1.Columns["Tahun"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Bulan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["JudulFilm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["JumlahDitonton"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            for (int i = 1; i <= 12; i++)
            {
                List<string> filmTerlaris = Laporan.BacaDataFilmTerlaris(i, dateTimePickerTahun.Value.Year);
                if (filmTerlaris.Count != 0)
                {
                    dataGridView1.Rows.Add(filmTerlaris[0], filmTerlaris[1], filmTerlaris[2], filmTerlaris[3]);
                }
                else
                {
                    dataGridView1.Rows.Add(dateTimePickerTahun.Value.Year, i, "Tidak ada data", "Tidak ada data");
                }
            }
        }
        private void TampilLaporan2()
        {
            dataGridView1.Columns.Clear();
            labelTahun.Visible = false;
            dateTimePickerTahun.Visible = false;
            dataGridView1.Columns.Add("NamaCabang", "Nama Cabang");
            dataGridView1.Columns.Add("TotalPendapatan", "Total Pendapatan");
            dataGridView1.Columns["NamaCabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["TotalPendapatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            foreach (var temp in Laporan.BacaDataCabangPemasukanTerbanyak())
            {
                dataGridView1.Rows.Add(temp.Item1, temp.Item2);
            }
        }

        private void TampilLaporan3()
        {
            dataGridView1.Columns.Clear();
            labelTahun.Visible = false;
            dateTimePickerTahun.Visible = false;
            dataGridView1.Columns.Add("JudulFilm", "Judul Film");
            dataGridView1.Columns.Add("JumlahKetidakHadiran", "Jumlah Ketidakhadiran");
            dataGridView1.Columns["JudulFilm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["JumlahKetidakHadiran"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            foreach (var temp in Laporan.BacaDataFilmTeratasKetidakhadiraan())
            {
                dataGridView1.Rows.Add(temp.Item1, temp.Item2);
            }
        }
        private void TampilLaporan4()
        {
            dataGridView1.Columns.Clear();
            labelTahun.Visible = true;
            dateTimePickerTahun.Visible = true;
            dataGridView1.Columns.Add("Tahun", "Tahun");
            dataGridView1.Columns.Add("Bulan", "Bulan");
            dataGridView1.Columns.Add("NamaStudio", "Nama Studio");
            dataGridView1.Columns.Add("NamaCabang", "Nama Cabang");
            dataGridView1.Columns.Add("TingkatUtilitas", "Tingkat Utilitas");
            dataGridView1.Columns["Tahun"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Bulan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["NamaStudio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["NamaCabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["TingkatUtilitas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            for (int i = 1; i <= 12; i++)
            {
                List<string> utilitasTerendah = Laporan.BacaDataUtilitasTerendah(i, dateTimePickerTahun.Value.Year);
                if (utilitasTerendah.Count != 0)
                {
                    dataGridView1.Rows.Add(utilitasTerendah[0], utilitasTerendah[1], utilitasTerendah[2], utilitasTerendah[3], utilitasTerendah[4]);
                }
                else
                {
                    dataGridView1.Rows.Add(dateTimePickerTahun.Value.Year, i, "Tidak ada data", "Tidak ada data", "Tidak ada data");
                }
            }
        }

        private void TampilLaporan5()
        {
            dataGridView1.Columns.Clear();
            labelTahun.Visible = false;
            dateTimePickerTahun.Visible = false;
            dataGridView1.Columns.Add("NamaKonsumen", "NamaKonsumen");
            dataGridView1.Columns.Add("FrekuensiMenonton", "FrekuensiMenonton");
            dataGridView1.Columns["NamaKonsumen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["FrekuensiMenonton"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            List<Tuple<string, int>> temp = Laporan.BacaKonsumenSukaGenreComedy();

            foreach (var a in temp)
            {
                dataGridView1.Rows.Add(a.Item1, a.Item2);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panelDepan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxPilih_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPilih.SelectedIndex == 0)
            {
                TampilLaporan1();
            }
            else if (comboBoxPilih.SelectedIndex == 1)
            {
                TampilLaporan2();
            }
            else if (comboBoxPilih.SelectedIndex == 2)
            {
                TampilLaporan3();

            }
            else if (comboBoxPilih.SelectedIndex == 3)
            {
                TampilLaporan4();
            } 
            else
            {
                TampilLaporan5();
            }
        }

        private void dateTimePickerTahun_ValueChanged(object sender, EventArgs e)
        {
            TampilLaporan1();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (comboBoxPilih.SelectedIndex == 0)
            {
                Laporan.PrintLaporan1(dateTimePickerTahun.Value.Year);
                MessageBox.Show("Berhasil Mencetak Laporan");
            }
            else if (comboBoxPilih.SelectedIndex == 1)
            {
                Laporan.PrintLaporan2();
                MessageBox.Show("Berhasil Mencetak Laporan");
            }
            else if (comboBoxPilih.SelectedIndex == 2)
            {
                Laporan.PrintLaporan3();
                MessageBox.Show("Berhasil Mencetak Laporan");
            }
            else if (comboBoxPilih.SelectedIndex == 3)
            {
                Laporan.PrintLaporan4(dateTimePickerTahun.Value.Year);
                MessageBox.Show("Berhasil Mencetak Laporan");
            }
            else if (comboBoxPilih.SelectedIndex == 4)
            {
                Laporan.PrintLaporan5();
                MessageBox.Show("Berhasil Mencetak Laporan");
            }
        }
    }
}
