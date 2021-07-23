using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft
{
  public static class Reverse_Words_in_a_String_II
    {
        public static void ReverseWords(char[] s)
        {
            s.reverse(0, s.Length - 1);
            int i = 0;
            while (i < s.Length) {
                int left = i;
                while (i<s.Length && s[i] != ' ') i++;

                s.reverse(left, i-1);
                i++;
            }
        }

        static void reverse(this char[] s, int left,int right)
        {

            while (left<right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }

        }
    }
}
