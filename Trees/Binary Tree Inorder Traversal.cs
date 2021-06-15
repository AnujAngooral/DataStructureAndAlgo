using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Binary_Tree_Inorder_Traversal
    {
        IList<int> lst = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {

            if (root != null)
                helper(root);

            return lst;
        }

        private void helper(TreeNode root)
        {
            if (root.left != null)
                helper(root.left);

            lst.Add(root.val);
            if (root.right != null)
                helper(root.right);

        }
    }
}
