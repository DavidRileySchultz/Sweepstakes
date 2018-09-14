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
            
        }
        private void CreateYourSweepstakes(ISweepstakesManager manager)
        {
            numberOfSweepstakes = UserInterface.PromptForNumberOfSweepstakes();
            for(int i = 0; i < numberOfSweepstakes; i++)
            {
                Sweepstakes sweepstakes = new Sweepstakes(UserInterface.PromptForSweepstakesName());
                sweepstakes = AddNewContestant();
            }

        }
        private Sweepstakes AddNewContestant()
        {

        }
    }
}
