using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CelikoorMaster_LIB
{
    public class Film_studio
    {
        #region DATA MEMBER
        private Film films;
        private Studio studios;
        #endregion

        #region CONSTRUCTORS
        public Film_studio()
        {
            Films = new Film();
            Studios = new Studio();
        }
        public Film_studio(Film f, Studio s)
        {
            Films = f;
            Studios = s;
        }
        #endregion

        #region PROPERTIES
        public Film Films { get => films; set => films = value; }
        public Studio Studios { get => studios; set => studios = value; }
        #endregion

        #region METHODS
        public static List<Film_studio> BacaData(string kriteria = "", string nilaiKriteria = "", string kriteria2 = "", string nilaiKriteria2 = "")
        {
            string sql = "select * from film_studio";
            if(kriteria != "")
            {
                sql += " where " + kriteria + " = '" + nilaiKriteria + "'";
                if(kriteria2 != "")
                {
                    sql += " and " + kriteria2 + " = '" + nilaiKriteria2 + "'";
                }
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Film_studio>filmStudioList = new List<Film_studio>();
            while(hasil.Read())
            {
                
                Studio s = new Studio();
                s.Id = int.Parse(hasil.GetValue(0).ToString());

                Film f = new Film();
                f.Id = int.Parse(hasil.GetValue(1).ToString());
                
                Film_studio fs = new Film_studio();
                fs.Studios = s;
                fs.Films = f;

                filmStudioList.Add(fs);
            }
            return filmStudioList;
        }


        public static void TambahData(Film_studio fs,Koneksi k)
        {
            string sql = "insert into film_studio values('" + fs.Studios.Id + "','" + fs.Films.Id + "')";
            Koneksi.JalankanPerintahDML(sql,k);
        }
        #endregion


    }
}
