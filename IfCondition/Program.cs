using System;
namespace IfCondition;

class Program {
    public static void Main(string[] args)
    {
        Console.Write("Enter your mark: ");
        int mark = Convert.ToInt32(Console.ReadLine());

        if (0 < mark && mark <= 100)
        {
            if (mark > 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (61 <= mark && mark <= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (36 <= mark && mark <= 60)
            {
                Console.WriteLine("Grade C");
            }
            else if(36 > mark){
                
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }else{
            Console.WriteLine("Invalid Input");
        }


    }
}