namespace Chainblock.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using global::Chainblock.Contracts;

    public class Chainblock : IChainblock
    {
        private Dictionary<int, ITransaction> byId;
        private Dictionary<TransactionStatus, HashSet<ITransaction>> byStatus;

        public Chainblock()
        {
            this.byId = new Dictionary<int, ITransaction>();
            this.byStatus = new Dictionary<TransactionStatus, HashSet<ITransaction>>();
        }

        public int Count => this.byId.Count;

        public void Add(ITransaction tx)
        {
            if (this.Contains(tx))
            {
                throw new InvalidOperationException(
                    "Transaction already exists!");
            }

            this.byId[tx.Id] = tx;

            if (!this.byStatus.ContainsKey(tx.Status))
            {
                this.byStatus[tx.Status] = new HashSet<ITransaction>();
            }

            this.byStatus[tx.Status].Add(tx);
        }

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (!this.byId.ContainsKey(id))
            {
                throw new AggregateException(
                    "There is no transaction with given Id present in the collection!");
            }

            ITransaction transaction = this.byId[id];

            this.byStatus[transaction.Status].Remove(transaction);

            transaction.Status = newStatus;

            if (!this.byStatus.ContainsKey(newStatus))
            {
                this.byStatus[newStatus] = new HashSet<ITransaction>();
            }

            this.byStatus[newStatus].Add(transaction);
        }

        public bool Contains(ITransaction tx)
        {
            return this.byId.Values
                .Contains(tx);
        }

        public bool Contains(int id)
        {
            if (id < 0)
            {
                throw new InvalidOperationException(
                    "Invalid id!");
            }

            return this.byId
                 .ContainsKey(id);
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            IEnumerable<ITransaction> result = this.byId
               .Values
               .Where(t => t.Amount >= lo && t.Amount <= hi);

            return result;
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            return this.byId.Values
                .OrderByDescending(t => t.Amount)
                .ThenBy(t => t.Id);
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            if (!this.byStatus.ContainsKey(status))
            {
                throw new InvalidOperationException(
                    "There is no transaction with given Id present in the collection!");
            }

            List<string> receiver = this.byStatus[status]
                .OrderByDescending(t => t.Amount)
                .Select(t => t.To)
                .ToList();

            if (receiver.Count == 0)
            {
                throw new InvalidOperationException(
                   "There is no transaction with given Id present in the collection!");
            }

            return receiver;
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            if (!this.byStatus.ContainsKey(status))
            {
                throw new InvalidOperationException(
                    "There is no transaction with given Id present in the collection!");
            }

            List<string> senders = this.byStatus[status]
                .OrderByDescending(t => t.Amount)
                .Select(t => t.From)
                .ToList();

            if (senders.Count == 0)
            {
                throw new InvalidOperationException(
                   "There is no transaction with given Id present in the collection!");
            }

            return senders;
        }

        public ITransaction GetById(int id)
        {
            if (!this.byId.ContainsKey(id))
            {
                throw new InvalidOperationException(
                    "Non existant Id provided!");
            }

            return this.byId[id];
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            IEnumerable<ITransaction> result = this.byId
                .Values
                .Where(t => t.To == receiver && 
                            t.Amount >= lo && 
                            t.Amount < hi)
                .OrderByDescending(t => t.Amount)
                .ThenBy(t => t.Id);

            if (result.Count() == 0)
            {
                throw new InvalidOperationException();
            }

            return result;
        }
                                      
        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            IEnumerable<ITransaction> result = this.byId
                .Values
                .Where(t => t.To == receiver)
                .OrderByDescending(t => t.Amount)
                .ThenBy(t => t.Id);

            if (result.Count() == 0)
            {
                throw new InvalidOperationException();
            }

            return result;
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(
            string sender,
            double amount)
        {
            IEnumerable<ITransaction> result = this.byId
               .Values
               .OrderByDescending(t => t.Amount)
               .Where(t => t.From == sender && t.Amount >= amount);

            if (result.Count() == 0)
            {
                throw new InvalidOperationException();
            }

            return result;
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            IEnumerable<ITransaction> result = this.byId
                .Values
                .Where(t => t.From == sender)
                .OrderByDescending(t => t.Amount);

            if (result.Count() == 0)
            {
                throw new InvalidOperationException();
            }

            return result;
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            if (!this.byStatus.ContainsKey(status))
            {
                throw new InvalidOperationException(
                    "There are no transaction with given status presented in the collection!");
            }

            HashSet<ITransaction> wantedTr = this.byStatus[status];

            if (wantedTr.Count == 0)
            {
                throw new InvalidOperationException(
                     "There are no transaction with given status presented in the collection!");
            }

            return wantedTr
                .OrderByDescending(t => t.Amount);
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(
            TransactionStatus status, 
            double amount)
        {
            IEnumerable<ITransaction> result = this.byId
               .Values
               .OrderByDescending(t => t.Amount)
               .Where(t => t.Status == status && t.Amount <= amount);

            return result;
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            for (int i = 1; i < this.byId.Count; i++)
            {
               yield return this.byId[i];
            }
        }

        public void RemoveTransactionById(int id)
        {
            if (!this.byId.ContainsKey(id))
            {
                throw new InvalidOperationException(
                    "Cannot remove non-existing transaction!");
            }

            ITransaction transaction = this.byId[id];

            this.byStatus[transaction.Status].Remove(transaction);
            this.byId.Remove(transaction.Id);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
