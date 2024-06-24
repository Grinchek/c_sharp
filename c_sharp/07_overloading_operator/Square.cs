using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_overloading_operator
{
    internal class Square
    {
		private int edge;

		public int Edge
		{
			get { return edge; }
			set { edge = (value>0)?value:1; }
		}
		public Square():this(0) { }

        public Square(int a)
		{
			Edge= a;
		}
        public override string ToString()
        {
            return $"Side of squere: {Edge}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Square s &&
                   Edge== s.Edge;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Edge);
        }
        public static Square operator ++(Square s)
        {
            s.Edge++;
            return s;
        }
        public static Square operator --(Square s)
        {
            s.Edge--;
            return s;
        }
        public static Square operator +(Square s1, Square s2)
        {
            Square res = new Square(s1.Edge + s2.Edge);
            
            return res;
        }
        public static Square operator -(Square s1, Square s2)
        {
                Square res = new Square(s1.Edge - s2.Edge);
                return res;
         }
        public static Square operator *(Square s1, Square s2)
        {
            Square res = new Square(s1.Edge * s2.Edge);
            return res;
        }
        public static Square operator /(Square s1, Square s2)
        {
            Square res = new Square(s1.Edge / s2.Edge);
            return res;
        }
        public static bool operator ==(Square s1, Square s2)
        {
            return s1.Edge==s2.Edge ;
            
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1.Edge == s2.Edge);

        }
        public static bool operator <(Square s1, Square s2)
        {
            return s1.Edge<s2.Edge;
        }
        public static bool operator <=(Square s1, Square s2)
        {
            return s1.Edge <= s2.Edge;
        }
        public static bool operator >(Square s1, Square s2)
        {
            return s1.Edge > s2.Edge;
        }
        public static bool operator >=(Square s1, Square s2)
        {
            return s1.Edge >= s2.Edge;
        }
        public static bool operator true(Square s)
        {
            return s.Edge>=0;
        }
        public static bool operator false(Square s)
        {
            return !(s.Edge >= 0);
        }
        public static explicit operator int(Square s)
        {
            return s.Edge;
        }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.Edge,s.Edge+10);
        }


    }
}
