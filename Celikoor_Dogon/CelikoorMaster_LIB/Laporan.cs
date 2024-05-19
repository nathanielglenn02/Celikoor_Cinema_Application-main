using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CelikoorMaster_LIB
{
    public class Laporan
    {
        public static string BacaDataTotalTiketTerjual(int bulan, int tahun)
        {
            string sql = "select count(t.status_hadir) as total_konsumen from konsumens as k " +
                         "inner join invoices as i on k.id = i.konsumens_id " +
                         "inner join tikets as t on i.id = t.invoices_id " +
                         "where t.status_hadir = 1 and month(i.tanggal) = '" + bulan + "' and year(i.tanggal) = '" + tahun + "' " +
                         "group by t.status_hadir";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            string totalTiket = "";
            if (hasil.Read())
            {
                totalTiket = hasil.GetValue(0).ToString();
            }
            return totalTiket;
        }


        //return jumlah film terlaris dari bulan dan tahun di parameter[tahun,bulan,judulfilm,jumlahpenonton]
        public static List<string> BacaDataFilmTerlaris(int bulan, int tahun)
        {
            string sql = "select f.judul, count(f.id) from films as f " +
                         "inner join tikets as t on f.id = t.films_id " +
                         "inner join invoices as i on t.invoices_id = i.id " +
                         "where t.status_hadir = 1 and month(i.tanggal) = '" + bulan + "' and year(i.tanggal) = '" + tahun + "' " +
                         "group by month(i.tanggal), f.id " +
                         "order by count(f.id) desc limit 1 ";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<string> listFilmTerlaris = new List<string>();
            if (hasil.Read())
            {
                listFilmTerlaris.Add(tahun.ToString());
                listFilmTerlaris.Add(bulan.ToString());
                listFilmTerlaris.Add(hasil.GetValue(0).ToString());
                listFilmTerlaris.Add(hasil.GetValue(1).ToString());
            }
            return listFilmTerlaris;
        }

        public static List<Tuple<string, int>> BacaDataCabangPemasukanTerbanyak()
        {
            string sql = "select c.nama_cabang, sum(t.harga) as total_transaksi from cinemas as c " +
                         "inner join studios as s on c.id= s.cinemas_id " +
                         "inner join tikets as t on s.id = t.studios_id " +
                         "inner join invoices as i on t.invoices_id = i.id " +
                         "group by c.id " +
                         "order by total_transaksi desc " +
                         "limit 3";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Tuple<string, int>> listCabangPemasukanTerbanyak = new List<Tuple<string, int>>();
            while (hasil.Read())
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    listCabangPemasukanTerbanyak.Add(new Tuple<string, int>(hasil.GetValue(0).ToString(), int.Parse(hasil.GetValue(1).ToString())));

                }
            }
            return listCabangPemasukanTerbanyak;
        }

        //return 3 film teratas yang paling banyak jumlah ketidakhadirannya [judulFilm, status_hadir]
        public static List<Tuple<string, int>> BacaDataFilmTeratasKetidakhadiraan()
        {
            string sql = "SELECT f.judul, COUNT(CASE WHEN t.status_hadir = 0 THEN 1 END) AS" +
                         " jumlah_tidak_hadir FROM invoices AS i" +
                         " INNER JOIN tikets AS t ON i.id = t.invoices_id" +
                         " INNER JOIN films AS f ON t.films_id = f.id" +
                         " WHERE t.status_hadir = 0" +
                         " GROUP BY f.judul" +
                         " ORDER BY jumlah_tidak_hadir DESC" +
                         " LIMIT 3";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Tuple<string, int>> listFilmTidakhadir = new List<Tuple<string, int>>();
            while (hasil.Read())
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    listFilmTidakhadir.Add(new Tuple<string, int>(hasil.GetValue(0).ToString(), int.Parse(hasil.GetValue(1).ToString())));

                }
            }
            return listFilmTidakhadir;
        }

        public static List<String> BacaDataUtilitasTerendah(int bulan, int tahun)
        {
            string sql = "SELECT s.nama, c.nama_cabang, s.kapasitas - COUNT(t.nomor_kursi) AS tingkat_utilitas " +
                         "FROM cinemas AS c " +
                         "INNER JOIN studios AS s ON c.id = s.cinemas_id " +
                         "INNER JOIN tikets AS t ON s.id = t.studios_id " +
                         "INNER JOIN invoices as i on t.invoices_id = i.id " +
                         "where month(i.tanggal) = '"+ bulan +"' and year(i.tanggal) = '"+tahun+"' " +
                         "GROUP BY month(i.tanggal), s.nama, c.nama_cabang " +
                         "ORDER BY tingkat_utilitas ASC " +
                         "LIMIT 3";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<String> listStudioUtilitasTerendah = new List<string>();
            if(hasil.Read())
            {
                listStudioUtilitasTerendah.Add(tahun.ToString());
                listStudioUtilitasTerendah.Add(bulan.ToString());
                listStudioUtilitasTerendah.Add(hasil.GetValue(0).ToString());
                listStudioUtilitasTerendah.Add(hasil.GetValue(1).ToString());
                listStudioUtilitasTerendah.Add(hasil.GetValue(2).ToString());
            }
            return listStudioUtilitasTerendah;
        }


        //[namaCustomer, banyaknya menonton film bergenre comedy]
        public static List<Tuple<string,int>> BacaKonsumenSukaGenreComedy()
        {
            string sql = "select k.nama, count(g.nama) from konsumens as k" +
                         " inner join invoices as i on k.id = i.konsumens_id" +
                         " inner join tikets as t on i.id = t.invoices_id" +
                         " inner join films as f on t.films_id = f.id" +
                         " inner join genre_film as gf on f.id = gf.films_id" +
                         " inner join genres as g on gf.genres_id = g.id" +
                         " where g.nama = 'comedy'" +
                         " group by k.id" +
                         " order by count(g.nama) desc limit 10";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Tuple<string,int>> listKonsumenSukaComedy = new List<Tuple<string,int>>();
            while(hasil.Read())
            {
                if (hasil.GetValue(0).ToString()!="")
                {
                    listKonsumenSukaComedy.Add(new Tuple<string,int>(hasil.GetValue(0).ToString(),int.Parse(hasil.GetValue(1).ToString())));

                }
            }
            return listKonsumenSukaComedy;
        }
        public static void PrintLaporan1(int tahun)
        {

            string namaFile = "Laporan Database Celikoor_Dogon";
            StreamWriter tempFile = new StreamWriter(namaFile);
            tempFile.WriteLine("");
            tempFile.WriteLine("Celikoor Dogon");
            tempFile.WriteLine("XII Cinema 21");
            tempFile.WriteLine("Phone. (031)-123456");
            tempFile.WriteLine("=".PadRight(50, '='));

            tempFile.WriteLine(("Laporan Jumlah Film Terlaris Tahun " + tahun));
            tempFile.WriteLine("");
            tempFile.Write("Tahun".PadRight(10, ' '));
            tempFile.Write("Bulan".PadRight(10, ' '));
            tempFile.Write("Judul Film".PadRight(20, ' '));
            tempFile.Write("Jumlah Penonton".PadRight(20, ' '));
            tempFile.WriteLine("");
            for(int i = 1; i<= 12; i++)
            {
                List<string> filmTerlarisList = Laporan.BacaDataFilmTerlaris(i, tahun);
                if (filmTerlarisList.Count != 0)
                {
                    tempFile.Write(filmTerlarisList[0].PadRight(10, ' '));
                    tempFile.Write(filmTerlarisList[1].PadRight(10, ' '));
                    tempFile.Write(filmTerlarisList[2].PadRight(20, ' '));
                    tempFile.Write(filmTerlarisList[3].PadRight(20, ' '));
                }
                else
                {
                    tempFile.Write(tahun.ToString().PadRight(10, ' '));
                    tempFile.Write(i.ToString().PadRight(10, ' '));
                    tempFile.Write("Tidak Ada Data".PadRight(20, ' '));
                    tempFile.Write("Tidak Ada Data".PadRight(20, ' '));
                }
                tempFile.WriteLine("");
            }

            tempFile.WriteLine("");

            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("Thank you");
            tempFile.WriteLine("");

            tempFile.Close();

            CustomPrint p = new CustomPrint(new Font("Courier New", 12), namaFile, 20, 10, 10, 10);
            p.SendToPrinter();
        }
        public static void PrintLaporan2()
        {
            string namaFile = "Laporan Database Celikoor_Dogon";
            StreamWriter tempFile = new StreamWriter(namaFile);

            tempFile.WriteLine("");
            tempFile.WriteLine("Celikoor Dogon");
            tempFile.WriteLine("XII Cinema 21");
            tempFile.WriteLine("Phone. (031)-123456");
            tempFile.WriteLine("=".PadRight(50, '='));

            tempFile.WriteLine("");
            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("");

            tempFile.WriteLine("Laporan Peringkat 3 Cabang Terbanyak Mendapatkan Pemasukan");
            tempFile.WriteLine("");
            tempFile.WriteLine("NamaCabang TotalPemasukan");
            List<Tuple<string, int>> temp = Laporan.BacaDataCabangPemasukanTerbanyak();
            foreach (var c in temp)
            {
                tempFile.Write(c.Item1.PadRight(25, ' '));
                tempFile.Write(c.Item2.ToString().PadRight(25, ' '));
            }

            tempFile.Close();

            CustomPrint p = new CustomPrint(new Font("Courier New", 12), namaFile, 20, 10, 10, 10);
            p.SendToPrinter();
        }
        public static void PrintLaporan3()
        {
            string namaFile = "Laporan Database Celikoor_Dogon";
            StreamWriter tempFile = new StreamWriter(namaFile);

            tempFile.WriteLine("");
            tempFile.WriteLine("Celikoor Dogon");
            tempFile.WriteLine("XII Cinema 21");
            tempFile.WriteLine("Phone. (031)-123456");
            tempFile.WriteLine("=".PadRight(50, '='));

            tempFile.WriteLine("");
            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("");
            

            tempFile.WriteLine("Laporan 3 Film Dengan Jumlah Ketidakhadiran Paling Banyak");
            tempFile.WriteLine("");
            tempFile.Write("Judul Film".PadRight(25, ' '));
            tempFile.Write("Jumlah Ketidakhadiran".PadRight(25, ' '));
            tempFile.WriteLine();

            List<Tuple<string, int>> temp = Laporan.BacaDataFilmTeratasKetidakhadiraan();
            foreach (var c in temp)
            {
                tempFile.Write(c.Item1.PadRight(25,' '));
                tempFile.Write(c.Item2.ToString().PadRight(25,' '));
            }

            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("Thank you");
            tempFile.WriteLine("");
            tempFile.Close();

            CustomPrint p = new CustomPrint(new Font("Courier New", 12), namaFile, 20, 10, 10, 10);
            p.SendToPrinter();

        }

        public static void PrintLaporan4(int tahun)
        {
            string namaFile = "Laporan Database Celikoor_Dogon";
            StreamWriter tempFile = new StreamWriter(namaFile);

            tempFile.WriteLine("");
            tempFile.WriteLine("Celikoor Dogon");
            tempFile.WriteLine("XII Cinema 21");
            tempFile.WriteLine("Phone. (031)-123456");
            tempFile.WriteLine("=".PadRight(50, '='));

            tempFile.WriteLine("");
            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("");

            tempFile.WriteLine("Laporan Peringkat 3 Studio dan Cinema Dengan Utilitas Terendah");
            tempFile.WriteLine("");
            for (int i = 1; i <= 12; i++)
            {
                List<string> studioUtilitasTerendah = Laporan.BacaDataUtilitasTerendah(i, tahun);
                if (studioUtilitasTerendah.Count != 0)
                {
                    tempFile.Write(studioUtilitasTerendah[0].PadRight(10, ' '));
                    tempFile.Write(studioUtilitasTerendah[1].PadRight(10, ' '));
                    tempFile.Write(studioUtilitasTerendah[2].PadRight(20, ' '));
                    tempFile.Write(studioUtilitasTerendah[3].PadRight(20, ' '));
                    tempFile.Write(studioUtilitasTerendah[4].PadRight(20, ' '));
                }
                else
                {
                    tempFile.Write(tahun.ToString().PadRight(10, ' '));
                    tempFile.Write(i.ToString().PadRight(10, ' '));
                    tempFile.Write("Tidak Ada Data".PadRight(20, ' '));
                    tempFile.Write("Tidak Ada Data".PadRight(20, ' '));
                    tempFile.Write("Tidak Ada Data".PadRight(20, ' '));
                }
                tempFile.WriteLine("");
            }

            tempFile.WriteLine("");

            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("Thank you");
            tempFile.WriteLine("");

            tempFile.Close();

            CustomPrint p = new CustomPrint(new Font("Courier New", 12), namaFile, 20, 10, 10, 10);
            p.SendToPrinter();
        }
        public static void PrintLaporan5()
        {
            string namaFile = "Laporan Database Celikoor_Dogon";
            StreamWriter tempFile = new StreamWriter(namaFile);

            tempFile.WriteLine("");
            tempFile.WriteLine("Celikoor Dogon");
            tempFile.WriteLine("XII Cinema 21");
            tempFile.WriteLine("Phone. (031)-123456");
            tempFile.WriteLine("=".PadRight(50, '='));

            tempFile.WriteLine("");
            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("");

            tempFile.WriteLine("Laporan 10 Konsumen Teratas Penyuka Genre Comedy");
            tempFile.WriteLine("");
            tempFile.Write("Nama Konsumen".PadRight(25, ' '));
            tempFile.Write("Jumlah Menonton film Comedy".PadRight(25, ' '));
            tempFile.WriteLine("");
            List<Tuple<string, int>> temp = Laporan.BacaKonsumenSukaGenreComedy();
            foreach (var a in temp)
            {
                tempFile.Write(a.Item1.PadRight(25, ' '));
                tempFile.Write(a.Item2.ToString().PadRight(25, ' '));
                tempFile.WriteLine("");
            }

            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("Thank you");
            tempFile.WriteLine("");

            tempFile.Close();

            CustomPrint p = new CustomPrint(new Font("Courier New", 12), namaFile, 20, 10, 10, 10);
            p.SendToPrinter();
        }
        
    }
}
