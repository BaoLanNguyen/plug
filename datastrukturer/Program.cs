using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Stack myStack = new Stack();

        // Push some elements onto the stack
        myStack.Push("apple");
        myStack.Push("banana");
        myStack.Push("cherry");
        myStack.Push("date");

        // Pop elements off the stack
        Console.WriteLine("Popping elements off the stack:");
        while (myStack.Count > 0)
        {
            Console.WriteLine(myStack.Pop());
        }
    }
}