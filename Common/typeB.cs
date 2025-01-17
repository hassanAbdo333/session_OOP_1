using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class typeB
    {
        public typeB() 
        {
            typeA obj = new typeA();
            //obj.x = 10; invalid
            obj.y = 1;// valid
            obj.z = 2;// valid
        }
    }
}
