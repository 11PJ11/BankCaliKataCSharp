using BankKata.Infrastructure;

namespace BankKata.Model
{
    public class BankAccount
    {
        private readonly IClock _clock;
        private readonly ITransactions _transactions;
        private readonly IStatementPrinter _statementPrinter;

        public BankAccount(
            IStatementPrinter statementPrinter, 
            ITransactions transactions, 
            IClock clock)
        {
            _statementPrinter = statementPrinter;
            _transactions = transactions;
            _clock = clock;
        }

        public void Deposit(int amount)
        {
            _transactions.Add(new Deposit(_clock.Today(), amount));
        }

        public void Withdraw(int amount)
        {
            _transactions.Add(new Withdrawal(_clock.Today(), amount));
        }

        public void PrintStatement()
        {
            _statementPrinter.PrintHeader();
            _statementPrinter.PrintAll(_transactions);
        }
    }
}
