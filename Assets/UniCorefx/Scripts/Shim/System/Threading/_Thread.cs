using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace System.Threading
{
    internal class _Thread
    {
        public static void Yield()
        {
            // ないからね、しょうがないね
            Thread.Sleep(0);
        }
    }

    [Serializable]
    internal enum StackCrawlMark
    {
        LookForMe = 0,
        LookForMyCaller = 1,
        LookForMyCallersCaller = 2,
        LookForThread = 3
    }
}
