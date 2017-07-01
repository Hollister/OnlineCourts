using OnlineCourt.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCourt.Controllers
{
    public class ClaimController : Controller
    {
        readonly CaseRepository _caseRepository;

        public ClaimController()
        {
            _caseRepository = new CaseRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CaseOfficer()
        {
            return View(_caseRepository.Get(new Guid("85F04508-7908-41DD-97F2-BCCFCF70C72C")));
        }

        public ActionResult Video()
        {
            return View();
        }

        public ActionResult Claimant()
        {
            return View();
        }

        public ActionResult Defendent()
        {
            return View();
        }

        public ActionResult _CaseHeader()
        {
            return View();
        }

        public ActionResult _ClaimFactTextAnalysis()
        {
            return View();
        }

        public ActionResult Test()
        {
            string testPhrase = "The claimant did not fulfil all of their obligations so I dispute paying the full invoice";
    
            OnlineCourt.TextAnalysis.TextAnalysis ta = new TextAnalysis.TextAnalysis();
            var t = ta.DetectKeyPhrases(testPhrase);
            decimal u;
            var x = ta.DetectLanguages(testPhrase, out u);

            return RedirectToAction("CaseOfficer");
        }
    }
}