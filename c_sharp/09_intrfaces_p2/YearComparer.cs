using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_intrfaces_p2
{
    internal class YearComparer :IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }
}
