using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_overloading_operator
{
    internal class Rectangle
    {
        private int sideA;

        public int SideA
        {
            get { return sideA; }
            set { sideA = (value > 0) ? value : 1; }
        }
        private int sideB;

        public int SideB
        {
            get { return sideB; }
            set { sideB = (value > 0) ? value : 1; }
        }
        public Rectangle() : this(0, 0) { }

        public Rectangle(int a, int b)
        {
            SideA = a;
            SideB = b;

        }
        public override string ToString()
        {
            return $"Side 1: {SideA}\nSide 2: {SideB}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Rectangle r &&
                   SideA==r.SideA&& SideB==r.SideB;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(SideA,SideB);
        }
        public static Rectangle operator ++(Rectangle r)
        {
            r.SideA++;
            r.sideB++;
            return r;
        }
        public static Rectangle operator --(Rectangle r)
        {
            r.SideA--;
            r.sideB--;
            return r;
        }
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                SideA = r1.SideA + r2.SideA,
                SideB = r1.SideB + r2.SideB
            };

            return res;
        }
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                SideA = r1.SideA - r2.SideA,
                SideB = r1.SideB - r2.SideB
            };
            return res;

        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                SideA = r1.SideA * r2.SideA,
                SideB = r1.SideB * r2.SideB
            };
            return res;

        }
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                SideA = r1.SideA / r2.SideA,
                SideB = r1.SideB / r2.SideB
            };
            return res;

        }
        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA==r2.SideA&&r1.SideB==r2.SideB);

        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1.SideA == r2.SideA && r1.SideB == r2.SideB);

        }
        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA+r1.SideB)<= (r2.SideA + r2.SideB);
        }
        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA + r1.SideB) <= (r2.SideA + r2.SideB);
        }
        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA + r1.SideB) > (r2.SideA + r2.SideB);
        }
        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return (r1.SideA + r1.SideB) >= (r2.SideA + r2.SideB);
        }
        public static bool operator true(Rectangle r)
        {
            return (r.SideA>=0&& r.SideB>=0);
        }
        public static bool operator false(Rectangle r)
        {
            return (r.SideA < 0 || r.SideB < 0);
        }
        public static explicit operator int(Rectangle r)
        {
            return r.SideA+r.SideB;
        }
        public static implicit operator int(Rectangle r)
        {
            return r.SideA + r.SideB;
        }
    }
}
