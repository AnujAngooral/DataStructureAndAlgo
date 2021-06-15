using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Binary_Tree_Level_Order_Traversal
    {
        List<IList<int>> answer = new List<IList<int>>();
        Queue<TreeNode> que = new Queue<TreeNode>();
        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            helper(root, 0);
            return answer;
        }

        void helper(TreeNode root, int level)
        {
            que.Enqueue(root);

            while (que.Count > 0)
            {
                List<int> subList = new List<int>();
                for (int i = 0; i < level + 1; i++)
                {
                    var currentNode = que.Dequeue();
                    subList.Add(currentNode.val);

                    if (currentNode.left != null)
                        que.Enqueue(currentNode.left);

                    if (currentNode.right != null)
                        que.Enqueue(currentNode.right);
                }
                level++;
            }
        }
    }
}
