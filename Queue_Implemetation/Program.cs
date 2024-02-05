using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Generic Queue
        Console.WriteLine("Generic Queue Example:");
        GenericQueueExample();

        // Non-generic Queue
        Console.WriteLine("\nNon-Generic Queue Example:");
        NonGenericQueueExample();
    }

    static void GenericQueueExample()
    {
        // Create a new queue of integers
        Queue<int> queue = new Queue<int>();

        // Enqueue elements into the queue
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        // Count of elements in the queue
        Console.WriteLine($"Count of elements in the queue: {queue.Count}");

        // Peek at the front element without removing it
        int frontElement = queue.Peek();
        Console.WriteLine($"Front element of the queue: {frontElement}");

        // Dequeue elements from the queue
        Console.WriteLine("Dequeueing elements from the queue:");
        while (queue.Count > 0)
        {
            int element = queue.Dequeue();
            Console.WriteLine($"Dequeued element: {element}");
        }

        // Count after dequeueing elements
        Console.WriteLine($"Count of elements in the queue after dequeueing: {queue.Count}");

        // Enqueue some more elements into the queue
        queue.Enqueue(4);
        queue.Enqueue(5);

        // Clear the queue
        queue.Clear();
        Console.WriteLine($"Count of elements in the queue after clearing: {queue.Count}");
    }

    static void NonGenericQueueExample()
    {
        // Create a new queue
        Queue queue = new Queue();

        // Enqueue elements into the queue
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        // Count of elements in the queue
        Console.WriteLine($"Count of elements in the queue: {queue.Count}");

        // Peek at the front element without removing it
        object frontElement = queue.Peek();
        Console.WriteLine($"Front element of the queue: {frontElement}");

        // Dequeue elements from the queue
        Console.WriteLine("Dequeueing elements from the queue:");
        while (queue.Count > 0)
        {
            object element = queue.Dequeue();
            Console.WriteLine($"Dequeued element: {element}");
        }

        // Count after dequeueing elements
        Console.WriteLine($"Count of elements in the queue after dequeueing: {queue.Count}");

        // Enqueue some more elements into the queue
        queue.Enqueue("Fourth");
        queue.Enqueue("Fifth");

        // Clear the queue
        queue.Clear();
        Console.WriteLine($"Count of elements in the queue after clearing: {queue.Count}");
    }
}
