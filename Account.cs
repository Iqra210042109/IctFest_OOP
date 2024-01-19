using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IctFest
{
    public class Account
    {
        private static int currentBalance = 0;
        private static List<int> unpaidIDs = new List<int>();

        public static void AddToBalance(int amount)
        {
            currentBalance += amount;
        }

        public static void DisplayUnpaidIDs()
        {
            Console.WriteLine("Unpaid Participant and Team IDs:");
            foreach (var id in unpaidIDs)
            {
                Console.WriteLine(id);
            }
        }

        public static void UpdateUnpaidIDs(int id)
        {
            unpaidIDs.Add(id);
        }
    }
}
