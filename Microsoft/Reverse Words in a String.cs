using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft
{
    public class Reverse_Words_in_a_String
    {
        // refactoring needed.
        public static string ReverseWords(string s)
        {
            //Input: s = "the sky is blue"
            //Output: "blue is sky the"

            int i = 0; int j = 0;
            int n = s.Length;
            StringBuilder result = new StringBuilder();
            i = n - 1;
            bool addSpace = false;
            while (i >= 0)
            {
                while (i >= 0 && s[i] == ' ') i--;
                if (i < 0) break;
                if (addSpace)
                {
                    result.Append(" ");
                }
                j = i - 1;
                while (j >= 0 && s[j] != ' ') j--;

                result.Append(s.Substring(j + 1, i - j));
                i = j - 1;
                addSpace = true;
            }
            return result.ToString();
        }
    }
}
