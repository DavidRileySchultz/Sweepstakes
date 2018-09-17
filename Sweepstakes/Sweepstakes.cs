using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public string name;
        private Dictionary<int, Contestant> registeredContestants;
        Random random = new Random();
        int RandomNumber()
        {
            int result = random.Next(1, registeredContestants.Count);
            return result;
        }
        public Sweepstakes(string name)
        {
            this.name = name;
            registeredContestants = new Dictionary<int, Contestant>();            
        }
        public void RegisterContestant(Contestant contestant)
        {
            DisplayContestantInformation(contestant);
            registeredContestants.Add(registeredContestants.Count, contestant);
        }
        void DisplayContestantInformation(Contestant contestant)
        {
            Console.WriteLine($"This contestant's name is: {contestant.firstName} {contestant.lastName}");
            Console.WriteLine($"This contestant's e-mail address is: {contestant.emailAddress}");
            Console.WriteLine($"This contestant's registration ID is: {contestant.registrationNumber}");
        }
        public string PickWinner()
        {
            int winningID = RandomNumber();
            Contestant winningContestant = registeredContestants[winningID];
            return $"The winner is: {registeredContestants[winningID].firstName} {registeredContestants[winningID].lastName}!!!"; 
        }        
    }
}
