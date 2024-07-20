using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_IntroToDesignPattern
{
    internal class PCconfigurator
    {
        public IPCfactory Factory { get; set; }
        public PCconfigurator(IPCfactory factory) 
        { 
            Factory = factory;
        }
        public void Configurate(PC pc)
        {
            pc.Box = Factory.CreateBox();
            pc.Processor=Factory.CreateProcessor();
            pc.MainBoard=Factory.CreateMainBoard();
            pc.HDD=Factory.CreateHdd();
            pc.Memory=Factory.CreateMemory();
        }
    }
}
