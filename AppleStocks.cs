using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class AppleStocks
    {
        
        public static int GetMaxProfit(int[] stockPrices)
        {
            #region //Brute Force
            //if(stockPrices.Length < 2  )
            //   throw new System.ArgumentException("Parameter cannot be null", "original");

            //if (stockPrices.Length == 1)
            //    throw new System.ArgumentException("We need atleast two values");

            //int maxProfit = stockPrices[1] - stockPrices[0];

            //for (int buyPrice = 0; buyPrice < stockPrices.Length - 1; buyPrice++)
            //{
            //    for (int salePrice = buyPrice + 1; salePrice < stockPrices.Length; salePrice++)
            //    {

            //        int currenProfit = stockPrices[salePrice] - stockPrices[buyPrice];

            //        maxProfit = Math.Max(maxProfit, currenProfit);
            //    }
            //}
            //return maxProfit;
            #endregion
            #region optimize solution with one pass greedy algo
                if (stockPrices.Length < 2)
                    throw new System.ArgumentException("Need Two prices atleast two prices");

                int minValue = stockPrices[0];
                int maxProfit = stockPrices[1] - stockPrices[0];

                for (int currentValue = 1; currentValue < stockPrices.Length; currentValue++)
                {
                    int currenProfit = stockPrices[currentValue] - minValue;

                    maxProfit = Math.Max(maxProfit, currenProfit);

                    minValue = Math.Min(stockPrices[currentValue], minValue);
                }
                return maxProfit;
            #endregion
        }
    }
}
