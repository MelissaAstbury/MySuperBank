using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    public class BankAccount
    {
        // Define what a bank account should look like
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
;                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        // You need to make a bank account - this is called the constructor
        public BankAccount(string name, decimal initialBalance)
        {
            // Assign the passed properties to the defined bank account fields above
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            Owner = name;

            MakeDeposit(initialBalance, DateTime.Now, "Inital Balance");
        }




        // Action - these are the methods
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            // Add in the rules
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            // Add in the rules
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawl must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            // Header
            report.AppendLine("Date\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                //Rows
                report.AppendLine($"{item.Date.ToShortDateString()}\t\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }

    }
}
