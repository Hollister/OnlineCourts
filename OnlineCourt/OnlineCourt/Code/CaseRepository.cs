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

            facts.Add(GetClaimFactA());
            facts.Add(GetClaimFactB());
            facts.Add(GetClaimFactC());
            facts.Add(GetClaimFactD());
            facts.Add(GetClaimFactE());
            facts.Add(GetClaimFactF());
            facts.Add(GetClaimFactG());
            facts.Add(GetClaimFactH());

            return new Claim
            {
                Id = new Guid("85F04508-7908-41DD-97F2-BCCFCF70C72C"),
                ClaimTitle = "Recruitment Ltd vs Bad Payer Ltd",
                ClaimantName = "Recruitment Ltd",
                ClaimantAddress = "St Albans",
                DefendantName = "Bad Payer Ltd",
                DefendantAddress = "St Albans",
                ClaimFacts = facts,
                ClaimSettlementOffers = offers
            };
        }

        private ClaimFact GetClaimFactA()
        {
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            return new ClaimFact
            {
                ClaimFactCode = "A",
                ClaimantClaim = "How did the Defendant's obligations to you arise?",
                ClaimantClaimResponse = "Under the terms of an agreement",
                ClaimantClaimDetectedKeyPhrases = "Outstanding unpaid bill, invoice, staff",
                ClaimantClaimDetectedLanguage = "English",
                ClaimantClaimDetectedLanguageConfidence = 100,
                DefendantQuestion = "",
                DefendantResponse = "",
                DefendantResponseDetectedKeyPhrases = "claimant, obligations, invoice",
                DefendantResponseDetectedLanguage = "English",
                DefendantResponseDetectedLanguageConfidence = 100,
                CaseOfficerComment = "",
                Questions = questions
            };
        }

        private ClaimFact GetClaimFactB()
        {
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            return new ClaimFact
            {
                ClaimFactCode = "B",
                ClaimantClaim = "How was the agreement made?",
                ClaimantClaimResponse = "In a written document",
                ClaimantClaimDetectedKeyPhrases = "Outstanding unpaid bill, invoice, staff",
                ClaimantClaimDetectedLanguage = "English",
                ClaimantClaimDetectedLanguageConfidence = 100,
                DefendantQuestion = "",
                DefendantResponse = "",
                DefendantResponseDetectedKeyPhrases = "claimant, obligations, invoice",
                DefendantResponseDetectedLanguage = "English",
                DefendantResponseDetectedLanguageConfidence = 100,
                CaseOfficerComment = "",
                Questions = questions
            };
        }

        private ClaimFact GetClaimFactC()
        {
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            return new ClaimFact
            {
                ClaimFactCode = "C",
                ClaimantClaim = "On what date was the agreement made?",
                ClaimantClaimResponse = "12/04/2017",
                ClaimantClaimDetectedKeyPhrases = "Outstanding unpaid bill, invoice, staff",
                ClaimantClaimDetectedLanguage = "English",
                ClaimantClaimDetectedLanguageConfidence = 100,
                DefendantQuestion = "",
                DefendantResponse = "",
                DefendantResponseDetectedKeyPhrases = "claimant, obligations, invoice",
                DefendantResponseDetectedLanguage = "English",
                DefendantResponseDetectedLanguageConfidence = 100,
                CaseOfficerComment = "",
                Questions = questions
            };
        }

        private ClaimFact GetClaimFactD()
        {
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            return new ClaimFact
            {
                ClaimFactCode = "D",
                ClaimantClaim = "What was the Defendant's legal responsibility to you?",
                ClaimantClaimResponse = "",
                ClaimantClaimDetectedKeyPhrases = "",
                ClaimantClaimDetectedLanguage = "English",
                ClaimantClaimDetectedLanguageConfidence = 100,
                DefendantQuestion = "",
                DefendantResponse = "",
                DefendantResponseDetectedKeyPhrases = "claimant, obligations, invoice",
                DefendantResponseDetectedLanguage = "English",
                DefendantResponseDetectedLanguageConfidence = 100,
                CaseOfficerComment = "",
                Questions = questions
            };
        }

        private ClaimFact GetClaimFactE()
        {
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            return new ClaimFact
            {
                ClaimFactCode = "E",
                ClaimantClaim = "How does that legal responsibility arise?",
                ClaimantClaimResponse = "",
                ClaimantClaimDetectedKeyPhrases = "Outstanding unpaid bill, invoice, staff",
                ClaimantClaimDetectedLanguage = "English",
                ClaimantClaimDetectedLanguageConfidence = 100,
                DefendantQuestion = "",
                DefendantResponse = "",
                DefendantResponseDetectedKeyPhrases = "claimant, obligations, invoice",
                DefendantResponseDetectedLanguage = "English",
                DefendantResponseDetectedLanguageConfidence = 100,
                CaseOfficerComment = "",
                Questions = questions
            };
        }

        private ClaimFact GetClaimFactF()
        {
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            return new ClaimFact
            {
                ClaimFactCode = "F",
                ClaimantClaim = "What has the Defendant done or failed to do?",
                ClaimantClaimResponse = "Failed to pay an invoice for staff",
                ClaimantClaimDetectedKeyPhrases = "Failed, pay, invoice, staff",
                ClaimantClaimDetectedLanguage = "English",
                ClaimantClaimDetectedLanguageConfidence = 100,
                DefendantQuestion = "",
                DefendantResponse = "",
                DefendantResponseDetectedKeyPhrases = "claimant, obligations, invoice",
                DefendantResponseDetectedLanguage = "English",
                DefendantResponseDetectedLanguageConfidence = 100,
                CaseOfficerComment = "",
                Questions = questions
            };
        }

        private ClaimFact GetClaimFactG()
        {
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            return new ClaimFact
            {
                ClaimFactCode = "G",
                ClaimantClaim = "How has the Defendant's failure caused you loss?",
                ClaimantClaimResponse = "Unpaid bill for £12,000",
                ClaimantClaimDetectedKeyPhrases = "Unpaid bill, £12,000",
                ClaimantClaimDetectedLanguage = "English",
                ClaimantClaimDetectedLanguageConfidence = 100,
                DefendantQuestion = "",
                DefendantResponse = "",
                DefendantResponseDetectedKeyPhrases = "claimant, obligations, invoice",
                DefendantResponseDetectedLanguage = "English",
                DefendantResponseDetectedLanguageConfidence = 100,
                CaseOfficerComment = "",
                Questions = questions
            };
        }

        private ClaimFact GetClaimFactH()
        {
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            return new ClaimFact
            {
                ClaimFactCode = "H",
                ClaimantClaim = "How much loss has been caused?",
                ClaimantClaimResponse = "£12,000",
                ClaimantClaimDetectedKeyPhrases = "£12,000",
                ClaimantClaimDetectedLanguage = "English",
                ClaimantClaimDetectedLanguageConfidence = 100,
                DefendantQuestion = "",
                DefendantResponse = "",
                DefendantResponseDetectedKeyPhrases = "claimant, obligations, invoice",
                DefendantResponseDetectedLanguage = "English",
                DefendantResponseDetectedLanguageConfidence = 100,
                CaseOfficerComment = "",
                Questions = questions
            };
        }

        private ClaimFact GetClaimFact1()
        {
            List<CaseFactQuestion> questions = new List<CaseFactQuestion>();

            questions.Add(new CaseFactQuestion
            {
                ClaimantQuestion = true,
                Question = "What obligations from the agreement were not met?",
                Date = new DateTime(2017, 2, 20),
                Responses = new List<CaseFactQuestionResponse> {
                        new CaseFactQuestionResponse { IsDefendantResponse = true, Response = "Contracted staff were not available on several occasions, but the agreement stated there would be guaranteed staff availability", ResponseDate = new DateTime(2017, 2, 21) },
                        new CaseFactQuestionResponse { IsClaimantResponse = true, Response = "We always do our best to make sure staff are always available, but due to staff shortages did fail to deliver on this on occasion", ResponseDate = new DateTime(2017, 2, 22) }
                    }
            });

            questions.Add(new CaseFactQuestion
            {
                CaseOfficerQuestion = true,
                Question = "I have looked through the contract and agree that although most requirements were met by the claimant, the defendant does has cause for complaint as not all obligations were met. Would both parties be happy for the defendent to pay a reduced invoice?",
                Date = new DateTime(2017, 2, 25),
                Responses = new List<CaseFactQuestionResponse> {
                        new CaseFactQuestionResponse { IsDefendantResponse = true, Response = "Based on the costs incurred by us because of the lack of staff we would be happy to pay £10,000 of the invoice", ResponseDate = new DateTime(2017, 2, 26) },
                        new CaseFactQuestionResponse { IsClaimantResponse = true, Response = "That seems a reasonable amount to pay based on the circumstances", ResponseDate = new DateTime(2017, 2, 27) }
                    }
            });

            return new ClaimFact
            {
                ClaimantClaim = "The defendant has caused us loss by doing or failing to do something under the terms of an agreement in a written document on 12/04/2016." + Environment.NewLine + "Failed to pay an invoice for staff" + Environment.NewLine + "Outstanding unpaid bill for £12,000",
                ClaimantClaimDetectedKeyPhrases = "Outstanding unpaid bill, invoice, staff",
                ClaimantClaimDetectedLanguage = "English",
                ClaimantClaimDetectedLanguageConfidence = 100,
                DefendantResponse = "I agree that the claimant is owed under the terms of a valid agreement, but dispute the item of loss." + Environment.NewLine + "The claimant did not fulfil all of their obligations so I dispute paying the full invoice",
                DefendantResponseDetectedKeyPhrases = "claimant, obligations, invoice",
                DefendantResponseDetectedLanguage = "English",
                DefendantResponseDetectedLanguageConfidence = 100,
                CaseOfficerComment = "Having reviewed the agreement between the two parties it is clear to me that although the defendant has not met their obligations they have a case to dispute the full invoice amount claimed. Both parties have agreed a fair value for the defendant to pay",
                Questions = questions
            };
        }
    }
}