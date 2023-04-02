using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challange_2
{
    internal class Boss : Employee
    {
        protected bool CompanyCar { get; set; }
        public Boss(string name, int salary, bool companycar):base(name, salary)
        {
            this.CompanyCar = companycar;
        }

        public void Lead()
        {
            if (CompanyCar == true)
            {
                Console.WriteLine($"Hello employees I am {Name}, you've worked very hard this year so I'm giving you an extra week off for Christmas!");
            }
            else
            {
                Console.WriteLine($"I'm afraid we've not quite hit our targets. You're all going to need to come in on Saturday");
            }


            }
    }
}
