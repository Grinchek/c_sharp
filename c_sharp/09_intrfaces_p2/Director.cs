using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_intrfaces_p2
{
    internal class Director:ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Director() { }
        public Director(string name,string sourname) 
        {
            FirstName = name;
            LastName = sourname;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
