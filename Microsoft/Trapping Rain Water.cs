using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft
{
    public class Trapping_Rain_Water
    {
        public static int Trap(int[] height)
        {
            int n = height.Length;
            int[] left = new int[n];
            int[] right = new int[n];
            left[0] = height[0];
            right[n - 1] = height[n - 1];

            for (int i = 1; i < height.Length; i++)
            {
                left[i] = Math.Max(height[i], left[i - 1]);
            }
            for (int i = n - 2; i >= 0; i--)
            {
                right[i] = Math.Max(height[i], right[i + 1]);
            }

            int ans = 0;

            for (int i = 0; i < height.Length; i++)
            {
                ans += Math.Min(left[i], right[i]) - height[i];
            }
            return ans;
        }
    }
}
