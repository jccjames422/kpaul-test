using InternTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternTest.Utilities
{
    public static class FauxStudentDb
    {
        public static List<StudentModel> students = new List<StudentModel>();
        public static int Id { get; set; }

        static FauxStudentDb()
        {
            Id = 1;
            students.Add(new StudentModel(Id++, "Sam", "Hill", "Math", 19));
            students.Add(new StudentModel(Id++, "Jessica", "Hill", "Chemistry", 20));
            students.Add(new StudentModel(Id++, "Doug", "Lin", "Math", 20));
            students.Add(new StudentModel(Id++, "Meridith", "Butcher", "Computer Science", 29));
            students.Add(new StudentModel(Id++, "Bob", "Best", "Chemistry", 19));
            students.Add(new StudentModel(Id++, "Linda", "Samson", "English", 21));
            students.Add(new StudentModel(Id++, "Sam", "Hill", "Math", 19));
        }
    }
}