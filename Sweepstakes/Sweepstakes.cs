using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        private Dictionary<int, Contestant> registeredContestants;
        public int Count
        {
            get
            {
                return registeredContestants.Count;
            }
        }
        public Sweepstakes()
        {
            registeredContestants = new Dictionary<int, Contestant>();
        }
        Sweepstakes(string name)
        {

        }
        void RegisterContestant(Contestant contestant)
        {
            registeredContestants.Add(registeredContestants.Count + 1, contestant);
        }
        void PrintContestantInformation(Contestant contestant)
        {
            Console.WriteLine($"This contestant's name is: {contestant.firstName} {contestant.lastName}");
            Console.WriteLine($"This contestant's e-mail address is: {contestant.emailAddress}");
            Console.WriteLine($"This contestant's registration ID is: {contestant.registrationNumber}");
        }
        string PickWinner()
        {
            
        }
        
    }
}
