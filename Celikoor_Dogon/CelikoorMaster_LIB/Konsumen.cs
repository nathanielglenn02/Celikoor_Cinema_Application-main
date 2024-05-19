using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CelikoorMaster_LIB
{
    public class Konsumen
    {
        #region DATA MEMBER
        private int id;
        private string nama;
        private string email;
        private string no_hp;
        private string gender;
        private DateTime tgl_lahir;
        private double saldo;
        private string username;
        private string password;

        #endregion

        #region CONSTRUCTORS
        public Konsumen()
        {
            Id = 0;
            Nama = "";
            Email = "";
            No_hp = "";
            Gender = "";
            Tgl_lahir = DateTime.Now;
            Saldo = 0;
            Username = "";
            Password = "";
        }
        public Konsumen(int id, string nama, string email, string no_hp, string gender,
                        DateTime tgl_lahir, double saldo, string username)
        {
            Id = id;
            Nama = nama;
            Email = email;
            No_hp = no_hp;
            Gender = gender;
            Tgl_lahir = tgl_lahir;
            Saldo = saldo;
            Username = username;
            Password = "";
        }
        #endregion


        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string No_hp { get => no_hp; set => no_hp = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Tgl_lahir { get => tgl_lahir; set => tgl_lahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region METHODS
        public static bool TambahData(Konsumen k)
        {
            k.Id = GenerateIdKonsumen();
            string sql = "insert into konsumens(id, nama, email, no_hp, gender, " +
                                                "tgl_lahir, saldo, username, password) " +
                         "values ('" + k.Id + "','" + k.Nama + "'," +
                                  "'" + k.Email + "', '" + k.No_hp + "', '" + k.gender + "'," +
                                  "'" + k.tgl_lahir.ToString("yyyy-MM-dd") + "'," +
                                  "'" + k.Saldo.ToString() + "', '" + k.Username + "', SHA2('" + k.Password + "',512))";
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
        public static bool UbahData(Konsumen k)
        {
            string sql = "UPDATE konsumens SET id='" + k.Id.ToString() + "', nama='" + k.Nama + "', " +
                                               "email= '" + k.Email + "', no_hp='" + k.No_hp + "', gender='" + k.Gender + "', " +
                                               "tgl_lahir= '" + k.Tgl_lahir.ToString("yyyy-MM-dd") + "', saldo='" + k.Saldo.ToString() + "'," +
                                               "username= '" + k.Username + "' " +
                         "WHERE id='" + k.Id.ToString() + "';";
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
        public static bool HapusData(Konsumen k)
        {
            string sql = "DELETE FROM konsumens WHERE id= '" + k.Id + "';";

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
        public static List<Konsumen> BacaData(string filter = "", string nilai = "")
        {
            string sql;
            if (filter == "")
            {
                sql = "select *" +
                         " from konsumens";
            }
            else
            {
                sql = "select *" +
                      " from konsumens" +
                      " where " + filter + " = '" + nilai + "'";
            }
            
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Konsumen> listKonsumen = new List<Konsumen>();
            while (hasil.Read() == true)
            {
                Konsumen konsumen = new Konsumen();
                konsumen.Id = int.Parse(hasil.GetValue(0).ToString());
                konsumen.Nama = hasil.GetValue(1).ToString();
                konsumen.Email = hasil.GetValue(2).ToString();
                konsumen.No_hp = hasil.GetValue(3).ToString();
                konsumen.Gender = hasil.GetValue(4).ToString();

                konsumen.Tgl_lahir = DateTime.Parse(hasil.GetValue(5).ToString());
                konsumen.Saldo = Double.Parse(hasil.GetValue(6).ToString());
                konsumen.Username = hasil.GetValue(7).ToString();
                konsumen.Password = "";
                listKonsumen.Add(konsumen);
            }
            return listKonsumen;
        }
        public static List<Konsumen> BacaDataFilter(string filter = "", string nilai = "")
        {
            string sql;
            if (filter == "")
            {
                sql = "select *" +
                         " from konsumens";
            }
            else
            {
                sql = "select *" +
                      " from konsumens" +
                      " where " + filter + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Konsumen> listKonsumen = new List<Konsumen>();
            while (hasil.Read() == true)
            {
                Konsumen konsumen = new Konsumen();
                konsumen.Id = int.Parse(hasil.GetValue(0).ToString());
                konsumen.Nama = hasil.GetValue(1).ToString();
                konsumen.Email = hasil.GetValue(2).ToString();
                konsumen.No_hp = hasil.GetValue(3).ToString();
                konsumen.Gender = hasil.GetValue(4).ToString();

                konsumen.Tgl_lahir = DateTime.Parse(hasil.GetValue(5).ToString());
                konsumen.Saldo = Double.Parse(hasil.GetValue(6).ToString());
                konsumen.Username = hasil.GetValue(7).ToString();
                konsumen.Password = "";
                listKonsumen.Add(konsumen);
            }
            return listKonsumen;
        }

        public static Konsumen CekLogin(string username, string password)
        {
            string sql = "select * from konsumens" +
                         " where username = '" + username + "' AND password = SHA2('" + password + "', 512)";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read() == true)
            {
                Konsumen konsumen = new Konsumen();
                konsumen.Id = int.Parse(hasil.GetValue(0).ToString());
                konsumen.Nama = hasil.GetValue(1).ToString();
                konsumen.Email = hasil.GetValue(2).ToString();
                konsumen.No_hp = hasil.GetValue(3).ToString();
                konsumen.Gender = hasil.GetValue(4).ToString();
                konsumen.Tgl_lahir = DateTime.Parse(hasil.GetValue(5).ToString());
                konsumen.Saldo = Double.Parse(hasil.GetValue(6).ToString());
                konsumen.Username = hasil.GetValue(7).ToString();
                konsumen.Password = "";
                return konsumen;
            }
            return null;
        }
        private static int GenerateIdKonsumen()
        {
            string sql = "select max(id) from konsumens";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }

        public static void UpdateSaldo(Konsumen konsumen, int nominal,Koneksi koneksi)
        {
            string sql = "update konsumens set saldo = saldo - '" + nominal + "' where id = '" + konsumen.Id + "'";
            Koneksi.JalankanPerintahDML(sql, koneksi);
        }

        public static void GantiPassword(Konsumen konsumen,string passwordLama, string passwordBaru) 
        {
            if(CekLogin(konsumen.Username,passwordLama) != null)
            {
                string sql = "Update konsumens set password = SHA2('"+ passwordBaru + "',512) where id = '" + konsumen.Id + "'";
                Koneksi.JalankanPerintahDML(sql);
            }
            else
            {
                throw new Exception("Password Lama Salah");
            }
            
        }
        #endregion
    }
}
