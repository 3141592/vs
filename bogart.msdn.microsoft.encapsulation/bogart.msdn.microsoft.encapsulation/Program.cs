using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountProtected[] bankAccts = new BankAccountProtected[2];
            bankAccts[0] = new SavingsAccount();
            bankAccts[1] = new CheckingAccount();

            foreach (BankAccountProtected acct in bankAccts)
            {
                // call public method, which invokes protected virtual methods
                acct.CloseAccount();
            }

            Console.ReadKey();
        }
    }
}
