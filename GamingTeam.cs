using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IctFest
{
    public class GamingTeam: ITeam, IEventWithFees, IEventWithElimination
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public List<IParticipant> Participants { get; set; }
        public bool IsEliminated { get; set; }

        public GamingTeam(int teamID, string teamName, List<IParticipant> participants)
        {
            TeamID = teamID;
            TeamName = teamName;
            Participants = participants;
            IsEliminated = false;
        }
        public int CalculateFees()
        {
            const int nfsFeePerParticipant = 500;
            return Participants.Count * nfsFeePerParticipant;
        }

        public void PayFees()
        {
            Account.AddToBalance(CalculateFees());
            Console.WriteLine($"Team {TeamName} has paid BDT {CalculateFees()}");
        }

        public void Eliminate()
        {
            IsEliminated = true;
        }
    }
}
