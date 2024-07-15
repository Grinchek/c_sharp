using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_IntroToDesignPattern
{
    internal class OfficePCFactory : IPCfactory
    {
        Box IPCfactory.CreateBox()
        {
            return new BlackBox();
        }

        HDD IPCfactory.CreateHdd()
        {
            return new LGHdd();
        }

        MainBoard IPCfactory.CreateMainBoard()
        {
            return new AsusMainBoard();
        }

        Memory IPCfactory.CreateMemory()
        {
            return new DDRMemory();
        }

        Processor IPCfactory.CreateProcessor()
        {
            return new AmdProcessor();
        }
    }
}
