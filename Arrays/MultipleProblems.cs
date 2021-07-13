using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class MultipleProblems
    {
        //Merge Sorted Array
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums1 == null || nums1.Length == 0) return;
            if (nums2 == null || nums2.Length == 0) return;

            Queue<int> result = new Queue<int>();
            int left = 0;
            int right = 0;
            while (left < m && right < n) {

                if (nums1[left] < nums2[right])
                {
                    result.Enqueue(nums1[left]);
                    left++;
                }
                else
                {
                    result.Enqueue(nums2[right]);
                    right++;
                }
            }

            while (left < m)
            {
                result.Enqueue(nums1[left]);
                left++;
            }

            while (right < n)
            {
                result.Enqueue(nums2[right]);
                right++;
            }

            int counter = 0;
            while (counter<nums1.Length)
            {
                nums1[counter++] = result.Dequeue();
            }
        }
    }
}
