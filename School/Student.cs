﻿using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Student
    {
        public class Student
        {
            private static int nextStudentId = 1;
            public string Name { get; set; }
            public int StudentId { get; set; }
            public int NumberOfCredits { get; set; }
            public double Gpa { get; set; }

            public Student(string name, int studentId, int numberOfCredits, double gpa)
            {
                NumberOfCredits = numberOfCredits;
                StudentId = studentId;
                Gpa = gpa;
            }

            public Student(string name, int studentId)
                : this(name, studentId, 0, 0) { }

            public Student(string name)
                : this(name, nextStudentId)
            {
                nextStudentId++;
            }

            public void AddGrade(int courseCredits, double grade)
            {
                double currentQualityScore = Gpa * NumberOfCredits;
                NumberOfCredits += courseCredits;
                Gpa = (currentQualityScore + (courseCredits * grade)) / NumberOfCredits;
            }

            public string GetGradeLevel()
            {
                if (NumberOfCredits < 30) return "freshman";
                if (NumberOfCredits < 60) return "sophomore";
                if (NumberOfCredits < 90) return "junior";
                return "senior";
            }

            public override string ToString()
            {
                return Name + " (Credit Hours: " + NumberOfCredits + "GPA: " + Gpa + ")";
            }

            public override bool Equals(object obj)
            {
                if (obj == this)
                {
                    return true;
                }

                if (obj == null || obj.GetType() != GetType())
                {
                    return false;
                }

                Student studentObj = obj as Student;
                return StudentId == studentObj.StudentId;
            }

            public override int GetHashCode()
            {
                return StudentId;
            }
        }
    }
}
