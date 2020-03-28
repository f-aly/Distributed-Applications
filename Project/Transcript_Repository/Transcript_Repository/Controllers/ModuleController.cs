using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Transcript_Repository.Models;
using EntityState = System.Data.Entity.EntityState;
using static DataLibrary.BusinessLogic.ModuleProcessor;

namespace Transcript_Repository.Controllers
{
    public class ModuleController : Controller
    {
        // GET: Module
        public ActionResult Index()
        {
            return View();
        }

        // GET: Module/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: Module/Create
        public ActionResult Add()
        {

            ViewBag.Message = "Add A Module";

            return View();
        }

        // POST: Module/Create
        [HttpPost]
        [ValidateAntiForgeryToken] // captures data
        public ActionResult Add(ModuleModel model)
        {
            if (ModelState.IsValid) // if they followed the validation rules set in ModuleModel
            {
                int moduleRecords = CreateModule(model.ModuleId,
                    model.ModuleTitle,
                    model.ModuleResult,
                    model.ModuleTrimester,
                    model.ModuleComment);
                return RedirectToAction("List"); // if added succesfully, go to ViewModules page
            }
            return View();
        }

        // GET: Module/Edit/5
        public ActionResult Edit(int id)
        {

            ViewBag.Message = "Edit A Module";
            var data = LoadModules();
            List<ModuleModel> modules = new List<ModuleModel>();
            var module = modules.Where(m => m.ModuleId == id);
            return View(module);
        }

        // POST: Module/Edit/5
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

        // GET: Module/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Module/Delete/5
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
            ViewBag.Message = "Modules List";

            var data = LoadModules();
            List<ModuleModel> modules = new List<ModuleModel>();
            foreach (var module in data)
            {
                modules.Add(new ModuleModel
                {
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
