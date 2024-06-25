using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_oop_intro_continue
{
    internal class Worker
    {
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public int Age
        {
            get { return Age; }
            set { Age = (value > 18 && value < 65) ? value : throw new Exception(); }
        }
        public int Salary
        {
            get { return Salary; }
            set { Salary = (value > 0) ? value : throw new Exception("Incorrect salary"); }
        }
        public DateTime HireDate
        {
            get { return HireDate; }
            set { HireDate = (value < DateTime.Now) ? value : throw new Exception("Incorrect hiredate"); }

        }
        public Worker()
        {
            Name = "Default";
            Last_Name = "Default";
            Age = 1;
            Salary = 1;
            HireDate = DateTime.Now;
        }
        public Worker(string name, string last_name, int age, int salary, DateTime hireDate)
        {
            Name = name;
            Last_Name = last_name;
            Age = age;
            Salary = salary;
            HireDate = hireDate;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last name: {Last_Name}");
            Console.WriteLine($"Age: {Age}");
        }





    }
}
