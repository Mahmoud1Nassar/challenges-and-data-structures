using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void PreOrder(Node node, List<int> result)
        {
            if (node == null) return;
            result.Add(node.Data);
            PreOrder(node.Left, result);
            PreOrder(node.Right, result);
        }

        public void InOrder(Node node, List<int> result)
        {
            if (node == null) return;
            InOrder(node.Left, result);
            result.Add(node.Data);
            InOrder(node.Right, result);
        }

        public void PostOrder(Node node, List<int> result)
        {
            if (node == null) return;
            PostOrder(node.Left, result);
            PostOrder(node.Right, result);
            result.Add(node.Data);
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
