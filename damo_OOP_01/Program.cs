using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damo_OOP_01
{
    enum Grades
    {
        //lables
        A, B, C, D, E, F
    }

    enum Gender
    {
        Male=1,Famale=2,M=1,F=2
    }
    internal class Program
    {
        private static void Main()
        {
            #region what is Access modifiers
            //typeA obj=new typeA();
            //obj.x = 10; invalid
            //obj.y = 20; invalid
            //obj.z = 11;// valid
            #endregion
            #region Enum
            //Grades grade = Grades.A;
            //if (grade == Grades.A)
            //{
            //    Console.WriteLine("A+");
            //}
            //else
            //{
            //    Console.WriteLine("sorry");
            //}


            #endregion
            #region struct
            //point p1=new point(4,2);
            // new jest for constructor selection
            //Console.WriteLine(p1);
            #endregion
            #region what is OOP

            #endregion
            #region Encapsulation
            Employee emp = new Employee(10, "hassan", 4000);
            
            
            emp.Salary = 2000;//set
            Console.WriteLine(emp.Salary);//get
            
            
            //emp.setName("omar");
            //Console.WriteLine(emp.GetName());
            
            //emp.id = 20;
            //Console.WriteLine(emp);
            #endregion
        }
    }
}
