using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Generic Dictionary
        Console.WriteLine("Generic Dictionary Example:");
        GenericDictionaryExample();

        // Non-generic Hashtable
        Console.WriteLine("\nNon-Generic Hashtable Example:");
        NonGenericHashtableExample();
    }

    static void GenericDictionaryExample()
    {
        // Create a new dictionary with string keys and int values
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Add elements into the dictionary
        dictionary["One"] = 1;
        dictionary["Two"] = 2;
        dictionary["Three"] = 3;

        // Count of elements in the dictionary
        Console.WriteLine($"Count of elements in the dictionary: {dictionary.Count}");

        // Accessing elements by key
        Console.WriteLine($"Value of key 'One': {dictionary["One"]}");
        Console.WriteLine($"Value of key 'Two': {dictionary["Two"]}");

        // Check if dictionary contains a key
        Console.WriteLine($"Does dictionary contain key 'Four'? {dictionary.ContainsKey("Four")}"); // Should be false

        // Check if dictionary contains a value
        Console.WriteLine($"Does dictionary contain value 2? {dictionary.ContainsValue(2)}"); // Should be true

        // Removing an element by key
        dictionary.Remove("Three");
        Console.WriteLine($"Count of elements in the dictionary after removing: {dictionary.Count}");

        // Clear the dictionary
        dictionary.Clear();
        Console.WriteLine($"Count of elements in the dictionary after clearing: {dictionary.Count}");
    }

    static void NonGenericHashtableExample()
    {
        // Create a new hashtable
        Hashtable hashtable = new Hashtable();

        // Add elements into the hashtable
        hashtable["One"] = 1;
        hashtable["Two"] = 2;
        hashtable["Three"] = 3;

        // Count of elements in the hashtable
        Console.WriteLine($"Count of elements in the hashtable: {hashtable.Count}");

        // Accessing elements by key
        Console.WriteLine($"Value of key 'One': {hashtable["One"]}");
        Console.WriteLine($"Value of key 'Two': {hashtable["Two"]}");

        // Check if hashtable contains a key
        Console.WriteLine($"Does hashtable contain key 'Four'? {hashtable.ContainsKey("Four")}"); // Should be false

        // Check if hashtable contains a value
        Console.WriteLine($"Does hashtable contain value 2? {hashtable.ContainsValue(2)}"); // Should be true

        // Removing an element by key
        hashtable.Remove("Three");
        Console.WriteLine($"Count of elements in the hashtable after removing: {hashtable.Count}");

        // Clear the hashtable
        hashtable.Clear();
        Console.WriteLine($"Count of elements in the hashtable after clearing: {hashtable.Count}");
    }
}
