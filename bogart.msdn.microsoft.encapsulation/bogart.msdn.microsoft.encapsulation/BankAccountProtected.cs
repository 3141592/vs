using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunter.roy.msdn.microsoft.encapsulation
{
    internal class BankAccountProtected
    {
        public void CloseAccount()
        {
            Console.WriteLine("CloseAccount public");
            ApplyPenalties();
            CalculateInterest();
            DeleteAccount();
        }

        protected virtual void ApplyPenalties()
        {
            Console.WriteLine("ApplyPenalties protected");
        }

        protected virtual void CalculateInterest()
        {
            Console.WriteLine("CalculateInterest protected");
        }

        protected virtual void DeleteAccount()
        {
            Console.WriteLine("DeleteAccount protected");
        }
    }
}
