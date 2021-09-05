using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Invert_Binary_Tree
    {
		// O(n) time | O(d) space
		public static void InvertBinaryTree(BinaryTree tree)
		{
			// Write your code here.
			helper(tree);
		}

		public static void helper(BinaryTree currentNode)
		{

			BinaryTree temp = currentNode.left;
			currentNode.left = currentNode.right;
			currentNode.right = temp;

			if (currentNode.left != null)
				helper(currentNode.left);
			if (currentNode.right != null)
				helper(currentNode.right);

		}

	}
}
