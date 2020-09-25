using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class OneDroneTest
    {
        public static int FindUniqueDeliveryId(int[] deliveryIds)
        {
            int uniqueDeliveryId = 0;

            foreach (int deliveryId in deliveryIds)
            {
                uniqueDeliveryId ^= deliveryId;
            }

            return uniqueDeliveryId;
        }
    }
}
