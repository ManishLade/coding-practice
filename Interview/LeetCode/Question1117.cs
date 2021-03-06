﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1117
    {
    }

    public class H2O
    {
        private long hCount = 0,
                     oCount = 0;

        public H2O()
        {

        }

        public void Hydrogen(Action releaseHydrogen)
        {
            while (System.Threading.Interlocked.Read(ref hCount) >= 2)
                System.Threading.Thread.Yield();

            System.Threading.Interlocked.Increment(ref hCount);

            // releaseHydrogen() outputs "H". Do not change or remove this line.
            releaseHydrogen();
        }

        public void Oxygen(Action releaseOxygen)
        {
            while (System.Threading.Interlocked.Read(ref hCount) < 2 || System.Threading.Interlocked.Read(ref oCount) == 1)
                System.Threading.Thread.Yield();

            System.Threading.Interlocked.Increment(ref oCount);

            // releaseOxygen() outputs "O". Do not change or remove this line.
            releaseOxygen();

            System.Threading.Interlocked.Decrement(ref hCount);
            System.Threading.Interlocked.Decrement(ref hCount);
            System.Threading.Interlocked.Decrement(ref oCount);
        }
    }
}
