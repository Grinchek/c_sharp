using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance
{
    internal class Triangle: Figure
    {
		private int sideB;

		public int SideB
		{
			get { return sideB; }
			set { sideB = (value>0)?value:1; }
		}
        private int sideC;

        public int SideC
        {
            get { return sideC; }
            set { sideC = (value > 0) ? value : 1; }
        }
        public Triangle() : base()
        {
            SideB = 1;
            SideC = 1;
        }
        public Triangle(int a,int b,int c): base(c)
        {
            SideB = b;
            SideC = c;
        }
        public Triangle(int side)
        {
            SideA = side;
            SideB = side;
            SideC = side;
        }
        public override void GetArea()
        {
            Console.WriteLine("Finding area of triangle.");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("Finding perimetr of triangle.");
        }

    }
}
