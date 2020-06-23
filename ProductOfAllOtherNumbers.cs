using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class ProductOfAllOtherNumbers
    {
        public static int[] GetProductsOfAllIntsExceptAtIndex(int[] intArray)
        {
            // Make an array with the products

            if (intArray.Length < 2)
                throw new ArgumentException("GettingError");

            int productSoFar = 1;

            int[] productOfAllIntExceptCurrentIndex = new int[intArray.Length];

            for (int i = 0; i < intArray.Length; i++)
            {
                productOfAllIntExceptCurrentIndex[i] = productSoFar;

                productSoFar *= intArray[i];
            }

            productSoFar = 1;


            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                productOfAllIntExceptCurrentIndex[i] *= productSoFar;

                productSoFar *= intArray[i];
            }

            return productOfAllIntExceptCurrentIndex;
        }
    }
}
