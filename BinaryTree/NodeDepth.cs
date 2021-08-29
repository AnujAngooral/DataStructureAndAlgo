using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class NodeDepth
    {public static int NodeDepths(BinaryTree root) {
		// Write your code here.
		List<int> array = new List<int>();
		 helper(root,0,array);
		int sum=0;
			foreach(var item in array)
					sum+=item;
		return sum;
	}
	
	public static List<int> helper(BinaryTree currentNode,int sum,List<int> array){
		
				if(currentNode.left != null)
					helper(currentNode.left,sum+1,array);
				if(currentNode.right != null)
						helper(currentNode.right,sum+1, array);
				
			//	if(currentNode.left == null && currentNode.right == null)
						array.Add(sum);
		return array;
	}
    }
}
