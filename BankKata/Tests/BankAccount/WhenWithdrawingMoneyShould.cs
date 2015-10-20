using BankKata.Model;
using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.BankAccount
{
    [TestFixture]
    public class WhenWithdrawingMoneyShould : BankAccountFixture
    {
        [Test]
        public void PersistTheTransaction()
        {
            const int amount = 1000;

            BankAccount.Withdraw(amount);

            Transactions.Received().Add(Arg.Any<Withdrawal>());
        }
    }
}