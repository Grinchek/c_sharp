using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_IntroToDesignPattern
{
    internal class HomePCFactory : IPCfactory
    {
        public Box CreateBox()
        {
            return new SilverBox();
        }

        public HDD CreateHdd()
        {
            return new SamsungHdd();
        }

        public MainBoard CreateMainBoard()
        {
            return new MSIMainBoard();
        }

        public Memory CreateMemory()
        {
            return new DDR2Memory();
        }

        public Processor CreateProcessor()
        {
            return new IntelProcessor();
        }
    }
}
