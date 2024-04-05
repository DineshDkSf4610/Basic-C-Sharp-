using System;
namespace WhileLoop;

class Program {
    public static void Main(string[] args)
    {
        // Qus 1
        int i = 0;
        while(i < 25){
            if(i%2 == 0){
                Console.WriteLine(i);
            }
            i++;
        }
        // 2nd Qus
        Console.Write("Enter a Number: ");
        int a;
        bool check = int.TryParse(Console.ReadLine(), out a);

        while(!check){
            Console.Write("Invalid Input Number. Enter again: ");
            check = int.TryParse(Console.ReadLine(),out a);
        }
        Console.WriteLine(a);
    }
}