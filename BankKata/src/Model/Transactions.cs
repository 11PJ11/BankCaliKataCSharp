using System;
using System.Collections.Generic;
using BankKata.Infrastructure;

namespace BankKata.Model
{
    public class Transactions : ITransactions
    {
        private readonly SortedSet<Transaction> _transactions;

        private Transactions()
        {
            var descendingTransactionDateComparer = new DescendingTransactionDateComparer();
            _transactions = new SortedSet<Transaction>(descendingTransactionDateComparer);
        }


        public void Add(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public bool Contains(Transaction transaction)
        {
            return _transactions.Contains(transaction);
        }

        public void ForEach(Action<Transaction> applyTo)
        {
            foreach (var transaction in _transactions)
            {
                applyTo(transaction);
            }
        }

        public static Transactions CreateEmpty(IStatementPrinter statementPrinter)
        {
            return new Transactions();
        }
    }
}