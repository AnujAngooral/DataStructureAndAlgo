using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft
{
    public class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> collection = new Stack<char>();
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    collection.Push(getReversedCharacter(s[i]));
                }
                else
                {
                    if (collection.Count==0|| s[i] != collection.Pop())
                        return false;
                }
                i++;
            }
            if (collection.Count > 0) return false;
            return true;
        }

        char getReversedCharacter(char curr)
        {

            switch (curr)
            {
                case '{':
                    return '}';
                case '[':
                    return ']';
                case '(':
                    return ')';
                default:
                    return ' ';
            }
        }
    }
}
