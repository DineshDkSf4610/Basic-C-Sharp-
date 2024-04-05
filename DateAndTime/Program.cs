using System;
namespace DateAndTime;

class Program
{
    public static void Main(string[] args)
    {
        // DateTime date = new DateTime(2021, 8, 10, 10, 40, 32);
        // Console.WriteLine(date);
        // Console.WriteLine("Enter a date: yyyy/MM/dd hh:mm:ss tt");

        // bool isValid = DateTime.TryParseExact(Console.ReadLine(), "yyyy/MM/dd hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out date);

        // while (!isValid)
        // {
        //     Console.WriteLine("Invalid format Please try again: ");
        //     isValid = DateTime.TryParseExact(Console.ReadLine(), "yyyy/MM/dd hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out date);
        // }

        // string convert_string = date.ToString("yyyy/MM/dd hh:mm:ss tt");
        // string[] convert = convert_string.Split('/', ':', ' ');

        // Console.WriteLine("Reverse Print");

        // for (int i = convert.Length - 1; i >= 0; i--)
        // {
        //     Console.Write(convert[i] + " ");
        // }
        // Console.WriteLine(" ");
        // Console.WriteLine($"year is {date.ToString("yyyy")}");
        // Console.WriteLine($"Month is {date.ToString("MM")}");
        // Console.WriteLine($"Day is {date.ToString("dd")}");

        DateTime date = new DateTime();
        string dateString = Console.ReadLine();

        if(DateTime.TryParseExact(dateString,"dd/MM/yyyy",null, System.Globalization.DateTimeStyles.None, out date)){
            DateTime newDate = date.AddYears(40);
            Console.WriteLine($"year = {newDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine(newDate.DayOfWeek);
        }else{
            Console.WriteLine("erroe");
        }
    }
}