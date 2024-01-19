using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IctFest
{
    public interface ITeam
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public List<IParticipant> Participants { get; set; }
    }
}
