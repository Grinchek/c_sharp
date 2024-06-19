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
        public class Worker {
            public string Name { get; set; }
            public string Last_Name { get; set; }
            private int salary;
            private int age;
            public int Age
            {
                get { return age; }
                set { age = (value>18&&value<65)?value:throw new Exception("Incorrect age"); }
            }
            public int Salary
            {
                get { return salary; }
                set { salary = (value>0)?value:throw new Exception("Incorrect salary"); }
            }
            private DateTime hireDate;

            public DateTime HireDate
            {
                get { return hireDate; }
                set { hireDate = (value < DateTime.Now) ? value : throw new Exception("Incorrect hiredate"); }
                   
            }






        }


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
        }
    }
}