using System;

namespace Branches
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 50;
            
            if (a + b > 100)
                Console.WriteLine("Answer is greater than 100");
            else
                Console.WriteLine("Answer is lower than 100");

            // Nested branches

            string Name = "Alexander";
            int Age = 32;

            if (Name.Equals("Alexander"))
            {
                if(Age > 18)
                {
                    Console.WriteLine(Name + " is older than 18");
                } else
                {
                    Console.WriteLine(Name + " is younger than 18");
                }
            }

            // Ternary operators

            int Temperature = 0;
            string Status;
            Status = Temperature > 27 ? "Hot" : "Cold";
            Console.WriteLine(Status);
        }
    }
}
