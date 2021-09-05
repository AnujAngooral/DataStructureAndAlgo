using System;
using System.Collections.Generic;
using System.Text;

namespace Karat
{
    public class Basic_Calculator
    {
        public static int basicCalculator(string expression)
        {
            if (expression == null || expression.Length == 0)
            {
                return 0;
            }
            int result = 0;
            int sign = 1;
            for (int i = 0; i < expression.Length; i++)
            {
                if (Char.IsNumber(expression[i]))
                {
                    string num = expression[i].ToString();
                    while (i + 1 < expression.Length && Char.IsNumber(expression[i + 1]))
                    {
                        num += expression[++i];
                    }
                    int num1 = int.Parse(num);
                    result += num1 * sign;
                }
                else if (expression[i] == '+')
                {
                    sign = 1;
                }
                else if (expression[i] == '-')
                {
                    sign = -1;
                }
            }
            return result;
        }

        public static int basicCalculatorwithbrackets(string expression)
        {
            Stack<int> stack = new Stack<int>();
            if (expression == null || expression.Length == 0)
            {
                return 0;
            }
            int result = 0;
            int sign = 1;
            for (int i = 0; i < expression.Length; i++)
            {
                if (Char.IsNumber(expression[i]))
                {
                    string num = expression[i].ToString();
                    while (i + 1 < expression.Length && Char.IsNumber(expression[i + 1]))
                    {
                        num += expression[++i];
                    }
                    int num1 = int.Parse(num);
                    result += num1 * sign;
                }
                else if (expression[i] == '+')
                {
                    sign = 1;
                }
                else if (expression[i] == '-')
                {
                    sign = -1;
                }
                else if (expression[i] == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);
                    result = 0;
                    sign = 1;
                }
                else if (expression[i] == ')')
                {
                    result = result * stack.Pop() + stack.Pop();
                }
            }
            return result;
        }
    }
}
