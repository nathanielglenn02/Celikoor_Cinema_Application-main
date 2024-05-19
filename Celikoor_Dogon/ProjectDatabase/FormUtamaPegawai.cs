using CelikoorMaster_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class FormUtamaPegawai : Form
    {
        Form activeForm;
        Pegawai userLogin;
        public FormUtamaPegawai(Pegawai p)
        {
            InitializeComponent();
            userLogin= p;
        }

        private void FormUtamaPegawai_Load(object sender, EventArgs e)
        {
            switch (userLogin.Roles)
            {
                case "ADMIN":
                    buttonScanTicket.Visible = true;
                    buttonInvoice.Visible = true;
                    buttonKonsumen.Visible = true;
                    buttonKelompok.Visible = true;
                    buttonFilm.Visible = true;
                    buttonGenre.Visible = true;
                    buttonAktor.Visible = true;
                    buttonCinema.Visible = true;
                    buttonJenisStudio.Visible = true;
                    buttonStudio.Visible = true;
                    buttonJadwal.Visible = true;
                    buttonLaporan.Visible = true;
                    buttonPegawai.Visible = true;
                    break;
                case "KASIR":
                    buttonScanTicket.Visible = false;
                    buttonInvoice.Visible = true;
                    buttonKonsumen.Visible = false;
                    buttonKelompok.Visible = false;
                    buttonFilm.Visible = false;
                    buttonGenre.Visible = false;
                    buttonAktor.Visible = false;
                    buttonCinema.Visible = false;
                    buttonJenisStudio.Visible = false;
                    buttonStudio.Visible = false;
                    buttonJadwal.Visible = false;
                    buttonLaporan.Visible = false;
                    buttonPegawai.Visible = false;
                    break;
                case "OPERATOR":
                    buttonScanTicket.Visible = true;
                    buttonInvoice.Visible = false;
                    buttonKonsumen.Visible = false;
                    buttonKelompok.Visible = false;
                    buttonFilm.Visible = false;
                    buttonGenre.Visible = false;
                    buttonAktor.Visible = false;
                    buttonCinema.Visible = false;
                    buttonJenisStudio.Visible = false;
                    buttonStudio.Visible = false;
                    buttonJadwal.Visible = false;
                    buttonLaporan.Visible = false;
                    buttonPegawai.Visible = false;
                    break;
            }
        }

        private void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Form form1 = Application.OpenForms[form.DataBindings.ToString()];
            if (form1 == null)
            {
                activeForm = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                this.panelForm.Controls.Add(form);
                this.panelForm.Tag = form;
                form.Show();
                form.BringToFront();
                
            }
            else
            {
                activeForm = form;
                form.Show();
                form.BringToFront();
            }

        }

        private void buttonScanTicket_Click(object sender, EventArgs e)
        {
            OpenForm(new FormOperator(userLogin));
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            OpenForm(new FormInvoice(userLogin));
        }

        private void buttonLaporanSistem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("excel application not found");
                return;
            }

            Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();

            xlWorkBook.Worksheets.Add();
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = xlWorkBook.Worksheets[1];

            xlWorkSheet.Cells[1, 1] = "Film Terlaris 2023";
            xlWorkSheet.Cells[1, 2] = "Cabang Dengan Pemasukan Terbanyak";
            xlWorkSheet.Cells[1, 3] = "Film Dengan Sepi Penonton";
            xlWorkSheet.Cells[1, 4] = "Studio Dengan Utilitas Terendah";
            xlWorkSheet.Cells[1, 5] = "Konsumen Penyuka Genre Komedi";
            xlWorkSheet.Cells[1, 6] = "Genre Paling Disukai";
            xlWorkSheet.Cells[1, 7] = "Pemasukan Tiap Tahun";

            Microsoft.Office.Interop.Excel.Range rng = xlWorkSheet.Cells[1, 1] as Microsoft.Office.Interop.Excel.Range;
            rng.EntireRow.Font.Bold = true;

            xlApp.DisplayAlerts = false;
            xlWorkBook.SaveAs("Laporan Sistem Celikoor.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault);



            xlWorkBook.Close();
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);


            MessageBox.Show("Berhasil export");
        }

        private void buttonKonsumen_Click(object sender, EventArgs e)
        {
            OpenForm(new FormDaftarKonsumen());
        }

        private void buttonKelompok_Click(object sender, EventArgs e)
        {
            OpenForm(new FormKelompok());
        }

        private void buttonFilm_Click(object sender, EventArgs e)
        {
            OpenForm(new FormDaftarFilm());
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            OpenForm(new FormGenre());
        }

        private void buttonAktor_Click(object sender, EventArgs e)
        {
            OpenForm(new FormDaftarAktor());
        }

        private void buttonCinema_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCinema());
        }

        private void buttonJenisStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormJenisStudio());
        }

        private void buttonStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormStudio());
        }

        private void buttonJadwal_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FormDaftarJadwalFilm());
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            OpenForm(new FormLaporan());
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            OpenForm(new FormDaftarPegawai());
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
