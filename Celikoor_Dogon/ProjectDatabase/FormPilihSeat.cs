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
    public partial class FormPilihSeat : Form
    {
        Sesi_films sesiFilm;
        List<string> listKursiTerisi;
        List<string> listKursiDipilih;
        public FormPilihSeat(Sesi_films sf)
        {
            InitializeComponent();
            sesiFilm = sf;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPilihSeat_Load(object sender, EventArgs e)
        {
            listKursiTerisi = Sesi_films.BacaDataKursiTerisi(sesiFilm);
            listKursiDipilih = ((FormPesanFilm)this.Owner).listKursi;
            GenerateKursi();
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenerateKursi()
        {
            int locXAwal;
            int locYAwal = 75;

            int jarakX = 42;
            int jarakY = 26;

            int jumlahBaris = sesiFilm.Film_studios.Studios.Kapasitas / 12;
            int sisaKursi = sesiFilm.Film_studios.Studios.Kapasitas % 12;

            for (int i = 0; i < jumlahBaris; i++)
            {
                locXAwal = 9;
                // kolom a
                for (int j = 0; j < 4; j++)
                {

                    string nomorKursi = "A" + ((i * 4) + (j + 1)).ToString().PadLeft(2,'0');
                    CreateCheckBox(nomorKursi, locXAwal, locYAwal);
                    locXAwal += jarakX;

                }
                locXAwal += 18;
                // kolom b
                for (int k = 0; k < 4; k++)
                {
                    string nomorKursi = "B" + ((i * 4) + (k + 1)).ToString().PadLeft(2, '0');
                    CreateCheckBox(nomorKursi, locXAwal, locYAwal);
                    locXAwal += jarakX;

                }
                locXAwal += 18;
                // kolom c
                for (int l = 0; l < 4; l++)
                {
                    string nomorKursi = "C" + ((i * 4) + (l + 1)).ToString().PadLeft(2, '0');
                    CreateCheckBox(nomorKursi, locXAwal, locYAwal);
                    locXAwal += jarakX;
                }
                locYAwal += jarakY;
            }

            if (sisaKursi == 4)
            {
                locXAwal = 9;
                //kolom a
                for (int j = 0; j < 4; j++)
                {
                    string nomorKursi = "A" + ((jumlahBaris * 4) + (j + 1)).ToString().PadLeft(2, '0');
                    CreateCheckBox(nomorKursi, locXAwal, locYAwal);
                    locXAwal += jarakX;
                }
            }

            if (sisaKursi == 8)
            {
                locXAwal = 9;
                // kolom a
                for (int j = 0; j < 4; j++)
                {

                    string nomorKursi = "A" + ((jumlahBaris * 4) + (j + 1)).ToString().PadLeft(2, '0');
                    CreateCheckBox(nomorKursi, locXAwal, locYAwal);
                    locXAwal += jarakX;

                }
                locXAwal += 18;
                // kolom b
                for (int k = 0; k < 4; k++)
                {
                    string nomorKursi = "B" + ((jumlahBaris * 4) + (k + 1)).ToString().PadLeft(2, '0');
                    CreateCheckBox(nomorKursi, locXAwal, locYAwal);
                    locXAwal += jarakX;

                }
            }
        }
        private bool IsKursiTerisi(string noKursi)
        {
            if (listKursiTerisi.Contains(noKursi))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {
                listKursiDipilih.Add((sender as CheckBox).Name);
            }
            else
            {
                listKursiDipilih.Remove((sender as CheckBox).Name);
            }
        }

        private void CreateCheckBox(string noKursi, int locX, int locY)
        {


            CheckBox cb = new CheckBox();
            cb.Enabled = true;
            cb.Checked = false;
            if (IsKursiTerisi(noKursi))
            {
                cb.Enabled = false;
                cb.Checked = true;
            }
            if (isKursiDipilih(noKursi))
            {
                cb.Enabled = true;
                cb.Checked = true;
            }

            cb.AutoSize = true;
            cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cb.ForeColor = System.Drawing.Color.White;
            cb.Location = new System.Drawing.Point(locX, locY);
            cb.Name = noKursi;
            cb.Size = new System.Drawing.Size(45, 20);
            cb.TabIndex = 166;
            cb.Text = noKursi.Substring(1);
            cb.UseVisualStyleBackColor = true;
            cb.Anchor =  AnchorStyles.Top | AnchorStyles.Left;

            cb.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            panel7.Controls.Add(cb);
        }
        private bool isKursiDipilih(string noKursi)
        {
            if (listKursiDipilih.Contains(noKursi))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkBoxB2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormPilihSeat_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((FormPesanFilm)this.Owner).listKursi = listKursiDipilih;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
