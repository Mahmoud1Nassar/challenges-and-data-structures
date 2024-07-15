﻿using System;
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
    }

}

