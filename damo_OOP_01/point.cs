using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damo_OOP_01
{
    internal struct point
    {
        //attributes
        public int x;
        public int y;
        //-----------------------
        //constructor : is special function
        //1- named always with the same name of class or struct
        //2- has no return
        public point()// by default at struct 
        {
            x = 0; 
            y = 0;
        }
        public point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        //method
        public override string ToString()
        {
            return $"the x ={x}, the y={y}";
        }
    }
}
