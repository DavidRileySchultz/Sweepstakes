using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string PromptForContestantsFirstName()
        {
            Console.WriteLine("Please enter contestant's first name:");
            return Console.ReadLine();
        }
        public static string PromptForContestantsLastName()
        {
            Console.WriteLine("Please enter the contestant's Last Name:");
            return Console.ReadLine();
        }
        public static string PromptForContestantsEmail()
        {
            Console.WriteLine("Please enter the contestant's E-Mail address:");
            return Console.ReadLine();
        }
        public static string PromptForSweepstakesName()
        {
            Console.WriteLine("Please enter the name of your Sweepstakes:");
            return Console.ReadLine();
        }
        public static int PromptForNumberOfSweepstakes()
        {
            Console.WriteLine("How many Sweepstakes would you like to run:");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
