using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance
{
    internal class Circle:Figure
    {
        public Circle() : base() { }
        public Circle(int a):base(a) { }



        public override void GetArea()
        {
            Console.WriteLine("Finding area of circle.");
        }
    }
}
