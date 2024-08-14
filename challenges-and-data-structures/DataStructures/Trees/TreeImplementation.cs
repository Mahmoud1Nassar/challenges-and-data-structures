using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Trees
{
    public class TreeImplementation : BinaryTree
    {
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Node current = Root;
            Node parent = null;

            while (true)
            {
                parent = current;
                if (data < current.Data)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        return;
                    }
                }
            }
        }

        public bool Contains(int data)
        {
            Node current = Root;
            while (current != null)
            {
                if (data == current.Data)
                {
                    return true;
                }
                else if (data < current.Data)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }

        public void Remove(int data)
        {
            Root = RemoveRecursively(Root, data);
        }

        private Node RemoveRecursively(Node root, int key)
        {
            if (root == null) return root;

            if (key < root.Data)
            {
                root.Left = RemoveRecursively(root.Left, key);
            }
            else if (key > root.Data)
            {
                root.Right = RemoveRecursively(root.Right, key);
            }
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Data = MinValue(root.Right);
                root.Right = RemoveRecursively(root.Right, root.Data);
            }
            return root;
        }

        private int MinValue(Node node)
        {
            int minValue = node.Data;
            while (node.Left != null)
            {
                minValue = node.Left.Data;
                node = node.Left;
            }
            return minValue;
        }
    }
}
