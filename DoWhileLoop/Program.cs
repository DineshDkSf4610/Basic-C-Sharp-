using System;
namespace DoWhileLoop;

class Program
{
    public static void Main(string[] args)
    {
        // int input;
        string ans;
        bool temp = true;


        do
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even Number: Do you continue ? - yes/no");
            }
            else
            {
                Console.WriteLine($"{number} is Odd Number, Do you continue ? - yes/no");
            }
            ans = Console.ReadLine();

            if (ans == "no")
            {
                break;
            }
            else if (ans == "yes")
            {
                continue;
            }
            else
            {
                temp = false;
            }
            while (!temp)
            {
                Console.WriteLine("Input is Wrong. Please Enter a valid Input: ");
                ans = Console.ReadLine();
                if (ans == "yes" || ans == "no")
                {
                    temp = true;
                }

            }



        } while (ans == "yes");
    }
}