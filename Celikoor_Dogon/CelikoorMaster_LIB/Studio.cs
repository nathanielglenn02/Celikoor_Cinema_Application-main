using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelikoorMaster_LIB
{
    public class Studio
    {
        private int id;
        private string nama;
        private int kapasitas;
        JenisStudio jenisStudio;
        Cinema cinema;
        private int hargaWeekday;
        private int hargaWeekend;

        public Studio(int id, string nama, int kapasitas, JenisStudio jenisStudio, Cinema cinema, int hargaWeekday, int hargaWeekend)
        {
            this.Id = id;
            this.Nama = nama;
            this.Kapasitas = kapasitas;
            this.JenisStudio = jenisStudio;
            this.Cinema = cinema;
            this.HargaWeekday = hargaWeekday;
            this.HargaWeekend = hargaWeekend;
        }
        public Studio()
        {
            this.Id = 0;
            this.Nama = "";
            this.Kapasitas = 0;
            this.JenisStudio = new JenisStudio();
            this.Cinema = new Cinema();
            this.HargaWeekday = 0;
            this.HargaWeekend = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public JenisStudio JenisStudio { get => jenisStudio; set => jenisStudio = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }
        public int HargaWeekday { get => hargaWeekday; set => hargaWeekday = value; }
        public int HargaWeekend { get => hargaWeekend; set => hargaWeekend = value; }

        public static List<Studio> BacaData(string kriteria = "", string nilaiKriteria = "")
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select s.id, s.nama, s.kapasitas, s.harga_weekday, s.harga_weekend, " +
                      "s.jenis_studios_id, js.nama, js.deskripsi, " +
                      "s.cinemas_id, c.nama_cabang, c.alamat, c.tgl_dibuka, c.kota " +
                      "from studios as s " +
                      "inner join jenis_studios as js on s.jenis_studios_id = js.id " +
                      "inner join cinemas as c on s.cinemas_id = c.id";
            }
            else
            {
                sql = "select s.id, s.nama, s.kapasitas, s.harga_weekday, s.harga_weekend, " +
                      "s.jenis_studios_id, js.nama, js.deskripsi, " +
                      "s.cinemas_id, c.nama_cabang, c.alamat, c.tgl_dibuka, c.kota " +
                      "from studios as s " +
                      "inner join jenis_studios as js on s.jenis_studios_id = js.id " +
                      "inner join cinemas as c on s.cinemas_id = c.id " +
                      "where " + kriteria + " = '" + nilaiKriteria + "'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Studio> listStudio = new List<Studio>();

            while (hasil.Read())
            {
                JenisStudio js = new JenisStudio(int.Parse(hasil.GetValue(5).ToString()),
                                                 hasil.GetValue(6).ToString(),
                                                 hasil.GetValue(7).ToString());

                Cinema c = new Cinema(int.Parse(hasil.GetValue(8).ToString()),
                                      hasil.GetValue(9).ToString(),
                                      hasil.GetValue(10).ToString(),
                                      DateTime.Parse(hasil.GetValue(11).ToString()),
                                      hasil.GetValue(12).ToString());

                Studio s = new Studio(int.Parse(hasil.GetValue(0).ToString()),
                                      hasil.GetValue(1).ToString(),
                                      int.Parse(hasil.GetValue(2).ToString()),
                                      js,
                                      c,
                                      int.Parse(hasil.GetValue(3).ToString()),
                                      int.Parse(hasil.GetValue(4).ToString()));

                listStudio.Add(s);
            }
            return listStudio;
        }
        public static List<Studio> BacaDataFilter(string kriteria = "", string nilaiKriteria = "")
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select s.id, s.nama, s.kapasitas, s.harga_weekday, s.harga_weekend, " +
                      "s.jenis_studios_id, js.nama, js.deskripsi, " +
                      "s.cinemas_id, c.nama_cabang, c.alamat, c.tgl_dibuka, c.kota " +
                      "from studios as s " +
                      "inner join jenis_studios as js on s.jenis_studios_id = js.id " +
                      "inner join cinemas as c on s.cinemas_id = c.id";
            }
            else
            {
                sql = "select s.id, s.nama, s.kapasitas, s.harga_weekday, s.harga_weekend, " +
                      "s.jenis_studios_id, js.nama, js.deskripsi, " +
                      "s.cinemas_id, c.nama_cabang, c.alamat, c.tgl_dibuka, c.kota " +
                      "from studios as s " +
                      "inner join jenis_studios as js on s.jenis_studios_id = js.id " +
                      "inner join cinemas as c on s.cinemas_id = c.id " +
                      "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Studio> listStudio = new List<Studio>();

            while (hasil.Read())
            {
                JenisStudio js = new JenisStudio(int.Parse(hasil.GetValue(5).ToString()),
                                                 hasil.GetValue(6).ToString(),
                                                 hasil.GetValue(7).ToString());

                Cinema c = new Cinema(int.Parse(hasil.GetValue(8).ToString()),
                                      hasil.GetValue(9).ToString(),
                                      hasil.GetValue(10).ToString(),
                                      DateTime.Parse(hasil.GetValue(11).ToString()),
                                      hasil.GetValue(12).ToString());

                Studio s = new Studio(int.Parse(hasil.GetValue(0).ToString()),
                                      hasil.GetValue(1).ToString(),
                                      int.Parse(hasil.GetValue(2).ToString()),
                                      js,
                                      c,
                                      int.Parse(hasil.GetValue(3).ToString()),
                                      int.Parse(hasil.GetValue(4).ToString()));

                listStudio.Add(s);
            }
            return listStudio;
        }

        public static bool TambahData(Studio s)
        {
            s.Id = GenerateIdStudio();
            string sql = "insert into studios " +
                         "values('" + s.Id + "','" + s.Nama + "','" + s.Kapasitas + "','" + s.JenisStudio.Id + "','" + s.Cinema.Id + "','" + s.HargaWeekday + "','" + s.HargaWeekend + "')";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);

            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool UpdateData(Studio s)
        {
            string sql = "update studios " +
                         "set nama = '" + s.Nama + "', kapasitas = '" + s.Kapasitas + "', jenis_studios_id = '" + s.JenisStudio.Id + "', cinemas_id = '" + s.Cinema.Id + "', harga_weekday = '" + s.HargaWeekday + "', harga_weekend = '" + s.HargaWeekend + "' " +
                         "where id = '" + s.Id + "'";
            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool HapusData(Studio s)
        {
            string sql = "delete from studios " +
                         "where id = '" + s.Id + "'";
            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);

            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return Nama;
        }
        private static int GenerateIdStudio()
        {
            string sql = "select max(id) from studios";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }
    }
}