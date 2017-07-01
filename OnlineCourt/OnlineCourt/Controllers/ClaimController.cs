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
            return View(_caseRepository.Get(new Guid("85F04508-7908-41DD-97F2-BCCFCF70C72C"));
        }
    }
}