using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_oop_intro_continue
{
    internal     class Worker
    {
        public string Name { get; set; }
        public string Last_Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = (value >= 18 && value < 65) ? value : throw new Exception(); }
        }
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = (value > 0) ? value : throw new Exception(); }
        }
        private DateTime hireDate;
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = (value <= DateTime.Now) ? value : throw new Exception(); }

        }
        public Worker() : this("Default", "Default", 18, 1, DateTime.Now) { }
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
