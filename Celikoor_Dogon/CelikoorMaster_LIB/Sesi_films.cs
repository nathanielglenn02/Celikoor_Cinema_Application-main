using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Transactions;
using System.Runtime.Remoting.Lifetime;
using System.Net;

namespace CelikoorMaster_LIB
{
    public class Sesi_films
    {
        #region DATA MEMBER
        private Film_studio film_studios;
        private JadwalFilm jadwalFilms;


        #endregion

        #region CONSTRUCTORS
        public Sesi_films()
        {
            film_studios = new Film_studio();
            JadwalFilms = new JadwalFilm();
        }

        public Sesi_films(Film_studio fs, JadwalFilm jf)
        {
            Film_studios = fs;
            JadwalFilms = jf;
        }
        #endregion

        #region PROPERTIES
        public Film_studio Film_studios { get => film_studios; set => film_studios = value; }
        public JadwalFilm JadwalFilms { get => jadwalFilms; set => jadwalFilms = value; }
        #endregion

        #region METHODS
        public static List<Sesi_films> BacaData(string kriteria = "", string nilaiKriteria = "", string kriteria2 = "", string nilaiKriteria2 = "", string kriteria3 = "", string nilaiKriteria3 = "")
        {
            string sql = "select * from sesi_films " +
                         "inner join jadwal_films on sesi_films.jadwal_film_id = jadwal_films.id";
            if (kriteria != "")
            {
                sql += " where " + kriteria + " = '" + nilaiKriteria + "'";
                if (kriteria2 != "")
                {
                    sql += " and " + kriteria2 + " = '" + nilaiKriteria2 + "'";
                    if (kriteria3 != "")
                    {
                        sql += " and " + kriteria3 + " = '" + nilaiKriteria3 + "'";
                    }
                }
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Sesi_films> sesiFilmList = new List<Sesi_films>();
            while (hasil.Read())
            {
                Film_studio fs = new Film_studio();
                fs.Studios.Id = int.Parse(hasil.GetValue(1).ToString());
                fs.Films.Id = int.Parse(hasil.GetValue(2).ToString());

                Sesi_films sf = new Sesi_films();
                sf.JadwalFilms.Id = int.Parse(hasil.GetValue(0).ToString());
                sf.JadwalFilms.Tanggal = DateTime.Parse(hasil.GetValue(4).ToString());
                sf.JadwalFilms.JamPemutaran = hasil.GetValue(5).ToString();
                sf.Film_studios = fs;
                sesiFilmList.Add(sf);
            }
            foreach (Sesi_films sf in sesiFilmList)
            {
                sf.Film_studios.Studios = Studio.BacaData("s.id", sf.Film_studios.Studios.Id.ToString())[0];
                sf.Film_studios.Films = Film.BacaData("f.id", sf.Film_studios.Films.Id.ToString())[0];
            }

            return sesiFilmList;
        }
        //baca data cinema yang menayangkan film f
        public static List<Cinema>BacaData(Film f)
        {
            string sql = "select distinct(cinemas.id), nama_cabang,alamat,tgl_dibuka,kota from cinemas" +
                         " inner join studios on cinemas.id = studios.cinemas_id" +
                         " inner join film_studio on studios.id = film_studio.studios_id" +
                         " where film_studio.films_id = '" + f.Id + "'";
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
        

        public static void TambahData(Sesi_films sf)
        {
            List<JadwalFilm>jadwalFilmList = JadwalFilm.BacaData("tanggal", sf.JadwalFilms.Tanggal.ToString("yyyy-MM-dd"), "jam_pemutaran", sf.JadwalFilms.JamPemutaran);
            List<Film_studio> filmStudioList = Film_studio.BacaData("studios_id", sf.Film_studios.Studios.Id.ToString(), "films_id", sf.Film_studios.Films.Id.ToString());

            if(jadwalFilmList.Count == 0)
            {
                sf.JadwalFilms.Id = JadwalFilm.GenerateId();
            }
            else
            {
                sf.JadwalFilms.Id = jadwalFilmList[0].Id;
            }
            List<Sesi_films> sesiFilmList = BacaData("jadwal_film_id",sf.JadwalFilms.Id.ToString(),"studios_id",sf.Film_studios.Studios.Id.ToString());
            if(sesiFilmList.Count == 1)
            {
                return;
            }
            using(TransactionScope transcope = new TransactionScope())
            {
                try
                {
                    Koneksi k = new Koneksi();
                    if(jadwalFilmList.Count == 0)
                    {
                        JadwalFilm.TambahData(sf.JadwalFilms, k);
                    }

                    if(filmStudioList.Count == 0)
                    {
                        Film_studio.TambahData(sf.Film_studios, k);
                    }
                    if(sesiFilmList.Count == 0)
                    {
                        string sql = "insert into sesi_films values ('" + sf.JadwalFilms.Id + "','" + sf.Film_studios.Studios.Id + "','" + sf.Film_studios.Films.Id + "')";
                        Koneksi.JalankanPerintahDML(sql, k);
                    }
                    transcope.Complete();

                }
                catch(Exception ex)
                {
                    transcope.Dispose();
                    throw new Exception(ex.Message);
                }
                
            }
        }
        public static bool HapusData(Sesi_films sf)
        {
            string sql = "select * from tikets where jadwal_film_id = '" + sf.JadwalFilms.Id + "' and studios_id = '" + 
                          sf.Film_studios.Studios.Id + "' " +
                         "and films_id = '" + sf.Film_studios.Films.Id + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read())
            {
                return false;
            }
            else
            {
                string sql2 = "delete from sesi_films " +
                             "where jadwal_film_id = '" + sf.JadwalFilms.Id + "' and studios_id = '" + sf.Film_studios.Studios.Id + "' " +
                             "and films_id = '" + sf.Film_studios.Films.Id + "'";
                int dataDiubah = Koneksi.JalankanPerintahDML(sql2);
                if (dataDiubah == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
            
        }

        //public static List<Tiket> BacaDataTiket(Sesi_films sf)
        //{
        //    string sql = "select * from tikets " +
        //                 "where jadwal_film_id = '" + sf.JadwalFilms.Id + "' and studios_id = '" + sf.Film_studios.Studios.Id + "' and films_id = '" + sf.Film_studios.Films.Id + "' " +
        //                 "order by nomor_kursi asc";
        //    MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
        //    List<Tiket > listTiket = new List<Tiket>();
        //    while (hasil.Read())
        //    {
        //        Tiket t = new Tiket();
        //        t.Invoices.Id = int.Parse(hasil.GetValue(0).ToString());
        //        t.Nomor_kursi = hasil.GetValue(1).ToString();
        //        t.Status_hadir = (int.Parse(hasil.GetValue(2).ToString()) == 0)?true : false;
        //        t.Operators.Id = int.Parse(hasil.GetValue(3).ToString());
        //        t.Harga = double.Parse(hasil.GetValue(4).ToString());
        //        t.Sesi_film = sf;
        //        listTiket.Add(t);
        //    }
        //    return listTiket;
        //}
        public static List<string> BacaDataKursiTerisi(Sesi_films sf)
        {
            string sql = "select nomor_kursi from tikets " +
                         "where jadwal_film_id = '" + sf.JadwalFilms.Id + "' and studios_id = '" + sf.Film_studios.Studios.Id + "' and films_id = '" + sf.Film_studios.Films.Id + "' " +
                         "order by nomor_kursi asc";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<string> listNomorKursi = new List<string>();
            while (hasil.Read())
            {

                listNomorKursi.Add(hasil.GetValue(0).ToString());
            }
            return listNomorKursi;
        }

        public static int BacaDataKursiKosong(Sesi_films sf)
        {
            string sql = "select (select kapasitas from studios where id = '" + sf.Film_studios.Studios.Id + "')- count(*) from tikets " +
                         "inner join studios on tikets.studios_id = studios.id " +
                         "where jadwal_film_id = '" + sf.JadwalFilms.Id + "' and studios_id = '" + sf.Film_studios.Studios.Id + "' and films_id = '" + sf.Film_studios.Films.Id + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            int jumlahKursiKosong = 0;
            if (hasil.Read())
            {
                jumlahKursiKosong = int.Parse(hasil.GetValue(0).ToString());
            }
            return jumlahKursiKosong;
        }
        #endregion


    }
}
