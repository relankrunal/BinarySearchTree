using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public class TreeOperations
    {

        public TreeNode Insert(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
            }
            else if (value < node.val)
            {
                node.left = Insert(node.left, value);
            }
            else
            {
                node.right = Insert(node.right, value);
            }

            return node;
        }

        /// <summary>
        ///     Pre order is Root node, left child , right child
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.val + " ");

                PreOrder(node.left);
                PreOrder(node.right);
            }

        }

        /// <summary>
        ///     In order is left child , Root node, right child
        /// </summary>
        /// <param name="node"></param>
        public void InOrder(TreeNode node)
        {
            if (node != null)
            {
                InOrder(node.left);
                Console.Write(node.val + " ");
                InOrder(node.right);
            }
        }

        /// <summary>
        ///     In order is left child , right child, Root node
        /// </summary>
        /// <param name="node"></param>
        public void PostOrder(TreeNode node)
        {
            if (node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                Console.Write(node.val + " ");
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode()
        {

        }
        public TreeNode(int x)
        {
            val = x;
        }
    }
}
