using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance
{
    internal class Romb: Figure
    {
        private int sideB;

        public int SideB
        {
            get { return sideB; }
            set { sideB = (value > 0) ? value : 1; }
        }
        private int sideC;

        public int SideC
        {
            get { return sideC; }
            set { sideC = (value > 0) ? value : 1; }
        }
        private int sideD;

        public int SideD
        {
            get { return sideD; }
            set { sideD = (value > 0) ? value : 1; }
        }
        public Romb() : base()
        {
            SideB = 1;
            SideC = 1;
            SideD = 1;
        }
        public Romb(int side) : base(side)
        {
            SideB = side;
            SideC = side;
            SideD = side;
        }
        public Romb(int a, int b, int c, int d) : base(a)
        {
            SideB = b;
            SideC = c;
            SideD = d;

        }
        public override void GetArea()
        {
            Console.WriteLine("Finding area of romb.");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("Finding perimetr of romb.");
        }
    }
}
