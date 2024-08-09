using challenges_and_data_structures.DataStructures.StackandQueue;

using Xunit;

namespace StackAndQueueTests
{
    public class StackAndQueueTests
    {
        // Tests for Stack functionality
        [Fact]
        public void StackPush_AddsNodeToTopOfStack()
        {
            var stackAndQueue = new StackAndQueue();
            stackAndQueue.StackPush(10);
            Assert.Equal(10, stackAndQueue.StackPeek());
        }

        [Fact]
        public void StackPop_RemovesAndReturnsTopNodeFromStack()
        {
            var stackAndQueue = new StackAndQueue();
            stackAndQueue.StackPush(10);
            stackAndQueue.StackPush(20);
            Assert.Equal(20, stackAndQueue.StackPop());
            Assert.Equal(10, stackAndQueue.StackPeek());
        }

        [Fact]
        public void StackIsEmpty_ReturnsTrueWhenStackIsEmpty()
        {
            var stackAndQueue = new StackAndQueue();
            Assert.True(stackAndQueue.StackIsEmpty());
            stackAndQueue.StackPush(10);
            stackAndQueue.StackPop();
            Assert.True(stackAndQueue.StackIsEmpty());
        }

        // Tests for Queue functionality
        [Fact]
        public void QueueEnqueue_AddsNodeToEndOfQueue()
        {
            var stackAndQueue = new StackAndQueue();
            stackAndQueue.QueueEnqueue(10);
            Assert.Equal(10, stackAndQueue.QueuePeek());
        }

        [Fact]
        public void QueueDequeue_RemovesAndReturnsFrontNodeFromQueue()
        {
            var stackAndQueue = new StackAndQueue();
            stackAndQueue.QueueEnqueue(10);
            stackAndQueue.QueueEnqueue(20);
            Assert.Equal(10, stackAndQueue.QueueDequeue());
            Assert.Equal(20, stackAndQueue.QueuePeek());
        }

        [Fact]
        public void QueueIsEmpty_ReturnsTrueWhenQueueIsEmpty()
        {
            var stackAndQueue = new StackAndQueue();
            Assert.True(stackAndQueue.QueueIsEmpty());
            stackAndQueue.QueueEnqueue(10);
            stackAndQueue.QueueDequeue();
            Assert.True(stackAndQueue.QueueIsEmpty());
        }

        // Tests for ReverseStack functionality
        [Fact]
        public void ReverseStack_ReversesStackWithMultipleElements()
        {
            var stackAndQueue = new StackAndQueue();
            stackAndQueue.StackPush(1);
            stackAndQueue.StackPush(2);
            stackAndQueue.StackPush(3);
            stackAndQueue.StackPush(4);
            stackAndQueue.StackPush(5);

            stackAndQueue.ReverseStack();

            Assert.Equal(1, stackAndQueue.StackPop());
            Assert.Equal(2, stackAndQueue.StackPop());
            Assert.Equal(3, stackAndQueue.StackPop());
            Assert.Equal(4, stackAndQueue.StackPop());
            Assert.Equal(5, stackAndQueue.StackPop());
        }

        [Fact]
        public void ReverseStack_ReversesStackWithOneElement()
        {
            var stackAndQueue = new StackAndQueue();
            stackAndQueue.StackPush(1);

            stackAndQueue.ReverseStack();

            Assert.Equal(1, stackAndQueue.StackPop());
        }

        [Fact]
        public void ReverseStack_DoesNothingForEmptyStack()
        {
            var stackAndQueue = new StackAndQueue();

            stackAndQueue.ReverseStack();

            Assert.True(stackAndQueue.StackIsEmpty());
        }

        // Tests for DeleteMiddle functionality
        [Fact]
        public void DeleteMiddle_RemovesMiddleElementOfOddSizedStack()
        {
            var stackAndQueue = new StackAndQueue();
            stackAndQueue.StackPush(7);
            stackAndQueue.StackPush(14);
            stackAndQueue.StackPush(3);
            stackAndQueue.StackPush(8);
            stackAndQueue.StackPush(5);

            stackAndQueue.DeleteMiddle();

            Assert.Equal(4, stackAndQueue.stackItems.Count);
            Assert.Equal(5, stackAndQueue.StackPop());
            Assert.Equal(8, stackAndQueue.StackPop());
            Assert.Equal(14, stackAndQueue.StackPop());
            Assert.Equal(7, stackAndQueue.StackPop());
        }

        [Fact]
        public void DeleteMiddle_RemovesLowerMiddleElementOfEvenSizedStack()
        {
            var stackAndQueue = new StackAndQueue();
            stackAndQueue.StackPush(7);
            stackAndQueue.StackPush(14);
            stackAndQueue.StackPush(3);
            stackAndQueue.StackPush(8);

            stackAndQueue.DeleteMiddle();

            Assert.Equal(3, stackAndQueue.stackItems.Count); // Verify count after removal
            Assert.Equal(8, stackAndQueue.StackPop());
            Assert.Equal(14, stackAndQueue.StackPop());
            Assert.Equal(7, stackAndQueue.StackPop());
        }



        [Fact]
        public void DeleteMiddle_ThrowsExceptionWhenStackIsEmpty()
        {
            var stackAndQueue = new StackAndQueue();

            Assert.Throws<InvalidOperationException>(() => stackAndQueue.DeleteMiddle());
        }

        [Fact]
        public void DeleteMiddle_RemovesOnlyElementWhenStackHasOneElement()
        {
            var stackAndQueue = new StackAndQueue();
            stackAndQueue.StackPush(10);

            stackAndQueue.DeleteMiddle();

            Assert.True(stackAndQueue.StackIsEmpty());
        }


        [Fact]
        public void TestGetMin()
        {
            var minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);
            Assert.Equal(3, minStack.GetMin());

            minStack.Pop();
            Assert.Equal(7, minStack.GetMin());
        }

        [Fact]
        public void TestPopAndMin()
        {
            var minStack = new MinStack();
            minStack.Push(10);
            minStack.Push(20);
            minStack.Push(5);
            minStack.Push(15);

            minStack.Pop();
            Assert.Equal(5, minStack.GetMin());

            minStack.Pop();
            Assert.Equal(10, minStack.GetMin());

            minStack.Pop();
            Assert.Equal(10, minStack.GetMin());
        }

        [Fact]
        public void TestPushAndMin()
        {
            var minStack = new MinStack();
            minStack.Push(10);
            Assert.Equal(10, minStack.GetMin());

            minStack.Push(20);
            Assert.Equal(10, minStack.GetMin());

            minStack.Push(5);
            Assert.Equal(5, minStack.GetMin());
        }

        [Fact]
        public void TestIsEmpty()
        {
            var minStack = new MinStack();
            Assert.True(minStack.IsEmpty());

            minStack.Push(10);
            Assert.False(minStack.IsEmpty());

            minStack.Pop();
            Assert.True(minStack.IsEmpty());
        }

        [Fact]
        public void TestTop()
        {
            var minStack = new MinStack();
            minStack.Push(10);
            minStack.Push(20);
            Assert.Equal(20, minStack.Top());

            minStack.Pop();
            Assert.Equal(10, minStack.Top());
        }
    }
}
