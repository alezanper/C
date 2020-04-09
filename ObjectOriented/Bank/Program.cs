using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Alexander", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "To someone");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(50, DateTime.Now, "buy game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            try
            {
                var invalidAccount = new BankAccount("Invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(account.Balance);
            }
        }
    }
}
