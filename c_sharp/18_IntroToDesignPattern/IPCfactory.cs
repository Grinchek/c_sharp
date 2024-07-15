using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _18_IntroToDesignPattern
{
    internal interface IPCfactory
    {
        Box CreateBox();
        Processor CreateProcessor();
        MainBoard CreateMainBoard();
        HDD CreateHdd();
        Memory CreateMemory();
        

    }
}
