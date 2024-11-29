using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // BankAccount.cs
    public class Bank
    {
        // Properties
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // Constructor
        public Bank(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Amount must be greater than zero.");
            }
        }

        // Method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
        }
    }

}
