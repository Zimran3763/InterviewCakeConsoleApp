using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class MergeSortedArrays
    {
        public static int[]  MergeArrays(int[] array1, int[] array2)
        {
            var result = new int [array1.Length + array2.Length] ;
            int array1Index = 0;
            int array2Index = 0;
            int resultArrayIndex = 0;
           

            for(resultArrayIndex = 0; resultArrayIndex < result.Length; resultArrayIndex ++)
            {
                bool array1Exhausted = array1Index >= array1.Length;
                bool array2Exhausted = array2Index >= array2.Length;
                // Case: next elements in result array comes from my array1
                // array1 must not be exhausted, and EITHER:
                // 1) array2 IS exhausted, or
                // 2) the current element in array1 is less
                //    than the current element in array2
                if ( !array1Exhausted && (array2Exhausted ||( array1[array1Index]<array2[array2Index])))
                {
                    result[resultArrayIndex] = array1[array1Index];
                    array1Index++;
                }
                else
                {
                    // Case: next elements in result array comes from array2
                    result[resultArrayIndex] = array2[array2Index];
                    array2Index++;
                }
                
            }
            return result;

        }
    }
}
