using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Find_Numbers_with_Even_Number_of_Digits
    {
        public int FindNumbers(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (NumberOfDigits(nums[i]) % 2 == 0)
                    result++;
            }

            return result;
        }

        int NumberOfDigits(int number)
        {
            int digits = 0;
            while (number != 0)
            {
                number /= 10;
                digits++;
            }

            return digits;
        }
    }


}
