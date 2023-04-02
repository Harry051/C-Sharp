using System;
using System.Collections;

namespace hashtables_challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK - make an array of students and write a program that will iterate through and insert them to a hashtable
            //ALSO if a student with an ID exists, skip it and say "Sorry a student with that ID exists already"

            Student[] students = new Student[5];
            students[0] = new Student(1, "Ted", 80);
            students[1] = new Student(2, "Jon", 90);
            students[2] = new Student(3, "Pete", 58);
            students[3] = new Student(1, "Tom", 62);
            students[4] = new Student(5, "Liv", 100);

            Hashtable studentsHash = new Hashtable();

            foreach(Student pupil in students)
            {
                if (studentsHash.ContainsKey(pupil.Id))
                { Console.WriteLine("Sorry that ID has already been assigned to another student"); }
                //Student temp = (Student)pupil;
                else { studentsHash.Add(pupil.Id, pupil); }
                Console.WriteLine($"Student {pupil.Id}: {pupil.name} was added");

            }
            
            foreach(Student hi in studentsHash.Values)
            {
                Console.WriteLine($"Student ID is {hi.Id}");
                Console.WriteLine($"Student name is: {hi.name}");
                Console.WriteLine($"Student GPA is: {hi.GPA}");
            }
            Console.ReadKey();
        }
    }

    class Student
    {
       
        public int Id { get; set; }
        public string name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.name = name;
            this.GPA = GPA;
        }
    }
}
