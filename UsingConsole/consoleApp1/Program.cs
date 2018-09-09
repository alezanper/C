using System;

/**
 * Using Console application
 * */

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             for(int i = 0; i<=100; i++)
            {
                // Printing only even numbers
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadLine();
        }
    }
}
