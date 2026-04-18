using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_App
{
    public class SavingsAccount:BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate) : base(owner + $" ({interestRate}%)")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot deposit $" + amount;
            if (amount > 20000)
                return "AML Deposit Limit Reached.";

            decimal interestAmount = (InterestRate / 100) * amount;
            Balance += amount + interestAmount;
            return "Deposit completed successfully.";
        }
    }
}
