using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;

            switch (number)
            {
                case 0:
                    Console.WriteLine("The number is zero");
                    break;
                case 1:
                    Console.WriteLine("The number is one");
                    break;
                case 2:
                    Console.WriteLine("The number is two");
                    break;
                case 3:
                    Console.WriteLine("The number is three");
                    break;
                case 4:
                    Console.WriteLine("The number is four");
                    break;
                case 5:
                    Console.WriteLine("The number is five");
                    break;
                default:
                    Console.WriteLine("The number is greater than 5");
                    break;
            } 
        }
    }
}
