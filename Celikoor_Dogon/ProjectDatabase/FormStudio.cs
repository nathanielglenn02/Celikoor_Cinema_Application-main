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

namespace ProjectDatabase
{
    public partial class FormStudio : Form
    {
        public FormStudio()
        {
            InitializeComponent();
        }
        public List<Studio> listStudio;
        
        private void FormStudio_Load(object sender, EventArgs e)
        {
            listStudio = Studio.BacaData();
            

            dataGridViewStudio.DataSource = listStudio;
            if (dataGridViewStudio.ColumnCount == 7)
            {
                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "AKSI";
                btnUbah.Text = "UBAH";
                btnUbah.Name = "buttonUbah";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridViewStudio.Columns.Add(btnUbah);

                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "AKSI";
                btnDel.Text = "DELETE";
                btnDel.Name = "buttonDelete";
                btnDel.UseColumnTextForButtonValue = true;
                dataGridViewStudio.Columns.Add(btnDel);
            }
            
        }

        private void dataGridViewAktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewStudio.Columns["buttonUbah"].Index)
            {
                Studio selectedStudio= listStudio[e.RowIndex];
                FormUpdateStudio form = new FormUpdateStudio(selectedStudio);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FormStudio_Load(dataGridViewStudio, e);
                }
               
            }
            else if (e.ColumnIndex == dataGridViewStudio.Columns["buttonDelete"].Index)
            {
                Studio selectedStudio = listStudio[e.RowIndex];
                DialogResult hasil = MessageBox.Show("Delete data ini?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Studio.HapusData(selectedStudio);
                    FormStudio_Load(dataGridViewStudio, e);
                }
            }

            
        }

        private void textBoxNoStudio_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxJenis.SelectedIndex == 0)
            {
                listStudio = Studio.BacaDataFilter("s.nama", textBoxNoStudio.Text);
            }
            else if (comboBoxJenis.SelectedIndex == 1)
            {
                listStudio = Studio.BacaDataFilter("s.kapasitas", textBoxNoStudio.Text);
            }
            else if (comboBoxJenis.SelectedIndex == 2)
            {
                listStudio = Studio.BacaDataFilter("s.harga_weekday", textBoxNoStudio.Text);
            }
            else if (comboBoxJenis.SelectedIndex == 3)
            {
                listStudio = Studio.BacaDataFilter("s.harga_weekend", textBoxNoStudio.Text);
            }
            else if (comboBoxJenis.SelectedIndex == 4)
            {
                listStudio = Studio.BacaDataFilter("c.nama_cabang", textBoxNoStudio.Text);
            }
            else if (comboBoxJenis.SelectedIndex == 5)
            {
                listStudio = Studio.BacaDataFilter("js.nama", textBoxNoStudio.Text);
            }
            dataGridViewStudio.DataSource = listStudio;
            if (dataGridViewStudio.ColumnCount == 7)
            {
                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "AKSI";
                btnUbah.Text = "UBAH";
                btnUbah.Name = "buttonUbah";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridViewStudio.Columns.Add(btnUbah);

                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "AKSI";
                btnDel.Text = "DELETE";
                btnDel.Name = "buttonDelete";
                btnDel.UseColumnTextForButtonValue = true;
                dataGridViewStudio.Columns.Add(btnDel);
            }
        }

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            FormTambahStudio form = new FormTambahStudio();
            if (form.ShowDialog()== DialogResult.OK)
            {
                FormStudio_Load(pictureBoxTambah, e);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
