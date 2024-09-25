using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.LinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList() {
            Head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool Includes(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Remove(int data)
        {
            if (Head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                throw new ArgumentException("The specified value is not in the list.");
            }

            current.Next = current.Next.Next;
        }

        public void PrintList()
        {
            Node current = Head;
            StringBuilder result = new StringBuilder("Head");
            while (current != null)
            {
                result.Append(" -> " + current.Data);
                current = current.Next;
            }
            result.Append(" -> Null");
            Console.WriteLine(result.ToString());
        }
        public void RemoveDuplicate()
        {
            Node current = Head;

            while (current != null && current.Next != null)
            {
                Node index = current;
                while (index.Next != null)
                {
                    if (current.Data == index.Next.Data)
                    {
                        index.Next = index.Next.Next;
                    }
                    else
                    {
                        index = index.Next;
                    }
                }
                current = current.Next;
            }
        }

        public static LinkedList MergeSortedLists(LinkedList list1 , LinkedList list2 ) { 
            LinkedList result = new LinkedList();
            Node current1 = list1.Head;
            Node current2 = list2.Head;

            while (current1 != null && current2 != null) {
                if (current1.Data <= current2.Data)
                {
                    result.Add(current1.Data);
                    current1 = current1.Next;
                }
                else { 
                    result.Add(current2.Data);
                    current2 = current2.Next;
                }
            }
            while (current1 != null) {
                result.Add(current1.Data);
                current1 = current1.Next;
            }
            while (current2 != null) {
                result.Add(current2.Data);
                current2 = current2.Next;
            }

            return result;
           
        }
        public void RotateLeft(int k)
        {
          
            if (Head == null || k == 0)
            {
                return; 
            }

            int length = 1;
            Node current = Head;
            while (current.Next != null)
            {
                length++;
                current = current.Next;
            }

            k = k % length;
            if (k == 0)
            {
                return; 
            }

            current.Next = Head;

            int newTailPosition = length - k;
            Node newTail = Head;
            for (int i = 1; i < newTailPosition; i++)
            {
                newTail = newTail.Next;
            }

            
            Head = newTail.Next;
            newTail.Next = null;
        }

    }

}

