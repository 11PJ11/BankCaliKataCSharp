using System;
using BankKata.Infrastructure;
using BankKata.Model;
using NSubstitute;
using TickSpec;

namespace BankKata.Specs.Steps
{
    public class BankAccountSteps
    {
        private readonly IClock _clock = Substitute.For<IClock>();
        private readonly IConsole _console = Substitute.For<IConsole>();
        private IStatementPrinter _statementPrinter;
        private Transactions _transactions;
        private BankAccount _bankAccount;

        [BeforeScenario]
        public void Before()
        {
            _statementPrinter = new StatementPrinter(_console);
            _transactions = Transactions.CreateEmpty(_statementPrinter);
            _bankAccount = new BankAccount(_statementPrinter, _transactions, _clock);
        }

        [Given(@"I deposited '(.*)' on '(.*)' with a balance of '(.*)'")]
        public void IDepositedAmounOnADateWithBalance(string amount, string date, decimal balance)
        {
            _clock.Today().Returns(DateTime.Parse(date));
            _bankAccount.Deposit(Int32.Parse(amount));
        }

        [Given(@"I withdrew '(.*)' on '(.*)' with a balance of '(.*)'")]
        public void IDWithdrewAmounOnADateWithBalance(string amount, string date, decimal balance)
        {
            _clock.Today().Returns(DateTime.Parse(date));
            _bankAccount.Withdraw(Int32.Parse(amount));
        }

        [When(@"I print the statement")]
        public void IPrintTheStatemnt()
        {
            _bankAccount.PrintStatement();
        }

        [Then(@"I should receive the following output (.*)")]
        public void IShouldReceiveTheFollowingOutput(string statementLine)
        {
            _console.Received().WriteLine(statementLine);
        }
    }
}