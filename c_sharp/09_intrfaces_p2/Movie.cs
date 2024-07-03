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
        Drama,
        Criminal
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
        private double rating;

        public double Rating
        {
            get { return Math.Round(rating,2); }
            set { rating = (value>0.0&&value<10.0)?Math.Round(value,2):throw new Exception(); }
        }

        public Movie() { }
        public Movie(string title, string name,string sourname, Genre genre, string country, int year,double rating)
        {
            Title = title;
            Director = new Director(name, sourname);
            this.Genre = genre;
            Country = country;
            Year = year;
            Rating = rating;
        }
        public override string ToString()
        {
            return $"-------------------------------\n" +
                $"{Title}\n{Director}" +
                $"\n{this.Genre}\n{Country}\n{Year} y\n" +
                $"Ratings {Rating}";
        }

        public object Clone()
        {
            
            Movie copy= (Movie)this.MemberwiseClone();
            copy.Director=(Director)this.Director.Clone();

            return copy;
        }

        public int CompareTo(Movie? other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }
}
