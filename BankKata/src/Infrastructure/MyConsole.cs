using System;

namespace BankKata.Infrastructure
{
    public class MyConsole : IConsole
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}