using BankKata.Infrastructure;
using NSubstitute;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace BankKata.Tests.Transactions
{
    public class TransactionsFixture
    {
        protected IStatementPrinter StatementPrinter;
        protected Fixture Fixture = new Fixture();
        protected Model.Transactions Transactions;

        [SetUp]
        public void SetUp()
        {
            StatementPrinter = Substitute.For<IStatementPrinter>();
            Transactions = Model.Transactions.CreateEmpty(StatementPrinter);
        }

        protected Model.Transaction GetATransaction()
        {
            return Fixture.Create<Model.Deposit>();
        }
    }
}
