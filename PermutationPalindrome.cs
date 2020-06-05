using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class PermutationPalindrome
    {
        public static bool HasPalindromePermutation(string theString)
        {
            // Check if any permutation of the input is a palindrome
            char[] c = theString.ToCharArray();
            var set = new HashSet<char>();
            //foreach (char c in theString)
            //{
            //    if (unpairedCharacters.Contains(c))
            //    {
            //        unpairedCharacters.Remove(c);
            //    }
            //    else
            //    {
            //        unpairedCharacters.Add(c);
            //    }
            //}
            for (int permutationIndex = 0; permutationIndex < c.Length; permutationIndex++)
            {

                if (set.Contains(c[permutationIndex]))
                    set.Remove(c[permutationIndex]);
                else
                    set.Add(c[permutationIndex]);
            }

            if (set.Count <= 1)
                return true;
            return false;
        }
    }
}
