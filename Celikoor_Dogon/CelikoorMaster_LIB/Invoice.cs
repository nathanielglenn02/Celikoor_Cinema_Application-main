using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Web;

namespace CelikoorMaster_LIB
{
    public class Invoice
    {
        private int id;
        private DateTime tanggal;
        private int grandTotal;
        private double diskonNominal;
        private Konsumen konsumen;
        private Pegawai kasir;
        private string status;
        List<Tiket> tiket;

        public Invoice()
        {
            this.Id = 0;
            this.Tanggal = DateTime.Now;
            this.GrandTotal = 0;
            this.DiskonNominal = 0;
            this.Konsumen = new Konsumen();
            this.Kasir = new Pegawai();
            this.Status = "";
            this.Tiket = new List<Tiket>();
            
        }
        public Invoice(int id, DateTime tanggal, int grandTotal, double diskonNominal, Konsumen konsumen, Pegawai kasir, string status)
        {
            this.Id = id;
            this.Tanggal = tanggal;
            this.GrandTotal = grandTotal;
            this.DiskonNominal = diskonNominal;
            this.Konsumen = konsumen;
            this.Kasir = kasir;
            this.Status = status;
            this.Tiket = new List<Tiket>();
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public int GrandTotal { get => grandTotal; set => grandTotal = value; }
        public double DiskonNominal { get => diskonNominal; set => diskonNominal = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status { get => status; set => status = value; }

        public List<Tiket> Tiket { get => tiket; set => tiket = value; }

        public static List<Invoice> BacaData(string kriteria = "", string nilaiKriteria = "",string kriteria2 = "", string nilaiKriteria2 = "")
        {
            string sql;

            sql = "select i.id, i.tanggal, i.grand_total, i.diskon_nominal, i.status," +
                  "i.konsumens_id, k.nama, k.email, k.no_hp, k.gender, k.tgl_lahir, k.saldo, k.username," +
                  "i.kasir_id, p.nama, p.email, p.username, p.roles " +
                  "from invoices as i " +
                  "inner join konsumens as k on i.konsumens_id = k.id " +
                  "left join pegawais as p on i.kasir_id = p.id";
            if(kriteria != "")
            {
                sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
                if(kriteria2 != "")
                {
                    sql += " and " + kriteria2 + " like '%" + nilaiKriteria2 + "%'";
                }
            }                        

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Invoice> listInvoice = new List<Invoice>();

            while (hasil.Read())
            {
                Konsumen k = new Konsumen(int.Parse(hasil.GetValue(5).ToString()),
                                          hasil.GetValue(6).ToString(),
                                          hasil.GetValue(7).ToString(),
                                          hasil.GetValue(8).ToString(),
                                          hasil.GetValue(9).ToString(),
                                          DateTime.Parse(hasil.GetValue(10).ToString()),
                                          double.Parse(hasil.GetValue(11).ToString()),
                                          hasil.GetValue(12).ToString());
                Pegawai p;
                if(hasil.GetValue(13).ToString() != "")
                {
                    p = new Pegawai(int.Parse(hasil.GetValue(13).ToString()),
                                        hasil.GetValue(14).ToString(),
                                        hasil.GetValue(15).ToString(),
                                        hasil.GetValue(16).ToString(),
                                        hasil.GetValue(17).ToString());

                }
                else
                {
                    p = new Pegawai();
                }

                Invoice i = new Invoice(int.Parse(hasil.GetValue(0).ToString()),
                                        DateTime.Parse(hasil.GetValue(1).ToString()),
                                        int.Parse(hasil.GetValue(2).ToString()),
                                        double.Parse(hasil.GetValue(3).ToString()),
                                        k,
                                        p,
                                        hasil.GetValue(4).ToString());
                listInvoice.Add(i);
            }
            return listInvoice;
        }

        public static List<Invoice> BacaDataByID(string idKonsumen)
        {
            string sql;

            sql = "select i.id, i.tanggal, i.grand_total, i.diskon_nominal, i.status," +
                  "i.konsumens_id, k.nama, k.email, k.no_hp, k.gender, k.tgl_lahir, k.saldo, k.username," +
                  "i.kasir_id, p.nama, p.email, p.username, p.roles " +
                  "from invoices as i " +
                  "inner join konsumens as k on i.konsumens_id = k.id " +
                  "left join pegawais as p on i.kasir_id = p.id " +
                  "where i.konsumens_id = '" + idKonsumen + "'";


            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Invoice> listInvoice = new List<Invoice>();

            while (hasil.Read())
            {
                Konsumen k = new Konsumen(int.Parse(hasil.GetValue(5).ToString()),
                                          hasil.GetValue(6).ToString(),
                                          hasil.GetValue(7).ToString(),
                                          hasil.GetValue(8).ToString(),
                                          hasil.GetValue(9).ToString(),
                                          DateTime.Parse(hasil.GetValue(10).ToString()),
                                          double.Parse(hasil.GetValue(11).ToString()),
                                          hasil.GetValue(12).ToString());
                Pegawai p;
                if (hasil.GetValue(13).ToString() != "")
                {
                    p = new Pegawai(int.Parse(hasil.GetValue(13).ToString()),
                                        hasil.GetValue(14).ToString(),
                                        hasil.GetValue(15).ToString(),
                                        hasil.GetValue(16).ToString(),
                                        hasil.GetValue(17).ToString());

                }
                else
                {
                    p = new Pegawai();
                }

                Invoice i = new Invoice(int.Parse(hasil.GetValue(0).ToString()),
                                        DateTime.Parse(hasil.GetValue(1).ToString()),
                                        int.Parse(hasil.GetValue(2).ToString()),
                                        double.Parse(hasil.GetValue(3).ToString()),
                                        k,
                                        p,
                                        hasil.GetValue(4).ToString());
                listInvoice.Add(i);
            }
            return listInvoice;
        }

        public static void TambahData(Invoice i, Konsumen konsumen)
        {
            if (konsumen.Saldo >= i.GrandTotal)
            {
                i.Id = GenerateId();
                i.Status = "PENDING";

                foreach(Tiket t in i.Tiket)
                {
                    t.Invoices = i;
                    t.Status_hadir = false;
                }
            
                using (TransactionScope transactionScope = new TransactionScope())
                {
                    try
                    {
                        Koneksi k = new Koneksi();
                        string sql = "insert into invoices " +
                                     "values('" + i.Id + "',now(),'" + i.GrandTotal + "','" + i.DiskonNominal + "','" + i.Konsumen.Id + "',null,'" + i.Status + "')";
                        Koneksi.JalankanPerintahDML(sql, k);
                        foreach(Tiket t in i.Tiket)
                        {
                            string sql2 = "insert into tikets " +
                                          "values('" + i.Id + "','" + t.Nomor_kursi + "','0',null,'" + t.Harga + "','" + t.Sesi_film.JadwalFilms.Id + "','" + t.Sesi_film.Film_studios.Studios.Id + "','" + t.Sesi_film.Film_studios.Films.Id + "')";
                            Koneksi.JalankanPerintahDML(sql2, k);
                        }
                        Konsumen.UpdateSaldo(konsumen, i.GrandTotal, k);
                        transactionScope.Complete();

                    }
                    catch(Exception ex)
                    {
                        transactionScope.Dispose();
                        throw new Exception(ex.Message);
                    }
                }
            }
            else
            {
                throw new Exception("Saldo tidak cukup");
            }
        }
        public static bool UpdateDataTerbayar(Invoice i)
        {
            if(i.Status == "VALIDASI")
            {
                string sql = "update Invoices " +
                             "set status = '" + "terbayar'" +
                             " where id = '" + i.Id + "'";
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
            else
            {
                return false;
            }
        }
        public static bool UpdateDataValidasi(Invoice i)
        {
            if(i.Status == "PENDING")
            {
                string sql = "update Invoices " +
                             "set status = '" + "validasi', kasir_id = '" + i.Kasir.Id + "' " +
                             " where id = '" + i.Id + "'";
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
            else
            {
                return false;
            }
        }

        public static void BacaDataTiket(Invoice i)
        {
            string sql = "select * from tikets left join pegawais on tikets.operator_id = pegawais.id " +
                         "where invoices_id = '" + i.Id + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
                Tiket tiket = new Tiket();
                tiket.Invoices = i;
                tiket.Nomor_kursi = hasil.GetValue(1).ToString();
                tiket.Status_hadir = int.Parse(hasil.GetValue(2).ToString())==1?true:false;
                if (hasil.GetValue(3).ToString()!= "")
                {
                    tiket.Operators.Id = int.Parse(hasil.GetValue(3).ToString());
                    tiket.Operators.Nama = hasil.GetValue(9).ToString();
                    tiket.Operators.Username = hasil.GetValue(10).ToString();
                    tiket.Operators.Roles = hasil.GetValue(12).ToString();

                }
                tiket.Harga = double.Parse(hasil.GetValue(4).ToString());
                tiket.Sesi_film.JadwalFilms.Id = int.Parse(hasil.GetValue(5).ToString());
                tiket.Sesi_film.Film_studios.Studios.Id = int.Parse(hasil.GetValue(6).ToString());
                tiket.Sesi_film.Film_studios.Films.Id = int.Parse(hasil.GetValue(7).ToString());


                i.Tiket.Add(tiket);
            }
            foreach(Tiket t in i.Tiket)
            {
                t.Sesi_film = Sesi_films.BacaData("jadwal_film_id", t.Sesi_film.JadwalFilms.Id.ToString(), "studios_id", t.Sesi_film.Film_studios.Studios.Id.ToString(), "films_id", t.Sesi_film.Film_studios.Films.Id.ToString())[0];
            }

        }
        public static int GenerateId()
        {
            string sql = "select max(id) from invoices";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                if(hasil.GetValue(0).ToString() != "")
                {
                    return int.Parse(hasil.GetValue(0).ToString()) + 1;
                }
             
            }
            return 1;
        }
    }
}
