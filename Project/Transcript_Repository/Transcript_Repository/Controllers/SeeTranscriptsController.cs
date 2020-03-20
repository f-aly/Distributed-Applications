using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transcript_Repository.DtoModels.Module;
using Transcript_Repository.DtoModels.Transcript;
using Transcript_Repository.ViewModels;

namespace Transcript_Repository.Controllers
{
    public class SeeTranscriptsController : Controller
    {
        // GET: SeeTranscripts
        public ActionResult Index()
        {
            var model = new TranscriptViewModel();
            //create 10 mock transcripts and add them to transcript list
            //basically this is replaced with get all transcripts this person should see
            Random rnd = new Random();
            int noTransc = rnd.Next(1,15);
            for (int i = 0; i < noTransc; i++)
            {
                model.Transcripts.Add(GiveMeAMockTranscript(999999, i));
            }

            return View(model);
        }

        public ActionResult Detailed_Transcript(string TranscriptID = "999999")
        {
            ViewBag.Message = "Your detailed transcript page.";

            //Create model 
            var model = new TranscriptViewModel();

            //get Transcript
            var transcript = GiveMeAMockTranscript(int.Parse(TranscriptID));

            //add it to model
            model.Transcripts.Add(transcript);
            return View(model);
        }

        public ActionResult EditTranscripts()
        {
            var model = new TranscriptViewModel();
            //create 10 mock transcripts and add them to transcript list
            //basically this is replaced with get all transcripts this person should see
            Random rnd = new Random();
            int noTransc = rnd.Next(1, 15);
            for (int i = 0; i < noTransc; i++)
            {
                model.Transcripts.Add(GiveMeAMockTranscript(999999, i));
            }
            return View(model);
        }



        public TranscriptDto GiveMeAMockTranscript(int TranscriptID = 999999,int counter = 0)
        {

            //////////////////mock Modules 
            Random rnd = new Random();
            if (TranscriptID == 999999)
            {
                TranscriptID = rnd.Next(100000, 999999);
            }
            List<ModuleDto> Mock_Modules = new List<ModuleDto>();
            string ModuleName = "Module_";
            for (int i = 0; i < 6; i++)
            {
                ModuleDto newModule = new ModuleDto
                {
                    ACWGrade = rnd.Next(1,100),
                    ModuleGrade = rnd.Next(1, 100),
                    Module_ACWs = ModuleName + i,
                    Module_ID = rnd.Next(100000, 999999)
                };
                Mock_Modules.Add(newModule);
            }

            //mock transcript
            TranscriptDto Transcript_mock = new TranscriptDto
            {
                EnrolledCourseID = 20,
                SemesterID = rnd.Next(1, 3),
                Transcript_ID = TranscriptID+ counter, //999999
                Modules_Taken = Mock_Modules//6 fake modules
            };
        
            return Transcript_mock;
        }


    }
}