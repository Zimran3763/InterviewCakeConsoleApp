using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class AppleStocks
    {
        //Brute Force
        public static int GetMaxProfit(int[] stockPrices)
        {
            // Calculate the max profit
            if (stockPrices.Length < 1)
                throw new System.ArgumentException("Array cannot be null less than 1");

            if (stockPrices.Length == 1)
                throw new System.ArgumentException("We need atleast two values");

            int maxProfit = stockPrices[1] - stockPrices[0];

            for (int buyPrice = 0; buyPrice < stockPrices.Length - 1; buyPrice++)
            {
                for (int salePrice = buyPrice + 1; salePrice < stockPrices.Length; salePrice++)
                {

                    int currenProfit = stockPrices[salePrice] - stockPrices[buyPrice];

                    maxProfit = Math.Max(maxProfit, currenProfit);
                }
            }
            return maxProfit;
        }
    }
}
