using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourt.Models
{
    public class Claim
    {
        public Guid Id { get; set; }
        public string ClaimTitle { get; set; }
        public string ClaimantName { get; set; }
        public string ClaimantAddress { get; set; }
        public string DefendantName { get; set; }
        public string DefendantAddress { get; set; }
        public List<ClaimFact> ClaimFacts { get; set; }
        public List<ClaimSettlementOffer> ClaimSettlementOffers { get; set; }
    }
}