using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_intrfaces_p2
{
    internal class Cinema : IEnumerable
    {
        Movie[] movies;
        public string Address { get; set; }
        public Cinema() { }
        public Cinema(string address,params Movie[] movies)
        {
            this.movies = movies;
            Address = address;
        }
        public void Display()
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
        public void Sort()
        {
            Movie tmp = new Movie();

            //for (int i = 0; i < movies.Length; i++)
            //{

            //    for (int j = 0; j < movies.Length; j++)
            //    {
            //        if (movies[j].CompareTo(movies[i]) == 1)
            //        {
            //            tmp = movies[i];
            //            movies[i] = movies[j];
            //            movies[j] = tmp;

            //        }
            //    }

            //}
            Array.Sort(movies);
        }
        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
            Array.Reverse(movies);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return movies.GetEnumerator();
        }
    }
}
