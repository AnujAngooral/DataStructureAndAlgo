using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Top_Interview_Questions
{
   public class StringProblems
    {
        public static int LengthOfLongestSubstring(string s)
        {

            int max = 0, left = 0, right = 0;

            Hashtable table = new Hashtable();
            while (right < s.Length)
            {
                var currentCharacter = s[right];
                Console.WriteLine(currentCharacter);
                if (!table.Contains(currentCharacter))
                {
                    table.Add(currentCharacter, currentCharacter);
                    max = Math.Max(max, right - left + 1);
                    right++;
                }

                else
                {


                    while (table[s[left]].ToString() != currentCharacter.ToString())
                    {
                        table.Remove(s[left]);
                        left++;
                    }

                    table.Remove(currentCharacter);
                    left++;

                }
            }

            return max;
        }
    }
}
