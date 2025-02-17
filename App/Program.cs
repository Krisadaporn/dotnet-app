// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Optional: Ask for user input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");

        // Wait by asking the user to hit the ENTER key explicitly
        Console.WriteLine("Press ENTER to exit...");
        Console.ReadLine(); // This works even without an actual console
    }
}
