using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace System
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    static class __CompatExtension
    {
        public static void Restart(this Stopwatch stopwatch)
        {
            stopwatch.Reset();
            stopwatch.Start();
        }
    }
}
