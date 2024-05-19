using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Configuration;
using System.IO;
using System.Drawing;

namespace CelikoorMaster_LIB
{
    public class Film
    {
        private int id;
        private string judul;
        private string sinopsis;
        private int tahun;
        private int durasi;
        private Kelompok kelompok;
        private string bahasa;
        private bool isSubIndo;
        private string coverImage;
        private double diskonNominal;
        List<Aktor_film> aktorList;
        List<Genre_film> genreList;

        public Film()
        {
            this.Id = 0;
            this.Judul = "";
            this.Sinopsis = "";
            this.Tahun = 0;
            this.Durasi = 0;
            this.Kelompok = new Kelompok();
            this.Bahasa = "";
            this.IsSubIndo = true;
            this.CoverImage = "";
            this.DiskonNominal = 0;
            AktorList = new List<Aktor_film>();
            GenreList = new List<Genre_film>();

        }
        public Film(int id, string judul, string sinopsis, int tahun, int durasi, Kelompok kelompok, string bahasa, bool isSubIndo, string coverImage, double diskonNominal)
        {
            this.Id = id;
            this.Judul = judul;
            this.Sinopsis = sinopsis;
            this.Tahun = tahun;
            this.Durasi = durasi;
            this.Kelompok = kelompok;
            this.Bahasa = bahasa;
            this.IsSubIndo = isSubIndo;
            this.CoverImage = coverImage;
            this.DiskonNominal = diskonNominal;
            AktorList = new List<Aktor_film>();
            GenreList = new List<Genre_film>();
        }

        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public Kelompok Kelompok { get => kelompok; set => kelompok = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public bool IsSubIndo { get => isSubIndo; set => isSubIndo = value; }
        public string CoverImage { get => coverImage; set => coverImage = value; }
        public double DiskonNominal { get => diskonNominal; set => diskonNominal = value; }
        public List<Aktor_film> AktorList { get => aktorList; private set => aktorList = value; }
        public List<Genre_film> GenreList { get => genreList; private set => genreList = value; }

        public static List<Film> BacaDataFilter(string kriteria = "", string nilaiKriteria = "")
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select f.id, f.judul, f.sinopsis, f.tahun, f.durasi, f.bahasa, f.is_sub_indo,f.cover_image, f.diskon_nominal, " +
                      "f.kelompoks_id, k.nama " +
                      "from films as f " +
                      "inner join kelompoks as k on f.kelompoks_id = k.id " +
                      "order by f.id";
            }
            else
            {
                sql = "select f.id, f.judul, f.sinopsis, f.tahun, f.durasi, f.bahasa, f.is_sub_indo,f.cover_image, f.diskon_nominal, " +
                      "f.kelompoks_id, k.nama " +
                      "from films as f " +
                      "inner join kelompoks as k on f.kelompoks_id = k.id " +
                      "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Film> listFilm = new List<Film>();

            while (hasil.Read())
            {
                Kelompok k = new Kelompok(int.Parse(hasil.GetValue(9).ToString()), hasil.GetValue(10).ToString());


                Film f = new Film();
                f.Id = int.Parse(hasil.GetValue(0).ToString());
                f.Judul = hasil.GetValue(1).ToString();
                f.Sinopsis = hasil.GetValue(2).ToString();
                f.Tahun = int.Parse(hasil.GetValue(3).ToString());
                f.Durasi = int.Parse(hasil.GetValue(4).ToString());
                f.Kelompok = k;
                f.Bahasa = hasil.GetValue(5).ToString();
                if (hasil.GetValue(6).ToString() == "1")
                {
                    f.IsSubIndo = true;
                }
                else
                {
                    f.IsSubIndo = false;
                }
                f.CoverImage = hasil.GetValue(7).ToString();
                if (hasil.GetValue(8).ToString() != "")
                {
                    f.DiskonNominal = double.Parse(hasil.GetValue(8).ToString());
                }

                listFilm.Add(f);
            }

            foreach (Film f in listFilm)
            {
                Film.BacaDataAktor(f);
                Film.BacaDataGenre(f);
            }

            return listFilm;
        }
        public static List<Film> BacaData(string kriteria = "", string nilaiKriteria = "")
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select f.id, f.judul, f.sinopsis, f.tahun, f.durasi, f.bahasa, f.is_sub_indo,f.cover_image, f.diskon_nominal, " +
                      "f.kelompoks_id, k.nama " +
                      "from films as f " +
                      "inner join kelompoks as k on f.kelompoks_id = k.id " +
                      "order by f.id";
            }
            else
            {
                sql = "select f.id, f.judul, f.sinopsis, f.tahun, f.durasi, f.bahasa, f.is_sub_indo,f.cover_image, f.diskon_nominal, " +
                      "f.kelompoks_id, k.nama " +
                      "from films as f " +
                      "inner join kelompoks as k on f.kelompoks_id = k.id " +
                      "where " + kriteria + " = '" + nilaiKriteria + "'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Film> listFilm = new List<Film>();

            while (hasil.Read())
            {
                Kelompok k = new Kelompok(int.Parse(hasil.GetValue(9).ToString()), hasil.GetValue(10).ToString());


                Film f = new Film();
                f.Id = int.Parse(hasil.GetValue(0).ToString());
                f.Judul = hasil.GetValue(1).ToString();
                f.Sinopsis = hasil.GetValue(2).ToString();
                f.Tahun = int.Parse(hasil.GetValue(3).ToString());
                f.Durasi = int.Parse(hasil.GetValue(4).ToString());
                f.Kelompok = k;
                f.Bahasa = hasil.GetValue(5).ToString();
                if (hasil.GetValue(6).ToString() == "1")
                {
                    f.IsSubIndo = true;
                }
                else
                {
                    f.IsSubIndo = false;
                }
                f.CoverImage = hasil.GetValue(7).ToString();
                if (hasil.GetValue(8).ToString() != "")
                {
                    f.DiskonNominal = double.Parse(hasil.GetValue(8).ToString());
                }

                listFilm.Add(f);
            }

            foreach (Film f in listFilm)
            {
                Film.BacaDataAktor(f);
                Film.BacaDataGenre(f);
            }

            return listFilm;
        }

