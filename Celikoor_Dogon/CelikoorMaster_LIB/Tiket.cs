using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CelikoorMaster_LIB
{
    public class Tiket
    {
        private Invoice invoices;
        private string nomor_kursi;
        private bool status_hadir;
        private Pegawai operators;
        private double harga;
        private Sesi_films sesi_film;

        public Tiket()
        {
            Invoices = new Invoice();
            Nomor_kursi = "";
            Status_hadir = false;
            Operators = new Pegawai();
            Harga = 0;
            Sesi_film = new Sesi_films();
        }
        public Tiket(Invoice invoices, string nomor_kursi, bool status_hadir, Pegawai operators, double harga, Sesi_films sesi_film)
        {
            Invoices = invoices;
            Nomor_kursi = nomor_kursi;
            Status_hadir = status_hadir;
            Operators = operators;
            Harga = harga;
            Sesi_film = sesi_film;
        }

        public Invoice Invoices { get => invoices; set => invoices = value; }
        public string Nomor_kursi { get => nomor_kursi; set => nomor_kursi = value; }
        public bool Status_hadir { get => status_hadir; set => status_hadir = value; }
        public Pegawai Operators { get => operators; set => operators = value; }
        public double Harga { get => harga; set => harga = value; }
        public Sesi_films Sesi_film { get => sesi_film; set => sesi_film = value; }

        public static Boolean AbsenCustomers(Tiket t, Pegawai pegawai)
        {
            string sql = "select invoices_id, nomor_kursi, operator_id, status_hadir " +
                         " from tikets where  invoices_id ='" + t.Invoices.Id + "' and nomor_kursi ='" + t.Nomor_kursi + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if(hasil.Read() == true)
            {               
                if (int.Parse(hasil.GetValue(3).ToString()) == 0)
                {                 
                    t.Operators = pegawai;

                    string sql2 = "update tikets set status_hadir ='1', operator_id ='" + pegawai.Id + "'" +
                              " where invoices_id ='" + t.Invoices.Id + "' and nomor_kursi ='" + t.Nomor_kursi + "'";
                    Koneksi.JalankanPerintahDML(sql2);
                    t.Status_hadir = true;
                    return true;
                    
                }
                else
                {
                    t.Status_hadir = false;
                    throw new Exception("Tiket sudah terabsen");
                }

            }
            else
            {
                throw new Exception("Tiket tidak valid atau tidak ditemukan");              
            }
             
        }
    }
}
