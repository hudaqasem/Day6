using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Employee2
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        
        public Employee2(string Name, decimal Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
        }
        //Copy constructor 
        public Employee2(Employee2 emp)
        {
            Name = emp.Name;
            Salary = emp.Salary;
        }
        public override string ToString()
        {
            return $"Name : {Name} , Salary : {Salary}";
        }
    }
}
