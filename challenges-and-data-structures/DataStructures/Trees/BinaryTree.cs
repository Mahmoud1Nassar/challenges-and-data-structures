﻿using System;
using System.Collections.Generic;

namespace challenges_and_data_structures.DataStructures.Trees
{
    public class BinaryTree
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void InOrder(Node node, List<int> result)
        {
            if (node == null) return;
            InOrder(node.Left, result);
            result.Add(node.Data);
            InOrder(node.Right, result);
        }

        public List<int> InorderTraversal()
        {
            List<int> result = new List<int>();
            InOrder(Root, result);
            return result;
        }

        public void Print(Node node, int space = 0, int indent = 5)
        {
            if (node == null) return;

            space += indent;

            Print(node.Right, space);

            Console.WriteLine();
            for (int i = indent; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(node.Data);

            Print(node.Left, space);
        }
    }
}
