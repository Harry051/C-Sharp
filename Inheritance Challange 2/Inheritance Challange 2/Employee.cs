using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challange_2
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working hard I promise");
        }

        public void Pause()
        {
            Console.WriteLine($"{Name} is having a break");
        }
    }
}
