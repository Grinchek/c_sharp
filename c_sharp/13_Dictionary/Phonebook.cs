using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Dictionary
{
    internal class Phonebook
    {
		private Dictionary<string,string> myPhonebook;
        //Phonebook() { myPhonebook = new Dictionary<string, string>(); }
        public Phonebook(string name,string number) {
            myPhonebook = new Dictionary<string, string>
            {
                { name, number }
            };
}
        public void WriteDown()
        {
            string newName;
            while (true)
            {
                Console.WriteLine("Enter name: ");
                newName = Console.ReadLine();
                if(myPhonebook.ContainsKey(newName))
                {
                    Console.WriteLine("There is this name already.");
                }
                else
                {
                    newName = newName;
                    break;}
                    
            }
            while(true)
            {
                Console.WriteLine("Enter number(format(+XXX XX XXX XX XX)): ");
                string newNumber = Console.ReadLine();
                if (newNumber.Length != 13 || newNumber[0]!='+')
                {
                    Console.WriteLine("Pleace check your input (wrong length or format)");
                }
                else
                {
                    
                    myPhonebook.Add(newName, newNumber);
                    break;
                   
                }

            }
             
        }
        public string Search()
        {
            Console.WriteLine("Enter name, you want to find:");
            string input= Console.ReadLine();
            if (myPhonebook.ContainsKey(input)) {
                return myPhonebook[input];
            }
            else {return "Abonent you entered not exist of wrong input value."; }
        }
        public void Display()
        {
            foreach(KeyValuePair<string,string> elem in myPhonebook)
            {
                Console.WriteLine($"Name: {elem.Key}\nNumber: {elem.Value}");
            }
        }

    }
}
