using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BST_Traverse
    {
		public static List<int> InOrderTraverse(BST tree, List<int> array)
		{
			// Write your code here.
			return helperInOrderTranverse(tree, array);
		}

		public static List<int> helperInOrderTranverse(BST tree, List<int> array)
		{

			if (tree.left != null)
				helperInOrderTranverse(tree.left, array);
			array.Add(tree.value);
			if (tree.right != null)
				helperInOrderTranverse(tree.right, array);
			return array;
		}

		public static List<int> PreOrderTraverse(BST tree, List<int> array)
		{
			// Write your code here.
			if (tree != null)
			{
				array.Add(tree.value);

				if (tree.left != null)
					PreOrderTraverse(tree.left, array);

				if (tree.right != null)
					PreOrderTraverse(tree.right, array);
			}
			return array;

		}

		public static List<int> PostOrderTraverse(BST tree, List<int> array)
		{
			// Write your code here.

			if (tree.left != null)
				PostOrderTraverse(tree.left, array);

			if (tree.right != null)
				PostOrderTraverse(tree.right, array);

			array.Add(tree.value);

			return array;
		}
	}
}
