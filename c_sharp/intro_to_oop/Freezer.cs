using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _c_sharp_
{
    partial class Freezer
{
        static string producer;
        static int counter;
        private int heigh;
        public int Heigh {
            get { return heigh; }
            set { this.heigh = (value > 0) ? value : 1; }
        }
        private int width;
        public int Width {
            get { return width; }
            set { this.width = (value>0)?value:1; }
        }
        private int volume;
        public int Volume
        {
            get { return volume; }
            set { this.volume = (value > 0) ? value : 1; }
        }
        private int power;
        public int Power
        {
            get { return power; }
            set { power=(value>0)?value:1; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}
