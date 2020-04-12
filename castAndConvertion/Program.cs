using System;

namespace castAndConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Implicit convertion");
            
            int a = 1012;
            long b = a;
            Console.WriteLine($"int value: {a}, long value: {b}");

            float c = 1.002f;
            double d = c;
            Console.WriteLine($"float value: {c}, double value: {d}");

            Console.WriteLine($"Using explicit convertion:");

            double e = 1.002;
            int f = (int) e;
            string g = e.ToString();
            bool h = false;
            string i = h.ToString();

            Console.WriteLine($"double value: {e}, int value: {f}, string value {g}");
            Console.WriteLine($"bool value: {h}, string value: {i}");

            string sTen = "10";
            string sEleven = "11";
            int iTen = Int32.Parse(sTen);
            int iEleven = Int32.Parse(sEleven);
            int iSum = iTen + iEleven;
            string sSum = sTen + sEleven;

            Console.WriteLine($"String answer: {sSum}");
            Console.WriteLine($"int answer: {iSum}");

            Console.WriteLine("Using constants");
            const double PI = 3.14159265359;
            const string noChange = "Cannot be change!";

            //PI = 2;   Cannot be changed!
            Console.WriteLine($"PI: {PI}, string value: {noChange}");




        }
    }
}
