using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Remove_Duplicates_from_Sorted_Array
    {
        //Input: nums = [0,0,1,1,1,2,2,3,3,4]
        //Output: 5, nums = [0,1,2,3,4, _, _, _, _, _]
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;
            int originalPointer = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[originalPointer] = nums[i];
                    originalPointer++;
                }
            }
            return originalPointer;
        }
    }
}
