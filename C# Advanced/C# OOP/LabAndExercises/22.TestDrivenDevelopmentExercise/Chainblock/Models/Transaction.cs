namespace Chainblock.Models
{
    using System;

    using global::Chainblock.Contracts;

    public class Transaction : ITransaction
    {
        private int id;
        private TransactionStatus status;
        private string from;
        private string to;
        private double amount;

        public Transaction(
            int id, 
            TransactionStatus status,
            string from, 
            string to, 
            double amount)
        {
            this.Id = id;
            this.Status = status;
            this.From = from;
            this.To = to;
            this.Amount = amount;
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Id cannot be negative!");
                }

                this.id = value;
            }
        }

        public TransactionStatus Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.status = value;
            }
        }

        public string From
        {
            get
            {
                return this.from;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Sender name should not be whitespace or empty!");      
                }

                this.from = value;
            }
        }

        public string To
        {
            get
            {
                return this.to;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Receiver name should not be whitespace or empty!");
                }

                this.to = value;
            }
        }

        public double Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "Amount value must be positive!");
                }

                this.amount = value;
            }
        }

        public int CompareTo(ITransaction other)
        {
            if (other == null)
            {
                return 1;
            }

            int compareId = this.Id.CompareTo(other.Id);
            int compareStatus = this.Status.CompareTo(other.Status);
            int compareFrom = this.From.CompareTo(other.From);
            int compareTo = this.To.CompareTo(other.To);
            int compareAmount = this.Amount.CompareTo(other.Amount);

            if (compareId == 0 &&
                compareStatus == 0 &&
                compareFrom == 0 &&
                compareTo == 0 &&
                compareAmount == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
