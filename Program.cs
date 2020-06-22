using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashingAndHashTables;

namespace InterviewCakeConsoleApp
{
    public class Program
    {
   
        public static void Main(string[] args)
        {
            #region Top Score
            int[] unorderedScores = new [] { 2, 6, 3,6, 1,6,2 };
            int highestPossibleScore = 10;
            TopScore.SortScores(unorderedScores,highestPossibleScore);
            #endregion

            #region Merge Sorted Arrays
            int[] array1 = { 3, 4, 6, 10, 11, 15 };
            int[] array2 = { 1, 5, 8, 12, 14, 19 };
            var arrayResult =  MergeSortedArrays.MergeArrays(array1, array2);
            foreach (var i in arrayResult)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            #endregion

            #region Merge Meetings
            List<Meeting> meetings = new List<Meeting>
            {
                new Meeting(0,1),
                new Meeting(3,5),
                new Meeting(4,8),
                new Meeting(10,12),
                new Meeting(9,10)
            };
            Meeting.MergeRanges(meetings);
            #endregion

            #region Cafe Order Checker
            //int[] takeOutOrders = new[] {1,3,5 };
            //int[] dineInOrders = new[] { 2, 4, 6 };
            //int[] servedOrders = new[] { 1, 2, 4, 6, 5, 3 };

            //int[] takeOutOrders = new[] { 17, 8, 24 };
            //int[] dineInOrders = new[] { 12, 19, 2 };
            //int[] servedOrders = new[] { 17, 8, 12, 19, 24, 2 };

            //int[] takeOutOrders = new[] {0};
            //int[] dineInOrders = new[] { 12, 19, 2 };
            //int[] servedOrders = new[] { 12, 19, 2 };

            var takeOutOrders = new int[] { 1, 9 };
            var dineInOrders = new int[] { 7, 8 };
            var servedOrders = new int[] { 1, 7, 8 };

            string v = CafeOrderChecker.CafeOrder(takeOutOrders, dineInOrders, servedOrders);
            Console.WriteLine(v);
            #endregion

            #region Reverse String In Place
            char[] actualArray = new char[]{ 'A', 'B', 'C', 'D', 'E' } ;
            ReverseStringInPlace.Reverse(actualArray);
            #endregion

            #region Reverse Words
            char[] message = { 'c', 'a', 'k', 'e', ' ',
                   'p', 'o', 'u', 'n', 'd', ' ',
                   's', 't', 'e', 'a', 'l'};
            ReverseWords.ReverseWord(message);
            #endregion

            #region Inflight Entertainment
            int[] movieLength = new int[] { 1, 2, 3, 4, 5, 6 };
            int flightLength = 7;
            InflightEntertainment.CanTwoMoviesFillFlight(movieLength,flightLength);
            #endregion
            #region Permutation Palindrome
            var result =  PermutationPalindrome.HasPalindromePermutation("aabcbcd");
            #endregion
            var text = "Dessert - mille-feuille cake? Allie's Bakery: Sasha's Cakes decisions..dessert dessert Yum!";
            //WordCloudData.GetWords(text).ForEach(Console.WriteLine);
            //Console.WriteLine(String.Join(" ", WordCloudData.GetWords(text)));
            WordCloudData wordCloudData = new WordCloudData(text);
            #region word cloud data

            #endregion

       
        }
    }
}
