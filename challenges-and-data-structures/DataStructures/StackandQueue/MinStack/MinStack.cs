using System;
using System.Collections.Generic;

public class MinStack
{
    public Stack<int> stack;
    public Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    // Push an element onto the stack
    public void Push(int x)
    {
        stack.Push(x);
        if (minStack.Count == 0 || x <= minStack.Peek())
        {
            minStack.Push(x);
        }
    }

    // Pop the top element off the stack
    public int Pop()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("Stack is empty.");

        int top = stack.Pop();
        if (top == minStack.Peek())
        {
            minStack.Pop();
        }
        return top;
    }

    // Get the top element without removing it
    public int Top()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("Stack is empty.");

        return stack.Peek();
    }

    // Check if the stack is empty
    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    // Get the minimum element in the stack
    public int GetMin()
    {
        if (minStack.Count == 0)
            throw new InvalidOperationException("Stack is empty.");

        return minStack.Peek();
    }

    // Print the contents of the stack
    public void PrintStack()
    {
        Console.Write("Top -> ");
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
