using InternTest.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace InternTest.Models
{
    public class StudentModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The first name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The last name is required")]
        public string LastName { get; set; }

        [Display(Name = "Field of Study")]
        [Required(ErrorMessage = "The field of study is required")]
        public string Field { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "The age is required")]
        public int Age { get; set; }

        public StudentModel() { }

        public StudentModel(int id, string firstName, string lastName, string field, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Field = field;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            StudentModel student = (StudentModel)obj;
            if (this.Id.Equals(student.Id))
            {
                return true;
            }
            return false;
        }
    }
}