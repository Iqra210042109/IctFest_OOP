using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IctFest
{
    public class ProgrammingTeam : ITeam,IEventWithFees, IParticipantWithSolutionsubmission
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public List<IParticipant> Participants { get; set; }
        public int TotalPoints { get; set; }
        public int RoomNumber { get; set; }
        public string PreferredLanguage { get; set; }

        public ProgrammingTeam(int teamID, string teamName, List<IParticipant> participants,
                                string preferredLanguage, int roomNumber)
        {
            TeamID = teamID;
            TeamName = teamName;
            Participants = participants;
            TotalPoints = 0;
            PreferredLanguage = preferredLanguage;
            RoomNumber = roomNumber;
        }
        public void SubmitSolution()
        {
            int generatedPoints = new Random().Next(101);
            TotalPoints += generatedPoints;
        }
        public int CalculateFees()
        {
            const int programmingContestFee = 3000;
            return programmingContestFee;
        }

        public void PayFees()
        {
            Account.AddToBalance(CalculateFees());
            Console.WriteLine($"Team {TeamName} has paid BDT {CalculateFees()}");
        }
    }
}
