using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CelikoorMaster_LIB
{
    public class Aktor_film 
    {
        private Film films;
        private Aktor aktors;
        private string peran;

        public Aktor_film()
        {
            Films = new Film();
            Aktors = new Aktor();
            Peran = "";
        }
        public Aktor_film(Film films, Aktor aktors, string peran)
        {
            Films = films;
            Aktors = aktors;
            Peran = peran;
        }

        public Film Films { get => films; set => films = value; }
        public Aktor Aktors { get => aktors; set => aktors = value; }
        public string Peran { get => peran; set => peran = value; }

    }
}
