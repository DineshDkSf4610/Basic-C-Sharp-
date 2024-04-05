using System;
namespace Methods;

class Programs
{
    public static void Main(string[] args)
    {
        bool check = false;
        bool check1 = true;
        do
        {
            Console.Write("Enter a Number 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a Number 2: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a operators: Ex(+,-,*,/) ");
            string operators = Console.ReadLine();

            switch (operators)
            {
                case "+":
                    {
                        Console.WriteLine(Add(Convert.ToInt32(a), Convert.ToInt32(b)));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(Sub(Convert.ToInt32(a), Convert.ToInt32(b)));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(Multi(Convert.ToInt32(a), Convert.ToInt32(b)));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine(Divison(a, b));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Inputs");
                        break;
                    }

            }

            Console.WriteLine("Do you Continue ? - yes/no");
            string conti = Console.ReadLine();

            while (check1)
            {
                if (conti == "yes")
                {
                    check = true;
                    break;
                }
                else if (conti == "no")
                {
                    check = false;
                    break;
                }
                else
                {
                    Console.Write("Invalid Input. Enter a correct input.");
                    conti = Console.ReadLine();
                }
            }

        } while (check);
    }

    static int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    static int Sub(int a, int b)
    {
        int c = a - b;
        return c;
    }

    static int Multi(int a, int b)
    {
        int c = a * b;
        return c;
    }

    static double Divison(double a, double b)
    {
        double c = a / b;
        return c;
    }
}