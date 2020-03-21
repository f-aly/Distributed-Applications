using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transcript_Repository.Models;
using static DataLibrary.BusinessLogic.InstructorProcessor;


namespace Transcript_Repository.Controllers
{
    public class InstructorController : Controller
    {
        // GET: Instructor
        public ActionResult Index()
        {
            return View();
        }

        // GET: Instructor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Instructor/Create
        public ActionResult Add()
        {
            ViewBag.Message = "Instructor Registration";

            return View();
        }

        // POST: Instructor/Create
        [HttpPost]
        public ActionResult Add(InstructorModel model)
        {
            if (ModelState.IsValid) // if they followed the validation rules set in CourseModel
            {
                int instructorRecords = CreateInstructor(model.InstructorId,
                    model.InstructorFirstName,
                    model.InstructorLastName,
                    model.InstructorEmail);
                return RedirectToAction("List"); // if added succesfully, go to ViewModules page
            }
            return View();
        }

        // GET: Instructor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Instructor/Edit/5
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

        // GET: Instructor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Instructor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult List()
        {
            ViewBag.Message = "Instructors List";

            var data = LoadInstructors();
            List<InstructorModel> instructors = new List<InstructorModel>();

            foreach (var instructor in data)
            {
                instructors.Add(new InstructorModel
                {
                    InstructorId = instructor.InstructorId,
                    InstructorFirstName = instructor.InstructorFirstName,
                    InstructorLastName = instructor.InstructorLastName,
                    InstructorEmail = instructor.InstructorEmail,
                    InstructorConfirmEmail = instructor.InstructorEmail
                });
            }

            return View(instructors);
        }
    }
}
