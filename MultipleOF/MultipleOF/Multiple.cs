using System;
using System.Collections.Generic;

namespace MultipleOF
{
    public class Multiple
    {
        public int SumOfMultiple(int a, int b, int limit)
        {
            int sum = 0;
            for (int i = 0; i < limit; i++)
            {
                var multiple = i * a;
                if (multiple < limit)
                {
                    sum += multiple;
                }
                multiple = i * b;
                if (multiple < limit)
                {
                    sum += multiple;
                }
            }
            return sum;
        }
        public int FibonacciWithLimit(int limit)
        {
            var prev = 1;
            var next = 2;
            do
            {
                next += prev;
                prev = next - prev;
            } while (next < limit);
            return prev;
        }
        public List<int> LargestPrimeFactor(long n)
        {
            var ret = new List<int>();
            var p = 2;
            do
            {
                if(n % p == 0)
                {
                    ret.Add(p);
                    n /= p;
                }
                else
                {
                    p++;
                }
            } while (n >= Math.Sqrt(p));
            return ret;
        }
    }
}
