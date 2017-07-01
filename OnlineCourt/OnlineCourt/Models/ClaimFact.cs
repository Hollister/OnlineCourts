using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourt.Models
{
    public class ClaimFact
    {
        public string ClaimantClaim { get; set; }
        public string ClaimantClaimDetectedLanguage { get; set; }
        public decimal ClaimantClaimDetectedLanguageConfidence { get; set; }
        public decimal ClaimantClaimDetectedKeyPhrases { get; set; }
        public string DefendantResponse { get; set; }
        public string DefendantResponseDetectedLanguage { get; set; }
        public decimal DefendantResponseDetectedLanguageConfidence { get; set; }
        public decimal DefendantResponseDetectedKeyPhrases { get; set; }
        public string CaseOfficerComment { get; set; }
        public List<CaseFactQuestion> Questions { get; set; }
    }
}