using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class HighestProductOf3
    {
        public static int HighestProductOfThree(int[] arrayOfInts)
        {
            // Calculate the highest product of three numbers
            if (arrayOfInts.Length < 3)
            {
                throw new ArgumentException("Less than 3 items!", nameof(arrayOfInts));
            }
            int highest = Math.Max(arrayOfInts[0], arrayOfInts[1]);
            int lowest = Math.Min(arrayOfInts[0], arrayOfInts[1]);


            int highestProductOfTwo = (arrayOfInts[0] * arrayOfInts[1]);
            int lowestProductOfTwo = (arrayOfInts[0] * arrayOfInts[1]);

            int highestProductOfThree = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];

            for (int current = 2; current < arrayOfInts.Length; current++)
            {
                highestProductOfThree = Math.Max(Math.Max(
                    highestProductOfThree,
                    highestProductOfTwo * arrayOfInts[current]),
                    lowestProductOfTwo * arrayOfInts[current]);

                highestProductOfTwo = Math.Max(Math.Max(
                    highestProductOfTwo,
                    highest * arrayOfInts[current]), lowest * arrayOfInts[current]);

                lowestProductOfTwo = Math.Min(Math.Min(
                    lowestProductOfTwo,
                    highest * arrayOfInts[current]), lowest * arrayOfInts[current]);

                highest = Math.Max(highest, arrayOfInts[current]);
                lowest = Math.Min(lowest, arrayOfInts[current]);
            }

            return highestProductOfThree;
        }
    }
}
