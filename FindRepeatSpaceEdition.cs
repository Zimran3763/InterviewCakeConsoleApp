using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class FindRepeatSpaceEdition
    {
        public static int FindRepeat(int[] numbers)
        {
            ///We have an array of integers, where:

            // The integers are in the range 1..n
            //The array has a length of n + 1
            //It follows that our array has at least one integer which appears at least twice.
            //But it may have several duplicates, and each duplicate may appear more than twice.

            int floor = 1;
            //this array should have atleast one duplicate because one index is always extra so if we put each number on each index like
            //one on one index and 10 on 10 index then still 0 index left that we have fill with duplicate
            int ceiling = numbers.Length - 1;

            while (floor < ceiling)
            {
                // Divide our range 1..n into an upper range and lower range
                // (such that they don't overlap)
                // Lower range is floor..midpoint
                // Upper range is midpoint+1..ceiling
                int midpoint = floor + (ceiling - floor) / 2;
                int lowerRangeFloor = floor;
                int lowerRangeCeiling = midpoint;
                int upperRangeFloor = midpoint + 1;
                int upperRangeCeiling = ceiling;

                // Count number of items in lower range which has value 1,2,3,4 in the array if we find more than 4 items in the array 
                //it means duplicate is from 1 ,2 ,3, 4

                int itemsInLowerRange = numbers.Count(item => item >= lowerRangeFloor && item <= lowerRangeCeiling);

                int distinctPossibleIntegersInLowerRange = lowerRangeCeiling - lowerRangeFloor + 1;

                if (itemsInLowerRange > distinctPossibleIntegersInLowerRange)
                {
                    // There must be a duplicate in the lower range
                    // so use the same approach iteratively on that range
                    floor = lowerRangeFloor;
                    ceiling = lowerRangeCeiling;
                }
                else
                {
                    // There must be a duplicate in the upper range
                    // so use the same approach iteratively on that range
                    floor = upperRangeFloor;
                    ceiling = upperRangeCeiling;
                }
            }

            // Floor and ceiling have converged
            // We found a number that repeats!
            return floor;
        }
    }
}
