using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }

        public BST Insert(int value)
        {
            BST currentNode = this;
            while (true)
            {

                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = new BST(value);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = new BST(value);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }

            }

            return this;
        }

        public bool Contains(int value)
        {
            // Write your code here.
            BST currentNode = this;
            while (currentNode != null)
            {
                if (currentNode.value == value)
                    return true;
                else if (value < currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode = currentNode.right;
                }

            }

            return false;
        }

        public BST Remove(int value)
        {
            // Write your code here.
            // Do not edit the return statement of this method.
            Remove(value, null);
            return this;
        }

        public void Remove(int value, BST parentNode)
        {
            BST currentNode = this;
            while (currentNode != null)
            {
                if (value < currentNode.value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.left;
                }
                else if (value > currentNode.value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.right;
                }
                else
                {
                    // we have found the element to remove
                    if (currentNode.left != null && currentNode.right != null)
                    {
                        currentNode.value = currentNode.right.getMinValue();
                        currentNode.right.Remove(currentNode.value, currentNode);
                    }
                    else if (parentNode == null)
                    {
                        if (currentNode.left != null)
                        {
                            currentNode.value = currentNode.left.value;
                            currentNode.right = currentNode.left.right;
                            currentNode.left = currentNode.left.left;
                        }
                        else if (currentNode.right != null)
                        {
                            currentNode.value = currentNode.right.value;
                            currentNode.left = currentNode.right.left;
                            currentNode.right = currentNode.right.right;
                        }
                        else
                        {
                            // this is a single node tree
                        }
                    }
                    else if (parentNode.left == currentNode)
                    {
                        parentNode.left = currentNode.left != null ? currentNode.left :
                                                            currentNode.right;
                    }
                    else if (parentNode.right == currentNode)
                    {
                        parentNode.right = currentNode.left != null ? currentNode.left :
                        currentNode.right;
                    }
                    break;

                }
            }

        }

        public int getMinValue()
        {
            if (left == null)
                return value;
            else
                return left.getMinValue();
        }
    }
}
