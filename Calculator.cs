using System;

public class Calculator
{
    public static void Run()
    {
        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine()!;
        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine()!;

        if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");

            string choice = Console.ReadLine()!.ToLower();

            switch (choice)
            {
                case "a":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "s":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "m":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "d":
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Error: Cannot divide by zero");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose A, S, M, or D.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }

        Console.WriteLine("\nPress ENTER to return to main menu...");
        Console.ReadLine(); // pause before going back
    }
}

