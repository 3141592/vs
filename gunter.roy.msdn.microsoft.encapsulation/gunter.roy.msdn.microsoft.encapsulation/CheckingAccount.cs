using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.encapsulation
{
    internal class CheckingAccount : BankAccountProtected
    {
        protected override void ApplyPenalties()
        {
            Console.WriteLine("CheckingAccount ApplyPenalties");
        }

        protected override void CalculateInterest()
        {
            Console.WriteLine("CheckingAccount CalculateInterest");
        }

        protected override void DeleteAccount()
        {
            base.DeleteAccount();
            Console.WriteLine("CheckingAccount DeleteAccount");
        }
    }
}
