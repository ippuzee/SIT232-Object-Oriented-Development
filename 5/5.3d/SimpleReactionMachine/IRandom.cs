using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReactionMachine
{
    internal interface IRandom
    {
        int GetRandom(int from, int to);
    }
}
