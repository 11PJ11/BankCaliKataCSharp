using FluentAssertions;
using NUnit.Framework;

namespace BankKata.Tests.Transactions
{
    public class WhenAddingATransactionShould 
        : TransactionsFixture
    {
        [Test]
        public void ContainTheAddedTransaction()
        {
            var aTransaction = GetATransaction();

            Transactions.Add(aTransaction);

            Transactions.Contains(aTransaction)
                .Should().BeTrue();
        }
    }
}