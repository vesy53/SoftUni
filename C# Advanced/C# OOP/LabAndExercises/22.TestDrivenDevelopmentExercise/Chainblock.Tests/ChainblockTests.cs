namespace Chainblock.Tests
{
    using NUnit.Framework;

    using Chainblock.Models;
    using System;
    using Chainblock.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class ChainblockTests
    {
        private const int Id = 1;
        private const TransactionStatus Status = TransactionStatus.Successfull;
        private const string From = "Pesho";
        private const string To = "Gosho";
        private const double Amount = 650;

        private Chainblock chainblock;
        private Transaction transaction;
        private Transaction transaction1;
        private Transaction transaction2;

        [SetUp]
        public void SetUp()
        {
            this.chainblock = new Chainblock();

            this.transaction = new Transaction(Id, Status, From, To, Amount);
            this.transaction1 = new Transaction(2, Status, From, To, Amount + 10);
            this.transaction2 = new Transaction(3, Status, From, To, Amount + 20);

            this.chainblock.Add(this.transaction);
        }

        [Test]
        public void TestIfAddWorkCorrect()
        {
            int expectedCount = 1;

            Assert.AreEqual(expectedCount, this.chainblock.Count);
        }

        [Test]
        public void TestAddingSameTransactionTwice()
        {
            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.Add(this.transaction));
        }

        [Test]
        public void TestIfContainsByTransactionWorksCorrect()
        {
            bool actualResult = this.chainblock
                .Contains(this.transaction);

            Assert.IsTrue(actualResult);
        }

        [Test]
        public void TestContainsNonExistantTransaction()
        {
            Transaction nonExistantTr = new Transaction(
                10, 
                TransactionStatus.Unauthorized,
                From, 
                To, 
                Amount);

            bool result = this.chainblock.Contains(nonExistantTr);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestContainsById()
        {
            bool result = this.chainblock.Contains(Id);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestContainsNonExistantId()
        {
            bool result = this.chainblock.Contains(5);

            Assert.IsFalse(result);
        }

        [Test]
        public void ContainsWithNegativeId()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock.Contains(-5);
            });
        }

        [Test]
        public void TestIfCountWorksCorrectly()
        {
            Transaction newTransaction = new Transaction(
               10,
               TransactionStatus.Unauthorized,
               From,
               To,
               Amount);

            this.chainblock.Add(newTransaction);

            int expectedCount = 2;
            int actualCount = this.chainblock.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void TestIfGetByIdWorkCorrectly()
        {
            ITransaction result = this.chainblock.GetById(Id);

            Assert.AreSame(this.transaction, result);
            Assert.AreEqual(this.transaction.Id, result.Id);
        }

        [Test]
        public void TestIfGetingNonExistantTransaction()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock.GetById(5);
            });
        }

        [Test]
        public void TestIfChangeTransactionStatusWorksCorrectly()
        {
            TransactionStatus newStatus = TransactionStatus.Aborted;

            this.chainblock.ChangeTransactionStatus(Id, newStatus);

            ITransaction result = this.chainblock.GetById(Id);

            Assert.AreEqual(newStatus, result.Status);
        }

        [Test]
        public void TestChangingStatusOnNonExistingTransaction()
        {
            Assert.Throws<AggregateException>(() =>
            {
                this.chainblock.ChangeTransactionStatus(
                    5,
                    TransactionStatus.Unauthorized);
            });
        }

        [Test]
        public void TestRemovingByIdCorrectly()
        {
            int expectedCount = 0;

            this.chainblock.RemoveTransactionById(Id);

            Assert.AreEqual(expectedCount, this.chainblock.Count);
        }

        [Test]
        public void TestRemovingNonExistingId()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock.RemoveTransactionById(5);
            });
        }

        [Test]
        public void TestIfGetByTransactionStatusReturnsAllWithIntendedStatus()
        {
            Transaction transaction4 = new Transaction(
                4,
                TransactionStatus.Aborted,
                From, 
                To,
                Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetByTransactionStatus(Status);

            bool result = resultCollection.All(t => t.Status == Status);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestIfGetByStatusReturnsCollectionWithCorrectCount()
        {
            Transaction transaction4 = new Transaction(
                4,
                TransactionStatus.Aborted,
                From,
                To,
                Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetByTransactionStatus(Status);

            int expectedCount = 3;
            int actualCount = resultCollection.Count();

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void TestIfGetStatusReturnedCollectionContainsOnlyOurTransactions()
        {
            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetByTransactionStatus(Status);

            Assert.AreSame(this.transaction, resultCollection.First());
        }

        [Test]
        public void TestIfGetByStatusReturnsTransactionsOrderedCorrect()
        {
            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);

            List<ITransaction> resultCollection = this.chainblock
                .GetByTransactionStatus(Status)
                .ToList();

            bool areOrdered = true;
            double currentMax = resultCollection
                .First()
                .Amount;

            for (int i = 1; i < resultCollection.Count(); i++)
            {
                ITransaction currTransaction = resultCollection[i];

                if (currTransaction.Amount > currentMax)
                {
                    areOrdered = false;
                }

                currentMax = currTransaction.Amount;
            }

            Assert.IsTrue(areOrdered);
        }

        [Test]
        public void TestIfGetByNonExistingStatus()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock.GetByTransactionStatus(TransactionStatus.Aborted);
            });
        }

        // GetAllSendersWithTransactionStatus
        [Test]
        public void TestIfGetAllSendersWithTransactionStatusReturnsCorrectCount()
        {
            Transaction transaction4 = new Transaction(
                4,
                TransactionStatus.Aborted,
                From,
                To,
                Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            IEnumerable<string> resultCollection = this.chainblock
                .GetAllSendersWithTransactionStatus(Status);

            int expectedCount = 3;

            Assert.AreEqual(expectedCount, resultCollection.Count());
        }

        [Test]
        public void TestIfGetAllSendersWithTransactionStatusReturnsCorrectCollection()
        {
            Transaction transaction4 = new Transaction(
                4,
                TransactionStatus.Aborted,
                From,
                To,
                Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            string[] expectedCollection = this.chainblock
                .GetByTransactionStatus(Status)
                .Select(t => t.From)
                .ToArray();

            IEnumerable<string> actualCollection = this.chainblock
                .GetAllSendersWithTransactionStatus(Status);

            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }

        [Test]
        public void TestIfGetAllSendersWithNonExistingTransactionStatus()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock
                .GetAllSendersWithTransactionStatus(TransactionStatus.Unauthorized);
            });
        }

        // GetAllReceiversWithTransactionStatus
        [Test]
        public void TestIfGetAllReceiversWithTransactionStatusReturnsCollectionWithCorrectCount()
        {
            Transaction transaction4 = new Transaction(
                4,
                TransactionStatus.Aborted,
                From,
                To,
                Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            IEnumerable<string> resultCollection = this.chainblock
                .GetAllReceiversWithTransactionStatus(Status);

            int expectedCount = 3;

            Assert.AreEqual(expectedCount, resultCollection.Count());
        }

        [Test]
        public void TestIfGetAllReceiversWithTransactionStatusReturnsCorrectCollection()
        {
            Transaction transaction4 = new Transaction(
                4,
                TransactionStatus.Aborted,
                From,
                To,
                Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            string[] expectedCollection = this.chainblock
                .GetByTransactionStatus(Status)
                .Select(t => t.To)
                .ToArray();

            IEnumerable<string> actualCollection = this.chainblock
                .GetAllReceiversWithTransactionStatus(Status);

            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }

        [Test] 
        public void TestIfGetAllReceiversWithNonExistingTransactionStatus()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock
                .GetAllReceiversWithTransactionStatus(TransactionStatus.Unauthorized);
            });
        }

        // GetAllOrderedByAmountDescendingThenById
        [Test]
        public void TestIfGetAllOrderedByAmountDescendingThenByIdReturnsOrderedCollection()
        {
            this.chainblock.Add(new Transaction(2, Status, From, To, Amount));
            this.chainblock.Add(this.transaction2);

            List<ITransaction> resultCollection = this.chainblock
                .GetAllOrderedByAmountDescendingThenById()
                .ToList();

            bool areOrdered = true;
            double currentMax = resultCollection
                .First()
                .Amount;
            double currentId = resultCollection
                .First()
                .Id;

            for (int i = 1; i < resultCollection.Count(); i++)
            {
                ITransaction currTransaction = resultCollection[i];

                if (currTransaction.Amount > currentMax)
                {
                    areOrdered = false;
                }
                else if (currTransaction.Amount == currentMax)
                {
                    if (currTransaction.Id < currentId)
                    {
                        areOrdered = false;
                    }
                }

                currentMax = currTransaction.Amount;
                currentId = currTransaction.Id;
            }

            Assert.IsTrue(areOrdered);
        }

        // GetBySenderOrderedByAmountDescending
        [Test]
        public void TestIfGetBySenderOrderedByAmountDescendingReturnsCorrectCount()
        {
            Transaction transaction4 = new Transaction(
                4,
                Status,
                "Vanko",
                To,
                Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            int expectedCount = 3;

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetBySenderOrderedByAmountDescending(From);

            Assert.AreEqual(expectedCount, resultCollection.Count());
        }

        [Test]
        public void TestIfGetBySenderOrderedByAmountDescendingReturnsCollectionWithCorrectSenderName()
        {
            Transaction transaction4 = new Transaction(
               4,
               Status,
               "Vanko",
               To,
               Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetBySenderOrderedByAmountDescending(From);

            bool result = resultCollection
                .All(t => t.From == From);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestIfGetBySenderOrderedByAmountDescendingReturnsOrderedCollection()
        {
            Transaction transaction4 = new Transaction(
               4,
               Status,
               "Vanko",
               To,
               Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            List<ITransaction> expectedResult = new List<ITransaction>()
            {
                transaction2,
                transaction1,
                this.transaction
            };

            List<ITransaction> resultCollection = this.chainblock
                .GetBySenderOrderedByAmountDescending(From)
                .ToList();

            CollectionAssert.AreEqual(expectedResult, resultCollection);
        }

        [Test]
        public void TestIfGetBySenderOrderedByAmountDescendingWithNonExistingSender()
        {
            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock
                .GetBySenderOrderedByAmountDescending("Vanko");
            });
        }

        // GetByReceiverOrderedByAmountThenById
        [Test]
        public void TestIfGetByReceiverOrderedByAmountThenByIdReturnsOrderedCollection()
        {
            this.chainblock.Add(new Transaction(2, Status, From, To, Amount));
            this.chainblock.Add(this.transaction2);

            List<ITransaction> resultCollection = this.chainblock
                .GetAllOrderedByAmountDescendingThenById()
                .ToList();

            bool areOrdered = true;
            double currentMax = resultCollection
                .First()
                .Amount;
            double currentId = resultCollection
                .First()
                .Id;

            for (int i = 1; i < resultCollection.Count(); i++)
            {
                ITransaction currTransaction = resultCollection[i];

                if (currTransaction.Amount > currentMax)
                {
                    areOrdered = false;
                }
                else if (currTransaction.Amount == currentMax)
                {
                    if (currTransaction.Id < currentId)
                    {
                        areOrdered = false;
                    }
                }

                currentMax = currTransaction.Amount;
                currentId = currTransaction.Id;
            }

            Assert.IsTrue(areOrdered);
        }

        // GetByReceiverOrderedByAmountDescending
        [Test]
        public void TestIfGetByReceiverOrderedByAmountDescendingReturnsCorrectCount()
        {
            Transaction transaction4 = new Transaction(
               4,
               Status,
               From,
               "Vanko",
               Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            int expectedCount = 3;

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetByReceiverOrderedByAmountThenById(To);

            Assert.AreEqual(expectedCount, resultCollection.Count());
        }

        [Test]
        public void TestIfGetByReceiverOrderedByAmountDescendingReturnsCollectionWithCorrectReceiverName()
        {
            Transaction transaction4 = new Transaction(
               4,
               Status,
               From,
               "Vanko",
               Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetByReceiverOrderedByAmountThenById(To);

            bool result = resultCollection
                .All(t => t.To == To);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestIfGetByReceiverOrderedByAmountDescendingReturnsOrderedCollection()
        {
            Transaction transaction4 = new Transaction(
               4,
               Status,
               From,
               "Vanko",
               Amount + 30);

            Transaction transaction1 = new Transaction(2, Status, From, To, Amount);

            this.chainblock.Add(transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction4);

            List<ITransaction> expectedResult = new List<ITransaction>()
            {
                transaction2,
                this.transaction,
                transaction1
            };

            List<ITransaction> resultCollection = this.chainblock
                .GetByReceiverOrderedByAmountThenById(To)
                .ToList();

            CollectionAssert.AreEqual(expectedResult, resultCollection);
        }

        [Test]
        public void TestIfGetByReceiverOrderedByAmountDescendingWithNonExistingReceiver()
        {
            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock
                    .GetByReceiverOrderedByAmountThenById("Vanko");
            });
        }

        // GetByTransactionStatusAndMaximumAmount
        [Test]
        public void TestIfGetByTransactionStatusAndMaximumAmountReturnCorrectTransactions()
        {
            Transaction transaction3 = new Transaction(
                4, 
                TransactionStatus.Unauthorized, 
                From,
                To, 
                Amount);
            Transaction transaction4 = new Transaction(
                5, 
                Status,
                From, 
                To,
                Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction3);
            this.chainblock.Add(transaction4);

            double maxAmount = Amount + 20;

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetByTransactionStatusAndMaximumAmount(Status, maxAmount);

            bool result = resultCollection
                .All(t => t.Status == Status 
                       && t.Amount <= maxAmount);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestIfGetByTransactionStatusAndMaximumAmountReturnsOrderedCollection()
        {
            Transaction transaction3 = new Transaction(
               4,
               TransactionStatus.Unauthorized,
               From,
               To,
               Amount);
            Transaction transaction4 = new Transaction(
                5,
                Status,
                From,
                To,
                Amount + 30);

            double maxAmount = Amount + 20;

            List<ITransaction> expectedResult = new List<ITransaction>()
            {
                this.transaction2,
                this.transaction1,
                this.transaction
            };

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction3);
            this.chainblock.Add(transaction4);

            List<ITransaction> actualResult = this.chainblock
                .GetByTransactionStatusAndMaximumAmount(Status, maxAmount)
                .ToList();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestGetByTransactionStatusAndMaximumAmountWhenThereIsNoTransactionsCorrespondToTransactionStatus()
        {
            IEnumerable<ITransaction> result = this.chainblock
                .GetByTransactionStatusAndMaximumAmount(TransactionStatus.Unauthorized, Amount + 10);

            CollectionAssert.IsEmpty(result);
        }

        [Test]
        public void TestGetByTransactionStatusAndMaximumAmountWhenThereIsNoTransactionsCorrespondToMaxAmount()
        {
            IEnumerable<ITransaction> result = this.chainblock
                .GetByTransactionStatusAndMaximumAmount(Status, Amount - 10);

            CollectionAssert.IsEmpty(result);
        }

        // GetBySenderAndMinimumAmountDescending
        [Test]
        public void TestGetBySenderAndMinimumAmountDescendingReturnsIntendedTransaction()
        {
            Transaction transaction3 = new Transaction(4, Status, "Vanko", To, Amount);
            Transaction transaction4 = new Transaction(5, Status, From, To, Amount - 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction3);
            this.chainblock.Add(transaction4);

            double minAmount = Amount - 10;

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetBySenderAndMinimumAmountDescending(From, minAmount);

            bool result = resultCollection
                .All(t => t.From == From
                       && t.Amount >= minAmount);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestIfGetBySenderAndMinimumAmountDescendingReturnsOrderedCollection()
        {
            Transaction transaction3 = new Transaction(4, Status, "Vanko", To, Amount);
            Transaction transaction4 = new Transaction(5, Status, From, To, Amount - 30);

            double minAmount = Amount - 10;

            List<ITransaction> expectedResult = new List<ITransaction>()
            {
                this.transaction2,
                this.transaction1,
                this.transaction
            };

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction3);
            this.chainblock.Add(transaction4);

            List<ITransaction> actualResult = this.chainblock
                .GetBySenderAndMinimumAmountDescending(From, minAmount)
                .ToList();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestGetBySenderAndMinimumAmountDescendingWithLikeNonExistingSender()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock.GetBySenderAndMinimumAmountDescending("Vanko", Amount - 10);
            });
        }

        [Test]
        public void TestGetBySenderAndMinimumAmountDescendingWithInvalidAmount()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock.GetBySenderAndMinimumAmountDescending(From, Amount + 10);
            });
        }

        // GetByReceiverAndAmountRange
        [Test]
        public void TestGetByReceiverAndAmountRangeReturnsCorrectCount()
        {
            Transaction transaction3 = new Transaction(4, Status, From, "Vanko", Amount);
            Transaction transaction4 = new Transaction(5, Status, From, To, Amount - 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction3);
            this.chainblock.Add(transaction4);

            double lo = Amount - 30;
            double hi = Amount + 10;

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetByReceiverAndAmountRange(To, lo, hi);

            bool result = resultCollection
                .All(t => t.To == To
                       && t.Amount >= lo && t.Amount < hi);

            Assert.IsTrue(result);

            int expectedCount = 2;

            Assert.AreEqual(expectedCount, resultCollection.Count());
        }

        [Test]
        public void TestGetByReceiverAndAmountRangeReturnsCollectionWithCorrectReceiverName()
        {
            Transaction transaction3 = new Transaction(4, Status, From, "Vanko", Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction3);

            double lo = Amount - 30;
            double hi = Amount + 10;

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetByReceiverAndAmountRange(To, lo, hi);

            bool result = resultCollection
               .All(t => t.To == To
                      && t.Amount >= lo && t.Amount < hi);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestGetByReceiverAndAmountRangeReturnsOrderedCollection()
        {
            double lo = Amount;
            double hi = Amount + 30;

            this.transaction1 = new Transaction(2, Status, From, To, Amount);
            Transaction transaction3 = new Transaction(4, Status, From, "Vanko", Amount + 30);

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);
            this.chainblock.Add(transaction3);

            List<ITransaction> expectedResult = new List<ITransaction>()
            {
                transaction2,
                this.transaction,
                transaction1
            };

            List<ITransaction> resultCollection = this.chainblock
                .GetByReceiverAndAmountRange(To, lo, hi)
                .ToList();

            CollectionAssert.AreEqual(expectedResult, resultCollection);
        }

        [Test]
        public void TestGetByReceiverAndAmountRangeReturnsWithNonExistingReceiver()
        {
            double lo = Amount;
            double hi = Amount + 20;

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.chainblock
                    .GetByReceiverAndAmountRange("Vanko", lo, hi);
            });
        }

        // GetAllInAmountRange
        [Test]
        public void TestGetAllInAmountRangeWorksCorrectly()
        {
            double minAmount = Amount + 5;
            double maxAmount = Amount + 25;

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetAllInAmountRange(minAmount, maxAmount);

            bool result = resultCollection
                .All(t => t.Amount >= minAmount
                       && t.Amount <= maxAmount);

            Assert.AreEqual(2, resultCollection.Count());
            Assert.IsTrue(result);
        }

        [Test]
        public void TestGetAllInAmountRangeWhenThereIsNotTransactionCorrespondingToGivenRange()
        {
            double minAmount = Amount + 35;
            double maxAmount = Amount + 55;

            this.chainblock.Add(this.transaction1);
            this.chainblock.Add(this.transaction2);

            IEnumerable<ITransaction> resultCollection = this.chainblock
                .GetAllInAmountRange(minAmount, maxAmount);

            CollectionAssert.IsEmpty(resultCollection);
        }
    }
}
