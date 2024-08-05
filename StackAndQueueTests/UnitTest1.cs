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
    }
}
