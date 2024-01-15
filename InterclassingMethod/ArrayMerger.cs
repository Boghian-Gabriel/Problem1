using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterclassingMethod
{
    public static class ArrayMerger
    {
        public static int[] MergeSortedArrays(int[] array1, int[] array2, int iDimension)
        {
            int[] mergedArray = new int[iDimension];

            int i = 0, j = 0, k = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    mergedArray[k++] = array1[i++];
                }
                else
                {
                    mergedArray[k++] = array2[j++];
                }
            }

            while (i < array1.Length)
            {
                mergedArray[k++] = array1[i++];
            }

            while (j < array2.Length)
            {
                mergedArray[k++] = array2[j++];
            }

            return mergedArray;
        }
    }
}
