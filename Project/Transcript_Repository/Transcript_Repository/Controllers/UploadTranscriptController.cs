using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transcript_Repository.Controllers
{
    public class UploadTranscriptController : Controller
    {
        // GET: Transcript
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PDFUpload()
        {
            return View();
        }

        public ActionResult XMLUpload()
        {
            return View();
        }

        public ActionResult CourseDetails()
        {
            return View();
        }

        public ActionResult YearResults()
        {
            return View();
        }
        
        public ActionResult UploadTranscripts()
        {
            return View();
        }

        public ActionResult Review()
        {
            return View();
        }

    }
}