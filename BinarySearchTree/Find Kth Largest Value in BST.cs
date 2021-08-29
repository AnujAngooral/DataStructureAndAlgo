using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Find_Kth_Largest_Value_in_BST
    {
		int kthElement = 0; int kthValue = -1;
		public int FindKthLargestValueInBst(BST tree, int k)
		{
			// Write your code here.
			kthElement = k;

			return helper(tree);
		}

		public int helper(BST currentNode)
		{

			//Console.WriteLine("currentNode.value "+ currentNode.value);
			//Console.WriteLine("kthElement "+ kthElement);
			if (currentNode.right != null)
				helper(currentNode.right);

			kthElement--;
			if (kthElement == 0)
				kthValue = currentNode.value;

			if (currentNode.left != null)
				helper(currentNode.left);
			return kthValue;
		}
	}
}
