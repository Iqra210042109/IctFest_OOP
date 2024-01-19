using System;
using System.Collections.Generic;
namespace IctFest
{
    class program
    {
        static void Main()
        {

            IParticipant participant1 = new Participant { ID = 1, Name = "Iqra", TShirtSize = "XL" };
            IParticipant participant2 = new Participant { ID = 2, Name = "Samia", TShirtSize = "S" };
            IParticipant participant3 = new Participant{ ID = 3, Name = "Dipto", TShirtSize = "XXL" };
            
            List<IParticipant> programmingParticipants = new List<IParticipant> { participant1, participant2, participant3 };
            
            ITeam  programmingTeam = new ProgrammingTeam(101, "Abstract", programmingParticipants,  "C#", 202);

            if (programmingTeam is IParticipantWithSolutionsubmission solutionSubmissionTeam)
            {
                solutionSubmissionTeam.SubmitSolution();
            }

            if (programmingTeam is IEventWithFees feePaymentTeam)
            {
                feePaymentTeam.PayFees();
            }

            if (programmingTeam is ITeam displayTeam)
            {
                Console.WriteLine($"Team ID: {displayTeam.TeamID}, Team Name: {displayTeam.TeamName}");
            }

           ;

            List<IParticipant> gamingParticipants = new List<IParticipant> { participant1, participant2, participant3 };

            ITeam gamingTeam = new GamingTeam(201, "Gaming Team 1", gamingParticipants);
            if (gamingTeam is IEventWithFees feePaymentGamingTeam)
            {
                feePaymentGamingTeam.PayFees();
            }

            if (gamingTeam is IEventWithElimination eliminationGamingTeam)
            {
                eliminationGamingTeam.Eliminate();
            }

            Account.AddToBalance(3000);
            Account.AddToBalance(1500);

            Account.DisplayUnpaidIDs();
        }
       

        
    }
}
