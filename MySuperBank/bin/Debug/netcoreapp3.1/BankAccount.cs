using System;
namespace MySuperBank
{
    public class BankAccount
    {
        // Define what a bank account should look like
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }



        // You need to make a bank account - this is called the constructor
        public BankAccount(string name, decimal initalBalance)
        {
            // Assign the passed properties to the defined bank account fields above
            Owner = name;
            Balance = initalBalance;

        }




        // Action - these are the methods
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }

    }
}
