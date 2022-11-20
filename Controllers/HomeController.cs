using InternTest.Models;
using InternTest.Utilities;
using InternTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<StudentViewModel> students = new List<StudentViewModel>();
            foreach (var item in FauxStudentDb.students)
            {
                students.Add(new StudentViewModel(item));
            }
            return View(students);
        }

        public ActionResult DeleteUser(string first, string last, string field, int age)
        {
            StudentModel student = new StudentModel(first, last, field, age);
            for(int i = FauxStudentDb.students.Count() - 1; i >= 0; i--)
            {
                if (FauxStudentDb.students[i].Equals(student))
                {
                    FauxStudentDb.students.RemoveAt(i);
                }
            }
            return RedirectToAction("Index", "Home", new { area = "", });
        }

        public ActionResult AddStudent()
        {
            StudentViewModel student = new StudentViewModel();

            return View();
        }


        [HttpPost]
        public ActionResult AddStudent(string first, string last, string field, int age)
        {
            StudentModel student = new StudentModel(first, last, field, age);
            for (int i = FauxStudentDb.students.Count() - 1; i >= 0; i--)
            {
                if (FauxStudentDb.students[i].Equals(student))
                {
                    FauxStudentDb.students.RemoveAt(i);
                }
            }
            return RedirectToAction("Index", "Home", new { area = "", });
        }


        [HttpPost]
        public ActionResult AddStudent(StudentViewModel student)
        {
            StudentModel studentModel = new StudentModel(student);
            FauxStudentDb.students.Add(studentModel);
            return RedirectToAction("Index", "Home", new { area = "", });
        }

        //public ActionResult EditUser(string first, string last, string field, int age)
        //{
        //    StudentModel student = new StudentModel(first, last, field, age);
        //    for (int i = FauxStudentDb.students.Count() - 1; i >= 0; i--)
        //    {
        //        if (FauxStudentDb.students[i].Equals(student))
        //        {
        //            FauxStudentDb.students[i].FirstName = first;
        //            FauxStudentDb.students[i].LastName = last;
        //            FauxStudentDb.students[i].Field = field;
        //            FauxStudentDb.students[i].Age = age;
        //        }
        //    }
        //    return Index();
        //}


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}