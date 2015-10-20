using System.Collections.Generic;

namespace BankKata.Model
{
    public class DescendingTransactionDateComparer : IComparer<Transaction>
    {
        public int Compare(Transaction aTransaction, Transaction anotherTransaction)
        {
            return -aTransaction.CompareTo(anotherTransaction);
        }
    }
}