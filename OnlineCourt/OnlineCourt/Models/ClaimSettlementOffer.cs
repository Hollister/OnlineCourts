using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourt.Models
{
    public class ClaimSettlementOffer
    {
        public DateTime OfferDate { get; set; }
        public decimal Offer { get; set; }
        public bool IsClaimantOffer { get; set; }
        public bool IsDefendantOffer { get; set; }
        public string Comment { get; set; }
    }
}