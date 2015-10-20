using System;

namespace BankKata.Model
{
    public class Withdrawal : Transaction
    {
        public Withdrawal(DateTime date, int amount) 
            : base(date, -amount)
        {
        }
    }
}