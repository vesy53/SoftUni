using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T> : IEqualityScale<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        public T Left
        {
            get => this.left;
            set => this.left = value;
        }

        public T Right
        {
            get => this.right;
            set => this.right = value;
        }

        public bool AreEqual()
        {
            bool isEqual = this.Left.Equals(this.Right);

            if (isEqual)
            {
                return true;
            }

            return false;
        }
    }
}
