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
    public partial class FormKelompok : Form
    {
        public FormKelompok()
        {
            InitializeComponent();
        }
        List<Kelompok> listKelompok;
        public void FormKelompok_Load(object sender, EventArgs e)
        {
            Kelompok k = new Kelompok();
            listKelompok = Kelompok.BacaData();
            
            TampilDataGrid();
        }
        private void TampilDataGrid()
        {
            dataGridViewAktor.Rows.Clear();
            foreach(Kelompok k in listKelompok)
            {
                dataGridViewAktor.Rows.Add(k.Id, k.Nama);
            }
        }
        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridViewAktor.Columns["btnHapus"].Index)
                {
                    Kelompok selectedKelompok = listKelompok[e.RowIndex];
                    DialogResult hasil = MessageBox.Show("Delete data ini?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hasil == DialogResult.Yes)
                    {
                        Kelompok.HapusData(selectedKelompok);
                        FormKelompok_Load(dataGridViewAktor, e);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            FormTambahKelompok form = new FormTambahKelompok();
            form.Owner = this;
            form.ShowDialog();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
