using NUnit.Framework;
using System;
namespace FriendlyBank
{
    public class AccountTest
    {
        // Arrange
        Account testAccount = new Account();
        Account testAccount2 = new Account();

        [Test()]
        public void CannotWithdrawFundsBeforeDeposit()
        {
            Assert.IsFalse(testAccount.WithdrawFunds(5));
        }

        [Test()]
        public void CanWithdrawFundsAfterDeposit()
        {
            testAccount.DepositFunds(5);
            Assert.AreEqual(5, testAccount.GetBalance());
            Assert.IsTrue(testAccount.WithdrawFunds(5));
            Assert.AreEqual(0, testAccount.GetBalance());
        }

        [Test()]
        public void InterestRateBehavesStatically()
        {
            Account.ChangeInterestRate(5);
            Assert.AreEqual(5, testAccount.GetInterestRate());
            Assert.AreEqual(5, testAccount2.GetInterestRate());
        }

        [Test()]
        public void CannotGiveAccountToUnderageOrUnemployed()
        {
            Assert.IsFalse(Account.IsAllowed(10000, 16));
            Assert.IsFalse(Account.IsAllowed(0, 18));
            Assert.IsTrue(Account.IsAllowed(10000, 18));
        }
    }
}
