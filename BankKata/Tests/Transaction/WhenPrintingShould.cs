using System;
using BankKata.Model;
using NSubstitute;
using NUnit.Framework;

namespace BankKata.Tests.Transaction
{
    public class WhenPrintingShould
        : TransactionFixture
    {
        [Test]
        public void UseAStatementPrinter()
        {
            var date = new DateTime(2015,10,16);
            const int amount = 1000;
            var balance = 0;
            var transaction = new Deposit(date, amount);
            
            transaction.PrintUsing(StatementPrinter, ref balance);

            StatementPrinter.Received()
                .PrintStatementLine("16/10/2015", "1000.00", "1000.00");
        }
    }
}