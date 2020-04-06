using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRS.Core.DomainModels;
using TRS.Core.Models.Course;
using TRS.Data;
using TRS.Web.Models.Course;

namespace TRS.Web.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            using (TRSContext context = new TRSContext())
            {
                return View(new ListViewModel
                {
                    Courses = context.Courses.Select(x => new CourseDto
                    {
                        Id = x.Id,
                        CourseId = x.CourseId,
                        Length = x.CourseLength,
                        Name = x.CourseName,
                        Qualification = x.CourseQualification
                    }).ToList()

                });
            }
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            using (TRSContext context = new TRSContext())
            {
                return View(new CourseViewModel
                {
                    Course = context.Courses.Select(x => new CourseDto
                    {
                        Id = x.Id,
                        CourseId = x.CourseId,
                        Length = x.CourseLength,
                        Name = x.CourseName,
                        Qualification = x.CourseQualification
                    }).FirstOrDefault(x => x.Id == id)
                });
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
        public ActionResult Add(CourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (TRSContext context = new TRSContext())
                    {
                        Course course = new Course
                        {
                            CourseId = model.Course.CourseId,
                            CourseLength = model.Course.Length,
                            CourseName = model.Course.Name,
                            CourseQualification = model.Course.Qualification
                        };
                        context.Courses.Add(course);
                        context.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            using (TRSContext context = new TRSContext())
            {
                return View(new CourseViewModel
                {
                    Course = context.Courses.Select(x => new CourseDto
                    {
                        Id = x.Id,
                        CourseId = x.CourseId,
                        Length = x.CourseLength,
                        Name = x.CourseName,
                        Qualification = x.CourseQualification
                    }).FirstOrDefault(x => x.Id == id)
                });
            }

        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CourseViewModel model)
        {
            try
            {
                using (TRSContext context = new TRSContext())
                {
                    var course = context.Courses.Find(id);
                    if (course != null)
                    {
                        course.CourseLength = model.Course.Length;
                        course.CourseName = model.Course.Name;
                        course.CourseQualification = model.Course.Qualification;
                    }
                    context.SaveChanges();
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

            using (TRSContext context = new TRSContext())
            {
                return View(new CourseViewModel
                {
                    Course = context.Courses.Select(x => new CourseDto
                    {
                        Id = x.Id,
                        CourseId = x.CourseId,
                        Length = x.CourseLength,
                        Name = x.CourseName,
                        Qualification = x.CourseQualification
                    }).FirstOrDefault(x => x.Id == id)
                });
            }
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (TRSContext context = new TRSContext())
                {
                    Course course = context.Courses.Find(id);
                    context.Courses.Remove(course);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}