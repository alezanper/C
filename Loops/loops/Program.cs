using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int limit = 5;
            Console.WriteLine("Using While:");
            while (counter < limit)
            {
                Console.WriteLine($"counter value is: {counter}");
                counter++;
            }

            counter = 0;
            Console.WriteLine("\nUsing do-While:");
            do
            {
                Console.WriteLine($"counter value is: {counter}");
                counter++;
            } while (counter < limit);

            counter = 0;
            Console.WriteLine("\nUsing for:");

            for(int i = 0; i < limit; i++)
            {
                Console.WriteLine($"counter value is: {counter}");
                counter++;
            }

        }
    }
}
