using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Duplicate_Zeros
    {
        public void DuplicateZeros(int[] arr)
        {
            if (arr == null || arr.Length == 0) return;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) { count++; break; }

            }

            if (count > 0)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {

                        for (int j = arr.Length - 1; j > i; j--)
                        {
                            arr[j] = arr[j - 1];
                        }

                        i++;
                    }
                }

            }
        }
    }
}
