using System;
using System.Collections.Generic;
using System.Text;

namespace Karat
{
   public class Decode_Ways
    {
        public static int numDecodings(String s)
        {
            if (s[0] == '0')
            {
                return 0;
            }

            int n = s.Length;
            int twoBack = 1;
            int oneBack = 1;
            for (int i = 1; i < n; i++)
            {
                int current = 0;
                if (s[i] != '0')
                {
                    current = oneBack;
                }
                int twoDigit = Int32.Parse(s.Substring(i - 1, 2));
                if (twoDigit >= 10 && twoDigit <= 26)
                {
                    current += twoBack;
                }

                twoBack = oneBack;
                oneBack = current;
            }
            return oneBack;
        }
    }
}
