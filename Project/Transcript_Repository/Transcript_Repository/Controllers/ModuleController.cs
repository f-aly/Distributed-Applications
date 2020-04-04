using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Transcript_Repository.Models;
using EntityState = System.Data.Entity.EntityState;
using System.Data.Entity;
//using static DataLibrary.BusinessLogic.ModuleProcessor;

namespace Transcript_Repository.Controllers
{
    public class ModuleController : Controller
    {
        // GET: Module/Index
        public ActionResult Index()
        {
            using (TRS_DbModels dbModel = new TRS_DbModels())
            {
                return View(dbModel.Modules.ToList());

            }
        }

        // GET: Module/Details/5
        public ActionResult Details(int id)
        {
            using (TRS_DbModels dbModel = new TRS_DbModels())
            {
                return View(dbModel.Modules.Where(m => m.Id == id).FirstOrDefault());
            }
        }

        // GET: Module/Add
        public ActionResult Add()
        {

            ViewBag.Message = "Add A Module";

            return View();
        }

        // POST: Module/Add
        [HttpPost]
        [ValidateAntiForgeryToken] // captures data
        public ActionResult Add(Module module)
        {

            try
            {
                using (TRS_DbModels dbModel = new TRS_DbModels())
                {
                    dbModel.Modules.Add(module);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            //if (ModelState.IsValid) // if they followed the validation rules set in ModuleModel
            //{
            //    int moduleRecords = CreateModule(model.ModuleId,
            //        model.ModuleTitle,
            //        model.ModuleResult,
            //        model.ModuleTrimester,
            //        model.ModuleComment);
            //    return RedirectToAction("List"); // if added succesfully, go to ViewModules page
            //}
            //return View();
        }

        // GET: Module/Edit/5
        public ActionResult Edit(int id)
        {

            ViewBag.Message = "Edit A Module";

            using (TRS_DbModels dbModel = new TRS_DbModels())
            {
                return View(dbModel.Modules.Where(m => m.Id == id).FirstOrDefault());
            }
        }

        // POST: Module/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Module module)
        {
            try
            {
                // TODO: Add update logic here
                using (TRS_DbModels dbModels = new TRS_DbModels())
                {
                    dbModels.Entry(module).State = EntityState.Modified;
                    dbModels.SaveChanges();
                }
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
            ViewBag.Message = "Delete A Module";

            using (TRS_DbModels dbModel = new TRS_DbModels())
            {
                return View(dbModel.Modules.Where(m => m.Id == id).FirstOrDefault());
            }
        }

        // POST: Module/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                using (TRS_DbModels dbModel = new TRS_DbModels())
                {
                    Module module = dbModel.Modules.Where(m => m.Id == id).FirstOrDefault();
                    dbModel.Modules.Remove(module);
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
        //    ViewBag.Message = "Modules List";

        //    var data = LoadModules();
        //    List<ModuleModel> modules = new List<ModuleModel>();
        //    foreach (var module in data)
        //    {
        //        modules.Add(new ModuleModel
        //        {
        //            ModuleId = module.ModuleId,
        //            ModuleTitle = module.ModuleTitle,
        //            ModuleResult = module.ModuleResult,
        //            ModuleTrimester = module.ModuleTrimester,
        //            ModuleComment = module.ModuleComment
        //        });
        //    }

        //    return View(modules);
        //}
    }
}
