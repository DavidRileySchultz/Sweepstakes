using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Contestant> sweepstakesStack;
        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<Contestant>();
        }
        public void InsertSweepstakes(Contestant contestant)
        {
            sweepstakesStack.Push(contestant);
        }
        public Sweepstakes GetSweepstakes()
        {
            sweepstakesStack.Pop();
        }
    }
}
