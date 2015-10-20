using BankKata.Model;

namespace BankKata.Infrastructure
{
    public class StatementPrinter : IStatementPrinter
    {
        private readonly IConsole _console;
        private const string HEADER = "|DATE       | AMOUNT  | BALANCE";

        public StatementPrinter(IConsole console)
        {
            _console = console;
        }

        public void PrintHeader()
        {
            _console.WriteLine(HEADER);
        }

        public void PrintStatementLine(string date, string amount, string balance)
        {
            var statementLine =
                string.Format("|{0} | {1}   | {2}", date, amount, balance);

            _console.WriteLine(statementLine);
        }

        public void PrintAll(ITransactions transactions)
        {
            var runningBalance = 0;
            transactions
                .ForEach(t => t.PrintUsing(this, ref runningBalance));
        }
    }
}