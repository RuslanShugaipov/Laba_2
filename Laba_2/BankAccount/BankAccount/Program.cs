using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    enum AccountType
    {
        Checking,
        Deposit
    }
    class Program
    {
        static void Main(string[] args)
        {
            AccountType goldAccount = AccountType.Checking;
            AccountType platinumAccount = AccountType.Deposit;
            Console.WriteLine(goldAccount);
            Console.WriteLine(platinumAccount);
        }
    }
}
