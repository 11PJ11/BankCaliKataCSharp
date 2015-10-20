using System;

namespace BankKata.Model
{
    public class Deposit : Transaction
    {
        public Deposit(DateTime date, int amount) 
            : base(date, amount)
        {
        }
    }
}