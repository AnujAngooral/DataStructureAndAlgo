using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Replace_Elements_with_Greatest_Element_on_Right_Side
    {
        public int[] ReplaceElements(int[] arr)
        {
            if (arr.Length == 1)
            {
                arr[0] = -1;
                return arr;
            }

            int max = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int temp = max;
                max = Math.Max(max,arr[i]);
                arr[i] = temp;
            }

            return arr;
        }
    }
}
