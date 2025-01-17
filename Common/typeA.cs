using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // what can we write inside the nameSpase?
    //1- class
    //2- struct
    //3- interface
    //4- enum
    //---------------------------
    // Allowed Access modifier inside the namespace
    // 1- internal(default)
    //2- public
    public class typeA
    {
        /*private*/ int x;
        internal int y;
        public int z;

        #region Definition
        //what can we write inside the class or struct?
        // 1- Attribute
        //2-property (fullproperty - automatic proprety - indexer)
        //3-function (constructor - getter/setter - method)
        //4-Event
        //------------------------
        // Allowed Access modifier inside the struct
        //1- private
        // 2- internal
        //3- public
        //---------------------------------------
        // Allowed Access modifier inside the class
        //1-private
        //2- private protected
        //3- protected
        //4- internal
        //5- internal protected
        //6- public
        //------------------------------------
        // what can we write inside the interface?
        //1- signature for property
        //-2 signature for method
        //-3 default implemented method
        //----------------------------------
        // default modifier (public)
        #endregion

    }
}
