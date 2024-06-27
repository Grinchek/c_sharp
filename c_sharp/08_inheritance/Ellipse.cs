using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance
{
    internal class Ellipse:Figure
    {
        public Ellipse() : base() { }
        public Ellipse(int a) : base(a) { }



        public override void GetArea()
        {
            Console.WriteLine("Finding area of ellipse.");
        }
    }
}
