using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Mel", 100);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with the balance of {account.Balance}");
        }
    }
}
