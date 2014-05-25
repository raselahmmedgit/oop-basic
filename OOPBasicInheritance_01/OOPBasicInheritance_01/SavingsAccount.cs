using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicInheritance_01
{
    class SavingsAccount : Account
    {
        public double InterestAmount { set; get; }

        public override string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return "Insufficient balance";
            }
        }
    }
}
