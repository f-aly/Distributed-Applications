using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRS.Core.DomainModels;
using TRS.Core.Models.Module;
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
                return View(new ListViewModel
                {
                    Modules = context.Modules.Select(x => new ModuleDto
                    {
                        Id = x.Id,
                        Title = x.ModuleTitle,
                        ModuleId = x.ModuleId,
                        Comment = x.ModuleComment,
                        Trimester = x.ModuleTrimester
                    }).ToList()

                });

            }
        }

        // GET: Module/Details/5
        public ActionResult Details(int id)
        {
            using (TRSContext context = new TRSContext())
            {
                return View(new ModuleViewModel
                {
                    Module = context.Modules.Select(x => new ModuleDto
                    {
                        Id = x.Id,
                        Title = x.ModuleTitle,
                        ModuleId = x.ModuleId,
                        Comment = x.ModuleComment,
                        Trimester = x.ModuleTrimester
                    }).FirstOrDefault(x => x.Id == id)
                });
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
        public ActionResult Add(ModuleViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (TRSContext context = new TRSContext())
                    {
                        Module module = new Module
                        {
                            ModuleTitle = model.Module.Title,
                            ModuleId = model.Module.ModuleId,
                            ModuleTrimester = model.Module.Trimester,
                            ModuleComment = model.Module.Comment
                        };
                        context.Modules.Add(module);
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

        // GET: Module/Edit/5
        public ActionResult Edit(int id)
        {

            ViewBag.Message = "Edit A Module";

            using (TRSContext context = new TRSContext())
            {
                return View(new ModuleViewModel
                {
                    Module = context.Modules.Select(x => new ModuleDto
                    {
                        Id = x.Id,
                        Title = x.ModuleTitle,
                        ModuleId = x.ModuleId,
                        Comment = x.ModuleComment,
                        Trimester = x.ModuleTrimester
                    }).FirstOrDefault(x => x.Id == id)
                });
            }
        }

        // POST: Module/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModuleViewModel model)
        {
            try
            {
                using (TRSContext context = new TRSContext())
                {
                    var module = context.Modules.Find(id);
                    if (module != null)
                    {
                        module.ModuleTitle = model.Module.Title;
                        module.ModuleTrimester = model.Module.Trimester;
                        module.ModuleComment = model.Module.Comment;
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

        // GET: Module/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Message = "Delete A Module";

            using (TRSContext context = new TRSContext())
            {
                return View(new ModuleViewModel
                {
                    Module = context.Modules.Select(x => new ModuleDto
                    {
                        Id = x.Id,
                        Title = x.ModuleTitle,
                        ModuleId = x.ModuleId,
                        Comment = x.ModuleComment,
                        Trimester = x.ModuleTrimester
                    }).FirstOrDefault(x => x.Id == id)
                });
            }
        }

        // POST: Module/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModuleViewModel model)
        {
            try
            {
                using (TRSContext context = new TRSContext())
                {
                    Module module = context.Modules.Find(id);
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

    }
}
