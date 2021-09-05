using System;
using System.Collections.Generic;

namespace Karat
{
    class Program
    {
        static void Main(string[] args)
        {

            Decode_Ways.numDecodings("226");

            List<int[]> intJaggedList = new List<int[]>();
            intJaggedList.Add(new int[2] { 1, 0 });
            intJaggedList.Add(new int[2] { 2, 0 });
            intJaggedList.Add(new int[2] { 3, 1 });
            intJaggedList.Add(new int[2] { 3,2 });

            Course_Schedule2.findOrder(4, intJaggedList.ToArray());

            Basic_Calculator.basicCalculator("2+3-999");
            Basic_Calculator.basicCalculatorwithbrackets("2+((8+2)+(3-999))");
            

            Text_Justification.FullyJustify(new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16);

            LongestCommonSubsequence.FindLength_Test(new int[] { 1, 2, 3, 2, 1 }, new int[] { 3, 2, 1, 4, 7 });
            SecurityBadge.find_mismatched();

             var result=LongestCommonSubsequence.FindLongestCommonSubsequence();
            Console.WriteLine("Hello World!");
        }
    }
}
