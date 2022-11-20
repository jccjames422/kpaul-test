using InternTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternTest.ViewModels
{
    public class StudentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Field { get; set; }
        public int Age { get; set; }


        public StudentViewModel() { }

        public StudentViewModel(StudentModel student)
        {
            this.FirstName = student.FirstName;
            this.LastName = student.LastName;
            this.Field = student.Field;
            this.Age = student.Age;
        }
    }
}