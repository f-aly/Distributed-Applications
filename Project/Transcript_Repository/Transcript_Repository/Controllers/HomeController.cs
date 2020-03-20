using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transcript_Repository.DtoModels.Module;
using Transcript_Repository.DtoModels.Transcript;
using Transcript_Repository.ViewModels;
using Transcript_Repository.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.ModuleProcessor;
using static DataLibrary.BusinessLogic.CourseProcessor;

namespace Transcript_Repository.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

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

        public ActionResult NotImplemented()
        {
            return View();
        }    

        public ActionResult Actions()
        {
            ViewBag.Message = "Your actions page.";

            return View();
        }

        /// <summary>
        /// MODULE SET UP
        /// </summary>
        /// <returns></returns>
        public ActionResult AddModule()
        {
            ViewBag.Message = "Add A Module";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // captures data
        public ActionResult AddModule(ModuleModel model)
        {
            if (ModelState.IsValid) // if they followed the validation rules set in ModuleModel
            {
                int moduleRecords = CreateModule(model.ModuleId,
                                        model.ModuleTitle,
                                        model.ModuleResult,
                                        model.ModuleTrimester,
                                        model.ModuleComment);
                return RedirectToAction("ViewModules"); // if added succesfully, go to ViewModules page
            }
            return View();
        }

        public ActionResult ViewModules()
        {
            ViewBag.Message = "Modules List";

            var data = LoadModules();
            List<ModuleModel> modules = new List<ModuleModel>();
            foreach(var module in data)
            {
                modules.Add(new ModuleModel {
                    ModuleId = module.ModuleId,
                    ModuleTitle = module.ModuleTitle,
                    ModuleResult = module.ModuleResult,
                    ModuleTrimester = module.ModuleTrimester,
                    ModuleComment = module.ModuleComment
                });
            }

            return View(modules);
        }


        /// <summary>
        /// COURSE SET UP
        /// </summary>
        /// <returns></returns>
        public ActionResult AddCourse()
        {
            ViewBag.Message = "Add A Course";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // captures data
        public ActionResult AddCourse(CourseModel model)
        {
            if (ModelState.IsValid) // if they followed the validation rules set in CourseModel
            {
                int courseRecords = CreateCourse(model.CourseId,
                                           model.CourseName,
                                           model.CourseQualification,
                                           model.CourseResult,
                                           model.CourseLength);
                return RedirectToAction("ViewCourses"); // if added succesfully, go to ViewModules page
            }
            return View();
        }

        public ActionResult ViewCourses()
        {
            ViewBag.Message = "Courses List";

            var data = LoadCourses();
            List<CourseModel> courses = new List<CourseModel>();
            foreach (var course in data)
            {
                courses.Add(new CourseModel
                {
                    CourseId = course.CourseId,
                    CourseName = course.CourseName,
                    CourseQualification = course.CourseQualification,
                    CourseResult = course.CourseResult,
                    CourseLength = course.CourseLength
                });
            }

            return View(courses);
        }
    }
}