using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace OOPBasicInheritance_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount aSavingsAccount = new SavingsAccount();
            aSavingsAccount.Number = "sv-001";
            aSavingsAccount.Deposit(2000);
            aSavingsAccount.Withdraw(1000);

            Checking aChecking = new Checking();
            aChecking.Number = "Chk-001";
            aChecking.Deposit(2000);
            aChecking.Withdraw(1500);


            List<Account> accounts = new List<Account>();
            accounts.Add(aSavingsAccount);
            accounts.Add(aChecking);

            foreach (Account account in accounts)
            {
                account.Withdraw(2000);
            }

        }
    }
}
