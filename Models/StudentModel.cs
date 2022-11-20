using InternTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternTest.Models
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Field { get; set; }
        public int Age { get; set; }

        public StudentModel() { }

        public StudentModel(string firstName, string lastName, string field, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Field = field;
            Age = age;
        }

        public StudentModel(StudentViewModel student)
        {
            this.FirstName = student.FirstName;
            this.LastName = student.LastName;
            this.Field = student.Field;
            this.Age = student.Age;
        }

        public override bool Equals(object obj)
        {
            StudentModel student = (StudentModel)obj;
            if(this.FirstName.Equals(student.FirstName) && this.LastName.Equals(student.LastName) && this.Field.Equals(student.Field) && this.Age == student.Age)
            {
                return true;
            }
            return false;
        }
    }
}