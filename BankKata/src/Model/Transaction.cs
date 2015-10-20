using System;
using System.Globalization;
using BankKata.Infrastructure;

namespace BankKata.Model
{
    public abstract class Transaction
    {
        private readonly DateTime _date;
        private readonly int _amount;

        protected Transaction(DateTime date, int amount)
        {
            _date = date;
            _amount = amount;
        }

        public void PrintUsing(
            IStatementPrinter statementPrinter, 
            ref int balance)
        {
            var date = _date.ToShortDateString();
            var amount = _amount.ToString("####.00", NumberFormatInfo.InvariantInfo);
            balance += _amount;
            var runningBalance = balance.ToString("####.00", NumberFormatInfo.InvariantInfo);

            statementPrinter.PrintStatementLine(date, amount, runningBalance);
        }

        public int CompareTo(Transaction other)
        {
            return other.CompareDate(_date);
        }

        private int CompareDate(DateTime otherDate)
        {
            return _date.CompareTo(otherDate);
        }
    }
}