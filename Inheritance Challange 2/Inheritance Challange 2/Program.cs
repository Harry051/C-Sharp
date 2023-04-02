using System;

namespace Inheritance_Challange_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee rodney = new Employee("Rodney Checkers", 30000);
            Boss miguel = new Boss("Miguel Thompson", 100000, false);
            Trainee bradley = new Trainee("Bradley Jones", 20000, 35, 15);

            rodney.Work();
            miguel.Lead();
            bradley.Work();
            bradley.Learn();
        }
    }
}

