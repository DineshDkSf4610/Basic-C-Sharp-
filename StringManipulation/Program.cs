using System;
namespace StringManipulation;

class Program {
    public static void Main(string[] args)
    {
        Console.Write("Main String: ");
        string mainInput = Console.ReadLine();
        Console.Write("String to be searched: ");
        string shortInput = Console.ReadLine();
        string[] result = mainInput.Split(shortInput);
        Console.WriteLine(result.Length-1);
    }
}