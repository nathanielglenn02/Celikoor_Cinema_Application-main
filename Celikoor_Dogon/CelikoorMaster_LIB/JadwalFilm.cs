using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelikoorMaster_LIB
{
    public class JadwalFilm
    {
        private int id;
        private DateTime tanggal;
        private string jamPemutaran;

        public JadwalFilm()
        {
            this.Id = 0;
            this.Tanggal = DateTime.Now;
            this.JamPemutaran = "";
        }
        public JadwalFilm(DateTime tanggal, string jamPemutaran)
        {
            this.Id = 0;
            this.Tanggal = tanggal;
            this.JamPemutaran = jamPemutaran;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string JamPemutaran { get => jamPemutaran; set => jamPemutaran = value; }

        public static List<JadwalFilm> BacaData(string kriteria = "", string nilaiKriteria = "",string kriteria2 = "", string nilaiKriteria2 = "")
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select * from jadwal_films ";
            }
            else
            {
                sql = "select * from jadwal_films " +
                      "where " + kriteria + " = '" + nilaiKriteria + "'";
                if(kriteria2 != "")
                {
                    sql += " and " + kriteria2 + " = '" + nilaiKriteria2 + "'";
                }
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();

            while (hasil.Read())
            {
                JadwalFilm jf = new JadwalFilm();
                jf.Id = int.Parse(hasil.GetValue(0).ToString());
                jf.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                jf.JamPemutaran = hasil.GetValue(2).ToString();

                listJadwalFilm.Add(jf);

            }
            return listJadwalFilm;
        }

        public static bool TambahData(JadwalFilm jf)
        {
            if(jf.Id == 0)
            {
                jf.Id = GenerateId();
            }
            string sql = "insert into jadwal_films " +
                         "values('" + jf.Id + "','" + jf.Tanggal.ToString("yyyy-MM-dd") + "','" + jf.JamPemutaran + "')";

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
        public static bool TambahData(JadwalFilm jf,Koneksi k)
        {
            if (jf.Id == 0)
            {
                jf.Id = GenerateId();
            }
            string sql = "insert into jadwal_films " +
                         "values('" + jf.Id + "','" + jf.Tanggal.ToString("yyyy-MM-dd") + "','" + jf.JamPemutaran + "')";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql,k);

            if(jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int GenerateId()
        {
            string sql = "select max(id) from jadwal_films";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }
    }
}
