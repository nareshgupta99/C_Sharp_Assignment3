using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    
    public sealed class SavingsAccount : Bank
    {
        // Property for annual interest rate
        public decimal InterestRate { get; set; }

        // Constructor
        public SavingsAccount(string accountNumber, decimal balance, decimal interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        // Method to calculate interest
        public decimal CalculateInterest()
        {
            return Balance * (InterestRate / 100);
        }

        // Method to add interest to balance
        public void AddInterest()
        {
            decimal interest = CalculateInterest();
            Balance += interest;
            Console.WriteLine($"Interest Added: {interest}. New Balance: {Balance}");
        }
    }

}
