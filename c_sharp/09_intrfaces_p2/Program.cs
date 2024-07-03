using _09_intrfaces_p2;

namespace _c_sharp_
{
    class Program
    {
        public static void Main(string[] args)
        {
            Movie outa = new Movie("Once Upon a Time in America","Sergio","Leone", Genre.Criminal,"USA",1984,8.3);
            Movie donie_brasco = new Movie("Donnie Brasco","Mike","Newell",Genre.Criminal,"USA",1997,7.7);
            Movie h_k = new Movie("Harold & Kumar","Danny","Leiner",Genre.Comedy,"USA",2004,7.0);
            Movie starIsBorn = new Movie("A Star is Born", "Bradley", "Cooper", Genre.Drama, "USA", 2018,7.6);
            Cinema ukraina=new Cinema("Rivne",outa,donie_brasco,h_k,starIsBorn);
            //ukraina.Display();
            //Console.WriteLine("###############################");
            //ukraina.Sort();
            //ukraina.Display();
            //Console.WriteLine("###############################");
            //ukraina.Sort(new RatingComparer());
            //ukraina.Display();
            //Console.WriteLine("###############################");
            //ukraina.Sort(new YearComparer());
            //ukraina.Display();
            foreach(var movie in ukraina)
            {
                Console.WriteLine(movie);
            }

        }
    }
}
