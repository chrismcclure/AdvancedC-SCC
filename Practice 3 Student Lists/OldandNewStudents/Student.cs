using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldandNewStudents
{
    public class Student
    {
        // Sample Student class
        // Each student has a first name, a last name, a class year, and a rank 
        // that indicates academic ranking in the student body.

        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentYear { get; set; }
        public int StudentRank { get; set; }

        public Student(string idNumber, string firstName, string lastName, string studentYear, int studentRank)
        {
            ID = idNumber;
            FirstName = firstName;
            LastName = lastName;
            StudentYear = studentYear;
            StudentRank = studentRank;
        }


        public override string ToString()
        {
            return ID + " " + FirstName + " " + LastName + " " + StudentYear + " " + StudentRank;
        }
    }
}
