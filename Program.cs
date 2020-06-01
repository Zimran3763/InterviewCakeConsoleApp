using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] unorderedScores = new [] { 2, 6, 3,6, 1,6,2 };
            int highestPossibleScore = 10;
            TopScore.SortScores(unorderedScores,highestPossibleScore);
            
        }
    }
}
