using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transcript_Repository.Models;
using static DataLibrary.BusinessLogic.CourseProcessor;


namespace Transcript_Repository.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            using (TRS_DbModels dbModel = new TRS_DbModels())
            {
                return View(dbModel.Courses.ToList());

            }
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            using (TRS_DbModels dbModel = new TRS_DbModels())
            {
                return View(dbModel.Courses.Where(m => m.Id == id).FirstOrDefault());
            }
        }

        // GET: Course/Add
        public ActionResult Add()
        {
            ViewBag.Message = "Add A Course";

            return View();
        }

        // POST: Course/Add
        [HttpPost]
        [ValidateAntiForgeryToken] // captures data
        public ActionResult Add(Course course)
        {

            try
            {
                using (TRS_DbModels dbModel = new TRS_DbModels())
                {
                    dbModel.Courses.Add(course);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {

            ViewBag.Message = "Edit A Course";

            using (TRS_DbModels dbModel = new TRS_DbModels())
            {
                return View(dbModel.Courses.Where(m => m.Id == id).FirstOrDefault());
            }
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                // TODO: Add update logic here
                using (TRS_DbModels dbModels = new TRS_DbModels())
                {
                    dbModels.Entry(course).State = EntityState.Modified;
                    dbModels.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Message = "Delete A Course";

            using (TRS_DbModels dbModel = new TRS_DbModels())
            {
                return View(dbModel.Courses.Where(m => m.Id == id).FirstOrDefault());
            }
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                using (TRS_DbModels dbModel = new TRS_DbModels())
                {
                    Course course = dbModel.Courses.Where(m => m.Id == id).FirstOrDefault();
                    dbModel.Courses.Remove(course);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //public ActionResult List()
        //{
        //    ViewBag.Message = "Courses List";

        //    var data = LoadCourses();
        //    List<CourseModel> courses = new List<CourseModel>();
        //    foreach (var course in data)
        //    {
        //        courses.Add(new CourseModel
        //        {
        //            CourseId = course.CourseId,
        //            CourseName = course.CourseName,
        //            CourseQualification = course.CourseQualification,
        //            CourseResult = course.CourseResult,
        //            CourseLength = course.CourseLength
        //        });
        //    }

        //    return View(courses);
        //}
    }
}
