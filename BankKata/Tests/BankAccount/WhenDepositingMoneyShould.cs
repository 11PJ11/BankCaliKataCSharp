using BankKata.Model;
using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.BankAccount
{
    [TestFixture]
    public class WhenDepositingMoneyShould : BankAccountFixture
    {
        [Test]
        public void PersistTheTransaction()
        {
            const int amount = 1000;

            BankAccount.Deposit(amount);

            Transactions.Received().Add(Arg.Any<Deposit>());
        }
    }
}