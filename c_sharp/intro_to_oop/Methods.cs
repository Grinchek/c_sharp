using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _c_sharp_
{
    partial class Freezer
    {
        public override string ToString()
        {
            return $"Producer: {producer}\nHeigh: {this.heigh} sm\nWidth: {this.width}"+
                $" sm\nVolume: {this.volume} l\nPower: {this.power} kwt\nColor: {this.color}";
        }

    }
}

