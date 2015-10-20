using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.BankAccount
{
    [TestFixture]
    public class WhenPrintingTheStatementShould 
        : BankAccountFixture
    {
        [Test]
        public void AlwaysPrintTheStatementHeader()
        {
            BankAccount.PrintStatement();

            StatementPrinter.Received().PrintHeader();
        }

        [Test]
        public void PrintTheTransaction_GivenOnePresent()
        {
            BankAccount.PrintStatement();

            StatementPrinter.Received().PrintAll(Transactions);
        }

    }
}
