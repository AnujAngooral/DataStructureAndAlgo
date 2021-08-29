using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class FindClosestValue
    {
		public static int FindClosestValueInBst(BST tree, int target)
		{
			// Write your code here.
			return helper(tree, target, tree.value);
		}

		private static int helper(BST tree, int target, int closest)
		{
			if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
			{
				closest = tree.value;
			}
			if (target < tree.value && tree.left != null)
			{
				return helper(tree.left, target, closest);
			}
			else if (target > tree.value && tree.right != null)
			{
				return helper(tree.right, target, closest);
			}
			else
			{

				return closest;
			}
		}
	}
}
