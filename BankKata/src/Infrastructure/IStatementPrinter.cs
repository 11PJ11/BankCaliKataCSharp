using BankKata.Model;

namespace BankKata.Infrastructure
{
    public interface IStatementPrinter
    {
        void PrintHeader();
        void PrintStatementLine(string date, string amount, string balance);
        void PrintAll(ITransactions transactions);
    }
}