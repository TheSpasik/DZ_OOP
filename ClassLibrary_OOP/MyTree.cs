using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_OOP
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    public class MyTree
    {
        public TreeNode Root { get; private set; }
        private int count;

        public MyTree()
        {
            Root = null;
            count = 0;
        }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new TreeNode(value);
            }
            else
            {
                AddRecursive(Root, value);
            }
            count++;
        }

        private void AddRecursive(TreeNode current, int value)
        {
            if (value < current.Value)
            {
                if (current.Left == null)
                {
                    current.Left = new TreeNode(value);
                }
                else
                {
                    AddRecursive(current.Left, value);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = new TreeNode(value);
                }
                else
                {
                    AddRecursive(current.Right, value);
                }
            }
        }

        public bool Contains(int value)
        {
            return ContainsRecursive(Root, value);
        }

        private bool ContainsRecursive(TreeNode current, int value)
        {
            if (current == null)
            {
                return false;
            }

            if (value == current.Value)
            {
                return true;
            }

            return value < current.Value
                ? ContainsRecursive(current.Left, value)
                : ContainsRecursive(current.Right, value);
        }

        public void Clear()
        {
            Root = null;
            count = 0;
        }

        public int[] ToArray()
        {
            List<int> result = new List<int>();
            TraverseInOrder(Root, result);
            return result.ToArray();
        }

        private void TraverseInOrder(TreeNode node, List<int> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node.Value);
                TraverseInOrder(node.Right, result);
            }
        }

        public int Count
        {
            get { return count; }
        }
    }
}
