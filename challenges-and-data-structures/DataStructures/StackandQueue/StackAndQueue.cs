using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.StackandQueue
{
    public class StackAndQueue
    {
        private LinkedList<int> stackItems = new LinkedList<int>();
        private LinkedList<int> queueItems = new LinkedList<int>();

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
    }
}
