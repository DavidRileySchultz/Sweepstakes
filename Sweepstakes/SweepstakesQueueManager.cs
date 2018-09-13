using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Contestant> sweepstakesQueue;
        public SweepstakesQueueManager()
        {
            sweepstakesQueue = new Queue<Contestant>();
        }
        public void InsertSweepstakes(Contestant contestant)
        {
            sweepstakesQueue.Enqueue(contestant);
        }
        public Sweepstakes GetSweepstakes()
        {
            sweepstakesQueue.Dequeue();
        }
    }
}
