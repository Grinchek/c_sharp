using _05_oop_intro_continue;
using Microsoft.VisualBasic;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace _c_sharp_
{
    #region classwork_structure
    //struct _2D_Point
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public _2D_Point(int x,int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //    public void Print()
    //    {
    //        Console.WriteLine(X);
    //        Console.WriteLine(Y);
    //    }
    //}
    #endregion


    class Program
    {
        #region classwork
        //internal class Point
        //{
        //    public int X { get; set; }
        //    public int Y { get; set; }
        //}
        //static void MethodWithParams(string name,params int[] marks) {
        //    Console.WriteLine("---------------" + name+ "---------------");
        //    foreach (var mark in marks)
        //    {
        //        Console.Write(mark + " ");
        //    }
        //    Console.WriteLine();


        //}
        //static void Modify(ref int num, ref string str, ref Point point)
        //{
        //    num += 1;
        //    str+= "!";
        //    point.X ++;
        //    point.Y ++;
        //}
        //static void GetCurentTime(out int hour,out int minute,out int second) {
        //    hour = DateTime.Now.Hour;
        //    minute = DateTime.Now.Minute;
        //    second = DateTime.Now.Second;
        //}
        #endregion



        static void Main(string[] args)
        {
            #region classwork_main
            //_2D_Point p1= new _2D_Point(3,3);
            //p1.Print();

            // out 
            //int h=0, m=0, s = 0;
            //Console.WriteLine($"{h}:{m}:{s}");
            //GetCurentTime(out h, out m, out s);
            //Console.WriteLine($"{h}:{m}:{s}");


            //ref
            //int num =10;
            //string str = "Hello academy";
            //Point point = new Point() {X=5,Y=7 };
            //Console.WriteLine($"Num = {num}");
            //Console.WriteLine($"Str = {str}");
            //Console.WriteLine($"point x = {point.X} y = {point.Y}");
            //Modify(ref num,ref str,ref point);
            //Console.WriteLine($"Num = {num}");
            //Console.WriteLine($"Str = {str}");
            //Console.WriteLine($"point x = {point.X} y = {point.Y}");



            //params
            //int[] marks = { 10, 11, 9, 12 };
            //MethodWithParams("Bob", marks);
            //MethodWithParams("Vasya",new int[] {9,8,7,6,5 });
            //MethodWithParams("Ivanka", 9,8,7,6,5 ,5,6,7,8,9);
            //Point p = new Point();
            //_2D_objects.Point point2 = new _2D_objects.Point();
            #endregion
            //Worker[] workers = new Worker[5];
            //for(int i = 0; i < workers.Length; i++)
            //{
            //    Console.WriteLine("Enter name");
            //    workers[i].Name = Console.ReadLine();
            //    Console.WriteLine("Enter last name");
            //    workers[i].Last_Name = Console.ReadLine();
            //    Console.WriteLine("Enter age");
            //    try { workers[i].Age = int.Parse(Console.ReadLine()); }
            //    catch(Exception e) { Console.WriteLine("Incorrect age"); }
            //    Console.WriteLine("Enter salary");
            //    try { workers[i].Salary = int.Parse(Console.ReadLine()); }
            //    catch (Exception e) { Console.WriteLine("Incorrect salary"); }
            //    Console.WriteLine("Enter Hire date");
            //    try { workers[i].HireDate = DateTime.Parse(Console.ReadLine()); }
            //    catch (Exception e) { Console.WriteLine("Incorrect hire date"); }
            //}

            // Calculator
            Console.WriteLine("Enter first value: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value: ");
            int b = int.Parse(Console.ReadLine());
            Calculator c = new Calculator();
            Console.WriteLine("Select an operation(+,-,*,/):");
            bool ex = false;
            while (!ex)
            {
                char op = char.Parse(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        c.Add(a, b);
                        ex = true;
                        break;
                    case '-':
                        c.Sub(a, b);
                        break;
                    case '*':
                        c.Mul(a, b);
                        ex = true;
                        break;
                    case '/':
                        try
                        {
                            c.Div(a, b);
                            ex = true;
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Can not divide by zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Incorrect operation");
                        break;
                }
            }
        }
    }
}