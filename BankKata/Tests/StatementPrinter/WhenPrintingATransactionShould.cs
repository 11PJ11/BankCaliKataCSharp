using System;
using BankKata.Model;
using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.StatementPrinter
{
    [TestFixture]
    public class WhenPrintingATransactionShould : StatementPrinterFixture
    {
        [Test]
        public void OutputTransactionDateAmountAndBalance()
        {
            const string date = "19/10/2015";
            const string amount = "1000.00";
            const string balance = "1400.00";
            
            Printer.PrintStatementLine(date, amount , balance);

            const string statementLine = "|19/10/2015 | 1000.00   | 1400.00";
            
            Console.Received().WriteLine(statementLine);
        }
    }

    [TestFixture]
    public class WhenPrintingAllTransactionsShould : StatementPrinterFixture
    {
        [Test]
        public void OutputAllTheTransactionsWithTheirDateAmountAndBalanceInReverseDateOrder()
        {
            var transactions = CreateSomeTransactions();

            Printer.PrintAll(transactions);

            Console.Received().WriteLine("|12/10/2015 | -100.00   | 900.00");
            Console.Received().WriteLine("|11/10/2015 | 1000.00   | 1000.00");
        }

        private ITransactions CreateSomeTransactions()
        {
            var transactions = Model.Transactions.CreateEmpty(Printer);
            var transaction1 = new Deposit(new DateTime(2015, 10, 11), 1000);
            var transaction2 = new Deposit(new DateTime(2015, 10, 12), -100);

            transactions.Add(transaction1);
            transactions.Add(transaction2);

            return transactions;
        }
    }
}