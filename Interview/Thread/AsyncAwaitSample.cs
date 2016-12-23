using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Thread
{
    class AsyncAwaitSample
    {
        public static void EntryPoint()
        {
            (new AsyncAwaitSample()).DoStuff();

            while (true)
            {
                Console.WriteLine("Doing Stuff on the Main Thread...................");
            }
        }

        public async Task DoStuff()
        {
            await Task.Run(() =>
            {
                LongRunningOperation();
            });
        }

        private static async Task<string> LongRunningOperation()
        {
            int counter;

            for (counter = 0; counter < 500; counter++)
            {
                Console.WriteLine(counter);
            }

            return "Counter = " + counter;
        }
    }
}