using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal struct point
    {
        public double x;
        public double y;

        public point()
        {
            x = 0;
            y = 0;
        }
        public point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
    }
}
