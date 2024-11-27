using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class BankAccount
    {
        int AccountNumber;
        string AccountHolderName;
        int balance;

        public BankAccount(int AccountNumber)
        {
            this.AccountNumber = AccountNumber;
        }
        public void Deposit(int balance)
        {
            this.balance = balance;
        }

        public void Withdrawal()
        {
            if(balance <= this.balance)
            {
                this.balance -= balance;
            }
            else
            {
                Console.WriteLine("Insuficent balance");
            }
        }

        private String ToString()
        {
            return "Account Number : " + this.AccountNumber + " Account Holder Name : " + this.AccountHolderName + " Account Balance :" + this.balance;
        }

        public String GetDetails()
        {
            return this.ToString();
        }

    }
}
