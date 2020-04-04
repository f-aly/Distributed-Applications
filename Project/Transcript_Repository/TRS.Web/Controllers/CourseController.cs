using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TRS.Web.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Add(string model)
        {
            if (ModelState.IsValid) // if they followed the validation rules set in CourseModel
            {
                
            }
            return View();
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
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

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
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
            ViewBag.Message = "Courses List";

            //List<CourseModel> courses = new List<CourseModel>();

            return View();
        }
    }
}