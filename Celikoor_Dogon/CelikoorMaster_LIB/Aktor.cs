using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelikoorMaster_LIB
{
    public class Aktor
    {
        #region DATA MEMBER
        private int id;
        private string nama;
        private DateTime tgl_Lahir;
        private string gender;
        private string negaraAsal;
        #endregion

        #region CONSTRUCTORS
        public Aktor()
        {
            Id = 0;
            Nama = "";
            Tgl_Lahir = DateTime.Now;
            Gender = "";
            NegaraAsal = "";
        }
        public Aktor(int id, string nama, DateTime tgl_Lahir, string gender, string negaraAsal)
        {
            Id = id;
            Nama = nama;
            Tgl_Lahir = tgl_Lahir;
            Gender = gender;
            NegaraAsal = negaraAsal;
        }
        #endregion


        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime Tgl_Lahir { get => tgl_Lahir; set => tgl_Lahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NegaraAsal { get => negaraAsal; set => negaraAsal = value; }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return this.Nama;
        }

        public static bool TambahData(Aktor a)
        {
            a.Id = GenerateIDAktor();
            string sql = "insert into aktors(id, nama, tgl_lahir, gender, negara_asal) " +
                         "values ('" + a.Id + "','" + a.Nama + "','" + a.Tgl_Lahir.ToString("yyyy-MM-dd") + 
                         "','" + a.Gender + "','" + a.NegaraAsal + "')";
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
        public static bool UbahData(Aktor a)
        {
            string sql = "UPDATE aktors SET id='" + a.Id.ToString() + "', nama='" + a.Nama + "', " +                                               
                                               "tgl_lahir= '" + a.Tgl_Lahir.ToString("yyyy-MM-dd") + "', gender='" + a.Gender + "'," +
                                               "negara_asal= '" + a.NegaraAsal + "' " +
                         "WHERE id='" + a.Id.ToString() + "';";
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
        public static bool HapusData(Aktor a)
        {
            string sql = "DELETE FROM aktors WHERE id= '" + a.Id + "';";

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
        public static List<Aktor> BacaData(string filter = "", string nilai = "")
        {
            string sql;
            if (filter == "")
            {
                sql = "select *" +
                         " from aktors";
            }
            else
            {
                sql = "select *" +
                      " from aktors" +
                      " where " + filter + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Aktor> listAktor = new List<Aktor>();
            while (hasil.Read() == true)
            {
                Aktor aktor = new Aktor();
                aktor.Id = int.Parse(hasil.GetValue(0).ToString());
                aktor.Nama = hasil.GetValue(1).ToString();
                aktor.Tgl_Lahir = DateTime.Parse(hasil.GetValue(2).ToString());
                aktor.Gender = hasil.GetValue(3).ToString();
                aktor.NegaraAsal = hasil.GetValue(4).ToString();
                listAktor.Add(aktor);
            }
            return listAktor;
        }

        public static int GenerateIDAktor()
        {
            string sql = "select max(id) from aktors";
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
