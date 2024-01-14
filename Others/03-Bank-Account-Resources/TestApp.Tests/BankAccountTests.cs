using NUnit.Framework;
using System;

namespace TestApp.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private const double Tolerance = 0.0001;

        [Test]
        public void Test_Constructor_InitialBalanceIsSet()
        {
            // Arrange
            double initialBalance = 100.0;

            // Act
            var account = new BankAccount(initialBalance);

            // Assert
            Assert.AreEqual(initialBalance, account.Balance, Tolerance);
        }

        [Test]
        public void Test_Deposit_PositiveAmount_IncreasesBalance()
        {
            // Arrange
            var account = new BankAccount(100.0);
            double depositAmount = 50.0;
            double expectedBalance = 150.0;

            // Act
            account.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedBalance, account.Balance, Tolerance);
        }

        [Test]
        public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
        {
            // Arrange
            var account = new BankAccount(100.0);
            double depositAmount = -50.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => account.Deposit(depositAmount));
        }

        [Test]
        public void Test_Withdraw_ValidAmount_DecreasesBalance()
        {
            // Arrange
            var account = new BankAccount(100.0);
            double withdrawAmount = 30.0;
            double expectedBalance = 70.0;

            // Act
            account.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(expectedBalance, account.Balance, Tolerance);
        }

        [Test]
        public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
        {
            // Arrange
            var account = new BankAccount(100.0);
            double withdrawAmount = -30.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawAmount));
        }

        [Test]
        public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
        {
            // Arrange
            var account = new BankAccount(100.0);
            double withdrawAmount = 150.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawAmount));
        }
    }
}
