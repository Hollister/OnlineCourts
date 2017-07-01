using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCourt.Controllers
{
    public class ClaimController : Controller
    {
        // GET: Claim
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CaseOfficer()
        {
            return View();
        }
    }
}