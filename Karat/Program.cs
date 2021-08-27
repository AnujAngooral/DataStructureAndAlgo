using System;

namespace Karat
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] user1 = { "/nine.html", "/four.html", "/six.html", "/seven.html", "/one.html" };
            String[] user2 = { "/nine.html", "/two.html", "/three.html", "/four.html", "/six.html", "/seven.html" };
            var result=LongestCommonSubsequence.FindLongestCommonSubsequence(user1, user2);
            Console.WriteLine("Hello World!");
        }
    }
}
