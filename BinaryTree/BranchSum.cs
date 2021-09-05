using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class BranchSum
    {
		public static List<int> BranchSums(BinaryTree root)
		{
			// Write your code here.
			return helper(root, 0, new List<int>());
		}

		public static List<int> helper(BinaryTree currentNode, int sumsequence,
													List<int> collection)
		{
			int runningSum = sumsequence + currentNode.value;
			if (currentNode.left != null)
			{
				helper(currentNode.left, runningSum, collection);
			}

			if (currentNode.right != null)
			{
				helper(currentNode.right, runningSum, collection);
			}
			if (currentNode.left == null && currentNode.right == null)
				collection.Add(sumsequence + currentNode.value);
			return collection;
		}
	}
}
