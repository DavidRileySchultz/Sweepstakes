using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Contestant> sweepstakesStack = new Stack<Contestant>();
        public int Count
        {
            get
            {
                return sweepstakesStack.Count;
            }
        }
        public void AddIntoSweepstakes(Contestant contestant)
        {
            sweepstakesStack.Push(contestant);
        }
        public void EndOfSweepstakes()
        {
            sweepstakesStack.Pop();//use random generator to pick last person of list to be winner?
        }
        public Sweepstakes GetSweepStakes()
        {
            return sweepstakesStack.First();
        }
    }
}
