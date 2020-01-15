using System;
using System.Collections.Generic;

namespace StudentRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            do
            {
                Console.WriteLine("Student name (leave blank to quit):");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    Console.WriteLine("Student ID:");
                    int studentID = int.Parse(Console.ReadLine());

                    students.Add(newStudent, studentID);
                }
            }
            while (newStudent != "");

            Console.WriteLine("Class roster:");

            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine("\nName: " + student.Key + "\nID: " + student.Value);
            }

            Console.ReadLine();
        }
    }
}
