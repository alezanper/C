using System;

namespace ConsoleBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is: " + DateTime.Now + "\n");

            Console.WriteLine("Using int:");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}\n");

            Console.WriteLine("Using double:");
            double maxd = double.MaxValue;
            double mind = double.MinValue;
            Console.WriteLine($"The range of double is {mind} to {maxd}\n");

            Console.WriteLine("1.0/3.0 usind double is:");
            double third = 1.0 / 3.0;
            Console.WriteLine(third + "\n");

            decimal mindc = decimal.MinValue;
            decimal maxdc = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {mindc} to {maxdc}");

            Console.WriteLine("1.0M/3.0M usind decimal is:");
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d + "\n");

            Console.WriteLine("String functions:");
            string p = "Alexander";
            Console.WriteLine($"My name is {p}");
            Console.WriteLine($"{p} has {p.Length} letters");

            Console.WriteLine("Trim:");
            string q = "     Hello World!     ";
            Console.WriteLine($"{q}");
            Console.WriteLine($"{q.Trim()}");

            Console.WriteLine("Replace hello with Bye");
            string r = "Hello World!";
            Console.WriteLine($"{r.Replace("Hello", "Bye")} \n");

            Console.WriteLine($"Function to {r}");
            Console.WriteLine($"Upper: {r.ToUpper()}");
            Console.WriteLine($"Lower: {r.ToLower()} \n");

            string s = "jarvis is my copilot";
            Console.WriteLine($"jarvis is in the phrase '{s}'?");
            Console.WriteLine(s.Contains("jarvis"));
        }
    }
}
