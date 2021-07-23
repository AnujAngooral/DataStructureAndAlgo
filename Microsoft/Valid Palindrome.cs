using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft
{
    public class Valid_Palindrome
    {
        public  static bool IsPalindrome(string s)
        {
            int left = 0; int right = s.Length - 1;

            while (left < right)
            {
                var leftCharacter = s[left];
                var rightCharacter = s[right];
                if (isAlphanumeric(s[left]) && isAlphanumeric(s[right]))
                {
                    if (string.Compare(s[left].ToString(), s[right].ToString(), true) != 0)
                        return false;
                    left++; right--;
                }
                else if (!isAlphanumeric(s[left]))
                    left++;
                else if (!isAlphanumeric(s[right]))
                    right--;
            }

            return true;
        }
        private static bool isAlphanumeric(char c)
        {

            return char.IsLetter(c) || char.IsDigit(c);
        }
    }
}
