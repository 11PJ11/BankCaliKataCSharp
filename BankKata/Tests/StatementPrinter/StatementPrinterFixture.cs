using BankKata.Infrastructure;
using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.StatementPrinter
{
    public class StatementPrinterFixture
    {
        protected readonly IConsole Console = Substitute.For<IConsole>();
        protected IStatementPrinter Printer;

        [SetUp]
        public void SetUp()
        {
            Printer = new Infrastructure.StatementPrinter(Console);
        }        
    }
}