using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _09_intrfaces_p2
{
    enum Genre
    {
        Comedy,
        Horror,
        Adventure,
        Drama
    }
    internal class Movie:ICloneable, IComparable<Movie>
    {
        public string Title { get; set; }
        public Director Director { get; set; }
        public Genre Genre { get; set; }
        public string Country { get; set; }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = (value<2024&&value>1894)?value:throw   new Exception(); }
        }
        public Movie() { }
        public Movie(string title, string name,string sourname, Genre genre, string country, int year)
        {
            Title = title;
            Director = new Director(name, sourname);
            this.Genre = genre;
            Country = country;
            Year = year;
        }
        public override string ToString()
        {
            return $"Title: {Title}\nDirector: {Director}" +
                $"\n{this.Genre}\n{Country}\n{Year} y";
        }

        public object Clone()
        {
            
            Movie copy= (Movie)this.MemberwiseClone();
            copy.Director=(Director)this.Director.Clone();

            return copy;
        }

        public int CompareTo(Movie? other)
        {
            throw new NotImplementedException();
        }
    }
}
