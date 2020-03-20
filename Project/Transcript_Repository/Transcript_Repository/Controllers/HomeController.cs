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
        /// ADD A MODULE
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
    }
}