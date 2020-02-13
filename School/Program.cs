using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
        }
    }

    public class Student
    {
        private double gpa;

        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa 
        {
            get { return gpa; }
            internal set { gpa = value; } 
        }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            NumberOfCredits = numberOfCredits;
            StudentId = studentId;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this (name, studentId, 0, 0) { }
    }

    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CreditHours { get; set; }
        public List<Student> StudentRoster { get; set; }
        
    }
}
