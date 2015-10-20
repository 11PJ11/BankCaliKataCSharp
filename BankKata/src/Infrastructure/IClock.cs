using System;

namespace BankKata.Infrastructure
{
    public interface IClock
    {
        DateTime Today();
    }
}