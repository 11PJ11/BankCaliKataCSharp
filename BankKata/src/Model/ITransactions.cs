using System;
using BankKata.Infrastructure;

namespace BankKata.Model
{
    public interface ITransactions
    {
        void Add(Transaction transaction);
        bool Contains(Transaction transaction);
        void ForEach(Action<Transaction> applyTo);
    }
}