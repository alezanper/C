using System;

namespace ConsoleBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            double maxd = double.MaxValue;
            double mind = double.MinValue;
            Console.WriteLine($"The range of double is {mind} to {maxd}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal mindc = decimal.MinValue;
            decimal maxdc = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {mindc} to {maxdc}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }
    }
}
