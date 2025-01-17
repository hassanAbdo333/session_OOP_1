using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damo_OOP_01
{
    internal class Employee
    {
        #region attributes
        public int id;
        public string name;
        private decimal salary;
        #endregion
        #region constructer
        public Employee(int _id, string _Name,decimal _salary)
        {
            id = _id;
            name = _Name;
            salary = _salary;
        }
        #endregion
        #region method
        public override string ToString()
        {
            return $"Id : {id}\nName : {name}\n Salary : {salary}";
        }
        #endregion
        #region encapsulation
        //from it is use(getter/setter - property - indexed)
        //Getter
        public string GetName()
        {
            return name ;
        }

        //setter
        public void setName(string value)
        {
            name=value.Length <=5?value:value.Substring(0,5) ;
            // controll data validation
        }



        //2- property
        //2.1 full property
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;// >= 4000 ? value : 4000;
            }
        }

       //2.2 automatic peoperty
        //public int age;

        public int age { get; set; }
        #endregion
    }
}
