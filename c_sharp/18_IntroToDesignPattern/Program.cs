using _18_IntroToDesignPattern;

namespace _c_sharp_
{

    class Program
    {
        static void Main(string[] args)
        {
            PC pC = new PC();
            IPCfactory homeFactory=new HomePCFactory();
            IPCfactory oficeFactory=new OfficePCFactory();
            PCconfigurator homePCconfigurator=new PCconfigurator(homeFactory);
            PCconfigurator oficeConfigurator=new PCconfigurator(oficeFactory);
            homePCconfigurator.Configurate(pC);
            Console.WriteLine("Home PC.");
            pC.Print();
            oficeConfigurator.Configurate(pC);
            Console.WriteLine("Ofice PC.");
            pC.Print();




        }
    }
}
