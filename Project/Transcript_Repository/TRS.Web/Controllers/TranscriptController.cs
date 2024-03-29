﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRS.Web.Models.Transcript;

namespace TRS.Web.Controllers
{
    public class TranscriptController : Controller
    {
        // GET: Transcript
        public ActionResult Index()
        {
            var model = new ListViewModel();
            //create 10 mock transcripts and add them to transcript list
            //basically this is replaced with get all transcripts this person should see
            Random rnd = new Random();
            int noTransc = rnd.Next(1, 15);
            for (int i = 0; i < noTransc; i++)
            {
               // model.Transcripts.Add(GiveMeAMockTranscript(999999, i));
            }



            return View(model);
        }

        // GET: Transcript/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Message = "Your detailed transcript page.";

            //Create model 
            var model = new TranscriptViewModel();

            //get Transcript
           // var transcript = GiveMeAMockTranscript(id);

            //add it to model
           // model.Transcripts.Add(transcript);
            return View(model);
        }

        // GET: Transcript/Create
        public ActionResult Add()
        {
            ViewBag.Message = "Add A Transcript";

            return View();
        }

        // POST: Transcript/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(TranscriptViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    
                    return RedirectToAction("Index"); 
                }
            }
            return View();
        }

        // GET: Transcript/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transcript/Edit/5
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

        // GET: Transcript/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transcript/Delete/5
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


        public ActionResult Upload()
        {
            return View();
        }

        public ActionResult UploadCourseDetails()
        {
            return View();
        }

        public ActionResult UploadYearResults()
        {
            return View();
        }

        public ActionResult Search()
        {
            var model = new TranscriptViewModel();
            //create 10 mock transcripts and add them to transcript list
            //basically this is replaced with get all transcripts this person should see
            Random rnd = new Random();
            int noTransc = rnd.Next(1, 15);
            for (int i = 0; i < noTransc; i++)
            {
                //model.Transcripts.Add(GiveMeAMockTranscript(999999, i));
            }
            return View(model);
        }

        //public TranscriptDto GiveMeAMockTranscript(int TranscriptID = 999999, int counter = 0)
        //{

        //    //////////////////mock Modules 
        //    Random rnd = new Random();
        //    if (TranscriptID == 999999)
        //    {
        //        TranscriptID = rnd.Next(100000, 999999);
        //    }
        //    List<ModuleDto> Mock_Modules = new List<ModuleDto>();
        //    string ModuleName = "Module_";
        //    for (int i = 0; i < 6; i++)
        //    {
        //        ModuleDto newModule = new ModuleDto
        //        {
        //            ACWGrade = rnd.Next(1, 100),
        //            ModuleGrade = rnd.Next(1, 100),
        //            Module_ACWs = ModuleName + i,
        //            Module_ID = rnd.Next(100000, 999999),

        //        };
        //        Mock_Modules.Add(newModule);
        //        Thread.Sleep(1);
        //    }

        //    int Public_Access = rnd.Next(1, 3);
        //    bool access;
        //    if (Public_Access == 1)
        //    {
        //        access = true;
        //    }
        //    else { access = false; }

        //    //mock transcript
        //    TranscriptDto Transcript_mock = new TranscriptDto
        //    {
        //        EnrolledCourseID = 20,
        //        SemesterID = rnd.Next(1, 3),
        //        Transcript_ID = TranscriptID + counter, //999999
        //        Modules_Taken = Mock_Modules,//6 fake modules
        //        isPublic_ = access
        //    };

        //    Thread.Sleep(1);
        //    return Transcript_mock;
        //}
    }
}