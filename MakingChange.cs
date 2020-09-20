using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class MakingChange
    {
        public static int ChangePossibilitiesBottomUp(int amount, int[] denominations)
        {
            //Here Index are value of the coin like 1Cent, 3Cent, 5cent
            //and value on each index is number of ways to arrange that coin
            // Array of zeros from 0..amount
            int[] waysOfDoingNCents = new int[amount + 1];
            //ways to arrange a zero coin is always 1 
            waysOfDoingNCents[0] = 1;

            foreach (int coin in denominations)
            {
                //higher value always start with coin value becuase if you want to arrange 6 cent with 3cents you can only start with 3 cents (there is only one way 3+3)
                //then you will increase your higher value by 1 so then it would be next value of coin like 4 cent and then you will substract coin value (3) from higher value 
                // 4 - 3 = 1 ; remainder would be 1cent so you will check 1 cent ways of arrangement and + 3 cents arrangement that would be 0 + 1 = 2 ways to do 4 cents with
                // 3 coins 
                // to jo bhi coin hume diye hain uske aage sabhi index matlan coin ko diye hue coin me se substract kerke check karenge ke jo bacha hua amount hai usko kitne
                // se arrange kar sakte hai
                for (int higherAmount = coin; higherAmount <= amount; higherAmount++)
                {
                    int higherAmountRemainder = higherAmount - coin;
                    waysOfDoingNCents[higherAmount] +=
                        waysOfDoingNCents[higherAmountRemainder];
                }
            }

            return waysOfDoingNCents[amount];
        }
    }
}
