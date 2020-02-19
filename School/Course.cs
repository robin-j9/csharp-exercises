using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Course
    {
        public class Course
        {
            public string CourseName { get; set; }
            public string CourseCode { get; set; }
            public int CreditHours { get; set; }
            public List<Student> StudentRoster { get; set; } = new List<Student>();

            public Course(string name, string code, int hours)
            {
                CourseName = name;
                CourseCode = code;
                CreditHours = hours;
            }

            public override string ToString()
            {
                return CourseName + " (Code: " + CourseCode + " Credit Hours: " + CreditHours;
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

                Course courseObj = obj as Course;
                return CourseCode == courseObj.CourseCode;
            }

            public override int GetHashCode()
            {
                return int.Parse(CourseCode);
            }
        }
    }
}
