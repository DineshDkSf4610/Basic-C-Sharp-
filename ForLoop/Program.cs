using System;
namespace ForLoop;

class Program {
    public static void Main(string[] args)
    {
        int sum = 0;
        Console.Write("Enter a Start Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a End Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        for(int i = num1; num1 <= num2; num1++){
            
            sum = sum + (num1 * num1);
           
        }
         Console.WriteLine(sum);
    }
}