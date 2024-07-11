using _13_Dictionary;
using System.Text;

namespace _c_sharp_
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region phonebook
            //Phonebook phonebook =new Phonebook("Ivan","+380971454437");
            //phonebook.WriteDown();
            //Console.WriteLine(phonebook.Search());
            //phonebook.Display();
            #endregion
            #region statistick
            string text = "Ось будинок, який збудував Джек. А це пшениця, яка у темній коморі зберігається " +
                "у будинку, який збудував Джек. А це веселий птах-синиця, який часто краде пшеницю, " +
                "яка в темній коморі зберігається у будинку, який збудував Джек.";
            string[] chars = { " ",", ",". ","\n ","-","."};
            string[] strings = text.Split(chars,StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> statistic=new Dictionary<string, int>();
            foreach (string s in strings)
            {

                int counter = 0; 
                for (int i = 0; i < strings.Length; i++)
                {
                    
                    if (s == strings[i] )
                    {
                        counter++;
                    }
                  


                }
                try
                {
                    statistic.Add(s, counter);
                }
                catch (System.ArgumentException) { }
            }
            foreach (var elem in statistic)
            {
                Console.WriteLine($"{elem.Key} : {elem.Value}");
            }


            #endregion
        }
    }
}