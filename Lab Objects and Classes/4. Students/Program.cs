using System;
using System.Collections.Generic;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Students student = new Students();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;
                

                int index = IsStudentValid(firstName, lastName, students);
                if (index != -1)
                {
                    students[index].Age = age;
                    students[index].HomeTown = homeTown;
                    continue;
                }
                



                students.Add(student);
                input = Console.ReadLine();
            }

            string cityFilter = Console.ReadLine();

            foreach (Students student in students)
            {
                if (cityFilter == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

         static int IsStudentValid(string firstName, string lastName, List<Students> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].FirstName == firstName && students[i].LastName == lastName)
                {
                    return i;
                }
            }

            return -1;
        }
    }


    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
