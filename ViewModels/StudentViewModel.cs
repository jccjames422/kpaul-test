using InternTest.Models;
using InternTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternTest.ViewModels
{
    public class StudentViewModel
    {
        public List<StudentModel> students;
        public StudentModel newStudent;

        public StudentViewModel()
        {
            students = FauxStudentDb.students;
            newStudent = new StudentModel();
        }
    }
}