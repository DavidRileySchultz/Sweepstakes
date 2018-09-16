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
        public static int PromptForNumberOfContestants()
        {
            Console.WriteLine("What is the number of contests allowed in your sweepstakes:");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static ISweepstakesManager PromptForTypeOfDataStructure()
        {
            Console.WriteLine("Would you like to store your Sweepstakes as a (1)Queue or a (2)Stack:");
            switch (Console.ReadLine())
            {
                case "queue":
                    Console.WriteLine("You chose to use a Queue to organize your sweepstakes.");
                    return new SweepstakesQueueManager();
                case "stack":
                    Console.WriteLine("You chose to use a Stack to organize your sweepstakes.");
                    return new SweepstakesStackManager();
                default:
                    Console.WriteLine("Invalid input, defaults to stack. . .");
                    return new SweepstakesStackManager();
            }
        }
    }
}
