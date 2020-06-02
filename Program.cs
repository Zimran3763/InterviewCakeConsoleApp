using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class Program
    {
   
        public static void Main(string[] args)
        {
            int[] unorderedScores = new [] { 2, 6, 3,6, 1,6,2 };
            int highestPossibleScore = 10;
            TopScore.SortScores(unorderedScores,highestPossibleScore);

            int[] array1 = { 3, 4, 6, 10, 11, 15 };
            int[] array2 = { 1, 5, 8, 12, 14, 19 };
            var arrayResult =  MergeSortedArrays.MergeArrays(array1, array2);
            foreach (var i in arrayResult)
            {
                Console.Write("{0} ", i);
            }
            List<Meeting> meetings = new List<Meeting>
            {
                new Meeting(0,1),
                new Meeting(3,5),
                new Meeting(4,8),
                new Meeting(10,12),
                new Meeting(9,10)
            };
            Meeting.MergeRanges(meetings);


        }
    }
}
