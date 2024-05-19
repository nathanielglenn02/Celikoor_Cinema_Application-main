using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelikoorMaster_LIB
{
    public class Genre
    {
        #region DATA MEMBER
        private int id;
        private string nama;
        private string deskripsi;
        #endregion

        #region CONSTRUCTORS
        public Genre()
        {
            Id = 0;
            Nama = "";
            Deskripsi = "";
        }
        public Genre(int id, string nama, string deskripsi)
        {
            Id = id;
            Nama = nama;
            Deskripsi = deskripsi;
        }
        #endregion


        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return this.Nama;
        }
        public static void TambahData(Genre g)
        {
            string sql = "insert into genres(id, nama, deskripsi) " +
                         "values ('0','" + g.Nama + "'," +
                                  "'" + g.Deskripsi + "')";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static bool HapusData(Genre g)
        {
            string sql = "DELETE FROM genres WHERE id= '" + g.Id + "';";

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
        public static List<Genre> BacaData()
        {
            string sql = "select *" +
                         " from genres";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Genre> listGenre = new List<Genre>();
            while (hasil.Read() == true)
            {
                Genre genre = new Genre();
                genre.Id = int.Parse(hasil.GetValue(0).ToString());
                genre.Nama = hasil.GetValue(1).ToString();
                genre.Deskripsi = hasil.GetValue(2).ToString();
                listGenre.Add(genre);
            }
            return listGenre;
        }
        #endregion
    }
}
