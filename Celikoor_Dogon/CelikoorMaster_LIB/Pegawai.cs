using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelikoorMaster_LIB
{
    public class Pegawai
    {
        #region DATA MEMBER
        private int id;
        private string nama;
        private string email;
        private string username;
        private string password;
        private string roles;
        #endregion

        #region CONSTRUCTORS
        public Pegawai()
        {
            Id = 0;
            Nama = "";
            Email = "";
            Username = "";
            Password = "";
            Roles = "";
        }
        public Pegawai(int id, string nama, string email, string username,
                       string roles)
        {
            Id = id;
            Nama = nama;
            Email = email;
            Username = username;
            Password = "";
            Roles = roles;
        }
        #endregion


        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Roles { get => roles; set => roles = value; }
        #endregion

        #region METHODS
        public static bool TambahData(Pegawai p)
        {
            p.Id = GenerateIdPegawai();
            string sql = "insert into pegawais(id, nama, email, username, password, roles) " +
                         "values ('" + p.Id + "','" + p.Nama + "','" +
                                  p.Email + "','" + p.Username + 
                                  "',SHA2('" + p.Password + "',512),'" + p.Roles+ "')";
            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if(jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool HapusData(Pegawai p)
        {
            string sql = "DELETE FROM pegawais" +
                         " WHERE id= '" + p.Id + "';";

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
        public static List<Pegawai> BacaData(string filter = "", string nilai = "")
        {
            string sql;
            if (filter == "")
            {
                sql = "select * from pegawais " +
                    "where roles != 'ADMIN'";
            }
            else
            {
                sql = "select * from pegawais" +
                      " where " + filter + " like '%" + nilai + "%' and roles != 'ADMIN'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Pegawai> listPegawai = new List<Pegawai>();
            while (hasil.Read() == true)
            {
                Pegawai pegawai = new Pegawai();
                pegawai.Id = int.Parse(hasil.GetValue(0).ToString());
                pegawai.Nama = hasil.GetValue(1).ToString();
                pegawai.Email = hasil.GetValue(2).ToString();;
                pegawai.Username = hasil.GetValue(3).ToString();
                pegawai.Password = "";
                pegawai.Roles = hasil.GetValue(5).ToString();
                listPegawai.Add(pegawai);
            }
            return listPegawai;
        }

        public static Pegawai CekLogin(string username, string password)
        {
            Koneksi k = new Koneksi();
            string sql = "select * from pegawais" +
                         " where username = '" + username + "' AND password = SHA2('" + password + "',512)";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql,k);

            while (hasil.Read() == true)
            {
                Pegawai pegawai = new Pegawai();
                pegawai.Id = int.Parse(hasil.GetValue(0).ToString());
                pegawai.Nama = hasil.GetValue(1).ToString();
                pegawai.Email = hasil.GetValue(2).ToString(); ;
                pegawai.Username = hasil.GetValue(3).ToString();
                pegawai.Password = "";
                pegawai.Roles = hasil.GetValue(5).ToString();
                return pegawai;
            }
            return null;
        }
        private static int GenerateIdPegawai()
        {
            string sql = "select max(id) from pegawais";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if(hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }
        #endregion

    }
}
