using System;
namespace SwitchCase;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a Number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a Operator: ");
        string Operator = Console.ReadLine();
        switch (Operator)
        {
            case "+":
                {
                    Console.WriteLine(number1 + number2);
                    break;
                }
            case "-":
                {
                    Console.WriteLine(number1 - number2);
                    break;
                }
            case "*":
                {
                    Console.WriteLine(number1 * number2);
                    break;
                }
            case "/":
                {
                    Console.WriteLine(number1 / number2);
                    break;
                }
            case "%":
                {
                    Console.WriteLine(number1 % number2);
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid");
                    break;
                }

        }

    }
}