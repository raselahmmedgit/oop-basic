namespace OOPBasic_02_BackAccountApp
{
    internal class BankAccount
    {
        private string no;
        private string name;
        private double balance;

        public BankAccount(string no, string name)
        {
            this.no = no;
            this.name = name;
        }

        public string Deposit(double amount)
        {
            balance += amount;
        }

        public string Withdraw(double amount)
        {
            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}