﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft
{
    public class Longest_Palindromic_Substring
    {
        public static string LongestPalindrome(string s)
        {
            if (s == null || s.Length < 1) return "";
            string ret = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                string len1 = getalindromeString(s, i, i);
                if (len1.Length > ret.Length)
                {
                    ret = len1;
                }

                string len2 = getalindromeString(s, i, i + 1);
                if (len2.Length > ret.Length)
                {
                    ret = len2;
                }

            }

            return ret;
        }

        private static string getalindromeString(string s, int left, int right)
        {

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return s.Substring(left + 1, right - left - 1);

        }
    }
}
