using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelikoorMaster_LIB
{
    public class Kelompok
    {
        #region DATA MEMBER
        private int id;
        private string nama;
        #endregion

        #region CONSTRUCTORS
        public Kelompok()
        {
            Id = 0;
            Nama = "";
        }
        public Kelompok(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion


        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return this.Nama;
        }
        public static bool TambahData(Kelompok k)
        {
            string sql = "insert into kelompoks(id, nama) " +
                         "values ('0','" + k.Nama + "')";
            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool HapusData(Kelompok k)
        {
            string sql = "DELETE FROM kelompoks WHERE id= '" + k.Id + "';";

            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static List<Kelompok> BacaData()
        {
            string sql = "select *" +
                         " from kelompoks";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Kelompok> listKelompok = new List<Kelompok>();
            while (hasil.Read() == true)
            {
                Kelompok kelompok = new Kelompok();
                kelompok.Id = int.Parse(hasil.GetValue(0).ToString());
                kelompok.Nama = hasil.GetValue(1).ToString();
                listKelompok.Add(kelompok);
            }
            return listKelompok;
        }
        #endregion
    }
}
