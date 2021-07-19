using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1 && nums[0] == val) return 0;

            int i = 0;
            int j = nums.Length - 1;
            // int newLength=1;
            while (i <= j)
            {

                if (nums[i] == val && nums[j] != val)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                    j--;
                }
                else if (nums[i] != val)
                {
                    i++;
                }
                else if (nums[j] == val)
                {
                    j--;
                }

            }
            //Console.WriteLine(i);
            foreach (var jj in nums)
            {
                Console.WriteLine(jj);
            }
            return i;
        }
    }
}
