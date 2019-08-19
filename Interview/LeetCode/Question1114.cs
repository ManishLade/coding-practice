using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.LeetCode
{
    class Question1114
    {

    }

    public class Foo
    {
        int count;

        public Foo()
        {
            this.count = 0;
        }

        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();

            this.count++;
        }

        public void Second(Action printSecond)
        {
            while (count < 1)
                System.Threading.Thread.Sleep(1);

            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();

            this.count++;
        }

        public void Third(Action printThird)
        {
            while (count < 2)
                System.Threading.Thread.Sleep(1);

            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
