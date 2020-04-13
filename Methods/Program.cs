using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double dValue_1;
            double dValue_2;

            WriteMessage("My Calculator");

            dValue_1 = ReadAsDouble("Please, enter first value");
            dValue_2 = ReadAsDouble("Please, enter second value");

            WriteMessage("The sum is: " + Sum(dValue_1, dValue_2));
            WriteMessage("The substract is: " + Subtract(dValue_1, dValue_2));
            WriteMessage("The multiply is: " + Multiply(dValue_1, dValue_2));
            WriteMessage("The Div is: " + Div(dValue_1, dValue_2));
        }

        public static void WriteMessage(string Msg)
        {
            Console.WriteLine(Msg);
        }

        public static double ReadAsDouble(string Msg)
        {
            string Value;
            double DoubleValue = 0;

            Console.WriteLine(Msg);
            Value = Console.ReadLine();

            try
            {
                DoubleValue = Double.Parse(Value);
            }
            catch (FormatException)
            {
                WriteMessage("Please, enter a correct value.");
            }
            catch (OverflowException)
            {
                WriteMessage("value was too long.");
            }
            catch (ArgumentNullException)
            {
                WriteMessage("Please, insert a value.");
            }
            finally
            {
                //WriteMessage("Always called");
            }
            return DoubleValue;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            return a/b;            
        }

    }
}
