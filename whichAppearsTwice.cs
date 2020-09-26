using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class WhichAppearsTwice
    {
        public static int FindRepeat(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Finding duplicate requires at least two numbers",
                                            nameof(numbers));
            }

            int n = numbers.Length - 1;
            //16+4 =20=> 20/2 = 10
            int sumWithoutDuplicate = (n * n + n) / 2;
            //add 4+1+3+4+2 = 14
            int actualSum = numbers.Sum(x => x);

            return actualSum - sumWithoutDuplicate;
        }
    }
}
