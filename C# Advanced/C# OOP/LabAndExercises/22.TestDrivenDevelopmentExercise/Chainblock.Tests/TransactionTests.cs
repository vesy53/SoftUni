namespace Chainblock.Tests
{
    using NUnit.Framework;
    using System;

    using Chainblock.Models;

    [TestFixture]
    public class TransactionTests
    {
        private const int Id = 1;
        private const TransactionStatus Status = TransactionStatus.Successfull;
        private const string From = "Pesho";
        private const string To = "Gosho";
        private const double Amount = 650;

        [Test]
        public void TestIfConstructorWorkCorrectly()
        {
            Transaction transaction = new Transaction(
                Id,
                Status,
                From,
                To,
                Amount);

            Assert.AreEqual(Id, transaction.Id);
            Assert.AreEqual(Status, transaction.Status);
            Assert.AreEqual(From, transaction.From);
            Assert.AreEqual(To, transaction.To);
            Assert.AreEqual(Amount, transaction.Amount);
        }

        [Test]
        public void TestWithLikeNegativeId()
        {
            int negativeId = -5;

            Assert.Throws<ArgumentException>(() =>
            {
                Transaction transaction = new Transaction(
                    negativeId,
                    Status,
                    From,
                    To,
                    Amount);
            });
        }

        [Test]
        public void TestWithLikeWhiteSpaceFrom()
        {
            string whiteSpaceFrom = "   ";

            Assert.Throws<ArgumentException>(() =>
            {
                Transaction transaction = new Transaction(
                    Id,
                    Status,
                    whiteSpaceFrom,
                    To,
                    Amount);
            });
        }

        [Test]
        public void TestWithLikeWhiteSpaceTo()
        {
            string whiteSpaceTo = "   ";

            Assert.Throws<ArgumentException>(() =>
            {
                Transaction transaction = new Transaction(
                    Id,
                    Status,
                    From,
                    whiteSpaceTo,
                    Amount);
            });
        }

        [Test]
        public void TestWithLikeZeroAmount()
        {
            int zeroAmount = 0;

            Assert.Throws<ArgumentException>(() =>
            {
                Transaction transaction = new Transaction(
                    Id,
                    Status,
                    From,
                    To,
                    zeroAmount);
            });
        }

        [Test]
        public void TestWithLikeNegativeAmount()
        {
            int negativeAmount = -9;

            Assert.Throws<ArgumentException>(() =>
            {
                Transaction transaction = new Transaction(
                    Id,
                    Status,
                    From,
                    To,
                    negativeAmount);
            });
        }

        [Test]
        public void TestCompareToWhenTheOtherTransactionIsNull()
        {
            Transaction transaction = new Transaction(
               Id,
               Status,
               From,
               To,
               Amount);

            int expectedResult = 1;
            int actualResult = transaction.CompareTo(null);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestCompareToWhenTheOtherTransactionIsEqual()
        {
            Transaction transaction = new Transaction(
               Id,
               Status,
               From,
               To,
               Amount);

            Transaction otherTransaction = transaction;

            int expectedResult = 0;
            int actualResult = transaction.CompareTo(otherTransaction);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestCompareToWhenTheOtherTransactionHasDifferentElement()
        {
            Transaction transaction = new Transaction(
               Id,
               Status,
               From,
               To,
               Amount);

            Transaction otherTransaction = new Transaction(
               2,
               Status,
               From,
               To,
               Amount);

            int expectedResult = -1;
            int actualResult = transaction.CompareTo(otherTransaction);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
