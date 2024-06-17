using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _c_sharp_
{
    partial class Freezer
{
        public Freezer() : this(0, 0, 0, 0, "") { }

        public Freezer(int value) : this(value, value, value, value,"") { }

        public Freezer(int heigh,int width,int volume,int power,string color)
        {
            this.Heigh = heigh;
            this.Width = width;
            this.Volume = volume;
            this.Power = power;
            this.Color = color;
            counter++;
        }
        static Freezer()
        {
            producer = "Samsung";
            counter = 0;
        }

    }
}
