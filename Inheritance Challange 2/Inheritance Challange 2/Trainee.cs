using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challange_2
{
    internal class Trainee : Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee(string name, int salary, int workingHours, int schoolHours):base(name, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"{Name} studies for {SchoolHours} hours per week");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} works for {WorkingHours} hours per week");
        }
    }
}
