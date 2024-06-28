using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance
{
    abstract class Figure
    {
		private int sideA;

		public int SideA
		{
			get { return sideA; }
			set { sideA = (value>0)?value:1; }
		}
        public Figure()
        {
            SideA = 1;
        }
        public Figure(int side)
        {
            SideA=side;
        }
        public abstract void GetArea();
        public abstract void GetPerimeter();

	}
}
