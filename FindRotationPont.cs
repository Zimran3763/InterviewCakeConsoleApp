using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class FindRotationPont
    {
        public static int FindRotationPoint(String[] words)
        {
            // Find the rotation point in the array
            // Guess a point halfway between floor and ceiling
            int floorIndex = 0;
            int ceillingIndex = words.Length - 1;

            string firstWord = words[0];

            while (floorIndex < ceillingIndex)
            {

                int guessIndex = (floorIndex + ceillingIndex) / 2;

                // Use String.Compare method  
                //if (String.Compare(author1, author2) == 0)  
                //Console.WriteLine($"Both strings have same value.");  
                //else if (String.Compare(author1, author2) < 0)  
                //Console.WriteLine($"{author1} precedes {author2}.");  
                //else if (String.Compare(author1, author2) > 0)  
                //Console.WriteLine($"{author1} follows {author2}.");  

                // If guess comes after first word or is the first word
                if (string.Compare(words[guessIndex], firstWord) >= 0)
                {
                    // Go right
                    floorIndex = guessIndex;
                }
                else
                {
                    // Go left
                    ceillingIndex = guessIndex;
                }

                // If floor and ceiling have converged
                if (floorIndex + 1 == ceillingIndex)
                {
                    // Between floor and ceiling is where we flipped to the beginning,
                    // so ceiling is alphabetically first
                    break;
                }

            }


            return ceillingIndex;
        }

    }
}
