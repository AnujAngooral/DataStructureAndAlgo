using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft
{
    public class Reverse_String
    {
        public void ReverseString(char[] s)
        {
            //Input: s = ["h", "e", "l", "l", "o"]
            //Output:["o","l","l","e","h"]

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;right--;
            }

        }
    }
}
