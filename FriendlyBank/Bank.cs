using System;
namespace FriendlyBank
{
    public class Bank
    {
        public static void Main()
        {
            Account BobsAccount = new Account();

            if (BobsAccount.WithdrawFunds(5))
            {
                Console.WriteLine("Money withdrawn");
            }
            else
            {
                Console.WriteLine("Insufficident funds");
            }
        }
    }
}
