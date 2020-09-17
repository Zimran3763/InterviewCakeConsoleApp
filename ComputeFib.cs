using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class ComputeFib
    {
        public static int Fib(int n)
        {
            // Edge cases:
            if (n < 0)
            {
                throw new ArgumentException("Index was negative. No such thing as a negative index in a series.");
            }

            if (n == 0 || n == 1)
            {
                return n;
            }

            // We'll be building the fibonacci series from the bottom up.
            // So we'll need to track the previous 2 numbers at each step.
            int prevPrev = 0;  // 0th fibonacci
            int prev = 1;      // 1st fibonacci
            int current = 0;   // Declare and initialize current

            for (int i = 1; i < n; i++)
            {
                // Iteration 1: current = 2nd fibonacci
                // Iteration 2: current = 3rd fibonacci
                // Iteration 3: current = 4th fibonacci
                // To get nth fibonacci ... do n-1 iterations.
                current = prev + prevPrev;
                prevPrev = prev;
                prev = current;
            }

            return current;
        }
    }
}
