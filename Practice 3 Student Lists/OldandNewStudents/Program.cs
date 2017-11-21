using System;
using System.Collections.Generic;
using System.Linq;


/// <summary>
/// Chris Mcclure
/// Student list sorted
/// 11-20-17
/// </summary>
/// 

namespace OldandNewStudents
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Display lists of old students
            Console.WriteLine("Here is the list of old students: ");
            ShowStudents(GetStudentsOld());

            // Display lists of new students
            Console.WriteLine("Here is the list of new students: ");
            ShowStudents(GetStudentsNew());

            //Show the additions
            Console.WriteLine("Here is the list Additions: ");
            ShowAddedStudents(GetStudentsOld(), GetStudentsNew());

            //Show the changes
            Console.WriteLine("Here is the list of Changes: ");
            ShowChangedStudents(GetStudentsOld(), GetStudentsNew());

            //Show the removed students
            Console.WriteLine("Here is the list of removed students: ");
            ShowRemovedStudents(GetStudentsOld(), GetStudentsNew());

            Console.ReadLine();
        }

        public static void ShowChangedStudents(List<Student> stuListOld, List<Student> stuListNew)
        {
            Console.WriteLine();

            foreach (Student student in stuListNew)
            {
                if (stuListOld.Any(x => x.ID == student.ID))
                {

                    var oldVersionOfStudent = stuListOld.Where(x => x.ID == student.ID).First();

                    //I really don't like this, but I couldn't get oldVersionOfStudent.equals(student) to return true for the one student :(
                    if (oldVersionOfStudent.FirstName != student.FirstName || 
                        oldVersionOfStudent.LastName != student.LastName ||
                        oldVersionOfStudent.StudentRank != student.StudentRank ||
                        oldVersionOfStudent.StudentYear != student.StudentYear)
                    {
                        Console.WriteLine(student);
                    }            
                }
            }

            Console.WriteLine();
        }


        public static void ShowAddedStudents(List<Student> stuListOld, List<Student> stuListNew)
        {
            Console.WriteLine();

            foreach (Student student in stuListNew)
            {
                if (!stuListOld.Any(x => x.ID == student.ID))
                {
                    Console.WriteLine(student);
                }
            }
            Console.WriteLine();
        }

        public static void ShowRemovedStudents(List<Student> stuListOld, List<Student> stuListNew)
        {
            Console.WriteLine();

            foreach (Student student in stuListOld)
            {
                if (!stuListNew.Any(x => x.ID == student.ID))
                {
                    Console.WriteLine(student);
                }
            }
            Console.WriteLine();
        }


        public static List<Student> GetStudentsOld()
        {
            List<Student> students = new List<Student>();
        
            students.Add(new Student("111", "Michael", "Tucker", "Junior", 10));
            students.Add(new Student("222", "Svetlana", "Omelchenko", "Senior", 2));
            students.Add(new Student("333", "Michiko", "Osada", "Senior", 7));
            students.Add(new Student("444", "Hugo", "Garcia", "Junior", 16));
            students.Add(new Student("555", "Cesar", "Garcia", "Freshman", 4));
            students.Add(new Student("666", "Fadi", "Fakhouri", "Senior", 72));
            students.Add(new Student("777", "Hanying", "Feng", "Senior", 11));
            students.Add(new Student("888", "Debra", "Garcia", "Junior", 41));
            students.Add(new Student("999", "Terry", "Adams", "Senior", 6));
            students.Add(new Student("211", "Bob", "Stephenson", "Junior", 150));
            return students;
        }

        public static List<Student> GetStudentsNew()
        {
           List<Student> students = new List<Student>();
       
            students.Add(new Student("111", "Michael", "Tucker", "Junior", 10));
            students.Add(new Student("222", "Svetlana", "Omelchenko", "Senior", 2));
            students.Add(new Student("333", "Michiko", "Osada", "Senior", 7));
            students.Add(new Student("311", "Sven", "Mortensen", "Freshman", 53));
            students.Add(new Student("444", "Hugo", "Garcia", "Freshman", 16));
            students.Add(new Student("555", "Cesar", "Garcia", "Freshman", 4));
            students.Add(new Student("666", "Fadi", "Fakhouri", "Senior", 72));
            students.Add(new Student("777", "Hanying", "Feng", "Senior", 11));
            students.Add(new Student("888", "Debra", "Garcia", "Junior", 41));
            students.Add(new Student("411", "Lance", "Tucker", "Junior", 60));
            students.Add(new Student("999", "Terry", "Adams", "Senior", 6));
            return students;
        }

        public static void ShowStudents(List<Student> stuList)
        {
            Console.WriteLine();

            foreach (Student s in stuList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

       
    }
}
