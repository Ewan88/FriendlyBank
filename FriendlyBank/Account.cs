using System;
namespace FriendlyBank
{
    public class Account
    {
        private decimal balance = 0;
        private static decimal interestRate;

        public bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance -= amount;
            return true;
        }

        public void DepositFunds(decimal amount)
        {
            balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public static void ChangeInterestRate(decimal value)
        {
            interestRate = value;
        }

        public decimal GetInterestRate()
        {
            return interestRate;
        }

        public static bool IsAllowed(decimal income, int age)
        {
            if ((income >= 10000) && (age >= 18))
            {
                return true;
            } else
            {
                return false;
            }
        }

        
    }
}
