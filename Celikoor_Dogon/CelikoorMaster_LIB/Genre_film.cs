using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CelikoorMaster_LIB
{
    public class Genre_film
    {
        private Film films;
        private Genre genres;

        public Genre_film()
        {
            Films = new Film();
            Genres = new Genre();
        }
        public Genre_film(Film films, Genre genres)
        {
            Films = films;
            Genres = genres;
        }

        public Film Films { get => films; set => films = value; }
        public Genre Genres { get => genres; set => genres = value; }

    }
}
