using System;

namespace ConsoleBasics
{
    class Program
    {
        static double max;
        static double min;
        static void Main(string[] args)
        {
            /**
             * For extra information about datatypes use:
             * https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables
             */
            Console.WriteLine("The current time is: " + DateTime.Now + "\n");

            Console.WriteLine("Using sbyte:");
            max = sbyte.MaxValue;
            min = sbyte.MinValue;
            Console.WriteLine($"The range of sbyte is {min} to {max}\n");

            Console.WriteLine("Using short:");
            max = short.MaxValue;
            min = short.MinValue;
            Console.WriteLine($"The range of short is {min} to {max}\n");

            Console.WriteLine("Using int:");
            max = int.MaxValue;
            min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}\n");

            Console.WriteLine("Using long:");
            max = long.MaxValue;
            min = long.MinValue;
            Console.WriteLine($"The range of long is {min} to {max}\n");

            Console.WriteLine("Using double:");
            max = double.MaxValue;
            min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}\n");

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
