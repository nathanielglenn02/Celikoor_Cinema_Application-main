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
    public partial class FormJenisStudio : Form
    {
        public FormJenisStudio()
        {
            InitializeComponent();
        }
        List<JenisStudio> listJenisStudio;
        private void FormJenisStudio_Load(object sender, EventArgs e)
        {
            listJenisStudio = JenisStudio.BacaData();
            if (listJenisStudio.Count > 0)
            {
                dataGridViewJenisStudio.DataSource = listJenisStudio;
                if(dataGridViewJenisStudio.ColumnCount == 3)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "DELETE";
                    bcol.Name = "btnDeleteGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewJenisStudio.Columns.Add(bcol);
                }
            }
            else
            {
                dataGridViewJenisStudio.DataSource = null;
            }
        }

        private void dataGridViewJenisStudio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewJenisStudio.Columns["btnDeleteGrid"].Index)
            {
                JenisStudio selectedJenisStudio = listJenisStudio[e.RowIndex];
                DialogResult hasil = MessageBox.Show("Delete data ini?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    JenisStudio.HapusData(selectedJenisStudio.Id.ToString());
                    FormJenisStudio_Load(dataGridViewJenisStudio, e);
                }
            }
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                FormTambahJenisStudio form = new FormTambahJenisStudio();
                if(form.ShowDialog() == DialogResult.OK)
                {
                    FormJenisStudio_Load(pictureBoxTambah, e);
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
    }
}
