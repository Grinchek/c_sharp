using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_oop_intro_continue
{
    internal class Calculator
    {
		private int a;

		public int A
		{
			get { return a; }
			set { a = value; }
		}
		private int b;

		public int B
		{
			get { return b; }
			set { b = value; }
		}
		public void Add(int a, int b)
		{
			A = a;
			B = b;
            Console.WriteLine($"{A} + {B} = {A+B}");
        }
		public void Sub(int a, int b)
		{
            A = a;
            B = b;
            Console.WriteLine($"{A} - {B} = {A - B}");
        }
		public void Mul(int a, int b)
        {
            A = a;
            B = b;
            Console.WriteLine($"{A} * {B} = {A * B}");
        }
        public void Div(int a, int b)
        {
            A = a;
            B = (b>0)?b:throw new DivideByZeroException();
            Console.WriteLine($"{A} * {B} = {A * B}");
        }


    }
}
