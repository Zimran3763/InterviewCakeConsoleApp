using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class CafeOrderChecker
    {
        public static string CafeOrder(int[] takeOutOrders, int[] dineInOrders, int[] servedOrders)
        {
            int takeOutIndex = 0;
            int dineInIndex = 0;
            int servedIndex;
            for (servedIndex = 0; servedIndex < servedOrders.Length; servedIndex++)
            {
                bool exhaustedTakeOut = takeOutIndex >= takeOutOrders.Length;
                bool exhaustedDineIn = dineInIndex >= dineInOrders.Length;

                if (!exhaustedTakeOut && servedOrders[servedIndex] == takeOutOrders[takeOutIndex])
                    takeOutIndex++;
                else if (!exhaustedDineIn && servedOrders[servedIndex] == dineInOrders[dineInIndex])
                    dineInIndex++;
                else
                    return "Not In Order";
            }
            if (dineInIndex != dineInOrders.Length || takeOutIndex != takeOutOrders.Length)
            {
                return "Not In Order because of extra order";
            }
            return "In Order";
        }
    }
}
