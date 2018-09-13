using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Contestant> sweepstakesQueue = new Queue<Contestant>();
        public int Count
        {
            get
            {
                return sweepstakesQueue.Count;
            }
        }
        public void AddIntoSweepSstakes(Contestant contestant)
        {
            sweepstakesQueue.Enqueue(contestant);
        }
        public void EndOfSweepstakes()
        {
            sweepstakesQueue.Dequeue();//use random generator to scramble to pick last person of list to be winner?
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.First();
        }
    }
}
