using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    class Binary_Tree_Postorder_Traversal
    {
        IList<int> lst = new List<int>();
        public IList<int> PostorderTraversal(TreeNode root)
        {

            if (root != null)
                helper(root);
            return lst;
        }

        private void helper(TreeNode root)
        {

            if (root.left != null)
                helper(root.left);
            if (root.right != null)
                helper(root.right);

            lst.Add(root.val);

        }
    }
}
