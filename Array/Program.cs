using System;
namespace Array;

class Program
{
    public static void Main(string[] args)
    {
        int temp = 0;
        int temp1 = 0;
        string[] array1 = new string[5] { "Mani", "Ganesh", "Venkat", "Suresh", "Venkat" };

        Console.WriteLine("Print all Names");
        Console.WriteLine("***************");       
        for(int i=0; i<array1.Length; i++){
            Console.WriteLine(array1[i]);
        }

        Console.Write("Enter a your name: ");
        string input = Console.ReadLine();

        Console.WriteLine("For Loop");
        Console.WriteLine("********"); 
        for (int i = 0; i<array1.Length; i++){
            if(array1[i] == input){
                temp ++;
                Console.WriteLine("The name is present in array");
                Console.WriteLine($"{array1[i]} Index value is {i}");
                break;
            }
        }
        if(temp == 0){
            Console.WriteLine("The name is not present in array");
        }
        Console.WriteLine("Foreach Loop");
        Console.WriteLine("************"); 
        foreach(string i in array1){
            if(input == i){
                temp1++;
                Console.WriteLine("The name is present in array");
                break;
            }
        }
        if(temp1 == 0){
            Console.WriteLine("The name is not present in array");
        }
    }
}