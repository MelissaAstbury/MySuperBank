using System;
namespace MySuperBank
{
    public class Transaction
    {
        // Define what a transaction should look like
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }


        // Create a transaction
        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }
}
