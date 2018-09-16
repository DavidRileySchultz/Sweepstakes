using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public int numberOfSweepstakes;
        public MarketingFirm(ISweepstakesManager manager)
        {
            CreateYourSweepstakes(manager);
        }
        private void CreateYourSweepstakes(ISweepstakesManager manager)
        {
            numberOfSweepstakes = UserInterface.PromptForNumberOfSweepstakes();
            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                Sweepstakes sweepstakes = new Sweepstakes(UserInterface.PromptForSweepstakesName());
                sweepstakes = AddNewContestant(sweepstakes);
                manager.InsertSweepstakes(sweepstakes);
            }
            PickWinners(manager);
        }
        private Sweepstakes AddNewContestant(Sweepstakes sweepstakes)
        {
            int numberOfContestants = UserInterface.PromptForNumberOfContestants();
            for (int i = 0; i < numberOfContestants; i++)
            {
                Contestant contestant = new Contestant();
                sweepstakes.RegisterContestant(contestant);               
            }
            return sweepstakes;
        }
        private void PickWinners(ISweepstakesManager manager)
        {
            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                Console.WriteLine(manager.GetSweepstakes().PickWinner());
            }
        }
    }    
}
