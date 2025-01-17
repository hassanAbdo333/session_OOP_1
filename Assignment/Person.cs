using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = null;
            Age = 0;
        }
        public Person(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }
        public override string ToString()
        {
            return $"the Name ={Name}, the Age={Age}";
        }
    }
}
