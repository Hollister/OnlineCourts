using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourt.Models
{
    public class CaseFactQuestionResponse
    {
        public DateTime ResponseDate { get; set; }
        public string Response { get; set; }
        public bool IsClaimantResponse { get; set; }
        public bool IsDefendantResponse { get; set; }
        public bool IsCaseOfficeResponse { get; set; }
    }
}