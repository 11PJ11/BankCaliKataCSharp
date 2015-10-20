using BankKata.Infrastructure;
using BankKata.Model;
using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.BankAccount
{
    public class BankAccountFixture
    {
        protected IClock Clock;
        protected IStatementPrinter StatementPrinter;
        protected ITransactions Transactions;
        protected Model.BankAccount BankAccount;

        [SetUp]
        public void SetUp()
        {
            Clock = new Clock();
            StatementPrinter = Substitute.For<IStatementPrinter>();
            Transactions = Substitute.For<ITransactions>();
            BankAccount = new Model.BankAccount(StatementPrinter, Transactions, Clock);
        }
    }
}