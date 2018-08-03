using System;

namespace Interview.Algorithm.Other
{
    class Wave
    {
        public static void MakeWave()
        {
            for (; ; )
            {
                for (int i = 0; i < 960000; i++)
                    ;
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}