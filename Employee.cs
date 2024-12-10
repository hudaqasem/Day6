using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal struct Employee
    {
        /*
            *Encapsulation restricts direct access to an object's 
             internal state, ensuring data integrit
            *It hides implementation details and exposes only what is 
             necessary, making the code easier to use and maintain
            *Improve Security
         */

        //private int EmpId;
        private string Name;
        //private double Salary;
        public int EmpId { get; set; }

        private double sal;

        public double Salary
        {
            get { return sal; }
            set { sal = value; }
        }



        public Employee(int EmpId , string Name , double Sal) 
        { 
            this.EmpId = EmpId;
            this.Name = Name;
            Salary = Sal;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        { 
            this.Name = Name; 
        }
        public override string ToString()
        {
            return $"Name : {Name} , ID : {EmpId} , Salary : {Salary}";
        }

    }
}
