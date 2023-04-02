using System;
using System.Collections.Generic; // Need this for Dicitonaries
using System.ComponentModel.Design;
using System.Linq; // needed for running some dictionary/ key value stuff - specifically here .ElementAt()

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize an empt dictionary
            Dictionary<int, string> myDicitionary = new Dictionary<int, string>()
            {
                // Key - Value
                { 1, "one" },
                { 2,  "two" },
                { 3, "three" }
            };


            Employee[] employeeList = {
                new Employee ("CEO", "Paddy D", 61, 1000),
                new Employee ("Manager", "Rob Harrison", 42, 35),
                new Employee ("Supervisor", "Tom Thompson", 30, 22),
                new Employee ("Senior Technician", "Sam Starr", 53, 15),
                new Employee ("Junior Technician", "Georgia McCartney", 23, 12),
                new Employee ("Intern", "Rosie Bourbonne", 20, 0)
            };

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();

            foreach(Employee person in employeeList)
            {
                employeeDirectory.Add(person.JobTitle, person); // adding job title as key, with all info as value :)
            }

            Employee emp5 = employeeDirectory["Junior Technician"];
            Console.WriteLine($"the fifth hire is called {emp5.Name}, she is a {emp5.Age} year old {emp5.JobTitle} and makes £{emp5.Wage} per hour. Her total annual salary is {emp5.Salary}.");

            Console.WriteLine("---------------------------");


            // A basic way to check if an employee/dictionary entry exists
            string keyExample = "Manager";
            Employee emp2 = employeeDirectory["Manager"];
            if(employeeDirectory.ContainsKey(keyExample))
            {
                Console.WriteLine($"the second hire is called {emp2.Name}, he is a {emp2.Age} year old {emp2.JobTitle} and makes £{emp2.Wage} per hour. His total annual salary is {emp2.Salary}.");
            }
            else
            {
                Console.WriteLine("This employee does not exist");
            }

            Console.WriteLine("---------------------------");

            // A better way to check if an employee exists
            // Using TryGetValue() returns true if operaion was successful and false if it failed

            Employee check = null;  //null so value will go into it
            if (employeeDirectory.TryGetValue("Supervisor", out check))
            {
                Console.WriteLine("Employee Retrived!");
                Console.WriteLine(check.JobTitle);
                Console.WriteLine(check.Name);
                Console.WriteLine($"{check.Age} years old");
                Console.WriteLine($"Pay: hourly £{check.Wage}, Yearly £{check.Salary}");
            }
            else
            {
                Console.WriteLine("This Employee does not exist.");
            }

            Console.WriteLine("---------------------------");

            //If wanted to UPDATE an entry do this:
            string keyToUpdate = "Senior Technician";
            if(employeeDirectory.ContainsKey(keyToUpdate))
            {
                employeeDirectory[keyToUpdate] = new Employee("Senior Technician", "Matt Lennon", 34, 16);
                Console.WriteLine($"{keyToUpdate} has been updated!");
            }
            else
            {
                //If not found do an error message:
                Console.WriteLine($"Sorry no employye found with {keyToUpdate}");
            }


            //If wanted to REMOVE an entry do this
            string keyToRemove = "Intern";
            if(employeeDirectory.ContainsKey(keyToRemove))
            {
                employeeDirectory.Remove(keyToRemove);
                Console.WriteLine($"{keyToRemove} has been deleted!");
            }
            else
            {
                Console.WriteLine($"Sorry no employee found with {keyToRemove}");
            }


            //How to display all info in dictionay.

            for(int i = 0; i < employeeDirectory.Count; i++)
            {
                // Using ElementAt(i) to return the key-value pair stored at index i.
                KeyValuePair<string, Employee> keyValuePair = employeeDirectory.ElementAt(i);

                // Print the Key
                Console.WriteLine($"Key: {keyValuePair}");

                // Store the value in an Employee object
                Employee employeeValue = keyValuePair.Value;

                // Print the properties of the Employee object
                Console.WriteLine(employeeValue.JobTitle);
                Console.WriteLine(employeeValue.Name);
                Console.WriteLine(employeeValue.Age);
                Console.WriteLine(employeeValue.Wage);
                Console.WriteLine(employeeValue.Salary);
            }

            Console.ReadKey();
        }
    }

    class Employee //role name age rate salary
    {
        public string JobTitle { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Wage { get; set; }

        public float Salary
        {
            get
            {
                //wage * hours * days * weeks * months
                return Wage * 8 * 5 * 7 * 12;
            }
        }

        public Employee(string position, string fullName, int age, float rate)
        {
            this.JobTitle = position;
            this.Name = fullName;
            this.Age = age;
            this.Wage = rate;
        }
    }
    //For this example used job role as key, but in real life using ID's is best practice
}
