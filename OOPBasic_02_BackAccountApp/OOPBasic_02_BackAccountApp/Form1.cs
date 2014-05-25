using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBasic_02_BackAccountApp
{
    public partial class Form1 : Form
    {
        private BankAccount aBankAccount;
        private double amount;
        private string text;

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aBankAccount = new BankAccount(noTextBox.Text, nameTextBox.Text);
            MessageBox.Show("Created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            InitializeAmount();
            text = aBankAccount.Deposit(amount);
            MessageBox.Show(text);
        }

        private void InitializeAmount()
        {
            amount = Convert.ToDouble(amountTextBox.Text);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            InitializeAmount();
            text = aBankAccount.Withdraw(amount);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aBankAccount.GetBalance().ToString());
        }
    }
}
