using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Mel", 100);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with the balance of {account.Balance}");


            account.MakeWithdrawal(70, DateTime.Now, "Chiar");
            Console.WriteLine(account.Balance);


            account.MakeDeposit(500, DateTime.Now, "wages");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());
  
            // Test that the inital balances must be positive
            try
            {
                var invalidAccount = new BankAccount("invalid account", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with a negative balance");
                Console.WriteLine(e.ToString());
            }


            account.MakeWithdrawal(500, DateTime.Now, "Rent");
            Console.WriteLine(account.Balance);


            // Test for a negative account balance
            try
            {
                account.MakeWithdrawal(50, DateTime.Now, "Food");
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to withdraw");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
