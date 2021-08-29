using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class ValidateBST
    {
		public static bool ValidateBst(BST tree)
		{
			// Write your code here.
			return validate(tree, int.MinValue, int.MaxValue);
			//return false;
		}

		public static bool validate(BST tree, int min, int max)
		{
			if (tree.value < min || tree.value >= max) return false;

			if (tree.left != null && !validate(tree.left, min, tree.value))
				return false;
			if (tree.right != null && !validate(tree.right, tree.value, max))
				return false;
			return true;
		}
	}
}
