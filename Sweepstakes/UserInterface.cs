using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class UserInterface
    {
        public void PromptForContestantsFirstName()
        {
            Console.WriteLine("Please enter the contestant's First Name:");
            Console.ReadLine();
        }
        public void PromptForContestantsLastName()
        {
            Console.WriteLine("Please enter the contestant's Last Name:");
            Console.ReadLine();
        }
        public void PromptForContestantsEmail()
        {
            Console.WriteLine("Please enter the contestant's E-Mail address:");
            Console.ReadLine();
        }
        public void PromptForContestantsId()
        {
            Console.WriteLine("Please enter contestant's ID number:");
            Console.ReadLine();
        }

    }
}
