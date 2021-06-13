using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Top_Interview_Questions
{
    class MultipleProblems
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;
            int originalPointer = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[originalPointer] = nums[i];
                    originalPointer++;

                }
            }
            return originalPointer;
        }

        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            if (prices == null || prices.Length == 0) return maxProfit;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i])
                    maxProfit += prices[i + 1] - prices[i];
            }
            return maxProfit;
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> result = new List<int>();
            int x = 0;
            int y = 0;

            int i = 0;
            while (x < nums1.Length && y < nums2.Length)
            {
                if (nums1[x] == nums2[y])
                {
                    result.Add(nums1[x]);
                    x++;
                    y++;
                }
                else if (nums1[x] < nums2[y])
                {
                    x++;
                }
                else
                {
                    y++;
                }
            }
            return result.ToArray();

        }

        public static int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;

            while (i >= 0)
            {

                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
                i--;
            }

            if (digits[0] == 0)
            {
                int[] result = new int[digits.Length];
                result[0] = 1;
                return result;
            }
            return digits;

        }

        public static void MoveZeroes(int[] nums)
        {
            int writePointer = 1;
            int i = 1;
            while (i < nums.Length)
            {
                if (nums[i] != 0)
                {
                    nums[writePointer] = nums[i];
                    writePointer++;
                }
                i++;
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            // [2,7,11,15], target = 9

            Dictionary<int, int> collection = new Dictionary<int, int>();
            List<int> result = new List<int>();
            int i = 0;
            while (i < nums.Length)
            {
                if (!collection.ContainsKey(nums[i]))
                {
                    collection.Add(target - nums[i], i);
                }
                else
                {
                    result.Add(collection[nums[i]]);
                    result.Add(i);
                    break;
                }
                i++;
            }
            return result.ToArray();
        }


        public static void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {

                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }

        }
        public static int Reverse(int x)
        {
            bool isNagative = false;
            if (x < 0)
            {
                isNagative = true;
                x = x * -1;
            }

            long number = 0;
            int num = x;
            while (num > 0)
            {
                int lastDigit = num % 10;
                number = number * 10 + lastDigit;
                num = num / 10;
            }

            if (isNagative)
                number = number * -1;

            return (int)number;

        }

        public int FirstUniqChar(string s)
        {
            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < s.Length; i++)
            {
                if (hashtable.ContainsKey(s[i]))
                {
                    hashtable[s[i]] = 2;
                }
                else
                {
                    hashtable[s[i]] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if ((int)hashtable[s[i]] == 0)
                    return i;
            }

            return -1;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            string first = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                string second = strs[i];

                while (!second.StartsWith(first))
                {
                    first = first.Substring(0, first.Length - 1);
                }
            }

            return first;
        }
    }
}
