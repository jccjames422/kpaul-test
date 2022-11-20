﻿using InternTest.Models;
using InternTest.Utilities;
using InternTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternTest.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View(new StudentViewModel());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [HandleError]
        public ActionResult Create(StudentModel student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    student.Id = FauxStudentDb.Id++;
                    FauxStudentDb.students.Add(student);
                    TempData["message"] = $"{student.FirstName} {student.LastName} has been saved.";
                    ModelState.Clear();
                    return JavaScript("location.reload(true)");
                }

                return PartialView("_AddNewStudentModal", student);
            }
            catch
            {
                ViewBag.Message = "There was an error with your request.";
                return PartialView("_AddNewStudentModal");
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Student/Delete/5
        [HttpPost]
        public string Delete(int id)
        {
            try
            {
                StudentModel student = FauxStudentDb.students.Where(s => s.Id == id).First();
                if (FauxStudentDb.students.Remove(student))
                {
                    return "The student has been deleted.";
                };
                return "The student has not been deleted";
            }
            catch
            {
                return "There has been an error.";
            }
        }
    }
}
