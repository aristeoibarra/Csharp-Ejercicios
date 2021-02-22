using System;

namespace ExampleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Aristeo", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance:C} initial balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance.ToString("C"));

            account.MakeDeposit(100, DateTime.Now, "Friend paid me");
            Console.WriteLine(account.Balance.ToString("C"));

            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.Message);
            }

            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.Message);
            }

            // Get the account history
            Console.WriteLine();
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
