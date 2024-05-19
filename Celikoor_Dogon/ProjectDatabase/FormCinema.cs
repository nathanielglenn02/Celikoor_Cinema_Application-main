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
    public partial class FormCinema : Form
    {
        public FormCinema()
        {
            InitializeComponent();
        }
        List<Cinema> listCinema;
        public Cinema selectedCinema;
        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                FormTambahCinema form = new FormTambahCinema();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FormCinema_Load(pictureBoxTambah, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal menambah data. Pesan kesalahan : " + ex.Message, "informasi");
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCinema.Columns["btnDeleteGrid"].Index)
            {
                selectedCinema = listCinema[e.RowIndex];
                DialogResult hasil = MessageBox.Show("Delete data ini?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Cinema.HapusData(selectedCinema);
                    FormCinema_Load(dataGridViewCinema, e);
                }
            }
        }
        
        private void FormCinema_Load(object sender, EventArgs e)
        {
            listCinema = Cinema.BacaData();  
            if (listCinema.Count > 0)
            {
                dataGridViewCinema.DataSource = listCinema;
                if (dataGridViewCinema.ColumnCount == 5)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "DELETE";
                    bcol.Name = "btnDeleteGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewCinema.Columns.Add(bcol);
                }
            }
            else
            {
                dataGridViewCinema.DataSource = null;
            }
        }
    }
}
