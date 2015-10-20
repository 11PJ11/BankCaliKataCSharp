using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.StatementPrinter
{
    [TestFixture]
    public class WhenPrintingTheHeaderShould : StatementPrinterFixture
    {

        [Test]
        public void OutputDateAmountAndBalance()
        {
            Printer.PrintHeader();

            Console.Received().WriteLine("|DATE       | AMOUNT  | BALANCE");
        }
    }
}
