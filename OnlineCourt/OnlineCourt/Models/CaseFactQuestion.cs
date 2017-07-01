using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourt.Models
{
    public class CaseFactQuestion
    {
        public DateTime Date { get; set; }
        public bool CaseOfficerQuestion { get; set; }
        public bool ClaimantQuestion { get; set; }
        public bool DefendantQuestion { get; set; }
    }
}