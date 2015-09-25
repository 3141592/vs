using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.encapsulation
{
    internal class SavingsAccount : BankAccountProtected
    {
        protected override void ApplyPenalties()
        {
            Console.WriteLine("SavingsAccount ApplyPenalties");
        }

        protected override void CalculateInterest()
        {
            Console.WriteLine("SavingsAccount CalculateInterest");
        }

        protected override void DeleteAccount()
        {
            base.DeleteAccount();
            Console.WriteLine("SavingsAccount DeleteAccount");
        }
    }
}
