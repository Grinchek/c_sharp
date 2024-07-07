using _13_Dictionary;

namespace _c_sharp_
{

    class Program
    {
        static void Main(string[] args)
        {
            Phonebook phonebook=new Phonebook("Ivan","+380971454437");
            phonebook.WriteDown();
            phonebook.Display();
        }
    }
}