﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRS.Data;
using TRS.Web.Models.Module;

namespace TRS.Web.Controllers
{
    public class ModuleController : Controller
    {
        // GET: Module/Index
        public ActionResult Index()
        {
            using (TRSContext context = new TRSContext())
            {
                return View(context.Modules.ToList());

            }
        }

        // GET: Module/Details/5
        public ActionResult Details(int id)
        {
            using (TRSContext context = new TRSContext())
            {
                return View(context.Modules.Where(m => m.Id == id).FirstOrDefault());
            }
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
        public ActionResult Add(AddModuleViewModel model)
        {

            try
            {
                using (TRSContext context = new TRSContext())
                {
                    //dbModel.Modules.Add(module);
                    context.SaveChanges();
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

            using (TRSContext context = new TRSContext())
            {
                return View(context.Modules.Where(m => m.Id == id).FirstOrDefault());
            }
        }

        // POST: Module/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Module module)
        {
            try
            {
                // TODO: Add update logic here
                using (TRSContext context = new TRSContext())
                {
                    context.Entry(module).State = EntityState.Modified;
                    context.SaveChanges();
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

            using (TRSContext context = new TRSContext())
            {
                return View(context.Modules.Where(m => m.Id == id).FirstOrDefault());
            }
        }

        // POST: Module/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                using (TRSContext context = new TRSContext())
                {
                    Module module = context.Modules.Where(m => m.Id == id).FirstOrDefault();
                    context.Modules.Remove(module);
                    context.SaveChanges();
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
