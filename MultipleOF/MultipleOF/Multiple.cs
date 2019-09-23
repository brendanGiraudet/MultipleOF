using System;
using System.Collections.Generic;

namespace MultipleOF
{
    public class Multiple
    {
        /// <summary>
        /// Sum of a and b digits multiple
        /// </summary>
        /// <param name="a">First digit</param>
        /// <param name="b">Second digit</param>
        /// <param name="limit">Iteration number</param>
        /// <returns>Sum of multiple a and b</returns>
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
        /// <summary>
        /// Fibonacci with limit
        /// </summary>
        /// <param name="limit">Limit of the fibonacci calcul</param>
        /// <returns>Value of the fibonacci calcul</returns>
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
        /// <summary>
        /// Split the digit n in multiple prime factor
        /// </summary>
        /// <param name="n">Digit to split</param>
        /// <returns>List of prime factor</returns>
        public List<int> LargestPrimeFactor(long n)
        {
            var ret = new List<int>();
            var p = 2;
            do
            {
                if (n % p == 0)
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
        /// <summary>
        /// Search index where the fibonacci sequence contain nbDigit
        /// </summary>
        /// <param name="nbDigit">Number of sequence</param>
        /// <returns>Index</returns>
        public int SearchIndexFibonacciNumber(int nbDigit)
        {
            var prev = 1;
            var next = 2;
            var index = 3;
            do
            {
                index++;
                next += prev;
                prev = next - prev;
            } while (next.ToString().Length < nbDigit);
            return index;
        }
        public double SumSquareDifference(int limit)
        {
            double sqrtValue = 1;
            double sumValue = 1;
            for (int i = 2; i <= limit; i++)
            {
                // squares of the first N natural numbers
                sqrtValue += Math.Pow(i, 2);
                // sum of the first N natural numbers
                sumValue += i;
            }

            return Math.Pow(sumValue, 2) - sqrtValue;
        }
    }
}
