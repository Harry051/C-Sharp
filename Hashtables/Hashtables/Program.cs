using System;
using System.Runtime.CompilerServices;
using System.Collections; //<-- Need to run hashtables

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            //Make some objects of Student class
            Student stud1 = new Student(1, "Jake", 72);
            Student stud2 = new Student(2, "Sarah", 88);
            Student stud3 = new Student(3, "Johan", 47);
            Student stud4 = new Student(4, "Sydney", 63);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // retrieve individual item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id]; // <-- Is an object but need to cast into type student
            Console.WriteLine($"Student number {storedStudent1.Id} is called {storedStudent1.name}, their GPA is {storedStudent1.GPA}");

            // retrieve all values from a hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID: {temp.Id}");
                Console.WriteLine($"Student Name: {temp.name}");
                Console.WriteLine($"Student GPA: {temp.GPA}");
            }// Unlike arrays will start at last entry and go back to first

            // A HASHTABLE IS ESSENTIALLY JUST A COLLECTION OF DICTIONARY ENTRIES

            //Could clean up loop and write this instead:

            foreach(Student dude in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {dude.Id}");
                Console.WriteLine($"Student Name: {dude.name}");
                Console.WriteLine($"Student GPA: {dude.GPA}");
            }
        }
    }

    class Student
    {
        // make a property called ID
        public int Id { get; set; }

        // make a property called name
        public string name { get; set; }

        // make a propety caled GPA
        public float GPA { get; set; }

        // make a simple constructor

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.name = name;
            this.GPA = GPA;
        }
    }
}