        public static void TambahData(Film f,Image coverImage)
        {
            f.Id = GenerateIdFilm();

            using(TransactionScope transcope = new TransactionScope())
            {
                try
                {
                    Koneksi k = new Koneksi();
                    int isSubIndo;
                    if (f.IsSubIndo)
                    {
                        isSubIndo = 1;
                    }
                    else
                    {
                        isSubIndo = 0;
                    }
                    f.CoverImage = Film.SimpanGambar(f,coverImage);
                    string sql = "insert into films " +
                                 "values('" + f.Id + "','" + f.Judul + "','" + f.Sinopsis + "','" + f.Tahun + "','" + f.Durasi + "','" + f.Kelompok.Id + "','" + f.Bahasa + "','" + isSubIndo + "','" + f.CoverImage + "','" + f.DiskonNominal + "')";
                    Koneksi.JalankanPerintahDML(sql,k);

                    foreach(Aktor_film af in f.AktorList)
                    {
                        string sql3 = "insert into aktor_film " +
                                      "values('" + af.Aktors.Id + "','" + f.Id + "','" + af.Peran + "')";
                        Koneksi.JalankanPerintahDML(sql3, k);
                    }
                    foreach(Genre_film gf in f.GenreList)
                    {
                        string sql4 = "insert into genre_film " +
                                      "values('" + f.Id + "','" + gf.Genres.Id + "')";
                        Koneksi.JalankanPerintahDML(sql4, k);
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

        public static bool HapusData(int idHapus)
        {
            string sql = "delete from films " +
                         "where id = '" + idHapus + "'";

            int jumlahDataDiubah = Koneksi.JalankanPerintahDML(sql);

            if (jumlahDataDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void UpdateData(Film f, Image i = null)
        {
            if(i != null)
            {
                Film.HapusGambar(f.CoverImage);
                f.CoverImage = Film.SimpanGambar(f, i);
            }
            string sql = "update films " +
                         "set judul = '" + f.Judul + "', " +
                         "sinopsis = '" + f.Sinopsis + "', " +
                         "tahun = '" + f.Tahun + "', " +
                         "durasi = '" + f.Durasi + "', " +
                         "kelompoks_id = '" + f.Kelompok.Id + "', " +
                         "cover_image = '" + f.CoverImage + "', " +
                         "bahasa = '" + f.Bahasa + "', " +
                         "is_sub_indo = '" + (f.IsSubIndo?1:0) + "', " +
                         "diskon_nominal = '" + f.DiskonNominal + "' " +
                         "where id = '" + f.Id + "'";
            Koneksi.JalankanPerintahDML(sql);


            string sql2 = "Delete from aktor_film " +
                          "where films_id = '" + f.Id + "'";
            Koneksi.JalankanPerintahDML(sql2);

            foreach (Aktor_film af in f.AktorList)
            {
                string sql3 = "insert into aktor_film " +
                              "values('" + af.Aktors.Id + "','" + f.Id + "','" + af.Peran + "')";
                Koneksi.JalankanPerintahDML(sql3);
            }

            string sql4 = "Delete from genre_film " +
                          "where films_id = '" + f.Id + "'";
            Koneksi.JalankanPerintahDML(sql4);
            foreach (Genre_film gf in f.GenreList)
            {
                string sql5 = "insert into genre_film " +
                              "values('" + f.Id + "','" + gf.Genres.Id + "')";
                Koneksi.JalankanPerintahDML(sql5);
            }

        }
        
        public void TambahAktor(Aktor a, string peran)
        {
            Aktor_film af = new Aktor_film(this,a,peran);
            AktorList.Add(af);

        }

        public void TambahGenre(Genre g)
        {
            Genre_film gf = new Genre_film(this,g);
            GenreList.Add(gf);
        }

        public static void BacaDataAktor(Film f)
        {
            string sql = "select * " +
                         "from aktor_film as af " +
                         "inner join aktors as a on af.aktors_id = a.id " +
                         "where af.films_id = '" + f.id + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
                Aktor a = new Aktor();
                a.Id = int.Parse(hasil.GetValue(3).ToString());
                a.Nama = hasil.GetValue(4).ToString();
                a.Tgl_Lahir = DateTime.Parse(hasil.GetValue(5).ToString());
                a.Gender = hasil.GetValue(6).ToString();
                a.NegaraAsal = hasil.GetValue(7).ToString();

                Aktor_film af = new Aktor_film();
                af.Films = f;
                af.Aktors = a;
                af.Peran = hasil.GetValue(2).ToString();

                f.AktorList.Add(af);
            }
        }


        public static void BacaDataGenre(Film f)
        {
            string sql = "select * from genre_film as gf " +
                         "inner join genres as g on gf.genres_id = g.id " +
                         "where gf.films_id = '" + f.Id + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            while (hasil.Read())
            {
                Genre g = new Genre();
                g.Id = int.Parse(hasil.GetValue(2).ToString());
                g.Nama = hasil.GetValue(3).ToString();
                g.Deskripsi = hasil.GetValue(4).ToString();

                Genre_film gf = new Genre_film();
                gf.Films = f;
                gf.Genres = g;

                f.GenreList.Add(gf);
            }
        }

        public static int GenerateIdFilm()
        {
            string sql = "select max(id) from films";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            int id;
            if (hasil.Read())
            {
                id = int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            else
            {
                id = 1;
            }
            return id; 
        }

        public static string SimpanGambar(Film f, Image image)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingSection = userSettings.Sections["ProjectDatabase.db"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("cover_image").Value.ValueXml.InnerText;

            if(image != null)
            {
                image.Save(path + "\\film_" + f.Id );
                return "film_" + f.Id;

            }
            else
            {
                return "";
            }
        }

        public static Image BacaGambar(string cover_image)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingSection = userSettings.Sections["ProjectDatabase.db"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("cover_image").Value.ValueXml.InnerText;
            try
            {
                Image coverImage = Image.FromFile(path + "\\" + cover_image );
                return coverImage;
            }
            catch
            {
                return null;
            }
        }

        public static bool HapusGambar(string cover_image)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingSection = userSettings.Sections["ProjectDatabase.db"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("cover_image").Value.ValueXml.InnerText;
            if (File.Exists(path + "\\" + cover_image))
            {
                File.Delete(path + "\\" + cover_image);
                return true;
            }
            return false;
        }
    }
}
