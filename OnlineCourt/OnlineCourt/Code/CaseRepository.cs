using OnlineCourt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourt.Code
{
    public class CaseRepository
    {
        public Claim Get(Guid id)
        {
            List<ClaimFact> facts = new List<ClaimFact>();
            List<ClaimSettlementOffer> offers = new List<ClaimSettlementOffer>();
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            questions.Add(new CaseFactQuestion
            {
                ClaimantQuestion = true,
                Question = "This is a question started by the claimant",
                Date = DateTime.Today,
                Responses = new List<CaseFactQuestionResponse> {
                        new CaseFactQuestionResponse { IsDefendantResponse = true, Response = "This is the defendant esponse", ResponseDate = DateTime.Today }
                    }
            });

            facts.Add(new ClaimFact
            {
                ClaimantClaim = "Claimant Claim",
                DefendantResponse = "Defendant Response",
                CaseOfficerComment = "Case Office Comment",
                Questions = questions
            });

            return new Claim
            {
                Id = new Guid("85F04508-7908-41DD-97F2-BCCFCF70C72C"),
                ClaimTitle = "Frank Hollister vs Top Notch Design Agency",
                ClaimantName = "Frank Hollister",
                ClaimantAddress = "29 Acacia Road" + Environment.NewLine + "Stockport" + Environment.NewLine + "BA54 ANA",
                DefendantName = "Top Notch Design Agency",
                DefendantAddress = "667 London Road" + Environment.NewLine + "St Albans" + Environment.NewLine + "AA4 8IP",
                ClaimFacts = facts,
                ClaimSettlementOffers = offers
            };
        }
    }
}