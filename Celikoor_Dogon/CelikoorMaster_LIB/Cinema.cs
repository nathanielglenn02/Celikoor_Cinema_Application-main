using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelikoorMaster_LIB
{
    public class Cinema : IEquatable<Cinema>
    {
        #region DATA MEMBER
        private int id;
        private string nama_cabang;
        private string alamat;
        private DateTime tgl_dibuka;
        private string kota;
        #endregion

        #region CONSTRUCTORS
        public Cinema()
        {
            Id = 0;
            Nama_cabang = "";
            Alamat = "";
            Tgl_dibuka = DateTime.Now;
            Kota = "";
        }
        public Cinema(int id, string nama_cabang, string alamat, DateTime tgl_dibuka, string kota)
        {
            Id = id;
            Nama_cabang = nama_cabang;
            Alamat = alamat;
            Tgl_dibuka = tgl_dibuka;
            Kota = kota;
        }
        #endregion


        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama_cabang { get => nama_cabang; set => nama_cabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime Tgl_dibuka { get => tgl_dibuka; set => tgl_dibuka = value; }
        public string Kota { get => kota; set => kota = value; }
        #endregion

        #region METHODS
        public static bool TambahData(Cinema c)
        {
            c.Id = GenerateIdCinema();
            string sql = "insert into cinemas(id, nama_cabang, alamat, tgl_dibuka, kota) " +
                         "values ('" + c.Id + "','" + c.Nama_cabang+ "'," +
                                  "'" + c.Alamat + "','" + c.tgl_dibuka.ToString("yyyy-MM-dd") + "'," +
                                  "'" + c.Kota + "')";
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
        public static bool HapusData(Cinema c)
        {
            string sql = "DELETE FROM cinemas WHERE id= '" + c.Id + "';";

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
        public static List<Cinema> BacaData()
        {
            string sql = "select *" +
                         " from cinemas";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Cinema> listCinema = new List<Cinema>();
            while (hasil.Read() == true)
            {
                Cinema cinema = new Cinema();
                cinema.Id = int.Parse(hasil.GetValue(0).ToString());
                cinema.Nama_cabang = hasil.GetValue(1).ToString();
                cinema.Alamat = hasil.GetValue(2).ToString();
                cinema.Tgl_dibuka = DateTime.Parse(hasil.GetValue(3).ToString());
                cinema.Kota = hasil.GetValue(4).ToString();
                listCinema.Add(cinema);
            }
            return listCinema;
        }
        
        public override string ToString()
        {
            return Nama_cabang;
        }

        //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.contains?view=net-8.0
        //method untuk List<cinema>.contains(cinema c) 
        public bool Equals(Cinema other)
        {
            if (this.Id == other.Id)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        private static int GenerateIdCinema()
        {
            string sql = "select max(id) from cinemas"; 
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }
        #endregion

    }
}
