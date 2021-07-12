using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Squares_of_a_Sorted_Array
    {
        public int[] SortedSquares(int[] A)
        {
            //Input: nums = [-4, -1, 0, 3, 10]
            //Output:[0,1,9,16,100]

            int[] sortedSquares = new int[A.Length];
            int i = 0;
            int j = A.Length - 1;
            int k = j;
            while (i < j)
            {
                int start = A[i] * A[i];
                int end = A[j] * A[j];

                sortedSquares[k--] = Math.Max(start, end);

                if (start > end)
                    i++;
                else j--;
            }
            return sortedSquares;
        }
    }
}
