using System;

public class Namn
{
    private static string favoritfärg = "blå";
    private static string? namn = null;

    public static void Run()
    {
        Console.WriteLine("Hej världen!");
        Console.WriteLine("Mitt namn är Edvin");
        Console.WriteLine("Idag är det " + DateTime.Now.ToString("d"));

        Console.WriteLine("Min favoritfärg är " + favoritfärg);
        Console.WriteLine("Vad är ditt namn?");
        namn = Console.ReadLine()!;
        Console.WriteLine("Hej " + namn + ", trevligt att träffas!");
    }
}
