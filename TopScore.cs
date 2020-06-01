using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class TopScore
    {
        public static int[] SortScores(int[] unorderedScores, int highestPossibleScore)
        {
            // Array of 0s at indices 0..highestPossibleScore
            int[] scoreCounts = new int[highestPossibleScore + 1];

            // Populate scoreCounts
            foreach (var score in unorderedScores)
            {
                scoreCounts[score]++;
            }

            // Populate the final sorted array
            int[] sortedScores = new int[unorderedScores.Length];
            int currentSortedIndex = 0;

            // For each item in scoreCounts
            for (int score = highestPossibleScore; score >= 0; score--)
            {
                int count = scoreCounts[score];

                // For the number of times the item occurs
                for (int occurrence = 0; occurrence < count; occurrence++)
                {
                    // Add it to the sorted array
                    sortedScores[currentSortedIndex] = score;
                    currentSortedIndex++;
                }
            }

            return sortedScores;
        }

    }
}
