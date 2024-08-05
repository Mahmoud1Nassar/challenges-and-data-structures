using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.StackandQueue
{
    public class StackAndQueue
    {
        public LinkedList<int> stackItems = new LinkedList<int>();
        public LinkedList<int> queueItems = new LinkedList<int>();

        // Stack Methods
        public void StackPush(int data)
        {
            stackItems.AddFirst(data);
        }

        public int StackPop()
        {
            if (StackIsEmpty())
                throw new InvalidOperationException("Stack is empty");

            int value = stackItems.First.Value;
            stackItems.RemoveFirst();
            return value;
        }

        public int StackPeek()
        {
            if (StackIsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return stackItems.First.Value;
        }

        public bool StackIsEmpty()
        {
            return stackItems.Count == 0;
        }

        // Queue Methods
        public void QueueEnqueue(int data)
        {
            queueItems.AddLast(data);
        }

        public int QueueDequeue()
        {
            if (QueueIsEmpty())
                throw new InvalidOperationException("Queue is empty");

            int value = queueItems.First.Value;
            queueItems.RemoveFirst();
            return value;
        }

        public int QueuePeek()
        {
            if (QueueIsEmpty())
                throw new InvalidOperationException("Queue is empty");

            return queueItems.First.Value;
        }

        public bool QueueIsEmpty()
        {
            return queueItems.Count == 0;
        }

        // Method to reverse stack using queue
        public void ReverseStack()
        {
            while (!StackIsEmpty())
            {
                QueueEnqueue(StackPop());
            }

            while (!QueueIsEmpty())
            {
                StackPush(QueueDequeue());
            }
        }

        // Method to delete the middle element of the stack
        public void DeleteMiddle()
        {
            if (StackIsEmpty())
                throw new InvalidOperationException("Stack is empty");

            int count = stackItems.Count;
            int middleIndex = count / 2;

            // If the count is even, we need to remove the lower middle element
            if (count % 2 == 0)
            {
                middleIndex--;
            }

            Stack<int> tempStack = new Stack<int>();

            // Push elements from the original stack to the temp stack until the middle is reached
            for (int i = 0; i <= middleIndex; i++)
            {
                tempStack.Push(StackPop());
            }

            // Remove the middle element
            tempStack.Pop();

            // Push the elements back from the temp stack to the original stack
            while (tempStack.Count > 0)
            {
                StackPush(tempStack.Pop());
            }
        }

    }
}
