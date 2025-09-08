using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose a program:");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Namn");
            Console.WriteLine("0. Exit");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Calculator.Run();   // runs calculator
                    break;
                case "2":
                    Namn.Run();         // runs namn
                    break;
                case "0":
                    running = false;    // exit loop
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
