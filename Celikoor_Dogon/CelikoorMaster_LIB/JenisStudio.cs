using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelikoorMaster_LIB
{
    public class JenisStudio
    {
        private int id;
        private string nama;
        private string deskripsi;

        public JenisStudio()
        {
            this.Id = 0;
            this.Nama = "";
            this.Deskripsi = "";
        }
        public JenisStudio(int id, string nama, string deskripsi)
        {
            this.Id = id;
            this.Nama = nama;
            this.Deskripsi = deskripsi;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        public static bool TambahData(JenisStudio j)
        {
            string sql = "insert into jenis_studios" +
                         " values('null','" + j.Nama + "','" + j.Deskripsi + "')";
            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static List<JenisStudio> BacaData()
        {
            string sql = "select * from jenis_studios";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<JenisStudio> listJenisStudio = new List<JenisStudio>();

            while(hasil.Read() == true)
            {
                JenisStudio j = new JenisStudio(int.Parse(hasil.GetValue(0).ToString()),hasil.GetValue(1).ToString(),hasil.GetValue(2).ToString());
                listJenisStudio.Add(j); ;
            }
            return listJenisStudio; 
        }

        public static bool HapusData(string idJenisStudio)
        {
            string sql = "delete from jenis_studios" +
                         " where id = '" + idJenisStudio + "'";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if(jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return Nama;
        }
    }
}
