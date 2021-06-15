using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Binary_Tree_Preorder_Traversal
    {
        IList<int> lst = new List<int>();
        public IList<int> PreorderTraversal(TreeNode root)
        {

            if (root != null)
                helper(root);

            return lst;
        }

        private void helper(TreeNode root)
        {

            lst.Add(root.val);

            if (root.left != null)
                helper(root.left);
            if (root.right != null)
                helper(root.right);

        }
    }
}
