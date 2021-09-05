using System;
using System.Collections.Generic;
using System.Text;

namespace Karat
{
   public class Text_Justification
    {
        public static List<string> FullyJustify(string[] words, int maxWidth)
        {
            List<string> result = new List<string>();

            int i = 0;
            int n = words.Length;

            while (i < n)
            {
                int j = i + 1;
                int lineLength = words[i].Length;

                while (j<n && (lineLength+ words[j].Length + ( j - i +1) <= maxWidth))
                {
                    lineLength += words[j].Length;
                    j++;
                }

                int diff = maxWidth - lineLength;
                int numberOfWords = j - i;

                if (j > n || numberOfWords == 1)
                    result.Add(JustifyLeft(words, diff, i, j));
                else
                    result.Add(JustifyMiddle(words, diff, i, j));
                i = j;
            }
            return result;
        }

       static string JustifyLeft(string[] words, int diff, int i, int j)
        {
            int spacesOnRight = diff - (j - i - 1);
            StringBuilder result = new StringBuilder(words[i]);
            for (int k = i+1; k < j; k++)
            {
                result.Append(" " + words[k]);
            }
            for (int m = 0; m < spacesOnRight; m++)
            {
                result.Append(" ");
            }
            return result.ToString();
        }
       static string JustifyMiddle(string[] words, int diff, int i, int j)
        {
            int spaceNeeded = j - i - 1;
            int spaces = diff / spaceNeeded;
            int extraSpaces = diff % spaceNeeded;
            StringBuilder result = new StringBuilder(words[i]);
            for (int k = i + 1; k < j; k++)
            {
                int spaceToApply = spaces + (extraSpaces-- > 0 ? 1 : 0);
                for (int g = 0; g < spaceToApply; g++)
                {
                    result.Append(" ");
                }
                result.Append( words[k]);
            }

            return result.ToString();
        }
    }
}
