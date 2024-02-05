using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Generic Stack
        Console.WriteLine("Generic Stack Example:");
        GenericStackExample();

        // Non-generic Stack
        Console.WriteLine("\nNon-Generic Stack Example:");
        NonGenericStackExample();
    }

    static void GenericStackExample()
    {
        // Create a new stack of integers
        Stack<int> stack = new Stack<int>();

        // Push elements onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Count of elements in the stack
        Console.WriteLine($"Count of elements in the stack: {stack.Count}");

        // Peek at the top element without removing it
        int topElement = stack.Peek();
        Console.WriteLine($"Top element of the stack: {topElement}");

        // Pop elements from the stack
        Console.WriteLine("Popping elements from the stack:");
        while (stack.Count > 0)
        {
            int element = stack.Pop();
            Console.WriteLine($"Popped element: {element}");
        }

        // Count after popping elements
        Console.WriteLine($"Count of elements in the stack after popping: {stack.Count}");

        // Push some more elements onto the stack
        stack.Push(4);
        stack.Push(5);

        // Clear the stack
        stack.Clear();
        Console.WriteLine($"Count of elements in the stack after clearing: {stack.Count}");
    }

    static void NonGenericStackExample()
    {
        // Create a new stack
        Stack stack = new Stack();

        // Push elements onto the stack
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        // Count of elements in the stack
        Console.WriteLine($"Count of elements in the stack: {stack.Count}");

        // Peek at the top element without removing it
        object topElement = stack.Peek();
        Console.WriteLine($"Top element of the stack: {topElement}");

        // Pop elements from the stack
        Console.WriteLine("Popping elements from the stack:");
        while (stack.Count > 0)
        {
            object element = stack.Pop();
            Console.WriteLine($"Popped element: {element}");
        }

        // Count after popping elements
        Console.WriteLine($"Count of elements in the stack after popping: {stack.Count}");

        // Push some more elements onto the stack
        stack.Push("Fourth");
        stack.Push("Fifth");

        // Clear the stack
        stack.Clear();
        Console.WriteLine($"Count of elements in the stack after clearing: {stack.Count}");
    }
}


