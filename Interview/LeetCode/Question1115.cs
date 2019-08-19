using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1115
    {
    }

    public class FooBar
    {
        private bool foo = true,
                     bar = false;
        private int n;

        public FooBar(int n)
        {
            this.n = n;
        }

        public void Foo(Action printFoo)
        {
            for (int i = 0; i < n; i++)
            {
                while (!foo)
                    System.Threading.Thread.Sleep(1);

                // printFoo() outputs "foo". Do not change or remove this line.
                printFoo();

                foo = false;
                bar = true;
            }
        }

        public void Bar(Action printBar)
        {
            for (int i = 0; i < n; i++)
            {
                while (!bar)
                    System.Threading.Thread.Sleep(1);

                // printBar() outputs "bar". Do not change or remove this line.
                printBar();

                foo = true;
                bar = false;
            }
        }
    }
}
