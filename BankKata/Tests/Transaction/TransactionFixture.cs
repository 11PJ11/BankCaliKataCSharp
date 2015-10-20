using BankKata.Infrastructure;
using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.Transaction
{
    public class TransactionFixture
    {
        protected IStatementPrinter StatementPrinter;

        [SetUp]
        public void SetUp()
        {
            StatementPrinter = Substitute.For<IStatementPrinter>();
        }
    }
}
