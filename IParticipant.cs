using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IctFest
{
    public interface IParticipant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Institution { get; set; }
        public string TShirtSize { get; set; }
    }
}
