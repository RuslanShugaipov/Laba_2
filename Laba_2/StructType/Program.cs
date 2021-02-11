using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    public enum AccountType
    {
        Checking,
        Deposit
    }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accNo = 11354782;
            goldAccount.accBal = 100199;
            goldAccount.accType = AccountType.Checking;
            Console.WriteLine(goldAccount.accNo);
            Console.WriteLine(goldAccount.accBal);
            Console.WriteLine(goldAccount.accType);
        }
    }
}
