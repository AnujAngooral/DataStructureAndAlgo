using System;
using System.Collections.Generic;
using System.Text;

namespace Karat
{
    public class LongestCommonSubsequence
    {
        public static char[] FindLongestCommonSubsequence(string str1, string str2)
        {
            string[,] lengths = new string[str2.Length + 1, str1.Length + 1];
            int rows = str2.Length + 1;
            int cols = str1.Length + 1;

            for (int i = 0; i < rows; i++)
            {
                lengths[i, 0] = "";
            }
            for (int i = 0; i < cols; i++)
            {
                lengths[0,i] = "";
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (str2[i - 1] == str1[j - 1])
                        lengths[i, j] = lengths[i - 1, j - 1] + str2[i-1];
                    else
                    {
                        lengths[i, j] = lengths[i - 1, j].Length > lengths[i, j - 1].Length ?
                            lengths[i - 1, j] : lengths[i, j - 1];
                    }
                }
            }


            return lengths[rows-1,cols-1].ToCharArray();
        }

      
        static  String[] user1 = { "/nine.html", "/four.html", "/six.html", "/seven.html", "/one.html" };
        static String[] user2 = { "/nine.html", "/two.html", "/three.html", "/four.html", "/six.html", "/seven.html" };
        public static string[] FindLongestCommonSubsequence()
        {
            // output =-> "/four.html", "/six.html", "/seven.html"
            string[] str1 = user1;
            string[] str2 = user2;
            string[,] lengths = new string[str2.Length + 1, str1.Length + 1];
            int rows = str2.Length + 1;
            int cols = str1.Length + 1;

            for (int i = 0; i < rows; i++)
            {
                lengths[i, 0] = "";
            }
            for (int i = 0; i < cols; i++)
            {
                lengths[0, i] = "";
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (str2[i - 1] == str1[j - 1])
                        lengths[i, j] = lengths[i - 1, j - 1] + str2[i - 1];
                    else
                    {
                        lengths[i, j] = "";
                    }
                }
            }


            return null ;
        }


        public static int FindLength(int[] nums1, int[] nums2)
        {

            int[,] dp = new int[nums2.Length + 1, nums2.Length + 1];
            int rows = nums2.Length + 1;
            int col = nums1.Length + 1;
            int max = 0;
            for (int i = 1; i < rows; i++)
            {

                for (int j = 1; j < col; j++)
                {

                    if (nums2[i - 1] == nums1[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;

                    max = Math.Max(max, dp[i, j]);
                }
            }

            Console.WriteLine("dp is: " + dp[rows - 1, col - 1]);
            return max;

        }

        public static int FindLength_Test(int[] nums1, int[] nums2)
        {

            string[,] dp = new string[nums2.Length + 1, nums2.Length + 1];
            int rows = nums2.Length + 1;
            int col = nums1.Length + 1;
            int max = 0; 
            for (int i = 0; i < rows; i++)
            {
                dp[i, 0] = "";
            }
            for (int i = 0; i < col; i++)
            {
                dp[0, i] = "";
            }
            for (int i = 1; i < rows; i++)
            {

                for (int j = 1; j < col; j++)
                {

                    if (nums2[i - 1] == nums1[j - 1])
                        dp[i, j] = dp[i - 1, j - 1].ToString() + "," + nums1[j - 1].ToString();
                    else
                        dp[i, j] = dp[i - 1, j].Length > dp[i, j - 1].Length ? dp[i - 1, j] : dp[i, j - 1];


                }
            }

            Console.WriteLine("dp is: " + dp[rows - 1, col - 1]);
            return max;

        }
    }
}
