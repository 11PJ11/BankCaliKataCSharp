using System;

namespace BankKata.Infrastructure
{
    public class Clock : IClock
    {
        public DateTime Today()
        {
            return DateTime.Now;
        }
    }
}