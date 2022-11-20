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

        static FauxStudentDb()
        {
            students.Add(new StudentModel("Sam", "Hill", "Math", 19));
            students.Add(new StudentModel("Jessica", "Hill", "Chemistry", 20));
            students.Add(new StudentModel("Doug", "Lin", "Math", 20));
            students.Add(new StudentModel("Meridith", "Butcher", "Computer Science", 29));
            students.Add(new StudentModel("Bob", "Best", "Chemistry", 19));
            students.Add(new StudentModel("Linda", "Samson", "English", 21));
            students.Add(new StudentModel("Sam", "Hill", "Math", 19));
        }
    }
}