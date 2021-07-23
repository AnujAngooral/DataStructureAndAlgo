using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft
{
    public class Two_Sum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> collection = new Dictionary<int, int>();
            int[] output = new int[2];
            int i = 0;
            while (i < nums.Length)
            {
                if (!collection.ContainsKey(nums[i]))
                {

                    collection.Add((target-nums[i]), i);
                }

                else
                {
                    output[0] = i;
                    output[1] = collection[nums[i]];
                    break;
                }
                i++;
            }

            return output;
        }


//        Dictionary<int, int> collection = new Dictionary<int, int>();
//        List<int> result = new List<int>();
//        int i = 0;
//            while (i<nums.Length)
//            {
//                if (!collection.ContainsKey(nums[i]))
//                {
//                    collection.Add(target - nums[i],i);
//                }
//                else
//                {
//                    result.Add(collection[nums[i]]);
//                    result.Add(i);
//                    break;
//                }
//i++;
//            }
//            return result.ToArray();
    }
}
