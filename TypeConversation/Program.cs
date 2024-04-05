using System;
namespace TypeConversation;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        double mark1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        double mark2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        double mark3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        long mob = Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string mail = Console.ReadLine();

        // Output
        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile: {mob}");
        Console.WriteLine($"Marks1: {mark1}");
        Console.WriteLine($"Marks2: {mark2}");
        Console.WriteLine($"Marks3: {mark3}");
        Console.WriteLine($"Total: {mark1 + mark2 + mark3}");
        double total = mark1 + mark2 + mark3;
        double avg = total / 3;
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Mail id: {mail}");

        
    }
}