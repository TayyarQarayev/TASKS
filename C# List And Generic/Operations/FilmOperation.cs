using C__List_And_Generic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__List_And_Generic.Operations
{
    public class FilmOperation : GenericOperation<Film>, IFilm
    {
        public FilmOperation(List<Film> collection) : base(collection)
        {

        }

        enum Price
        {
            Pis,
            Yaxşı,
            Əla,
        }
        public double FilmPrice(Film film)
        {
            if (film.ImdbScore >= 2 && film.ImdbScore <= 5)
            {
                return (double)Price.Pis;
            }
            else if (film.ImdbScore > 5 && film.ImdbScore <= 7.5)
            {
                return (double)Price.Yaxşı;
            }
            else if (film.ImdbScore > 7.5 && film.ImdbScore <= 10)
            {
                return (double)Price.Əla;
            }
            else
            {
                return 0;
            }
        }
    }
}
