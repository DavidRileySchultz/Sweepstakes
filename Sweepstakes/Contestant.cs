using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        Random rnd = new Random();

        public Contestant()
        {
            firstName = UserInterface.PromptForContestantsFirstName();
            lastName = UserInterface.PromptForContestantsLastName();
            emailAddress = UserInterface.PromptForContestantsEmail();
            registrationNumber = rnd.Next(1000000000, 2000000000);
        }
    }
}
