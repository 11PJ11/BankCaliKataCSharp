using FluentAssertions;
using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.Transactions
{
    public class WhenApplyingAnActionOnAllTransactionsShould
        : TransactionsFixture
    {
        [Test]
        public void NotCallTheActionWhenTransactionsIsEmpty()
        {
            var actionWasCalled = false;

            Transactions.ForEach(t => actionWasCalled = true);

            actionWasCalled.Should().BeFalse();
        }

        [Test]
        public void CallTheActionWhenTransactionsIsNotEmpty()
        {
            var actionWasCalled = false;
            var aTransaction = GetATransaction();
            Transactions.Add(aTransaction);

            Transactions.ForEach(t => actionWasCalled = true);

            actionWasCalled.Should().BeTrue();
        }
    }
}