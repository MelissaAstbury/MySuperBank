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

            account.MakeWithdrawal(530, DateTime.Now, "Rent");
            Console.WriteLine(account.Balance);

            //account.MakeWithdrawal(20, DateTime.Now, "Food");
            //Console.WriteLine(account.Balance);
        }
    }
}
