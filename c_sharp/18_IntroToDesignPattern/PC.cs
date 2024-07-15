using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_IntroToDesignPattern
{
    internal class PC
    {
        public Box Box { get; set; }
        public Processor Proocessor { get; set; }
        public MainBoard MainBoard { get; set; }
        public HDD HDD { get; set; } 
        public Memory Memory { get; set; }  
        public PC() { }
        public PC(Box box,Processor processor,MainBoard mainboard,HDD hdd,Memory memory)
        {
            Box= box;
            Proocessor= processor;
            MainBoard= mainboard;
            HDD= hdd;
            Memory= memory;
        }
        public void Print()
        {
            Console.WriteLine();
        }

    }
}
