using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Recusion");
            Console.WriteLine();

            long value = Factorial(10);
            Console.WriteLine(value);
            Console.ReadLine();
        }

        static long Factorial(int n) {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

    }
}
