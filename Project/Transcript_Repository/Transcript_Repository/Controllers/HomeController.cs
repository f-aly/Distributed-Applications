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


    }
}