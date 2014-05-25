using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicInheritance_01
{
    class Account
    {
        public string Number { set; get; }
        public string Name { set; get; }
        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn";
        }
    }
}
