namespace p04._01.ShoppingSpree.Validations
{
    using System;

    public static class Validation
    {
        private const int DefaultMoney = 0;
        
        public static void ValidateName(string value)
        {
            if (string.IsNullOrEmpty(value) ||
                string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    $"Name cannot be empty");
            }
        }

        public static void ValidateMoney(decimal value)
        {
            if (value < DefaultMoney)
            {
                throw new ArgumentException(
                    $"Money cannot be negative");
            }
        }
    }
}
